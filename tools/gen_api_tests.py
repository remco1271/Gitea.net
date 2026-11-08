"""Generate request-shape tests for every API method.

For each method on I<Name>ApiSync the test calls the sync and async variant against
RecordingApiClient and checks HTTP method, path template, path/query/header/form
parameters, body and auth header against the swagger spec (not the generated code).
"""
import json, os, re, sys, glob

spec_path, src_dir = sys.argv[1], sys.argv[2]
api_dir = os.path.join(src_dir, "Gitea.Net", "Api")
model_dir = os.path.join(src_dir, "Gitea.Net", "Model")
test_dir = os.path.join(src_dir, "Gitea.Net.Test", "Api")

spec = json.load(open(spec_path, encoding="utf-8"))
global_security = spec.get("security", [])

def key(s):
    return re.sub(r"[^a-z0-9]", "", s.lower())

def resolve(p):
    if "$ref" in p:
        name = p["$ref"].split("/")[-1]
        return spec["parameters"][name]
    return p

ops = {}
for path, item in spec["paths"].items():
    shared = [resolve(p) for p in item.get("parameters", [])]
    for method, op in item.items():
        if method == "parameters":
            continue
        params = {(p["in"], p["name"]): p for p in shared}
        for p in op.get("parameters", []):
            p = resolve(p)
            params[(p["in"], p["name"])] = p
        sec = op.get("security", global_security)
        oid = op["operationId"]
        ops[oid[0].upper() + oid[1:]] = ops[key(oid)] = dict(deprecated=op.get("deprecated", False), method=method.upper(), path=path, params=list(params.values()), secured=bool(sec))

enums = set()
for f in glob.glob(os.path.join(model_dir, "*.cs")):
    txt = open(f, encoding="utf-8").read()
    for m in re.finditer(r"public enum (\w+)\s*\{\s*(?:///[^\n]*\n\s*)*(?:\[[^\]]*\]\s*)*(\w+)", txt):
        enums.add(m.group(1))
enum_first = {}
for f in glob.glob(os.path.join(model_dir, "*.cs")):
    txt = open(f, encoding="utf-8").read()
    m = re.search(r"\[JsonConverter\(typeof\(StringEnumConverter\)\)\]\s*public enum (\w+)\s*\{(.*?)\}", txt, re.S)
    if m:
        first = re.search(r"^\s*(\w+)\s*=", re.sub(r"(///[^\n]*|\[[^\]]*\])", "", m.group(2)), re.M)
        enum_first[m.group(1)] = first.group(1) if first else None

def split_params(s):
    out, depth, cur = [], 0, ""
    for ch in s:
        if ch in "<(":
            depth += 1
        elif ch in ">)":
            depth -= 1
        if ch == "," and depth == 0:
            out.append(cur.strip()); cur = ""
        else:
            cur += ch
    if cur.strip():
        out.append(cur.strip())
    return out

counter = [0]
def sample(cs_type, name):
    t = cs_type.rstrip("?")
    counter[0] += 1
    n = counter[0]
    if t == "string":
        return f'"{name}-value"'
    if t in ("int", "long", "short"):
        return str(n)
    if t in ("decimal", "double", "float"):
        return f"{n}.5{'m' if t == 'decimal' else ('f' if t == 'float' else '')}"
    if t == "bool":
        return "true"
    if t == "DateTime":
        return "new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc)"
    if t in ("System.IO.Stream", "Stream", "FileParameter"):
        return "new System.IO.MemoryStream(new byte[] { 1, 2, 3 })"
    if t in ("Object", "object"):
        return "new object()"
    m = re.match(r"List<(.+)>$", t)
    if m:
        inner = m.group(1)
        return f"new List<{inner}> {{ {sample(inner, name + '1')}, {sample(inner, name + '2')} }}"
    if t in enum_first and enum_first[t]:
        return f"{t}.{enum_first[t]}"
    return f"NewModel<{t}>()"

