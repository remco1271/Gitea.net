/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 28.3.0
 *
 * Request-shape tests for PackageApi. Every call is sent to RecordingApiClient, so no
 * Gitea server is needed. Expected values come from the Gitea swagger spec.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

using Gitea.Net.Api;
using Gitea.Net.Model;

namespace Gitea.Net.Test.Api
{
    /// <summary>
    ///  Class for testing PackageApi
    /// </summary>
    public class PackageApiTests
    {
        private readonly RecordingApiClient client;
        private readonly PackageApi instance;

        public PackageApiTests()
        {
            client = new RecordingApiClient();
            instance = new PackageApi(client, client, RecordingApiClient.CreateConfiguration());
        }

        // Creates a model without running its constructor, so required-field checks don't fire.
        private static T NewModel<T>() => (T)System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(typeof(T));

        /// <summary>
        /// Test an instance of PackageApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<PackageApi>(instance);
        }

        /// <summary>
        /// Test DeletePackage: DELETE /packages/{owner}/{type}/{name}
        /// </summary>
        [Fact]
        public async Task DeletePackageTest()
        {
            string owner = "owner-value";
            string type = "type-value";
            string name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/packages/{owner}/{type}/{name}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "type", type);
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeletePackage(owner, type, name);
            Verify(client.TakeSingle());

            await instance.DeletePackageAsync(owner, type, name, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DeletePackageVersion: DELETE /packages/{owner}/{type}/{name}/{version}
        /// </summary>
        [Fact]
        public async Task DeletePackageVersionTest()
        {
            string owner = "owner-value";
            string type = "type-value";
            string name = "name-value";
            string version = "version-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/packages/{owner}/{type}/{name}/{version}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "type", type);
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.PathParameter(r, "version", version);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeletePackageVersion(owner, type, name, version);
            Verify(client.TakeSingle());

            await instance.DeletePackageVersionAsync(owner, type, name, version, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetLatestPackageVersion: GET /packages/{owner}/{type}/{name}/-/latest
        /// </summary>
        [Fact]
        public async Task GetLatestPackageVersionTest()
        {
            string owner = "owner-value";
            string type = "type-value";
            string name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/packages/{owner}/{type}/{name}/-/latest");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "type", type);
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetLatestPackageVersion(owner, type, name);
            Verify(client.TakeSingle());

            await instance.GetLatestPackageVersionAsync(owner, type, name, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetPackage: GET /packages/{owner}/{type}/{name}/{version}
        /// </summary>
        [Fact]
        public async Task GetPackageTest()
        {
            string owner = "owner-value";
            string type = "type-value";
            string name = "name-value";
            string version = "version-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/packages/{owner}/{type}/{name}/{version}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "type", type);
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.PathParameter(r, "version", version);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetPackage(owner, type, name, version);
            Verify(client.TakeSingle());

            await instance.GetPackageAsync(owner, type, name, version, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test LinkPackage: POST /packages/{owner}/{type}/{name}/-/link/{repo_name}
        /// </summary>
        [Fact]
        public async Task LinkPackageTest()
        {
            string owner = "owner-value";
            string type = "type-value";
            string name = "name-value";
            string repoName = "repoName-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/packages/{owner}/{type}/{name}/-/link/{repo_name}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "type", type);
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.PathParameter(r, "repo_name", repoName);
                RequestAssert.HasAuthToken(r);
            }

            instance.LinkPackage(owner, type, name, repoName);
            Verify(client.TakeSingle());

            await instance.LinkPackageAsync(owner, type, name, repoName, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ListPackageFiles: GET /packages/{owner}/{type}/{name}/{version}/files
        /// </summary>
        [Fact]
        public async Task ListPackageFilesTest()
        {
            string owner = "owner-value";
            string type = "type-value";
            string name = "name-value";
            string version = "version-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/packages/{owner}/{type}/{name}/{version}/files");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "type", type);
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.PathParameter(r, "version", version);
                RequestAssert.HasAuthToken(r);
            }

            instance.ListPackageFiles(owner, type, name, version);
            Verify(client.TakeSingle());

            await instance.ListPackageFilesAsync(owner, type, name, version, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ListPackageVersions: GET /packages/{owner}/{type}/{name}
        /// </summary>
        [Fact]
        public async Task ListPackageVersionsTest()
        {
            string owner = "owner-value";
            string type = "type-value";
            string name = "name-value";
            int? page = 4;
            int? limit = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/packages/{owner}/{type}/{name}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "type", type);
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.ListPackageVersions(owner, type, name, page, limit);
            Verify(client.TakeSingle());

            await instance.ListPackageVersionsAsync(owner, type, name, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ListPackages: GET /packages/{owner}
        /// </summary>
        [Fact]
        public async Task ListPackagesTest()
        {
            string owner = "owner-value";
            int? page = 2;
            int? limit = 3;
            string? type = "type-value";
            string? q = "q-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/packages/{owner}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "type");
                RequestAssert.QueryParameter(r, "q");
                RequestAssert.HasAuthToken(r);
            }

            instance.ListPackages(owner, page, limit, type, q);
            Verify(client.TakeSingle());

            await instance.ListPackagesAsync(owner, page, limit, type, q, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UnlinkPackage: POST /packages/{owner}/{type}/{name}/-/unlink
        /// </summary>
        [Fact]
        public async Task UnlinkPackageTest()
        {
            string owner = "owner-value";
            string type = "type-value";
            string name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/packages/{owner}/{type}/{name}/-/unlink");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "type", type);
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.HasAuthToken(r);
            }

            instance.UnlinkPackage(owner, type, name);
            Verify(client.TakeSingle());

            await instance.UnlinkPackageAsync(owner, type, name, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }
    }
}
