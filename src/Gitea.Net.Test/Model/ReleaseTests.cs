/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 1.22.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Gitea.Net.Api;
using Gitea.Net.Client;
using Gitea.Net.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xunit;

namespace Gitea.Net.Test.Model
{
    /// <summary>
    ///  Class for testing Release
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class ReleaseTests : IDisposable
    {
        public readonly static string GITEA_SERVER = Environment.GetEnvironmentVariable("VELOPACK_GITEA_SERVER") ?? "https://gitea.com";
        public readonly static string GITEA_TOKEN = Environment.GetEnvironmentVariable("VELOPACK_GITEA_TEST_TOKEN");
        public readonly static string GITEA_REPO = Environment.GetEnvironmentVariable("VELOPACK_GITEA_RELEASE_REPO") ?? "VeloPackTest";
        public readonly static string GITEA_USERNAME = Environment.GetEnvironmentVariable("VELOPACK_GITEA_USERNAME") ?? "remco1271";
        // TODO uncomment below to declare an instance variable for Release
        //private Release instance;
        private Configuration config;
        public ReleaseTests()
        {
            // TODO uncomment below to create an instance of Release
            //instance = new Release();
            // Setup Gitea config
            config = new Configuration();
            // Example: http://www.Gitea.com/api/v1
            var uri = new Uri(GITEA_SERVER);
            var baseUri = uri.GetLeftPart(System.UriPartial.Authority);
            config.BasePath = baseUri + "/api/v1";
            config.ApiKey.Add("token", GITEA_TOKEN);
        }


        [Fact]
        public async Task GetRealease()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var result = instance.GetRelease(GITEA_TOKEN, GITEA_REPOURL, "v1.0.0");
            //Assert.NotNull(result);
            //https://gitea.com/remco1271/VeloPackTest.git+
            var apiInstance = new RepositoryApi(config);
            ApiResponse<Repository> repositoryInfo = await apiInstance.RepoGetWithHttpInfoAsync(GITEA_USERNAME, GITEA_REPO);

            Assert.NotNull(repositoryInfo);
            Assert.True(repositoryInfo.StatusCode == System.Net.HttpStatusCode.OK);
            var allReleases = await apiInstance.RepoListReleasesWithHttpInfoAsync(GITEA_USERNAME, GITEA_REPO, page: 1, limit: (int)repositoryInfo.Data.ReleaseCounter);
            Assert.NotNull(allReleases.Data);
            Assert.IsType<List<Gitea.Net.Model.Release>>(allReleases.Data);
            Assert.True(allReleases.Data.Last().TagName == "1.0.0");
            //Assert.ThrowsAny<ApiException>(() => apiInstance.RepoGetWithHttpInfoAsync("remco1271", "VeloPackTest").ConfigureAwait(true).GetAwaiter());


        }

        [Fact]
        public async Task UpdateRealease()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var result = instance.GetRelease(GITEA_TOKEN, GITEA_REPOURL, "v1.0.0");
            //Assert.NotNull(result);
            //https://gitea.com/remco1271/VeloPackTest.git+
            var apiInstance = new RepositoryApi(config);
            ApiResponse<Release> repositoryInfo = await apiInstance.RepoGetLatestReleaseWithHttpInfoAsync(GITEA_USERNAME, GITEA_REPO);


            if(repositoryInfo != null && repositoryInfo.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Release release = repositoryInfo.Data;
                EditReleaseOption editReleaseOption = new EditReleaseOption()
                {
                    TagName = release.TagName,
                    Name = release.Name,
                    Body = "This is a test release for the VeloPack Github Update Test." + DateTime.UtcNow.ToString("dd-MM-yyyy HH:mm:ss"),
                    Prerelease = release.Prerelease,
                    Draft = release.Draft
                };
                var updateReleaseResponse = await apiInstance.RepoEditReleaseWithHttpInfoAsync(GITEA_USERNAME, GITEA_REPO, release.Id, editReleaseOption);
                Assert.NotNull(updateReleaseResponse);
                Assert.True(updateReleaseResponse.StatusCode == System.Net.HttpStatusCode.OK);
            }
            Assert.NotNull(repositoryInfo);
        }

        public void Dispose()
        {
            // Cleanup when everything is done.

        }

        /// <summary>
        /// Test an instance of Release
        /// </summary>
        [Fact]
        public void ReleaseInstanceTest()
        {
            // TODO uncomment below to test "IsType" Release
            //Assert.IsType<Release>(instance);
        }

        /// <summary>
        /// Test the property 'Assets'
        /// </summary>
        [Fact]
        public void AssetsTest()
        {
            // TODO unit test for the property 'Assets'
        }

        /// <summary>
        /// Test the property 'Author'
        /// </summary>
        [Fact]
        public void AuthorTest()
        {
            // TODO unit test for the property 'Author'
        }

        /// <summary>
        /// Test the property 'Body'
        /// </summary>
        [Fact]
        public void BodyTest()
        {
            // TODO unit test for the property 'Body'
        }

        /// <summary>
        /// Test the property 'CreatedAt'
        /// </summary>
        [Fact]
        public void CreatedAtTest()
        {
            // TODO unit test for the property 'CreatedAt'
        }

        /// <summary>
        /// Test the property 'Draft'
        /// </summary>
        [Fact]
        public void DraftTest()
        {
            // TODO unit test for the property 'Draft'
        }

        /// <summary>
        /// Test the property 'HtmlUrl'
        /// </summary>
        [Fact]
        public void HtmlUrlTest()
        {
            // TODO unit test for the property 'HtmlUrl'
        }

        /// <summary>
        /// Test the property 'Id'
        /// </summary>
        [Fact]
        public void IdTest()
        {
            // TODO unit test for the property 'Id'
        }

        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Fact]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }

        /// <summary>
        /// Test the property 'Prerelease'
        /// </summary>
        [Fact]
        public void PrereleaseTest()
        {
            // TODO unit test for the property 'Prerelease'
        }

        /// <summary>
        /// Test the property 'PublishedAt'
        /// </summary>
        [Fact]
        public void PublishedAtTest()
        {
            // TODO unit test for the property 'PublishedAt'
        }

        /// <summary>
        /// Test the property 'TagName'
        /// </summary>
        [Fact]
        public void TagNameTest()
        {
            // TODO unit test for the property 'TagName'
        }

        /// <summary>
        /// Test the property 'TarballUrl'
        /// </summary>
        [Fact]
        public void TarballUrlTest()
        {
            // TODO unit test for the property 'TarballUrl'
        }

        /// <summary>
        /// Test the property 'TargetCommitish'
        /// </summary>
        [Fact]
        public void TargetCommitishTest()
        {
            // TODO unit test for the property 'TargetCommitish'
        }

        /// <summary>
        /// Test the property 'UploadUrl'
        /// </summary>
        [Fact]
        public void UploadUrlTest()
        {
            // TODO unit test for the property 'UploadUrl'
        }

        /// <summary>
        /// Test the property 'Url'
        /// </summary>
        [Fact]
        public void UrlTest()
        {
            // TODO unit test for the property 'Url'
        }

        /// <summary>
        /// Test the property 'ZipballUrl'
        /// </summary>
        [Fact]
        public void ZipballUrlTest()
        {
            // TODO unit test for the property 'ZipballUrl'
        }
    }
}