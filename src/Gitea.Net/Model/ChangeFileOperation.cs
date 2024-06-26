/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 1.22.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Gitea.Net.Client.OpenAPIDateConverter;

namespace Gitea.Net.Model
{
    /// <summary>
    /// ChangeFileOperation for creating, updating or deleting a file
    /// </summary>
    [DataContract(Name = "ChangeFileOperation")]
    public partial class ChangeFileOperation : IValidatableObject
    {
        /// <summary>
        /// indicates what to do with the file
        /// </summary>
        /// <value>indicates what to do with the file</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OperationEnum
        {
            /// <summary>
            /// Enum Create for value: create
            /// </summary>
            [EnumMember(Value = "create")]
            Create = 1,

            /// <summary>
            /// Enum Update for value: update
            /// </summary>
            [EnumMember(Value = "update")]
            Update = 2,

            /// <summary>
            /// Enum Delete for value: delete
            /// </summary>
            [EnumMember(Value = "delete")]
            Delete = 3
        }


        /// <summary>
        /// indicates what to do with the file
        /// </summary>
        /// <value>indicates what to do with the file</value>
        [DataMember(Name = "operation", IsRequired = true, EmitDefaultValue = true)]
        public OperationEnum Operation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeFileOperation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ChangeFileOperation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeFileOperation" /> class.
        /// </summary>
        /// <param name="content">new or updated file content, must be base64 encoded.</param>
        /// <param name="fromPath">old path of the file to move.</param>
        /// <param name="operation">indicates what to do with the file (required).</param>
        /// <param name="path">path to the existing or new file (required).</param>
        /// <param name="sha">sha is the SHA for the file that already exists, required for update or delete.</param>
        public ChangeFileOperation(string content = default(string), string fromPath = default(string), OperationEnum operation = default(OperationEnum), string path = default(string), string sha = default(string))
        {
            this.Operation = operation;
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new ArgumentNullException("path is a required property for ChangeFileOperation and cannot be null");
            }
            this.Path = path;
            this.Content = content;
            this.FromPath = fromPath;
            this.Sha = sha;
        }

        /// <summary>
        /// new or updated file content, must be base64 encoded
        /// </summary>
        /// <value>new or updated file content, must be base64 encoded</value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// old path of the file to move
        /// </summary>
        /// <value>old path of the file to move</value>
        [DataMember(Name = "from_path", EmitDefaultValue = false)]
        public string FromPath { get; set; }

        /// <summary>
        /// path to the existing or new file
        /// </summary>
        /// <value>path to the existing or new file</value>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// sha is the SHA for the file that already exists, required for update or delete
        /// </summary>
        /// <value>sha is the SHA for the file that already exists, required for update or delete</value>
        [DataMember(Name = "sha", EmitDefaultValue = false)]
        public string Sha { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChangeFileOperation {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  FromPath: ").Append(FromPath).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Sha: ").Append(Sha).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