problems = []
api_files = sorted(glob.glob(os.path.join(api_dir, "*Api.cs")))
total = 0
for api_file in api_files:
    api = os.path.splitext(os.path.basename(api_file))[0]
    txt = open(api_file, encoding="utf-8").read()
    m = re.search(r"public interface I%sSync : IApiAccessor\s*\{(.*?)\n    \}" % api, txt, re.S)
    body = m.group(1)
    methods = []
    for mm in re.finditer(r"^\s{8}([\w<>\.,\? ]+?)\s+(\w+)\((.*?)\);\s*$", body, re.M):
        ret, name, plist = mm.groups()
        if name.endswith("WithHttpInfo"):
            continue
        params = []
        for p in split_params(plist):
            p = p.split("=")[0].strip()
            ptype, pname = p.rsplit(" ", 1)
            if pname == "operationIndex":
                continue
            params.append((ptype, pname))
        methods.append((ret, name, params))

    tests = []
    for ret, name, params in methods:
        op = ops.get(name) or ops.get(key(name))
        if op is None:
            problems.append(f"{api}.{name}: no operation in spec")
            continue
        total += 1
        counter[0] = 0
        by_key = {}
        for p in op["params"]:
            by_key[key(p["name"])] = p
        lines = []
        args = []
        checks = [f'RequestAssert.Matches(r, "{op["method"]}", "{op["path"]}");']
        matched = set()
        for ptype, pname in params:
            local = "@" + pname if pname in ("ref", "event", "base", "object", "string", "params", "lock") else pname
            lines.append(f"            {ptype} {local} = {sample(ptype, pname)};")
            args.append(local)
            sp = by_key.get(key(pname)) or by_key.get(key(re.sub(r"^var", "", pname)))
            if sp is None:
                problems.append(f"{api}.{name}: C# param '{pname}' not found in spec")
                continue
            matched.add(sp["name"])
            where = sp["in"]
            if where == "path":
                checks.append(f'RequestAssert.PathParameter(r, "{sp["name"]}", {local});')
            elif where == "query":
                checks.append(f'RequestAssert.QueryParameter(r, "{sp["name"]}");')
            elif where == "header":
                checks.append(f'RequestAssert.HeaderParameter(r, "{sp["name"]}", {local});')
            elif where == "formData":
                checks.append(f'RequestAssert.FormParameter(r, "{sp["name"]}");')
            elif where == "body":
                checks.append(f"RequestAssert.Body(r, {local});")
        for p in op["params"]:
            if p["name"] not in matched:
                problems.append(f"{api}.{name}: spec param '{p['in']}:{p['name']}' has no C# argument")
        if op["secured"]:
            checks.append("RequestAssert.HasAuthToken(r);")
        call = ", ".join(args)
        check_body = "\n".join("                " + c for c in checks)
        dep = op.get("deprecated")
        pre = "#pragma warning disable CS0612 // deprecated endpoint\n" if dep else ""
        post = "#pragma warning restore CS0612\n" if dep else ""
        tests.append(pre + f"""        /// <summary>
        /// Test {name}: {op["method"]} {op["path"]}
        /// </summary>
        [Fact]
        public async Task {name}Test()
        {{
{chr(10).join(lines) if lines else "            // no parameters"}

            void Verify(RecordedRequest r)
            {{
{check_body}
            }}

            instance.{name}({call});
            Verify(client.TakeSingle());

            await instance.{name}Async({call});
            Verify(client.TakeSingle());
        }}
""" + post)

    content = f"""/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: {spec["info"]["version"]}
 *
 * Request-shape tests for {api}. Every call is sent to RecordingApiClient, so no
 * Gitea server is needed. Expected values come from the Gitea swagger spec.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

using Gitea.Net.Api;
using Gitea.Net.Model;

namespace Gitea.Net.Test.Api
{{
    /// <summary>
    ///  Class for testing {api}
    /// </summary>
    public class {api}Tests
    {{
        private readonly RecordingApiClient client;
        private readonly {api} instance;

        public {api}Tests()
        {{
            client = new RecordingApiClient();
            instance = new {api}(client, client, RecordingApiClient.CreateConfiguration());
        }}

        // Creates a model without running its constructor, so required-field checks don't fire.
        private static T NewModel<T>() => (T)System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(typeof(T));

        /// <summary>
        /// Test an instance of {api}
        /// </summary>
        [Fact]
        public void InstanceTest()
        {{
            Assert.IsType<{api}>(instance);
        }}

{chr(10).join(tests)}    }}
}}
"""
    out = os.path.join(test_dir, f"{api}Tests.cs")
    with open(out, "w", encoding="utf-8", newline="\r\n") as fh:
        fh.write(content)
    print(f"{api}: {len(tests)} tests")

print("total", total, "spec ops", len(ops))
print("\n".join(problems) if problems else "no mapping problems")
