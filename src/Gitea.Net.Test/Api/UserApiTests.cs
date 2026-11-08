/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 28.3.0
 *
 * Request-shape tests for UserApi. Every call is sent to RecordingApiClient, so no
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
    ///  Class for testing UserApi
    /// </summary>
    public class UserApiTests
    {
        private readonly RecordingApiClient client;
        private readonly UserApi instance;

        public UserApiTests()
        {
            client = new RecordingApiClient();
            instance = new UserApi(client, client, RecordingApiClient.CreateConfiguration());
        }

        // Creates a model without running its constructor, so required-field checks don't fire.
        private static T NewModel<T>() => (T)System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(typeof(T));

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<UserApi>(instance);
        }

        /// <summary>
        /// Test CreateCurrentUserRepo: POST /user/repos
        /// </summary>
        [Fact]
        public async Task CreateCurrentUserRepoTest()
        {
            CreateRepoOption? body = NewModel<CreateRepoOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/repos");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.CreateCurrentUserRepo(body);
            Verify(client.TakeSingle());

            await instance.CreateCurrentUserRepoAsync(body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test CreateUserVariable: POST /user/actions/variables/{variablename}
        /// </summary>
        [Fact]
        public async Task CreateUserVariableTest()
        {
            string variablename = "variablename-value";
            CreateVariableOption? body = NewModel<CreateVariableOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/actions/variables/{variablename}");
                RequestAssert.PathParameter(r, "variablename", variablename);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.CreateUserVariable(variablename, body);
            Verify(client.TakeSingle());

            await instance.CreateUserVariableAsync(variablename, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DeleteUserRunner: DELETE /user/actions/runners/{runner_id}
        /// </summary>
        [Fact]
        public async Task DeleteUserRunnerTest()
        {
            string runnerId = "runnerId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/actions/runners/{runner_id}");
                RequestAssert.PathParameter(r, "runner_id", runnerId);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeleteUserRunner(runnerId);
            Verify(client.TakeSingle());

            await instance.DeleteUserRunnerAsync(runnerId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DeleteUserSecret: DELETE /user/actions/secrets/{secretname}
        /// </summary>
        [Fact]
        public async Task DeleteUserSecretTest()
        {
            string secretname = "secretname-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/actions/secrets/{secretname}");
                RequestAssert.PathParameter(r, "secretname", secretname);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeleteUserSecret(secretname);
            Verify(client.TakeSingle());

            await instance.DeleteUserSecretAsync(secretname, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DeleteUserVariable: DELETE /user/actions/variables/{variablename}
        /// </summary>
        [Fact]
        public async Task DeleteUserVariableTest()
        {
            string variablename = "variablename-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/actions/variables/{variablename}");
                RequestAssert.PathParameter(r, "variablename", variablename);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeleteUserVariable(variablename);
            Verify(client.TakeSingle());

            await instance.DeleteUserVariableAsync(variablename, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetUserRunner: GET /user/actions/runners/{runner_id}
        /// </summary>
        [Fact]
        public async Task GetUserRunnerTest()
        {
            string runnerId = "runnerId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/actions/runners/{runner_id}");
                RequestAssert.PathParameter(r, "runner_id", runnerId);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetUserRunner(runnerId);
            Verify(client.TakeSingle());

            await instance.GetUserRunnerAsync(runnerId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetUserRunners: GET /user/actions/runners
        /// </summary>
        [Fact]
        public async Task GetUserRunnersTest()
        {
            bool? disabled = true;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/actions/runners");
                RequestAssert.QueryParameter(r, "disabled");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetUserRunners(disabled);
            Verify(client.TakeSingle());

            await instance.GetUserRunnersAsync(disabled, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetUserSettings: GET /user/settings
        /// </summary>
        [Fact]
        public async Task GetUserSettingsTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/settings");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetUserSettings();
            Verify(client.TakeSingle());

            await instance.GetUserSettingsAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetUserVariable: GET /user/actions/variables/{variablename}
        /// </summary>
        [Fact]
        public async Task GetUserVariableTest()
        {
            string variablename = "variablename-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/actions/variables/{variablename}");
                RequestAssert.PathParameter(r, "variablename", variablename);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetUserVariable(variablename);
            Verify(client.TakeSingle());

            await instance.GetUserVariableAsync(variablename, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetUserVariablesList: GET /user/actions/variables
        /// </summary>
        [Fact]
        public async Task GetUserVariablesListTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/actions/variables");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetUserVariablesList(page, limit);
            Verify(client.TakeSingle());

            await instance.GetUserVariablesListAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetUserWorkflowJobs: GET /user/actions/jobs
        /// </summary>
        [Fact]
        public async Task GetUserWorkflowJobsTest()
        {
            string? status = "status-value";
            int? page = 2;
            int? limit = 3;
            string? sort = "sort-value";
            string? order = "order-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/actions/jobs");
                RequestAssert.QueryParameter(r, "status");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "sort");
                RequestAssert.QueryParameter(r, "order");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetUserWorkflowJobs(status, page, limit, sort, order);
            Verify(client.TakeSingle());

            await instance.GetUserWorkflowJobsAsync(status, page, limit, sort, order, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetUserWorkflowRuns: GET /user/actions/runs
        /// </summary>
        [Fact]
        public async Task GetUserWorkflowRunsTest()
        {
            string? varEvent = "varEvent-value";
            string? branch = "branch-value";
            string? status = "status-value";
            string? actor = "actor-value";
            string? headSha = "headSha-value";
            int? page = 6;
            int? limit = 7;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/actions/runs");
                RequestAssert.QueryParameter(r, "event");
                RequestAssert.QueryParameter(r, "branch");
                RequestAssert.QueryParameter(r, "status");
                RequestAssert.QueryParameter(r, "actor");
                RequestAssert.QueryParameter(r, "head_sha");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetUserWorkflowRuns(varEvent, branch, status, actor, headSha, page, limit);
            Verify(client.TakeSingle());

            await instance.GetUserWorkflowRunsAsync(varEvent, branch, status, actor, headSha, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetVerificationToken: GET /user/gpg_key_token
        /// </summary>
        [Fact]
        public async Task GetVerificationTokenTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/gpg_key_token");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetVerificationToken();
            Verify(client.TakeSingle());

            await instance.GetVerificationTokenAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UpdateUserRunner: PATCH /user/actions/runners/{runner_id}
        /// </summary>
        [Fact]
        public async Task UpdateUserRunnerTest()
        {
            string runnerId = "runnerId-value";
            EditActionRunnerOption? body = NewModel<EditActionRunnerOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/user/actions/runners/{runner_id}");
                RequestAssert.PathParameter(r, "runner_id", runnerId);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UpdateUserRunner(runnerId, body);
            Verify(client.TakeSingle());

            await instance.UpdateUserRunnerAsync(runnerId, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UpdateUserSecret: PUT /user/actions/secrets/{secretname}
        /// </summary>
        [Fact]
        public async Task UpdateUserSecretTest()
        {
            string secretname = "secretname-value";
            CreateOrUpdateSecretOption? body = NewModel<CreateOrUpdateSecretOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/user/actions/secrets/{secretname}");
                RequestAssert.PathParameter(r, "secretname", secretname);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UpdateUserSecret(secretname, body);
            Verify(client.TakeSingle());

            await instance.UpdateUserSecretAsync(secretname, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UpdateUserSettings: PATCH /user/settings
        /// </summary>
        [Fact]
        public async Task UpdateUserSettingsTest()
        {
            UserSettingsOptions? body = NewModel<UserSettingsOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/user/settings");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UpdateUserSettings(body);
            Verify(client.TakeSingle());

            await instance.UpdateUserSettingsAsync(body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UpdateUserVariable: PUT /user/actions/variables/{variablename}
        /// </summary>
        [Fact]
        public async Task UpdateUserVariableTest()
        {
            string variablename = "variablename-value";
            UpdateVariableOption? body = NewModel<UpdateVariableOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/user/actions/variables/{variablename}");
                RequestAssert.PathParameter(r, "variablename", variablename);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UpdateUserVariable(variablename, body);
            Verify(client.TakeSingle());

            await instance.UpdateUserVariableAsync(variablename, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserAddEmail: POST /user/emails
        /// </summary>
        [Fact]
        public async Task UserAddEmailTest()
        {
            CreateEmailOption? body = NewModel<CreateEmailOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/emails");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserAddEmail(body);
            Verify(client.TakeSingle());

            await instance.UserAddEmailAsync(body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserBlockUser: PUT /user/blocks/{username}
        /// </summary>
        [Fact]
        public async Task UserBlockUserTest()
        {
            string username = "username-value";
            string? note = "note-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/user/blocks/{username}");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "note");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserBlockUser(username, note);
            Verify(client.TakeSingle());

            await instance.UserBlockUserAsync(username, note, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCheckFollowing: GET /users/{username}/following/{target}
        /// </summary>
        [Fact]
        public async Task UserCheckFollowingTest()
        {
            string username = "username-value";
            string target = "target-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/following/{target}");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.PathParameter(r, "target", target);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCheckFollowing(username, target);
            Verify(client.TakeSingle());

            await instance.UserCheckFollowingAsync(username, target, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCheckUserBlock: GET /user/blocks/{username}
        /// </summary>
        [Fact]
        public async Task UserCheckUserBlockTest()
        {
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/blocks/{username}");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCheckUserBlock(username);
            Verify(client.TakeSingle());

            await instance.UserCheckUserBlockAsync(username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCreateHook: POST /user/hooks
        /// </summary>
        [Fact]
        public async Task UserCreateHookTest()
        {
            CreateHookOption body = NewModel<CreateHookOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/hooks");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCreateHook(body);
            Verify(client.TakeSingle());

            await instance.UserCreateHookAsync(body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCreateOAuth2Application: POST /user/applications/oauth2
        /// </summary>
        [Fact]
        public async Task UserCreateOAuth2ApplicationTest()
        {
            CreateOAuth2ApplicationOptions body = NewModel<CreateOAuth2ApplicationOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/applications/oauth2");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCreateOAuth2Application(body);
            Verify(client.TakeSingle());

            await instance.UserCreateOAuth2ApplicationAsync(body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCreateRunnerRegistrationToken: POST /user/actions/runners/registration-token
        /// </summary>
        [Fact]
        public async Task UserCreateRunnerRegistrationTokenTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/actions/runners/registration-token");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCreateRunnerRegistrationToken();
            Verify(client.TakeSingle());

            await instance.UserCreateRunnerRegistrationTokenAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCreateToken: POST /users/{username}/tokens
        /// </summary>
        [Fact]
        public async Task UserCreateTokenTest()
        {
            string username = "username-value";
            CreateAccessTokenOption? body = NewModel<CreateAccessTokenOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/users/{username}/tokens");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCreateToken(username, body);
            Verify(client.TakeSingle());

            await instance.UserCreateTokenAsync(username, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentAddIssueToProjectColumn: POST /user/projects/{id}/columns/{column_id}/issues/{issue_id}
        /// </summary>
        [Fact]
        public async Task UserCurrentAddIssueToProjectColumnTest()
        {
            long id = 1;
            long columnId = 2;
            long issueId = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/projects/{id}/columns/{column_id}/issues/{issue_id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.PathParameter(r, "issue_id", issueId);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentAddIssueToProjectColumn(id, columnId, issueId);
            Verify(client.TakeSingle());

            await instance.UserCurrentAddIssueToProjectColumnAsync(id, columnId, issueId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentCheckFollowing: GET /user/following/{username}
        /// </summary>
        [Fact]
        public async Task UserCurrentCheckFollowingTest()
        {
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/following/{username}");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentCheckFollowing(username);
            Verify(client.TakeSingle());

            await instance.UserCurrentCheckFollowingAsync(username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentCheckStarring: GET /user/starred/{owner}/{repo}
        /// </summary>
        [Fact]
        public async Task UserCurrentCheckStarringTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/starred/{owner}/{repo}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentCheckStarring(owner, repo);
            Verify(client.TakeSingle());

            await instance.UserCurrentCheckStarringAsync(owner, repo, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentCreateProject: POST /user/projects
        /// </summary>
        [Fact]
        public async Task UserCurrentCreateProjectTest()
        {
            CreateProjectOption? body = NewModel<CreateProjectOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/projects");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentCreateProject(body);
            Verify(client.TakeSingle());

            await instance.UserCurrentCreateProjectAsync(body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentCreateProjectColumn: POST /user/projects/{id}/columns
        /// </summary>
        [Fact]
        public async Task UserCurrentCreateProjectColumnTest()
        {
            long id = 1;
            CreateProjectColumnOption? body = NewModel<CreateProjectColumnOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/projects/{id}/columns");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentCreateProjectColumn(id, body);
            Verify(client.TakeSingle());

            await instance.UserCurrentCreateProjectColumnAsync(id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentDeleteFollow: DELETE /user/following/{username}
        /// </summary>
        [Fact]
        public async Task UserCurrentDeleteFollowTest()
        {
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/following/{username}");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentDeleteFollow(username);
            Verify(client.TakeSingle());

            await instance.UserCurrentDeleteFollowAsync(username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentDeleteGPGKey: DELETE /user/gpg_keys/{id}
        /// </summary>
        [Fact]
        public async Task UserCurrentDeleteGPGKeyTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/gpg_keys/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentDeleteGPGKey(id);
            Verify(client.TakeSingle());

            await instance.UserCurrentDeleteGPGKeyAsync(id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentDeleteKey: DELETE /user/keys/{id}
        /// </summary>
        [Fact]
        public async Task UserCurrentDeleteKeyTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/keys/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentDeleteKey(id);
            Verify(client.TakeSingle());

            await instance.UserCurrentDeleteKeyAsync(id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentDeleteProject: DELETE /user/projects/{id}
        /// </summary>
        [Fact]
        public async Task UserCurrentDeleteProjectTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/projects/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentDeleteProject(id);
            Verify(client.TakeSingle());

            await instance.UserCurrentDeleteProjectAsync(id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentDeleteProjectColumn: DELETE /user/projects/{id}/columns/{column_id}
        /// </summary>
        [Fact]
        public async Task UserCurrentDeleteProjectColumnTest()
        {
            long id = 1;
            long columnId = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/projects/{id}/columns/{column_id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentDeleteProjectColumn(id, columnId);
            Verify(client.TakeSingle());

            await instance.UserCurrentDeleteProjectColumnAsync(id, columnId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentDeleteStar: DELETE /user/starred/{owner}/{repo}
        /// </summary>
        [Fact]
        public async Task UserCurrentDeleteStarTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/starred/{owner}/{repo}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentDeleteStar(owner, repo);
            Verify(client.TakeSingle());

            await instance.UserCurrentDeleteStarAsync(owner, repo, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentEditProject: PATCH /user/projects/{id}
        /// </summary>
        [Fact]
        public async Task UserCurrentEditProjectTest()
        {
            long id = 1;
            EditProjectOption? body = NewModel<EditProjectOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/user/projects/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentEditProject(id, body);
            Verify(client.TakeSingle());

            await instance.UserCurrentEditProjectAsync(id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentEditProjectColumn: PATCH /user/projects/{id}/columns/{column_id}
        /// </summary>
        [Fact]
        public async Task UserCurrentEditProjectColumnTest()
        {
            long id = 1;
            long columnId = 2;
            EditProjectColumnOption? body = NewModel<EditProjectColumnOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/user/projects/{id}/columns/{column_id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentEditProjectColumn(id, columnId, body);
            Verify(client.TakeSingle());

            await instance.UserCurrentEditProjectColumnAsync(id, columnId, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentGetGPGKey: GET /user/gpg_keys/{id}
        /// </summary>
        [Fact]
        public async Task UserCurrentGetGPGKeyTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/gpg_keys/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentGetGPGKey(id);
            Verify(client.TakeSingle());

            await instance.UserCurrentGetGPGKeyAsync(id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentGetKey: GET /user/keys/{id}
        /// </summary>
        [Fact]
        public async Task UserCurrentGetKeyTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/keys/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentGetKey(id);
            Verify(client.TakeSingle());

            await instance.UserCurrentGetKeyAsync(id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentGetProject: GET /user/projects/{id}
        /// </summary>
        [Fact]
        public async Task UserCurrentGetProjectTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/projects/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentGetProject(id);
            Verify(client.TakeSingle());

            await instance.UserCurrentGetProjectAsync(id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentGetProjectColumn: GET /user/projects/{id}/columns/{column_id}
        /// </summary>
        [Fact]
        public async Task UserCurrentGetProjectColumnTest()
        {
            long id = 1;
            long columnId = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/projects/{id}/columns/{column_id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentGetProjectColumn(id, columnId);
            Verify(client.TakeSingle());

            await instance.UserCurrentGetProjectColumnAsync(id, columnId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentListFollowers: GET /user/followers
        /// </summary>
        [Fact]
        public async Task UserCurrentListFollowersTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/followers");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentListFollowers(page, limit);
            Verify(client.TakeSingle());

            await instance.UserCurrentListFollowersAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentListFollowing: GET /user/following
        /// </summary>
        [Fact]
        public async Task UserCurrentListFollowingTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/following");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentListFollowing(page, limit);
            Verify(client.TakeSingle());

            await instance.UserCurrentListFollowingAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentListGPGKeys: GET /user/gpg_keys
        /// </summary>
        [Fact]
        public async Task UserCurrentListGPGKeysTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/gpg_keys");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentListGPGKeys(page, limit);
            Verify(client.TakeSingle());

            await instance.UserCurrentListGPGKeysAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentListKeys: GET /user/keys
        /// </summary>
        [Fact]
        public async Task UserCurrentListKeysTest()
        {
            string? fingerprint = "fingerprint-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/keys");
                RequestAssert.QueryParameter(r, "fingerprint");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentListKeys(fingerprint, page, limit);
            Verify(client.TakeSingle());

            await instance.UserCurrentListKeysAsync(fingerprint, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentListProjectColumnIssues: GET /user/projects/{id}/columns/{column_id}/issues
        /// </summary>
        [Fact]
        public async Task UserCurrentListProjectColumnIssuesTest()
        {
            long id = 1;
            long columnId = 2;
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/projects/{id}/columns/{column_id}/issues");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentListProjectColumnIssues(id, columnId, page, limit);
            Verify(client.TakeSingle());

            await instance.UserCurrentListProjectColumnIssuesAsync(id, columnId, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentListProjectColumns: GET /user/projects/{id}/columns
        /// </summary>
        [Fact]
        public async Task UserCurrentListProjectColumnsTest()
        {
            long id = 1;
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/projects/{id}/columns");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentListProjectColumns(id, page, limit);
            Verify(client.TakeSingle());

            await instance.UserCurrentListProjectColumnsAsync(id, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentListProjects: GET /user/projects
        /// </summary>
        [Fact]
        public async Task UserCurrentListProjectsTest()
        {
            string? state = "state-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/projects");
                RequestAssert.QueryParameter(r, "state");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentListProjects(state, page, limit);
            Verify(client.TakeSingle());

            await instance.UserCurrentListProjectsAsync(state, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentListRepos: GET /user/repos
        /// </summary>
        [Fact]
        public async Task UserCurrentListReposTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/repos");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentListRepos(page, limit);
            Verify(client.TakeSingle());

            await instance.UserCurrentListReposAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentListStarred: GET /user/starred
        /// </summary>
        [Fact]
        public async Task UserCurrentListStarredTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/starred");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentListStarred(page, limit);
            Verify(client.TakeSingle());

            await instance.UserCurrentListStarredAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentListSubscriptions: GET /user/subscriptions
        /// </summary>
        [Fact]
        public async Task UserCurrentListSubscriptionsTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/subscriptions");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentListSubscriptions(page, limit);
            Verify(client.TakeSingle());

            await instance.UserCurrentListSubscriptionsAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentMoveProjectColumns: POST /user/projects/{id}/columns/move
        /// </summary>
        [Fact]
        public async Task UserCurrentMoveProjectColumnsTest()
        {
            long id = 1;
            MoveProjectColumnsOption? body = NewModel<MoveProjectColumnsOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/projects/{id}/columns/move");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentMoveProjectColumns(id, body);
            Verify(client.TakeSingle());

            await instance.UserCurrentMoveProjectColumnsAsync(id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentMoveProjectIssue: POST /user/projects/{id}/issues/{issue_id}/move
        /// </summary>
        [Fact]
        public async Task UserCurrentMoveProjectIssueTest()
        {
            long id = 1;
            long issueId = 2;
            MoveProjectIssueOption? body = NewModel<MoveProjectIssueOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/projects/{id}/issues/{issue_id}/move");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "issue_id", issueId);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentMoveProjectIssue(id, issueId, body);
            Verify(client.TakeSingle());

            await instance.UserCurrentMoveProjectIssueAsync(id, issueId, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentPostGPGKey: POST /user/gpg_keys
        /// </summary>
        [Fact]
        public async Task UserCurrentPostGPGKeyTest()
        {
            CreateGPGKeyOption? form = NewModel<CreateGPGKeyOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/gpg_keys");
                RequestAssert.Body(r, form);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentPostGPGKey(form);
            Verify(client.TakeSingle());

            await instance.UserCurrentPostGPGKeyAsync(form, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentPostKey: POST /user/keys
        /// </summary>
        [Fact]
        public async Task UserCurrentPostKeyTest()
        {
            CreateKeyOption? body = NewModel<CreateKeyOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/keys");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentPostKey(body);
            Verify(client.TakeSingle());

            await instance.UserCurrentPostKeyAsync(body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentPutFollow: PUT /user/following/{username}
        /// </summary>
        [Fact]
        public async Task UserCurrentPutFollowTest()
        {
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/user/following/{username}");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentPutFollow(username);
            Verify(client.TakeSingle());

            await instance.UserCurrentPutFollowAsync(username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentPutStar: PUT /user/starred/{owner}/{repo}
        /// </summary>
        [Fact]
        public async Task UserCurrentPutStarTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/user/starred/{owner}/{repo}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentPutStar(owner, repo);
            Verify(client.TakeSingle());

            await instance.UserCurrentPutStarAsync(owner, repo, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentRemoveIssueFromProjectColumn: DELETE /user/projects/{id}/columns/{column_id}/issues/{issue_id}
        /// </summary>
        [Fact]
        public async Task UserCurrentRemoveIssueFromProjectColumnTest()
        {
            long id = 1;
            long columnId = 2;
            long issueId = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/projects/{id}/columns/{column_id}/issues/{issue_id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.PathParameter(r, "issue_id", issueId);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentRemoveIssueFromProjectColumn(id, columnId, issueId);
            Verify(client.TakeSingle());

            await instance.UserCurrentRemoveIssueFromProjectColumnAsync(id, columnId, issueId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentSetDefaultProjectColumn: POST /user/projects/{id}/columns/{column_id}/default
        /// </summary>
        [Fact]
        public async Task UserCurrentSetDefaultProjectColumnTest()
        {
            long id = 1;
            long columnId = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/projects/{id}/columns/{column_id}/default");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentSetDefaultProjectColumn(id, columnId);
            Verify(client.TakeSingle());

            await instance.UserCurrentSetDefaultProjectColumnAsync(id, columnId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentTrackedTimes: GET /user/times
        /// </summary>
        [Fact]
        public async Task UserCurrentTrackedTimesTest()
        {
            int? page = 1;
            int? limit = 2;
            DateTime? since = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            DateTime? before = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/times");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "since");
                RequestAssert.QueryParameter(r, "before");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentTrackedTimes(page, limit, since, before);
            Verify(client.TakeSingle());

            await instance.UserCurrentTrackedTimesAsync(page, limit, since, before, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserDeleteAccessToken: DELETE /users/{username}/tokens/{token}
        /// </summary>
        [Fact]
        public async Task UserDeleteAccessTokenTest()
        {
            string username = "username-value";
            string token = "token-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/users/{username}/tokens/{token}");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.PathParameter(r, "token", token);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserDeleteAccessToken(username, token);
            Verify(client.TakeSingle());

            await instance.UserDeleteAccessTokenAsync(username, token, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserDeleteAvatar: DELETE /user/avatar
        /// </summary>
        [Fact]
        public async Task UserDeleteAvatarTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/avatar");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserDeleteAvatar();
            Verify(client.TakeSingle());

            await instance.UserDeleteAvatarAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserDeleteEmail: DELETE /user/emails
        /// </summary>
        [Fact]
        public async Task UserDeleteEmailTest()
        {
            DeleteEmailOption? body = NewModel<DeleteEmailOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/emails");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserDeleteEmail(body);
            Verify(client.TakeSingle());

            await instance.UserDeleteEmailAsync(body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserDeleteHook: DELETE /user/hooks/{id}
        /// </summary>
        [Fact]
        public async Task UserDeleteHookTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/hooks/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserDeleteHook(id);
            Verify(client.TakeSingle());

            await instance.UserDeleteHookAsync(id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserDeleteOAuth2Application: DELETE /user/applications/oauth2/{id}
        /// </summary>
        [Fact]
        public async Task UserDeleteOAuth2ApplicationTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/applications/oauth2/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserDeleteOAuth2Application(id);
            Verify(client.TakeSingle());

            await instance.UserDeleteOAuth2ApplicationAsync(id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserEditHook: PATCH /user/hooks/{id}
        /// </summary>
        [Fact]
        public async Task UserEditHookTest()
        {
            long id = 1;
            EditHookOption? body = NewModel<EditHookOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/user/hooks/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserEditHook(id, body);
            Verify(client.TakeSingle());

            await instance.UserEditHookAsync(id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserGet: GET /users/{username}
        /// </summary>
        [Fact]
        public async Task UserGetTest()
        {
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserGet(username);
            Verify(client.TakeSingle());

            await instance.UserGetAsync(username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserGetCurrent: GET /user
        /// </summary>
        [Fact]
        public async Task UserGetCurrentTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserGetCurrent();
            Verify(client.TakeSingle());

            await instance.UserGetCurrentAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserGetHeatmapData: GET /users/{username}/heatmap
        /// </summary>
        [Fact]
        public async Task UserGetHeatmapDataTest()
        {
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/heatmap");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserGetHeatmapData(username);
            Verify(client.TakeSingle());

            await instance.UserGetHeatmapDataAsync(username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserGetHook: GET /user/hooks/{id}
        /// </summary>
        [Fact]
        public async Task UserGetHookTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/hooks/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserGetHook(id);
            Verify(client.TakeSingle());

            await instance.UserGetHookAsync(id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserGetOAuth2Application: GET /user/applications/oauth2/{id}
        /// </summary>
        [Fact]
        public async Task UserGetOAuth2ApplicationTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/applications/oauth2/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserGetOAuth2Application(id);
            Verify(client.TakeSingle());

            await instance.UserGetOAuth2ApplicationAsync(id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserGetOauth2Application: GET /user/applications/oauth2
        /// </summary>
        [Fact]
        public async Task UserGetOauth2ApplicationTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/applications/oauth2");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserGetOauth2Application(page, limit);
            Verify(client.TakeSingle());

            await instance.UserGetOauth2ApplicationAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserGetStopWatches: GET /user/stopwatches
        /// </summary>
        [Fact]
        public async Task UserGetStopWatchesTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/stopwatches");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserGetStopWatches(page, limit);
            Verify(client.TakeSingle());

            await instance.UserGetStopWatchesAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserGetTokens: GET /users/{username}/tokens
        /// </summary>
        [Fact]
        public async Task UserGetTokensTest()
        {
            string username = "username-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/tokens");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserGetTokens(username, page, limit);
            Verify(client.TakeSingle());

            await instance.UserGetTokensAsync(username, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserListActivityFeeds: GET /users/{username}/activities/feeds
        /// </summary>
        [Fact]
        public async Task UserListActivityFeedsTest()
        {
            string username = "username-value";
            bool? onlyPerformedBy = true;
            DateTime? date = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            int? page = 4;
            int? limit = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/activities/feeds");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "only-performed-by");
                RequestAssert.QueryParameter(r, "date");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserListActivityFeeds(username, onlyPerformedBy, date, page, limit);
            Verify(client.TakeSingle());

            await instance.UserListActivityFeedsAsync(username, onlyPerformedBy, date, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserListBlocks: GET /user/blocks
        /// </summary>
        [Fact]
        public async Task UserListBlocksTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/blocks");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserListBlocks(page, limit);
            Verify(client.TakeSingle());

            await instance.UserListBlocksAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserListEmails: GET /user/emails
        /// </summary>
        [Fact]
        public async Task UserListEmailsTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/emails");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserListEmails();
            Verify(client.TakeSingle());

            await instance.UserListEmailsAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserListFollowers: GET /users/{username}/followers
        /// </summary>
        [Fact]
        public async Task UserListFollowersTest()
        {
            string username = "username-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/followers");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserListFollowers(username, page, limit);
            Verify(client.TakeSingle());

            await instance.UserListFollowersAsync(username, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserListFollowing: GET /users/{username}/following
        /// </summary>
        [Fact]
        public async Task UserListFollowingTest()
        {
            string username = "username-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/following");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserListFollowing(username, page, limit);
            Verify(client.TakeSingle());

            await instance.UserListFollowingAsync(username, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserListGPGKeys: GET /users/{username}/gpg_keys
        /// </summary>
        [Fact]
        public async Task UserListGPGKeysTest()
        {
            string username = "username-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/gpg_keys");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserListGPGKeys(username, page, limit);
            Verify(client.TakeSingle());

            await instance.UserListGPGKeysAsync(username, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserListHooks: GET /user/hooks
        /// </summary>
        [Fact]
        public async Task UserListHooksTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/hooks");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserListHooks(page, limit);
            Verify(client.TakeSingle());

            await instance.UserListHooksAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserListKeys: GET /users/{username}/keys
        /// </summary>
        [Fact]
        public async Task UserListKeysTest()
        {
            string username = "username-value";
            string? fingerprint = "fingerprint-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/keys");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "fingerprint");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserListKeys(username, fingerprint, page, limit);
            Verify(client.TakeSingle());

            await instance.UserListKeysAsync(username, fingerprint, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserListProjects: GET /users/{username}/projects
        /// </summary>
        [Fact]
        public async Task UserListProjectsTest()
        {
            string username = "username-value";
            string? state = "state-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/projects");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "state");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserListProjects(username, state, page, limit);
            Verify(client.TakeSingle());

            await instance.UserListProjectsAsync(username, state, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserListRepos: GET /users/{username}/repos
        /// </summary>
        [Fact]
        public async Task UserListReposTest()
        {
            string username = "username-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/repos");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserListRepos(username, page, limit);
            Verify(client.TakeSingle());

            await instance.UserListReposAsync(username, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserListStarred: GET /users/{username}/starred
        /// </summary>
        [Fact]
        public async Task UserListStarredTest()
        {
            string username = "username-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/starred");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserListStarred(username, page, limit);
            Verify(client.TakeSingle());

            await instance.UserListStarredAsync(username, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserListSubscriptions: GET /users/{username}/subscriptions
        /// </summary>
        [Fact]
        public async Task UserListSubscriptionsTest()
        {
            string username = "username-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/subscriptions");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserListSubscriptions(username, page, limit);
            Verify(client.TakeSingle());

            await instance.UserListSubscriptionsAsync(username, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserListTeams: GET /user/teams
        /// </summary>
        [Fact]
        public async Task UserListTeamsTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/teams");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserListTeams(page, limit);
            Verify(client.TakeSingle());

            await instance.UserListTeamsAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserSearch: GET /users/search
        /// </summary>
        [Fact]
        public async Task UserSearchTest()
        {
            string? q = "q-value";
            long? uid = 2;
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/search");
                RequestAssert.QueryParameter(r, "q");
                RequestAssert.QueryParameter(r, "uid");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserSearch(q, uid, page, limit);
            Verify(client.TakeSingle());

            await instance.UserSearchAsync(q, uid, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserUnblockUser: DELETE /user/blocks/{username}
        /// </summary>
        [Fact]
        public async Task UserUnblockUserTest()
        {
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/user/blocks/{username}");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserUnblockUser(username);
            Verify(client.TakeSingle());

            await instance.UserUnblockUserAsync(username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserUpdateAvatar: POST /user/avatar
        /// </summary>
        [Fact]
        public async Task UserUpdateAvatarTest()
        {
            UpdateUserAvatarOption? body = NewModel<UpdateUserAvatarOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/avatar");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserUpdateAvatar(body);
            Verify(client.TakeSingle());

            await instance.UserUpdateAvatarAsync(body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserUpdateOAuth2Application: PATCH /user/applications/oauth2/{id}
        /// </summary>
        [Fact]
        public async Task UserUpdateOAuth2ApplicationTest()
        {
            long id = 1;
            CreateOAuth2ApplicationOptions body = NewModel<CreateOAuth2ApplicationOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/user/applications/oauth2/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserUpdateOAuth2Application(id, body);
            Verify(client.TakeSingle());

            await instance.UserUpdateOAuth2ApplicationAsync(id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserVerifyGPGKey: POST /user/gpg_key_verify
        /// </summary>
        [Fact]
        public async Task UserVerifyGPGKeyTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/user/gpg_key_verify");
                RequestAssert.HasAuthToken(r);
            }

            instance.UserVerifyGPGKey();
            Verify(client.TakeSingle());

            await instance.UserVerifyGPGKeyAsync(cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }
    }
}
