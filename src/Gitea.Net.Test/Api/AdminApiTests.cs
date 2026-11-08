/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 28.3.0
 *
 * Request-shape tests for AdminApi. Every call is sent to RecordingApiClient, so no
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
    ///  Class for testing AdminApi
    /// </summary>
    public class AdminApiTests
    {
        private readonly RecordingApiClient client;
        private readonly AdminApi instance;

        public AdminApiTests()
        {
            client = new RecordingApiClient();
            instance = new AdminApi(client, client, RecordingApiClient.CreateConfiguration());
        }

        // Creates a model without running its constructor, so required-field checks don't fire.
        private static T NewModel<T>() => (T)System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(typeof(T));

        /// <summary>
        /// Test an instance of AdminApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<AdminApi>(instance);
        }

        /// <summary>
        /// Test AdminAddUserBadges: POST /admin/users/{username}/badges
        /// </summary>
        [Fact]
        public async Task AdminAddUserBadgesTest()
        {
            string username = "username-value";
            UserBadgeOption? body = NewModel<UserBadgeOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/admin/users/{username}/badges");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminAddUserBadges(username, body);
            Verify(client.TakeSingle());

            await instance.AdminAddUserBadgesAsync(username, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminAdoptRepository: POST /admin/unadopted/{owner}/{repo}
        /// </summary>
        [Fact]
        public async Task AdminAdoptRepositoryTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/admin/unadopted/{owner}/{repo}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminAdoptRepository(owner, repo);
            Verify(client.TakeSingle());

            await instance.AdminAdoptRepositoryAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminCreateHook: POST /admin/hooks
        /// </summary>
        [Fact]
        public async Task AdminCreateHookTest()
        {
            CreateHookOption body = NewModel<CreateHookOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/admin/hooks");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminCreateHook(body);
            Verify(client.TakeSingle());

            await instance.AdminCreateHookAsync(body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminCreateOrg: POST /admin/users/{username}/orgs
        /// </summary>
        [Fact]
        public async Task AdminCreateOrgTest()
        {
            string username = "username-value";
            CreateOrgOption organization = NewModel<CreateOrgOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/admin/users/{username}/orgs");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.Body(r, organization);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminCreateOrg(username, organization);
            Verify(client.TakeSingle());

            await instance.AdminCreateOrgAsync(username, organization);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminCreatePublicKey: POST /admin/users/{username}/keys
        /// </summary>
        [Fact]
        public async Task AdminCreatePublicKeyTest()
        {
            string username = "username-value";
            CreateKeyOption? key = NewModel<CreateKeyOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/admin/users/{username}/keys");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.Body(r, key);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminCreatePublicKey(username, key);
            Verify(client.TakeSingle());

            await instance.AdminCreatePublicKeyAsync(username, key);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminCreateRepo: POST /admin/users/{username}/repos
        /// </summary>
        [Fact]
        public async Task AdminCreateRepoTest()
        {
            string username = "username-value";
            CreateRepoOption repository = NewModel<CreateRepoOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/admin/users/{username}/repos");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.Body(r, repository);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminCreateRepo(username, repository);
            Verify(client.TakeSingle());

            await instance.AdminCreateRepoAsync(username, repository);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminCreateRunnerRegistrationToken: POST /admin/actions/runners/registration-token
        /// </summary>
        [Fact]
        public async Task AdminCreateRunnerRegistrationTokenTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/admin/actions/runners/registration-token");
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminCreateRunnerRegistrationToken();
            Verify(client.TakeSingle());

            await instance.AdminCreateRunnerRegistrationTokenAsync();
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminCreateUser: POST /admin/users
        /// </summary>
        [Fact]
        public async Task AdminCreateUserTest()
        {
            CreateUserOption? body = NewModel<CreateUserOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/admin/users");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminCreateUser(body);
            Verify(client.TakeSingle());

            await instance.AdminCreateUserAsync(body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminCronList: GET /admin/cron
        /// </summary>
        [Fact]
        public async Task AdminCronListTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/admin/cron");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminCronList(page, limit);
            Verify(client.TakeSingle());

            await instance.AdminCronListAsync(page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminCronRun: POST /admin/cron/{task}
        /// </summary>
        [Fact]
        public async Task AdminCronRunTest()
        {
            string task = "task-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/admin/cron/{task}");
                RequestAssert.PathParameter(r, "task", task);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminCronRun(task);
            Verify(client.TakeSingle());

            await instance.AdminCronRunAsync(task);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminDeleteHook: DELETE /admin/hooks/{id}
        /// </summary>
        [Fact]
        public async Task AdminDeleteHookTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/admin/hooks/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminDeleteHook(id);
            Verify(client.TakeSingle());

            await instance.AdminDeleteHookAsync(id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminDeleteUnadoptedRepository: DELETE /admin/unadopted/{owner}/{repo}
        /// </summary>
        [Fact]
        public async Task AdminDeleteUnadoptedRepositoryTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/admin/unadopted/{owner}/{repo}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminDeleteUnadoptedRepository(owner, repo);
            Verify(client.TakeSingle());

            await instance.AdminDeleteUnadoptedRepositoryAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminDeleteUser: DELETE /admin/users/{username}
        /// </summary>
        [Fact]
        public async Task AdminDeleteUserTest()
        {
            string username = "username-value";
            bool? purge = true;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/admin/users/{username}");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "purge");
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminDeleteUser(username, purge);
            Verify(client.TakeSingle());

            await instance.AdminDeleteUserAsync(username, purge);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminDeleteUserBadges: DELETE /admin/users/{username}/badges
        /// </summary>
        [Fact]
        public async Task AdminDeleteUserBadgesTest()
        {
            string username = "username-value";
            UserBadgeOption? body = NewModel<UserBadgeOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/admin/users/{username}/badges");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminDeleteUserBadges(username, body);
            Verify(client.TakeSingle());

            await instance.AdminDeleteUserBadgesAsync(username, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminDeleteUserPublicKey: DELETE /admin/users/{username}/keys/{id}
        /// </summary>
        [Fact]
        public async Task AdminDeleteUserPublicKeyTest()
        {
            string username = "username-value";
            long id = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/admin/users/{username}/keys/{id}");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminDeleteUserPublicKey(username, id);
            Verify(client.TakeSingle());

            await instance.AdminDeleteUserPublicKeyAsync(username, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminEditHook: PATCH /admin/hooks/{id}
        /// </summary>
        [Fact]
        public async Task AdminEditHookTest()
        {
            long id = 1;
            EditHookOption? body = NewModel<EditHookOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/admin/hooks/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminEditHook(id, body);
            Verify(client.TakeSingle());

            await instance.AdminEditHookAsync(id, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminEditUser: PATCH /admin/users/{username}
        /// </summary>
        [Fact]
        public async Task AdminEditUserTest()
        {
            string username = "username-value";
            EditUserOption? body = NewModel<EditUserOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/admin/users/{username}");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminEditUser(username, body);
            Verify(client.TakeSingle());

            await instance.AdminEditUserAsync(username, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminGetAllEmails: GET /admin/emails
        /// </summary>
        [Fact]
        public async Task AdminGetAllEmailsTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/admin/emails");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminGetAllEmails(page, limit);
            Verify(client.TakeSingle());

            await instance.AdminGetAllEmailsAsync(page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminGetAllOrgs: GET /admin/orgs
        /// </summary>
        [Fact]
        public async Task AdminGetAllOrgsTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/admin/orgs");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminGetAllOrgs(page, limit);
            Verify(client.TakeSingle());

            await instance.AdminGetAllOrgsAsync(page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminGetHook: GET /admin/hooks/{id}
        /// </summary>
        [Fact]
        public async Task AdminGetHookTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/admin/hooks/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminGetHook(id);
            Verify(client.TakeSingle());

            await instance.AdminGetHookAsync(id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminListHooks: GET /admin/hooks
        /// </summary>
        [Fact]
        public async Task AdminListHooksTest()
        {
            int? page = 1;
            int? limit = 2;
            string? type = "type-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/admin/hooks");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "type");
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminListHooks(page, limit, type);
            Verify(client.TakeSingle());

            await instance.AdminListHooksAsync(page, limit, type);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminListPackages: GET /admin/packages
        /// </summary>
        [Fact]
        public async Task AdminListPackagesTest()
        {
            int? page = 1;
            int? limit = 2;
            string? type = "type-value";
            string? q = "q-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/admin/packages");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "type");
                RequestAssert.QueryParameter(r, "q");
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminListPackages(page, limit, type, q);
            Verify(client.TakeSingle());

            await instance.AdminListPackagesAsync(page, limit, type, q);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminListUserBadges: GET /admin/users/{username}/badges
        /// </summary>
        [Fact]
        public async Task AdminListUserBadgesTest()
        {
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/admin/users/{username}/badges");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminListUserBadges(username);
            Verify(client.TakeSingle());

            await instance.AdminListUserBadgesAsync(username);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminRenameUser: POST /admin/users/{username}/rename
        /// </summary>
        [Fact]
        public async Task AdminRenameUserTest()
        {
            string username = "username-value";
            RenameUserOption body = NewModel<RenameUserOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/admin/users/{username}/rename");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminRenameUser(username, body);
            Verify(client.TakeSingle());

            await instance.AdminRenameUserAsync(username, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminSearchEmails: GET /admin/emails/search
        /// </summary>
        [Fact]
        public async Task AdminSearchEmailsTest()
        {
            string? q = "q-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/admin/emails/search");
                RequestAssert.QueryParameter(r, "q");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminSearchEmails(q, page, limit);
            Verify(client.TakeSingle());

            await instance.AdminSearchEmailsAsync(q, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminSearchUsers: GET /admin/users
        /// </summary>
        [Fact]
        public async Task AdminSearchUsersTest()
        {
            long? sourceId = 1;
            string? loginName = "loginName-value";
            int? page = 3;
            int? limit = 4;
            string? sort = "sort-value";
            string? order = "order-value";
            string? q = "q-value";
            string? visibility = "visibility-value";
            bool? isActive = true;
            bool? isAdmin = true;
            bool? isRestricted = true;
            bool? is2faEnabled = true;
            bool? isProhibitLogin = true;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/admin/users");
                RequestAssert.QueryParameter(r, "source_id");
                RequestAssert.QueryParameter(r, "login_name");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "sort");
                RequestAssert.QueryParameter(r, "order");
                RequestAssert.QueryParameter(r, "q");
                RequestAssert.QueryParameter(r, "visibility");
                RequestAssert.QueryParameter(r, "is_active");
                RequestAssert.QueryParameter(r, "is_admin");
                RequestAssert.QueryParameter(r, "is_restricted");
                RequestAssert.QueryParameter(r, "is_2fa_enabled");
                RequestAssert.QueryParameter(r, "is_prohibit_login");
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminSearchUsers(sourceId, loginName, page, limit, sort, order, q, visibility, isActive, isAdmin, isRestricted, is2faEnabled, isProhibitLogin);
            Verify(client.TakeSingle());

            await instance.AdminSearchUsersAsync(sourceId, loginName, page, limit, sort, order, q, visibility, isActive, isAdmin, isRestricted, is2faEnabled, isProhibitLogin);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test AdminUnadoptedList: GET /admin/unadopted
        /// </summary>
        [Fact]
        public async Task AdminUnadoptedListTest()
        {
            int? page = 1;
            int? limit = 2;
            string? query = "query-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/admin/unadopted");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "query");
                RequestAssert.HasAuthToken(r);
            }

            instance.AdminUnadoptedList(page, limit, query);
            Verify(client.TakeSingle());

            await instance.AdminUnadoptedListAsync(page, limit, query);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DeleteAdminRunner: DELETE /admin/actions/runners/{runner_id}
        /// </summary>
        [Fact]
        public async Task DeleteAdminRunnerTest()
        {
            string runnerId = "runnerId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/admin/actions/runners/{runner_id}");
                RequestAssert.PathParameter(r, "runner_id", runnerId);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeleteAdminRunner(runnerId);
            Verify(client.TakeSingle());

            await instance.DeleteAdminRunnerAsync(runnerId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetAdminRunner: GET /admin/actions/runners/{runner_id}
        /// </summary>
        [Fact]
        public async Task GetAdminRunnerTest()
        {
            string runnerId = "runnerId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/admin/actions/runners/{runner_id}");
                RequestAssert.PathParameter(r, "runner_id", runnerId);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetAdminRunner(runnerId);
            Verify(client.TakeSingle());

            await instance.GetAdminRunnerAsync(runnerId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetAdminRunners: GET /admin/actions/runners
        /// </summary>
        [Fact]
        public async Task GetAdminRunnersTest()
        {
            bool? disabled = true;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/admin/actions/runners");
                RequestAssert.QueryParameter(r, "disabled");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetAdminRunners(disabled);
            Verify(client.TakeSingle());

            await instance.GetAdminRunnersAsync(disabled);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ListAdminWorkflowJobs: GET /admin/actions/jobs
        /// </summary>
        [Fact]
        public async Task ListAdminWorkflowJobsTest()
        {
            string? status = "status-value";
            int? page = 2;
            int? limit = 3;
            string? sort = "sort-value";
            string? order = "order-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/admin/actions/jobs");
                RequestAssert.QueryParameter(r, "status");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "sort");
                RequestAssert.QueryParameter(r, "order");
                RequestAssert.HasAuthToken(r);
            }

            instance.ListAdminWorkflowJobs(status, page, limit, sort, order);
            Verify(client.TakeSingle());

            await instance.ListAdminWorkflowJobsAsync(status, page, limit, sort, order);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ListAdminWorkflowRuns: GET /admin/actions/runs
        /// </summary>
        [Fact]
        public async Task ListAdminWorkflowRunsTest()
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
                RequestAssert.Matches(r, "GET", "/admin/actions/runs");
                RequestAssert.QueryParameter(r, "event");
                RequestAssert.QueryParameter(r, "branch");
                RequestAssert.QueryParameter(r, "status");
                RequestAssert.QueryParameter(r, "actor");
                RequestAssert.QueryParameter(r, "head_sha");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.ListAdminWorkflowRuns(varEvent, branch, status, actor, headSha, page, limit);
            Verify(client.TakeSingle());

            await instance.ListAdminWorkflowRunsAsync(varEvent, branch, status, actor, headSha, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UpdateAdminRunner: PATCH /admin/actions/runners/{runner_id}
        /// </summary>
        [Fact]
        public async Task UpdateAdminRunnerTest()
        {
            string runnerId = "runnerId-value";
            EditActionRunnerOption? body = NewModel<EditActionRunnerOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/admin/actions/runners/{runner_id}");
                RequestAssert.PathParameter(r, "runner_id", runnerId);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UpdateAdminRunner(runnerId, body);
            Verify(client.TakeSingle());

            await instance.UpdateAdminRunnerAsync(runnerId, body);
            Verify(client.TakeSingle());
        }
    }
}
