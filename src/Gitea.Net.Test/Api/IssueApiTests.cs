/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 28.3.0
 *
 * Request-shape tests for IssueApi. Every call is sent to RecordingApiClient, so no
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
    ///  Class for testing IssueApi
    /// </summary>
    public class IssueApiTests
    {
        private readonly RecordingApiClient client;
        private readonly IssueApi instance;

        public IssueApiTests()
        {
            client = new RecordingApiClient();
            instance = new IssueApi(client, client, RecordingApiClient.CreateConfiguration());
        }

        // Creates a model without running its constructor, so required-field checks don't fire.
        private static T NewModel<T>() => (T)System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(typeof(T));

        /// <summary>
        /// Test an instance of IssueApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<IssueApi>(instance);
        }

        /// <summary>
        /// Test IssueAddAssignees: POST /repos/{owner}/{repo}/issues/{index}/assignees
        /// </summary>
        [Fact]
        public async Task IssueAddAssigneesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            IssueAssigneesOption body = NewModel<IssueAssigneesOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/{index}/assignees");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueAddAssignees(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.IssueAddAssigneesAsync(owner, repo, index, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueAddLabel: POST /repos/{owner}/{repo}/issues/{index}/labels
        /// </summary>
        [Fact]
        public async Task IssueAddLabelTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            IssueLabelsOption? body = NewModel<IssueLabelsOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/{index}/labels");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueAddLabel(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.IssueAddLabelAsync(owner, repo, index, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueAddSubscription: PUT /repos/{owner}/{repo}/issues/{index}/subscriptions/{user}
        /// </summary>
        [Fact]
        public async Task IssueAddSubscriptionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            string user = "user-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/issues/{index}/subscriptions/{user}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "user", user);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueAddSubscription(owner, repo, index, user);
            Verify(client.TakeSingle());

            await instance.IssueAddSubscriptionAsync(owner, repo, index, user, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueAddTime: POST /repos/{owner}/{repo}/issues/{index}/times
        /// </summary>
        [Fact]
        public async Task IssueAddTimeTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            AddTimeOption? body = NewModel<AddTimeOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/{index}/times");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueAddTime(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.IssueAddTimeAsync(owner, repo, index, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueCheckAssignee: GET /repos/{owner}/{repo}/issues/{index}/assignees/{assignee}
        /// </summary>
        [Fact]
        public async Task IssueCheckAssigneeTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            string assignee = "assignee-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/{index}/assignees/{assignee}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "assignee", assignee);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueCheckAssignee(owner, repo, index, assignee);
            Verify(client.TakeSingle());

            await instance.IssueCheckAssigneeAsync(owner, repo, index, assignee, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueCheckSubscription: GET /repos/{owner}/{repo}/issues/{index}/subscriptions/check
        /// </summary>
        [Fact]
        public async Task IssueCheckSubscriptionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/{index}/subscriptions/check");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueCheckSubscription(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.IssueCheckSubscriptionAsync(owner, repo, index, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueClearLabels: DELETE /repos/{owner}/{repo}/issues/{index}/labels
        /// </summary>
        [Fact]
        public async Task IssueClearLabelsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/labels");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueClearLabels(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.IssueClearLabelsAsync(owner, repo, index, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueCreateComment: POST /repos/{owner}/{repo}/issues/{index}/comments
        /// </summary>
        [Fact]
        public async Task IssueCreateCommentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            CreateIssueCommentOption? body = NewModel<CreateIssueCommentOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/{index}/comments");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueCreateComment(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.IssueCreateCommentAsync(owner, repo, index, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueCreateIssue: POST /repos/{owner}/{repo}/issues
        /// </summary>
        [Fact]
        public async Task IssueCreateIssueTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateIssueOption? body = NewModel<CreateIssueOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueCreateIssue(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.IssueCreateIssueAsync(owner, repo, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueCreateIssueAttachment: POST /repos/{owner}/{repo}/issues/{index}/assets
        /// </summary>
        [Fact]
        public async Task IssueCreateIssueAttachmentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            System.IO.Stream attachment = new System.IO.MemoryStream(new byte[] { 1, 2, 3 });
            string? name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/{index}/assets");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.FormParameter(r, "attachment");
                RequestAssert.QueryParameter(r, "name");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueCreateIssueAttachment(owner, repo, index, attachment, name);
            Verify(client.TakeSingle());

            await instance.IssueCreateIssueAttachmentAsync(owner, repo, index, attachment, name, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueCreateIssueBlocking: POST /repos/{owner}/{repo}/issues/{index}/blocks
        /// </summary>
        [Fact]
        public async Task IssueCreateIssueBlockingTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string index = "index-value";
            IssueMeta? body = NewModel<IssueMeta>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/{index}/blocks");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueCreateIssueBlocking(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.IssueCreateIssueBlockingAsync(owner, repo, index, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueCreateIssueCommentAttachment: POST /repos/{owner}/{repo}/issues/comments/{id}/assets
        /// </summary>
        [Fact]
        public async Task IssueCreateIssueCommentAttachmentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            System.IO.Stream attachment = new System.IO.MemoryStream(new byte[] { 1, 2, 3 });
            string? name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/comments/{id}/assets");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.FormParameter(r, "attachment");
                RequestAssert.QueryParameter(r, "name");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueCreateIssueCommentAttachment(owner, repo, id, attachment, name);
            Verify(client.TakeSingle());

            await instance.IssueCreateIssueCommentAttachmentAsync(owner, repo, id, attachment, name, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueCreateIssueDependencies: POST /repos/{owner}/{repo}/issues/{index}/dependencies
        /// </summary>
        [Fact]
        public async Task IssueCreateIssueDependenciesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string index = "index-value";
            IssueMeta? body = NewModel<IssueMeta>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/{index}/dependencies");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueCreateIssueDependencies(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.IssueCreateIssueDependenciesAsync(owner, repo, index, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueCreateLabel: POST /repos/{owner}/{repo}/labels
        /// </summary>
        [Fact]
        public async Task IssueCreateLabelTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateLabelOption? body = NewModel<CreateLabelOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/labels");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueCreateLabel(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.IssueCreateLabelAsync(owner, repo, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueCreateMilestone: POST /repos/{owner}/{repo}/milestones
        /// </summary>
        [Fact]
        public async Task IssueCreateMilestoneTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateMilestoneOption? body = NewModel<CreateMilestoneOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/milestones");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueCreateMilestone(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.IssueCreateMilestoneAsync(owner, repo, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueDelete: DELETE /repos/{owner}/{repo}/issues/{index}
        /// </summary>
        [Fact]
        public async Task IssueDeleteTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueDelete(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.IssueDeleteAsync(owner, repo, index, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueDeleteComment: DELETE /repos/{owner}/{repo}/issues/comments/{id}
        /// </summary>
        [Fact]
        public async Task IssueDeleteCommentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/comments/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueDeleteComment(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.IssueDeleteCommentAsync(owner, repo, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

#pragma warning disable CS0612 // deprecated endpoint
        /// <summary>
        /// Test IssueDeleteCommentDeprecated: DELETE /repos/{owner}/{repo}/issues/{index}/comments/{id}
        /// </summary>
        [Fact]
        public async Task IssueDeleteCommentDeprecatedTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int index = 3;
            long id = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/comments/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueDeleteCommentDeprecated(owner, repo, index, id);
            Verify(client.TakeSingle());

            await instance.IssueDeleteCommentDeprecatedAsync(owner, repo, index, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }
#pragma warning restore CS0612

        /// <summary>
        /// Test IssueDeleteCommentReaction: DELETE /repos/{owner}/{repo}/issues/comments/{id}/reactions
        /// </summary>
        [Fact]
        public async Task IssueDeleteCommentReactionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            EditReactionOption? content = NewModel<EditReactionOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/comments/{id}/reactions");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, content);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueDeleteCommentReaction(owner, repo, id, content);
            Verify(client.TakeSingle());

            await instance.IssueDeleteCommentReactionAsync(owner, repo, id, content, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueDeleteIssueAttachment: DELETE /repos/{owner}/{repo}/issues/{index}/assets/{attachment_id}
        /// </summary>
        [Fact]
        public async Task IssueDeleteIssueAttachmentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            long attachmentId = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/assets/{attachment_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "attachment_id", attachmentId);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueDeleteIssueAttachment(owner, repo, index, attachmentId);
            Verify(client.TakeSingle());

            await instance.IssueDeleteIssueAttachmentAsync(owner, repo, index, attachmentId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueDeleteIssueCommentAttachment: DELETE /repos/{owner}/{repo}/issues/comments/{id}/assets/{attachment_id}
        /// </summary>
        [Fact]
        public async Task IssueDeleteIssueCommentAttachmentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long attachmentId = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/comments/{id}/assets/{attachment_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "attachment_id", attachmentId);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueDeleteIssueCommentAttachment(owner, repo, id, attachmentId);
            Verify(client.TakeSingle());

            await instance.IssueDeleteIssueCommentAttachmentAsync(owner, repo, id, attachmentId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueDeleteIssueReaction: DELETE /repos/{owner}/{repo}/issues/{index}/reactions
        /// </summary>
        [Fact]
        public async Task IssueDeleteIssueReactionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            EditReactionOption? content = NewModel<EditReactionOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/reactions");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, content);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueDeleteIssueReaction(owner, repo, index, content);
            Verify(client.TakeSingle());

            await instance.IssueDeleteIssueReactionAsync(owner, repo, index, content, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueDeleteLabel: DELETE /repos/{owner}/{repo}/labels/{id}
        /// </summary>
        [Fact]
        public async Task IssueDeleteLabelTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/labels/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueDeleteLabel(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.IssueDeleteLabelAsync(owner, repo, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueDeleteMilestone: DELETE /repos/{owner}/{repo}/milestones/{id}
        /// </summary>
        [Fact]
        public async Task IssueDeleteMilestoneTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string id = "id-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/milestones/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueDeleteMilestone(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.IssueDeleteMilestoneAsync(owner, repo, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueDeleteStopWatch: DELETE /repos/{owner}/{repo}/issues/{index}/stopwatch/delete
        /// </summary>
        [Fact]
        public async Task IssueDeleteStopWatchTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/stopwatch/delete");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueDeleteStopWatch(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.IssueDeleteStopWatchAsync(owner, repo, index, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueDeleteSubscription: DELETE /repos/{owner}/{repo}/issues/{index}/subscriptions/{user}
        /// </summary>
        [Fact]
        public async Task IssueDeleteSubscriptionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            string user = "user-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/subscriptions/{user}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "user", user);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueDeleteSubscription(owner, repo, index, user);
            Verify(client.TakeSingle());

            await instance.IssueDeleteSubscriptionAsync(owner, repo, index, user, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueDeleteTime: DELETE /repos/{owner}/{repo}/issues/{index}/times/{id}
        /// </summary>
        [Fact]
        public async Task IssueDeleteTimeTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            long id = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/times/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueDeleteTime(owner, repo, index, id);
            Verify(client.TakeSingle());

            await instance.IssueDeleteTimeAsync(owner, repo, index, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueEditComment: PATCH /repos/{owner}/{repo}/issues/comments/{id}
        /// </summary>
        [Fact]
        public async Task IssueEditCommentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            EditIssueCommentOption? body = NewModel<EditIssueCommentOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/issues/comments/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueEditComment(owner, repo, id, body);
            Verify(client.TakeSingle());

            await instance.IssueEditCommentAsync(owner, repo, id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

#pragma warning disable CS0612 // deprecated endpoint
        /// <summary>
        /// Test IssueEditCommentDeprecated: PATCH /repos/{owner}/{repo}/issues/{index}/comments/{id}
        /// </summary>
        [Fact]
        public async Task IssueEditCommentDeprecatedTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int index = 3;
            long id = 4;
            EditIssueCommentOption? body = NewModel<EditIssueCommentOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/issues/{index}/comments/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueEditCommentDeprecated(owner, repo, index, id, body);
            Verify(client.TakeSingle());

            await instance.IssueEditCommentDeprecatedAsync(owner, repo, index, id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }
#pragma warning restore CS0612

        /// <summary>
        /// Test IssueEditIssue: PATCH /repos/{owner}/{repo}/issues/{index}
        /// </summary>
        [Fact]
        public async Task IssueEditIssueTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            EditIssueOption? body = NewModel<EditIssueOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/issues/{index}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueEditIssue(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.IssueEditIssueAsync(owner, repo, index, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueEditIssueAttachment: PATCH /repos/{owner}/{repo}/issues/{index}/assets/{attachment_id}
        /// </summary>
        [Fact]
        public async Task IssueEditIssueAttachmentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            long attachmentId = 4;
            EditAttachmentOptions? body = NewModel<EditAttachmentOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/issues/{index}/assets/{attachment_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "attachment_id", attachmentId);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueEditIssueAttachment(owner, repo, index, attachmentId, body);
            Verify(client.TakeSingle());

            await instance.IssueEditIssueAttachmentAsync(owner, repo, index, attachmentId, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueEditIssueCommentAttachment: PATCH /repos/{owner}/{repo}/issues/comments/{id}/assets/{attachment_id}
        /// </summary>
        [Fact]
        public async Task IssueEditIssueCommentAttachmentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long attachmentId = 4;
            EditAttachmentOptions? body = NewModel<EditAttachmentOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/issues/comments/{id}/assets/{attachment_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "attachment_id", attachmentId);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueEditIssueCommentAttachment(owner, repo, id, attachmentId, body);
            Verify(client.TakeSingle());

            await instance.IssueEditIssueCommentAttachmentAsync(owner, repo, id, attachmentId, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueEditIssueDeadline: POST /repos/{owner}/{repo}/issues/{index}/deadline
        /// </summary>
        [Fact]
        public async Task IssueEditIssueDeadlineTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            EditDeadlineOption? body = NewModel<EditDeadlineOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/{index}/deadline");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueEditIssueDeadline(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.IssueEditIssueDeadlineAsync(owner, repo, index, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueEditLabel: PATCH /repos/{owner}/{repo}/labels/{id}
        /// </summary>
        [Fact]
        public async Task IssueEditLabelTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            EditLabelOption? body = NewModel<EditLabelOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/labels/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueEditLabel(owner, repo, id, body);
            Verify(client.TakeSingle());

            await instance.IssueEditLabelAsync(owner, repo, id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueEditMilestone: PATCH /repos/{owner}/{repo}/milestones/{id}
        /// </summary>
        [Fact]
        public async Task IssueEditMilestoneTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string id = "id-value";
            EditMilestoneOption? body = NewModel<EditMilestoneOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/milestones/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueEditMilestone(owner, repo, id, body);
            Verify(client.TakeSingle());

            await instance.IssueEditMilestoneAsync(owner, repo, id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueGetComment: GET /repos/{owner}/{repo}/issues/comments/{id}
        /// </summary>
        [Fact]
        public async Task IssueGetCommentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/comments/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueGetComment(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.IssueGetCommentAsync(owner, repo, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueGetCommentReactions: GET /repos/{owner}/{repo}/issues/comments/{id}/reactions
        /// </summary>
        [Fact]
        public async Task IssueGetCommentReactionsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/comments/{id}/reactions");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueGetCommentReactions(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.IssueGetCommentReactionsAsync(owner, repo, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueGetComments: GET /repos/{owner}/{repo}/issues/{index}/comments
        /// </summary>
        [Fact]
        public async Task IssueGetCommentsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            DateTime? since = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            DateTime? before = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/{index}/comments");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.QueryParameter(r, "since");
                RequestAssert.QueryParameter(r, "before");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueGetComments(owner, repo, index, since, before);
            Verify(client.TakeSingle());

            await instance.IssueGetCommentsAsync(owner, repo, index, since, before, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueGetCommentsAndTimeline: GET /repos/{owner}/{repo}/issues/{index}/timeline
        /// </summary>
        [Fact]
        public async Task IssueGetCommentsAndTimelineTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            DateTime? since = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            int? page = 5;
            int? limit = 6;
            DateTime? before = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/{index}/timeline");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.QueryParameter(r, "since");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "before");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueGetCommentsAndTimeline(owner, repo, index, since, page, limit, before);
            Verify(client.TakeSingle());

            await instance.IssueGetCommentsAndTimelineAsync(owner, repo, index, since, page, limit, before, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueGetIssue: GET /repos/{owner}/{repo}/issues/{index}
        /// </summary>
        [Fact]
        public async Task IssueGetIssueTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/{index}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueGetIssue(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.IssueGetIssueAsync(owner, repo, index, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueGetIssueAttachment: GET /repos/{owner}/{repo}/issues/{index}/assets/{attachment_id}
        /// </summary>
        [Fact]
        public async Task IssueGetIssueAttachmentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            long attachmentId = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/{index}/assets/{attachment_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "attachment_id", attachmentId);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueGetIssueAttachment(owner, repo, index, attachmentId);
            Verify(client.TakeSingle());

            await instance.IssueGetIssueAttachmentAsync(owner, repo, index, attachmentId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueGetIssueCommentAttachment: GET /repos/{owner}/{repo}/issues/comments/{id}/assets/{attachment_id}
        /// </summary>
        [Fact]
        public async Task IssueGetIssueCommentAttachmentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long attachmentId = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/comments/{id}/assets/{attachment_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "attachment_id", attachmentId);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueGetIssueCommentAttachment(owner, repo, id, attachmentId);
            Verify(client.TakeSingle());

            await instance.IssueGetIssueCommentAttachmentAsync(owner, repo, id, attachmentId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueGetIssueReactions: GET /repos/{owner}/{repo}/issues/{index}/reactions
        /// </summary>
        [Fact]
        public async Task IssueGetIssueReactionsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            int? page = 4;
            int? limit = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/{index}/reactions");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueGetIssueReactions(owner, repo, index, page, limit);
            Verify(client.TakeSingle());

            await instance.IssueGetIssueReactionsAsync(owner, repo, index, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueGetLabel: GET /repos/{owner}/{repo}/labels/{id}
        /// </summary>
        [Fact]
        public async Task IssueGetLabelTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/labels/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueGetLabel(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.IssueGetLabelAsync(owner, repo, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueGetLabels: GET /repos/{owner}/{repo}/issues/{index}/labels
        /// </summary>
        [Fact]
        public async Task IssueGetLabelsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/{index}/labels");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueGetLabels(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.IssueGetLabelsAsync(owner, repo, index, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueGetMilestone: GET /repos/{owner}/{repo}/milestones/{id}
        /// </summary>
        [Fact]
        public async Task IssueGetMilestoneTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string id = "id-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/milestones/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueGetMilestone(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.IssueGetMilestoneAsync(owner, repo, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueGetMilestonesList: GET /repos/{owner}/{repo}/milestones
        /// </summary>
        [Fact]
        public async Task IssueGetMilestonesListTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string? state = "state-value";
            string? name = "name-value";
            int? page = 5;
            int? limit = 6;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/milestones");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "state");
                RequestAssert.QueryParameter(r, "name");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueGetMilestonesList(owner, repo, state, name, page, limit);
            Verify(client.TakeSingle());

            await instance.IssueGetMilestonesListAsync(owner, repo, state, name, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueGetRepoComments: GET /repos/{owner}/{repo}/issues/comments
        /// </summary>
        [Fact]
        public async Task IssueGetRepoCommentsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            DateTime? since = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            DateTime? before = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            int? page = 5;
            int? limit = 6;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/comments");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "since");
                RequestAssert.QueryParameter(r, "before");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueGetRepoComments(owner, repo, since, before, page, limit);
            Verify(client.TakeSingle());

            await instance.IssueGetRepoCommentsAsync(owner, repo, since, before, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueListBlocks: GET /repos/{owner}/{repo}/issues/{index}/blocks
        /// </summary>
        [Fact]
        public async Task IssueListBlocksTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string index = "index-value";
            int? page = 4;
            int? limit = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/{index}/blocks");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueListBlocks(owner, repo, index, page, limit);
            Verify(client.TakeSingle());

            await instance.IssueListBlocksAsync(owner, repo, index, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueListIssueAttachments: GET /repos/{owner}/{repo}/issues/{index}/assets
        /// </summary>
        [Fact]
        public async Task IssueListIssueAttachmentsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/{index}/assets");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueListIssueAttachments(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.IssueListIssueAttachmentsAsync(owner, repo, index, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueListIssueCommentAttachments: GET /repos/{owner}/{repo}/issues/comments/{id}/assets
        /// </summary>
        [Fact]
        public async Task IssueListIssueCommentAttachmentsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/comments/{id}/assets");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueListIssueCommentAttachments(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.IssueListIssueCommentAttachmentsAsync(owner, repo, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueListIssueDependencies: GET /repos/{owner}/{repo}/issues/{index}/dependencies
        /// </summary>
        [Fact]
        public async Task IssueListIssueDependenciesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string index = "index-value";
            int? page = 4;
            int? limit = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/{index}/dependencies");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueListIssueDependencies(owner, repo, index, page, limit);
            Verify(client.TakeSingle());

            await instance.IssueListIssueDependenciesAsync(owner, repo, index, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueListIssues: GET /repos/{owner}/{repo}/issues
        /// </summary>
        [Fact]
        public async Task IssueListIssuesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string? state = "state-value";
            string? labels = "labels-value";
            string? q = "q-value";
            string? type = "type-value";
            string? milestones = "milestones-value";
            DateTime? since = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            DateTime? before = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            string? createdBy = "createdBy-value";
            string? assignedBy = "assignedBy-value";
            string? mentionedBy = "mentionedBy-value";
            int? page = 13;
            int? limit = 14;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "state");
                RequestAssert.QueryParameter(r, "labels");
                RequestAssert.QueryParameter(r, "q");
                RequestAssert.QueryParameter(r, "type");
                RequestAssert.QueryParameter(r, "milestones");
                RequestAssert.QueryParameter(r, "since");
                RequestAssert.QueryParameter(r, "before");
                RequestAssert.QueryParameter(r, "created_by");
                RequestAssert.QueryParameter(r, "assigned_by");
                RequestAssert.QueryParameter(r, "mentioned_by");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueListIssues(owner, repo, state, labels, q, type, milestones, since, before, createdBy, assignedBy, mentionedBy, page, limit);
            Verify(client.TakeSingle());

            await instance.IssueListIssuesAsync(owner, repo, state, labels, q, type, milestones, since, before, createdBy, assignedBy, mentionedBy, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueListLabels: GET /repos/{owner}/{repo}/labels
        /// </summary>
        [Fact]
        public async Task IssueListLabelsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/labels");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueListLabels(owner, repo, page, limit);
            Verify(client.TakeSingle());

            await instance.IssueListLabelsAsync(owner, repo, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueLockIssue: PUT /repos/{owner}/{repo}/issues/{index}/lock
        /// </summary>
        [Fact]
        public async Task IssueLockIssueTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            LockIssueOption? body = NewModel<LockIssueOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/issues/{index}/lock");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueLockIssue(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.IssueLockIssueAsync(owner, repo, index, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssuePostCommentReaction: POST /repos/{owner}/{repo}/issues/comments/{id}/reactions
        /// </summary>
        [Fact]
        public async Task IssuePostCommentReactionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            EditReactionOption? content = NewModel<EditReactionOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/comments/{id}/reactions");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, content);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssuePostCommentReaction(owner, repo, id, content);
            Verify(client.TakeSingle());

            await instance.IssuePostCommentReactionAsync(owner, repo, id, content, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssuePostIssueReaction: POST /repos/{owner}/{repo}/issues/{index}/reactions
        /// </summary>
        [Fact]
        public async Task IssuePostIssueReactionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            EditReactionOption? content = NewModel<EditReactionOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/{index}/reactions");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, content);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssuePostIssueReaction(owner, repo, index, content);
            Verify(client.TakeSingle());

            await instance.IssuePostIssueReactionAsync(owner, repo, index, content, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueRemoveAssignees: DELETE /repos/{owner}/{repo}/issues/{index}/assignees
        /// </summary>
        [Fact]
        public async Task IssueRemoveAssigneesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            IssueAssigneesOption body = NewModel<IssueAssigneesOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/assignees");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueRemoveAssignees(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.IssueRemoveAssigneesAsync(owner, repo, index, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueRemoveIssueBlocking: DELETE /repos/{owner}/{repo}/issues/{index}/blocks
        /// </summary>
        [Fact]
        public async Task IssueRemoveIssueBlockingTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string index = "index-value";
            IssueMeta? body = NewModel<IssueMeta>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/blocks");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueRemoveIssueBlocking(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.IssueRemoveIssueBlockingAsync(owner, repo, index, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueRemoveIssueDependencies: DELETE /repos/{owner}/{repo}/issues/{index}/dependencies
        /// </summary>
        [Fact]
        public async Task IssueRemoveIssueDependenciesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string index = "index-value";
            IssueMeta? body = NewModel<IssueMeta>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/dependencies");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueRemoveIssueDependencies(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.IssueRemoveIssueDependenciesAsync(owner, repo, index, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueRemoveLabel: DELETE /repos/{owner}/{repo}/issues/{index}/labels/{id}
        /// </summary>
        [Fact]
        public async Task IssueRemoveLabelTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            long id = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/labels/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueRemoveLabel(owner, repo, index, id);
            Verify(client.TakeSingle());

            await instance.IssueRemoveLabelAsync(owner, repo, index, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueReplaceLabels: PUT /repos/{owner}/{repo}/issues/{index}/labels
        /// </summary>
        [Fact]
        public async Task IssueReplaceLabelsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            IssueLabelsOption? body = NewModel<IssueLabelsOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/issues/{index}/labels");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueReplaceLabels(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.IssueReplaceLabelsAsync(owner, repo, index, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueResetTime: DELETE /repos/{owner}/{repo}/issues/{index}/times
        /// </summary>
        [Fact]
        public async Task IssueResetTimeTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/times");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueResetTime(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.IssueResetTimeAsync(owner, repo, index, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueSearchIssues: GET /repos/issues/search
        /// </summary>
        [Fact]
        public async Task IssueSearchIssuesTest()
        {
            string? state = "state-value";
            string? labels = "labels-value";
            string? milestones = "milestones-value";
            string? q = "q-value";
            string? type = "type-value";
            DateTime? since = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            DateTime? before = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            bool? assigned = true;
            bool? created = true;
            bool? mentioned = true;
            bool? reviewRequested = true;
            bool? reviewed = true;
            string? owner = "owner-value";
            string? createdBy = "createdBy-value";
            string? team = "team-value";
            int? page = 16;
            int? limit = 17;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/issues/search");
                RequestAssert.QueryParameter(r, "state");
                RequestAssert.QueryParameter(r, "labels");
                RequestAssert.QueryParameter(r, "milestones");
                RequestAssert.QueryParameter(r, "q");
                RequestAssert.QueryParameter(r, "type");
                RequestAssert.QueryParameter(r, "since");
                RequestAssert.QueryParameter(r, "before");
                RequestAssert.QueryParameter(r, "assigned");
                RequestAssert.QueryParameter(r, "created");
                RequestAssert.QueryParameter(r, "mentioned");
                RequestAssert.QueryParameter(r, "review_requested");
                RequestAssert.QueryParameter(r, "reviewed");
                RequestAssert.QueryParameter(r, "owner");
                RequestAssert.QueryParameter(r, "created_by");
                RequestAssert.QueryParameter(r, "team");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueSearchIssues(state, labels, milestones, q, type, since, before, assigned, created, mentioned, reviewRequested, reviewed, owner, createdBy, team, page, limit);
            Verify(client.TakeSingle());

            await instance.IssueSearchIssuesAsync(state, labels, milestones, q, type, since, before, assigned, created, mentioned, reviewRequested, reviewed, owner, createdBy, team, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueStartStopWatch: POST /repos/{owner}/{repo}/issues/{index}/stopwatch/start
        /// </summary>
        [Fact]
        public async Task IssueStartStopWatchTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/{index}/stopwatch/start");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueStartStopWatch(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.IssueStartStopWatchAsync(owner, repo, index, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueStopStopWatch: POST /repos/{owner}/{repo}/issues/{index}/stopwatch/stop
        /// </summary>
        [Fact]
        public async Task IssueStopStopWatchTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/{index}/stopwatch/stop");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueStopStopWatch(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.IssueStopStopWatchAsync(owner, repo, index, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueSubscriptions: GET /repos/{owner}/{repo}/issues/{index}/subscriptions
        /// </summary>
        [Fact]
        public async Task IssueSubscriptionsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            int? page = 4;
            int? limit = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/{index}/subscriptions");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueSubscriptions(owner, repo, index, page, limit);
            Verify(client.TakeSingle());

            await instance.IssueSubscriptionsAsync(owner, repo, index, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueTrackedTimes: GET /repos/{owner}/{repo}/issues/{index}/times
        /// </summary>
        [Fact]
        public async Task IssueTrackedTimesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            string? user = "user-value";
            DateTime? since = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            DateTime? before = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            int? page = 7;
            int? limit = 8;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/{index}/times");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.QueryParameter(r, "user");
                RequestAssert.QueryParameter(r, "since");
                RequestAssert.QueryParameter(r, "before");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueTrackedTimes(owner, repo, index, user, since, before, page, limit);
            Verify(client.TakeSingle());

            await instance.IssueTrackedTimesAsync(owner, repo, index, user, since, before, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test IssueUnlockIssue: DELETE /repos/{owner}/{repo}/issues/{index}/lock
        /// </summary>
        [Fact]
        public async Task IssueUnlockIssueTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/lock");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.IssueUnlockIssue(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.IssueUnlockIssueAsync(owner, repo, index, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test MoveIssuePin: PATCH /repos/{owner}/{repo}/issues/{index}/pin/{position}
        /// </summary>
        [Fact]
        public async Task MoveIssuePinTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            long position = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/issues/{index}/pin/{position}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "position", position);
                RequestAssert.HasAuthToken(r);
            }

            instance.MoveIssuePin(owner, repo, index, position);
            Verify(client.TakeSingle());

            await instance.MoveIssuePinAsync(owner, repo, index, position, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test PinIssue: POST /repos/{owner}/{repo}/issues/{index}/pin
        /// </summary>
        [Fact]
        public async Task PinIssueTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/issues/{index}/pin");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.PinIssue(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.PinIssueAsync(owner, repo, index, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UnpinIssue: DELETE /repos/{owner}/{repo}/issues/{index}/pin
        /// </summary>
        [Fact]
        public async Task UnpinIssueTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/issues/{index}/pin");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.UnpinIssue(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.UnpinIssueAsync(owner, repo, index, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }
    }
}
