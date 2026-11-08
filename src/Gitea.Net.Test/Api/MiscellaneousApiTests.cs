/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 28.3.0
 *
 * Request-shape tests for MiscellaneousApi. Every call is sent to RecordingApiClient, so no
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
    ///  Class for testing MiscellaneousApi
    /// </summary>
    public class MiscellaneousApiTests
    {
        private readonly RecordingApiClient client;
        private readonly MiscellaneousApi instance;

        public MiscellaneousApiTests()
        {
            client = new RecordingApiClient();
            instance = new MiscellaneousApi(client, client, RecordingApiClient.CreateConfiguration());
        }

        // Creates a model without running its constructor, so required-field checks don't fire.
        private static T NewModel<T>() => (T)System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(typeof(T));

        /// <summary>
        /// Test an instance of MiscellaneousApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<MiscellaneousApi>(instance);
        }

        /// <summary>
        /// Test DeleteCurrentToken: DELETE /token
        /// </summary>
        [Fact]
        public async Task DeleteCurrentTokenTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/token");
                RequestAssert.HasAuthToken(r);
            }

            instance.DeleteCurrentToken();
            Verify(client.TakeSingle());

            await instance.DeleteCurrentTokenAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetCurrentToken: GET /token
        /// </summary>
        [Fact]
        public async Task GetCurrentTokenTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/token");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetCurrentToken();
            Verify(client.TakeSingle());

            await instance.GetCurrentTokenAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetGitignoreTemplateInfo: GET /gitignore/templates/{name}
        /// </summary>
        [Fact]
        public async Task GetGitignoreTemplateInfoTest()
        {
            string name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/gitignore/templates/{name}");
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetGitignoreTemplateInfo(name);
            Verify(client.TakeSingle());

            await instance.GetGitignoreTemplateInfoAsync(name, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetLabelTemplateInfo: GET /label/templates/{name}
        /// </summary>
        [Fact]
        public async Task GetLabelTemplateInfoTest()
        {
            string name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/label/templates/{name}");
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetLabelTemplateInfo(name);
            Verify(client.TakeSingle());

            await instance.GetLabelTemplateInfoAsync(name, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetLicenseTemplateInfo: GET /licenses/{name}
        /// </summary>
        [Fact]
        public async Task GetLicenseTemplateInfoTest()
        {
            string name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/licenses/{name}");
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetLicenseTemplateInfo(name);
            Verify(client.TakeSingle());

            await instance.GetLicenseTemplateInfoAsync(name, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetSigningKey: GET /signing-key.gpg
        /// </summary>
        [Fact]
        public async Task GetSigningKeyTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/signing-key.gpg");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetSigningKey();
            Verify(client.TakeSingle());

            await instance.GetSigningKeyAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetSigningKeySSH: GET /signing-key.pub
        /// </summary>
        [Fact]
        public async Task GetSigningKeySSHTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/signing-key.pub");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetSigningKeySSH();
            Verify(client.TakeSingle());

            await instance.GetSigningKeySSHAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetVersion: GET /version
        /// </summary>
        [Fact]
        public async Task GetVersionTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/version");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetVersion();
            Verify(client.TakeSingle());

            await instance.GetVersionAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ListGitignoresTemplates: GET /gitignore/templates
        /// </summary>
        [Fact]
        public async Task ListGitignoresTemplatesTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/gitignore/templates");
                RequestAssert.HasAuthToken(r);
            }

            instance.ListGitignoresTemplates();
            Verify(client.TakeSingle());

            await instance.ListGitignoresTemplatesAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ListLabelTemplates: GET /label/templates
        /// </summary>
        [Fact]
        public async Task ListLabelTemplatesTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/label/templates");
                RequestAssert.HasAuthToken(r);
            }

            instance.ListLabelTemplates();
            Verify(client.TakeSingle());

            await instance.ListLabelTemplatesAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ListLicenseTemplates: GET /licenses
        /// </summary>
        [Fact]
        public async Task ListLicenseTemplatesTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/licenses");
                RequestAssert.HasAuthToken(r);
            }

            instance.ListLicenseTemplates();
            Verify(client.TakeSingle());

            await instance.ListLicenseTemplatesAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RenderMarkdown: POST /markdown
        /// </summary>
        [Fact]
        public async Task RenderMarkdownTest()
        {
            MarkdownOption? body = NewModel<MarkdownOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/markdown");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RenderMarkdown(body);
            Verify(client.TakeSingle());

            await instance.RenderMarkdownAsync(body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RenderMarkdownRaw: POST /markdown/raw
        /// </summary>
        [Fact]
        public async Task RenderMarkdownRawTest()
        {
            string body = "body-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/markdown/raw");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RenderMarkdownRaw(body);
            Verify(client.TakeSingle());

            await instance.RenderMarkdownRawAsync(body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RenderMarkup: POST /markup
        /// </summary>
        [Fact]
        public async Task RenderMarkupTest()
        {
            MarkupOption? body = NewModel<MarkupOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/markup");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RenderMarkup(body);
            Verify(client.TakeSingle());

            await instance.RenderMarkupAsync(body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }
    }
}
