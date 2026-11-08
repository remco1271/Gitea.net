/*
 * Gitea API
 *
 * Test helper: an ISynchronousClient / IAsynchronousClient that records requests
 * instead of sending them, so API classes can be tested without a Gitea server.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Gitea.Net.Client;
using Xunit;

namespace Gitea.Net.Test.Api
{
    /// <summary>
    /// A single request captured by <see cref="RecordingApiClient"/>.
    /// </summary>
    public sealed class RecordedRequest
    {
        public RecordedRequest(string method, string path, RequestOptions options, bool isAsync)
        {
            Method = method;
            Path = path;
            Options = options;
            IsAsync = isAsync;
        }

        public string Method { get; }
        public string Path { get; }
        public RequestOptions Options { get; }
        public bool IsAsync { get; }
    }

    /// <summary>
    /// Records every request and returns an empty 200 OK response.
    /// </summary>
    public sealed class RecordingApiClient : ISynchronousClient, IAsynchronousClient
    {
        public const string TestToken = "test-token";

        private readonly List<RecordedRequest> _requests = new List<RecordedRequest>();

        public IReadOnlyList<RecordedRequest> Requests => _requests;

        /// <summary>
        /// Configuration with an API token, so every request should carry the Authorization header.
        /// </summary>
        public static Configuration CreateConfiguration()
        {
            var config = new Configuration { BasePath = "http://localhost/api/v1" };
            config.ApiKey.Add("token", TestToken);
            return config;
        }

        /// <summary>
        /// Returns the only recorded request and clears the list.
        /// </summary>
        public RecordedRequest TakeSingle()
        {
            var request = Assert.Single(_requests);
            _requests.Clear();
            return request;
        }

        private ApiResponse<T> Record<T>(string method, string path, RequestOptions options, bool isAsync)
        {
            _requests.Add(new RecordedRequest(method, path, options, isAsync));
            return new ApiResponse<T>(HttpStatusCode.OK, new Multimap<string, string>(), default(T), string.Empty);
        }

        public ApiResponse<T> Get<T>(string path, RequestOptions options, IReadableConfiguration configuration = null) => Record<T>("GET", path, options, false);
        public ApiResponse<T> Post<T>(string path, RequestOptions options, IReadableConfiguration configuration = null) => Record<T>("POST", path, options, false);
        public ApiResponse<T> Put<T>(string path, RequestOptions options, IReadableConfiguration configuration = null) => Record<T>("PUT", path, options, false);
        public ApiResponse<T> Delete<T>(string path, RequestOptions options, IReadableConfiguration configuration = null) => Record<T>("DELETE", path, options, false);
        public ApiResponse<T> Head<T>(string path, RequestOptions options, IReadableConfiguration configuration = null) => Record<T>("HEAD", path, options, false);
        public ApiResponse<T> Options<T>(string path, RequestOptions options, IReadableConfiguration configuration = null) => Record<T>("OPTIONS", path, options, false);
        public ApiResponse<T> Patch<T>(string path, RequestOptions options, IReadableConfiguration configuration = null) => Record<T>("PATCH", path, options, false);

        public Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, CancellationToken cancellationToken = default) => Task.FromResult(Record<T>("GET", path, options, true));
        public Task<ApiResponse<T>> PostAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, CancellationToken cancellationToken = default) => Task.FromResult(Record<T>("POST", path, options, true));
        public Task<ApiResponse<T>> PutAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, CancellationToken cancellationToken = default) => Task.FromResult(Record<T>("PUT", path, options, true));
        public Task<ApiResponse<T>> DeleteAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, CancellationToken cancellationToken = default) => Task.FromResult(Record<T>("DELETE", path, options, true));
        public Task<ApiResponse<T>> HeadAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, CancellationToken cancellationToken = default) => Task.FromResult(Record<T>("HEAD", path, options, true));
        public Task<ApiResponse<T>> OptionsAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, CancellationToken cancellationToken = default) => Task.FromResult(Record<T>("OPTIONS", path, options, true));
        public Task<ApiResponse<T>> PatchAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration = null, CancellationToken cancellationToken = default) => Task.FromResult(Record<T>("PATCH", path, options, true));
    }

    /// <summary>
    /// Shared assertions for recorded requests.
    /// </summary>
    public static class RequestAssert
    {
        public static void Matches(RecordedRequest request, string method, string path)
        {
            Assert.Equal(method, request.Method);
            Assert.Equal(path, request.Path);
        }

        public static void HasAuthToken(RecordedRequest request)
        {
            Assert.True(request.Options.HeaderParameters.ContainsKey("Authorization"), "Authorization header missing");
            Assert.Contains("token " + RecordingApiClient.TestToken, request.Options.HeaderParameters["Authorization"]);
            Assert.False(request.Options.QueryParameters.ContainsKey("token"), "token must not be sent in the query string");
        }

        public static void PathParameter(RecordedRequest request, string name, object value)
        {
            Assert.True(request.Options.PathParameters.ContainsKey(name), $"Path parameter '{name}' missing");
            Assert.Equal(ClientUtils.ParameterToString(value), request.Options.PathParameters[name]);
        }

        public static void QueryParameter(RecordedRequest request, string name)
        {
            Assert.True(request.Options.QueryParameters.ContainsKey(name), $"Query parameter '{name}' missing");
            Assert.NotEmpty(request.Options.QueryParameters[name]);
        }

        public static void HeaderParameter(RecordedRequest request, string name, object value)
        {
            Assert.True(request.Options.HeaderParameters.ContainsKey(name), $"Header '{name}' missing");
            Assert.Contains(ClientUtils.ParameterToString(value), request.Options.HeaderParameters[name]);
        }

        public static void FormParameter(RecordedRequest request, string name)
        {
            var found = request.Options.FormParameters.ContainsKey(name) || request.Options.FileParameters.ContainsKey(name);
            Assert.True(found, $"Form parameter '{name}' missing");
        }

        public static void Body(RecordedRequest request, object body)
        {
            Assert.Same(body, request.Options.Data);
        }
    }
}
