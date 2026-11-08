/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 28.3.0
 *
 * Request-shape tests for NotificationApi. Every call is sent to RecordingApiClient, so no
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
    ///  Class for testing NotificationApi
    /// </summary>
    public class NotificationApiTests
    {
        private readonly RecordingApiClient client;
        private readonly NotificationApi instance;

        public NotificationApiTests()
        {
            client = new RecordingApiClient();
            instance = new NotificationApi(client, client, RecordingApiClient.CreateConfiguration());
        }

        // Creates a model without running its constructor, so required-field checks don't fire.
        private static T NewModel<T>() => (T)System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(typeof(T));

        /// <summary>
        /// Test an instance of NotificationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<NotificationApi>(instance);
        }

        /// <summary>
        /// Test NotifyGetList: GET /notifications
        /// </summary>
        [Fact]
        public async Task NotifyGetListTest()
        {
            bool? all = true;
            List<string>? statusTypes = new List<string> { "statusTypes1-value", "statusTypes2-value" };
            List<string>? subjectType = new List<string> { "subjectType1-value", "subjectType2-value" };
            DateTime? since = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            DateTime? before = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            int? page = 10;
            int? limit = 11;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/notifications");
                RequestAssert.QueryParameter(r, "all");
                RequestAssert.QueryParameter(r, "status-types");
                RequestAssert.QueryParameter(r, "subject-type");
                RequestAssert.QueryParameter(r, "since");
                RequestAssert.QueryParameter(r, "before");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.NotifyGetList(all, statusTypes, subjectType, since, before, page, limit);
            Verify(client.TakeSingle());

            await instance.NotifyGetListAsync(all, statusTypes, subjectType, since, before, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test NotifyGetRepoList: GET /repos/{owner}/{repo}/notifications
        /// </summary>
        [Fact]
        public async Task NotifyGetRepoListTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            bool? all = true;
            List<string>? statusTypes = new List<string> { "statusTypes1-value", "statusTypes2-value" };
            List<string>? subjectType = new List<string> { "subjectType1-value", "subjectType2-value" };
            DateTime? since = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            DateTime? before = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            int? page = 12;
            int? limit = 13;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/notifications");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "all");
                RequestAssert.QueryParameter(r, "status-types");
                RequestAssert.QueryParameter(r, "subject-type");
                RequestAssert.QueryParameter(r, "since");
                RequestAssert.QueryParameter(r, "before");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.NotifyGetRepoList(owner, repo, all, statusTypes, subjectType, since, before, page, limit);
            Verify(client.TakeSingle());

            await instance.NotifyGetRepoListAsync(owner, repo, all, statusTypes, subjectType, since, before, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test NotifyGetThread: GET /notifications/threads/{id}
        /// </summary>
        [Fact]
        public async Task NotifyGetThreadTest()
        {
            string id = "id-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/notifications/threads/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.NotifyGetThread(id);
            Verify(client.TakeSingle());

            await instance.NotifyGetThreadAsync(id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test NotifyNewAvailable: GET /notifications/new
        /// </summary>
        [Fact]
        public async Task NotifyNewAvailableTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/notifications/new");
                RequestAssert.HasAuthToken(r);
            }

            instance.NotifyNewAvailable();
            Verify(client.TakeSingle());

            await instance.NotifyNewAvailableAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test NotifyReadList: PUT /notifications
        /// </summary>
        [Fact]
        public async Task NotifyReadListTest()
        {
            DateTime? lastReadAt = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            string? all = "all-value";
            List<string>? statusTypes = new List<string> { "statusTypes1-value", "statusTypes2-value" };
            string? toStatus = "toStatus-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/notifications");
                RequestAssert.QueryParameter(r, "last_read_at");
                RequestAssert.QueryParameter(r, "all");
                RequestAssert.QueryParameter(r, "status-types");
                RequestAssert.QueryParameter(r, "to-status");
                RequestAssert.HasAuthToken(r);
            }

            instance.NotifyReadList(lastReadAt, all, statusTypes, toStatus);
            Verify(client.TakeSingle());

            await instance.NotifyReadListAsync(lastReadAt, all, statusTypes, toStatus, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test NotifyReadRepoList: PUT /repos/{owner}/{repo}/notifications
        /// </summary>
        [Fact]
        public async Task NotifyReadRepoListTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string? all = "all-value";
            List<string>? statusTypes = new List<string> { "statusTypes1-value", "statusTypes2-value" };
            string? toStatus = "toStatus-value";
            DateTime? lastReadAt = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/notifications");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "all");
                RequestAssert.QueryParameter(r, "status-types");
                RequestAssert.QueryParameter(r, "to-status");
                RequestAssert.QueryParameter(r, "last_read_at");
                RequestAssert.HasAuthToken(r);
            }

            instance.NotifyReadRepoList(owner, repo, all, statusTypes, toStatus, lastReadAt);
            Verify(client.TakeSingle());

            await instance.NotifyReadRepoListAsync(owner, repo, all, statusTypes, toStatus, lastReadAt, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test NotifyReadThread: PATCH /notifications/threads/{id}
        /// </summary>
        [Fact]
        public async Task NotifyReadThreadTest()
        {
            string id = "id-value";
            string? toStatus = "toStatus-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/notifications/threads/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.QueryParameter(r, "to-status");
                RequestAssert.HasAuthToken(r);
            }

            instance.NotifyReadThread(id, toStatus);
            Verify(client.TakeSingle());

            await instance.NotifyReadThreadAsync(id, toStatus, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }
    }
}
