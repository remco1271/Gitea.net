/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 28.3.0
 *
 * Request-shape tests for OrganizationApi. Every call is sent to RecordingApiClient, so no
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
    ///  Class for testing OrganizationApi
    /// </summary>
    public class OrganizationApiTests
    {
        private readonly RecordingApiClient client;
        private readonly OrganizationApi instance;

        public OrganizationApiTests()
        {
            client = new RecordingApiClient();
            instance = new OrganizationApi(client, client, RecordingApiClient.CreateConfiguration());
        }

        // Creates a model without running its constructor, so required-field checks don't fire.
        private static T NewModel<T>() => (T)System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(typeof(T));

        /// <summary>
        /// Test an instance of OrganizationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<OrganizationApi>(instance);
        }

        /// <summary>
        /// Test CreateOrgRepo: POST /orgs/{org}/repos
        /// </summary>
        [Fact]
        public async Task CreateOrgRepoTest()
        {
            string org = "org-value";
            CreateRepoOption? body = NewModel<CreateRepoOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/repos");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.CreateOrgRepo(org, body);
            Verify(client.TakeSingle());

            await instance.CreateOrgRepoAsync(org, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

#pragma warning disable CS0612 // deprecated endpoint
        /// <summary>
        /// Test CreateOrgRepoDeprecated: POST /org/{org}/repos
        /// </summary>
        [Fact]
        public async Task CreateOrgRepoDeprecatedTest()
        {
            string org = "org-value";
            CreateRepoOption? body = NewModel<CreateRepoOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/org/{org}/repos");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.CreateOrgRepoDeprecated(org, body);
            Verify(client.TakeSingle());

            await instance.CreateOrgRepoDeprecatedAsync(org, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }
#pragma warning restore CS0612

        /// <summary>
        /// Test CreateOrgVariable: POST /orgs/{org}/actions/variables/{variablename}
        /// </summary>
        [Fact]
        public async Task CreateOrgVariableTest()
        {
            string org = "org-value";
            string variablename = "variablename-value";
            CreateVariableOption? body = NewModel<CreateVariableOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/actions/variables/{variablename}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "variablename", variablename);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.CreateOrgVariable(org, variablename, body);
            Verify(client.TakeSingle());

            await instance.CreateOrgVariableAsync(org, variablename, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DeleteOrgRunner: DELETE /orgs/{org}/actions/runners/{runner_id}
        /// </summary>
        [Fact]
        public async Task DeleteOrgRunnerTest()
        {
            string org = "org-value";
            string runnerId = "runnerId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}/actions/runners/{runner_id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "runner_id", runnerId);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeleteOrgRunner(org, runnerId);
            Verify(client.TakeSingle());

            await instance.DeleteOrgRunnerAsync(org, runnerId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DeleteOrgSecret: DELETE /orgs/{org}/actions/secrets/{secretname}
        /// </summary>
        [Fact]
        public async Task DeleteOrgSecretTest()
        {
            string org = "org-value";
            string secretname = "secretname-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}/actions/secrets/{secretname}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "secretname", secretname);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeleteOrgSecret(org, secretname);
            Verify(client.TakeSingle());

            await instance.DeleteOrgSecretAsync(org, secretname, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DeleteOrgVariable: DELETE /orgs/{org}/actions/variables/{variablename}
        /// </summary>
        [Fact]
        public async Task DeleteOrgVariableTest()
        {
            string org = "org-value";
            string variablename = "variablename-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}/actions/variables/{variablename}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "variablename", variablename);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeleteOrgVariable(org, variablename);
            Verify(client.TakeSingle());

            await instance.DeleteOrgVariableAsync(org, variablename, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetOrgRunner: GET /orgs/{org}/actions/runners/{runner_id}
        /// </summary>
        [Fact]
        public async Task GetOrgRunnerTest()
        {
            string org = "org-value";
            string runnerId = "runnerId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/actions/runners/{runner_id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "runner_id", runnerId);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetOrgRunner(org, runnerId);
            Verify(client.TakeSingle());

            await instance.GetOrgRunnerAsync(org, runnerId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetOrgRunners: GET /orgs/{org}/actions/runners
        /// </summary>
        [Fact]
        public async Task GetOrgRunnersTest()
        {
            string org = "org-value";
            bool? disabled = true;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/actions/runners");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "disabled");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetOrgRunners(org, disabled);
            Verify(client.TakeSingle());

            await instance.GetOrgRunnersAsync(org, disabled, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetOrgVariable: GET /orgs/{org}/actions/variables/{variablename}
        /// </summary>
        [Fact]
        public async Task GetOrgVariableTest()
        {
            string org = "org-value";
            string variablename = "variablename-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/actions/variables/{variablename}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "variablename", variablename);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetOrgVariable(org, variablename);
            Verify(client.TakeSingle());

            await instance.GetOrgVariableAsync(org, variablename, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetOrgVariablesList: GET /orgs/{org}/actions/variables
        /// </summary>
        [Fact]
        public async Task GetOrgVariablesListTest()
        {
            string org = "org-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/actions/variables");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetOrgVariablesList(org, page, limit);
            Verify(client.TakeSingle());

            await instance.GetOrgVariablesListAsync(org, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetOrgWorkflowJobs: GET /orgs/{org}/actions/jobs
        /// </summary>
        [Fact]
        public async Task GetOrgWorkflowJobsTest()
        {
            string org = "org-value";
            string? status = "status-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/actions/jobs");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "status");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetOrgWorkflowJobs(org, status, page, limit);
            Verify(client.TakeSingle());

            await instance.GetOrgWorkflowJobsAsync(org, status, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetOrgWorkflowRuns: GET /orgs/{org}/actions/runs
        /// </summary>
        [Fact]
        public async Task GetOrgWorkflowRunsTest()
        {
            string org = "org-value";
            string? varEvent = "varEvent-value";
            string? branch = "branch-value";
            string? status = "status-value";
            string? actor = "actor-value";
            string? headSha = "headSha-value";
            int? page = 7;
            int? limit = 8;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/actions/runs");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "event");
                RequestAssert.QueryParameter(r, "branch");
                RequestAssert.QueryParameter(r, "status");
                RequestAssert.QueryParameter(r, "actor");
                RequestAssert.QueryParameter(r, "head_sha");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetOrgWorkflowRuns(org, varEvent, branch, status, actor, headSha, page, limit);
            Verify(client.TakeSingle());

            await instance.GetOrgWorkflowRunsAsync(org, varEvent, branch, status, actor, headSha, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgAddIssueToProjectColumn: POST /orgs/{org}/projects/{id}/columns/{column_id}/issues/{issue_id}
        /// </summary>
        [Fact]
        public async Task OrgAddIssueToProjectColumnTest()
        {
            string org = "org-value";
            long id = 2;
            long columnId = 3;
            long issueId = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/projects/{id}/columns/{column_id}/issues/{issue_id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.PathParameter(r, "issue_id", issueId);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgAddIssueToProjectColumn(org, id, columnId, issueId);
            Verify(client.TakeSingle());

            await instance.OrgAddIssueToProjectColumnAsync(org, id, columnId, issueId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgAddTeamMember: PUT /teams/{id}/members/{username}
        /// </summary>
        [Fact]
        public async Task OrgAddTeamMemberTest()
        {
            long id = 1;
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/teams/{id}/members/{username}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgAddTeamMember(id, username);
            Verify(client.TakeSingle());

            await instance.OrgAddTeamMemberAsync(id, username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgAddTeamRepository: PUT /teams/{id}/repos/{org}/{repo}
        /// </summary>
        [Fact]
        public async Task OrgAddTeamRepositoryTest()
        {
            long id = 1;
            string org = "org-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/teams/{id}/repos/{org}/{repo}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgAddTeamRepository(id, org, repo);
            Verify(client.TakeSingle());

            await instance.OrgAddTeamRepositoryAsync(id, org, repo, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgConcealMember: DELETE /orgs/{org}/public_members/{username}
        /// </summary>
        [Fact]
        public async Task OrgConcealMemberTest()
        {
            string org = "org-value";
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}/public_members/{username}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgConcealMember(org, username);
            Verify(client.TakeSingle());

            await instance.OrgConcealMemberAsync(org, username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgCreate: POST /orgs
        /// </summary>
        [Fact]
        public async Task OrgCreateTest()
        {
            CreateOrgOption organization = NewModel<CreateOrgOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs");
                RequestAssert.Body(r, organization);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgCreate(organization);
            Verify(client.TakeSingle());

            await instance.OrgCreateAsync(organization, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgCreateHook: POST /orgs/{org}/hooks
        /// </summary>
        [Fact]
        public async Task OrgCreateHookTest()
        {
            string org = "org-value";
            CreateHookOption body = NewModel<CreateHookOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/hooks");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgCreateHook(org, body);
            Verify(client.TakeSingle());

            await instance.OrgCreateHookAsync(org, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgCreateLabel: POST /orgs/{org}/labels
        /// </summary>
        [Fact]
        public async Task OrgCreateLabelTest()
        {
            string org = "org-value";
            CreateLabelOption? body = NewModel<CreateLabelOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/labels");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgCreateLabel(org, body);
            Verify(client.TakeSingle());

            await instance.OrgCreateLabelAsync(org, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgCreateProject: POST /orgs/{org}/projects
        /// </summary>
        [Fact]
        public async Task OrgCreateProjectTest()
        {
            string org = "org-value";
            CreateProjectOption? body = NewModel<CreateProjectOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/projects");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgCreateProject(org, body);
            Verify(client.TakeSingle());

            await instance.OrgCreateProjectAsync(org, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgCreateProjectColumn: POST /orgs/{org}/projects/{id}/columns
        /// </summary>
        [Fact]
        public async Task OrgCreateProjectColumnTest()
        {
            string org = "org-value";
            long id = 2;
            CreateProjectColumnOption? body = NewModel<CreateProjectColumnOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/projects/{id}/columns");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgCreateProjectColumn(org, id, body);
            Verify(client.TakeSingle());

            await instance.OrgCreateProjectColumnAsync(org, id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgCreateRunnerRegistrationToken: POST /orgs/{org}/actions/runners/registration-token
        /// </summary>
        [Fact]
        public async Task OrgCreateRunnerRegistrationTokenTest()
        {
            string org = "org-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/actions/runners/registration-token");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgCreateRunnerRegistrationToken(org);
            Verify(client.TakeSingle());

            await instance.OrgCreateRunnerRegistrationTokenAsync(org, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgCreateTeam: POST /orgs/{org}/teams
        /// </summary>
        [Fact]
        public async Task OrgCreateTeamTest()
        {
            string org = "org-value";
            CreateTeamOption? body = NewModel<CreateTeamOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/teams");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgCreateTeam(org, body);
            Verify(client.TakeSingle());

            await instance.OrgCreateTeamAsync(org, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgDelete: DELETE /orgs/{org}
        /// </summary>
        [Fact]
        public async Task OrgDeleteTest()
        {
            string org = "org-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgDelete(org);
            Verify(client.TakeSingle());

            await instance.OrgDeleteAsync(org, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgDeleteAvatar: DELETE /orgs/{org}/avatar
        /// </summary>
        [Fact]
        public async Task OrgDeleteAvatarTest()
        {
            string org = "org-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}/avatar");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgDeleteAvatar(org);
            Verify(client.TakeSingle());

            await instance.OrgDeleteAvatarAsync(org, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgDeleteHook: DELETE /orgs/{org}/hooks/{id}
        /// </summary>
        [Fact]
        public async Task OrgDeleteHookTest()
        {
            string org = "org-value";
            long id = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}/hooks/{id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgDeleteHook(org, id);
            Verify(client.TakeSingle());

            await instance.OrgDeleteHookAsync(org, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgDeleteLabel: DELETE /orgs/{org}/labels/{id}
        /// </summary>
        [Fact]
        public async Task OrgDeleteLabelTest()
        {
            string org = "org-value";
            long id = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}/labels/{id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgDeleteLabel(org, id);
            Verify(client.TakeSingle());

            await instance.OrgDeleteLabelAsync(org, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgDeleteMember: DELETE /orgs/{org}/members/{username}
        /// </summary>
        [Fact]
        public async Task OrgDeleteMemberTest()
        {
            string org = "org-value";
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}/members/{username}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgDeleteMember(org, username);
            Verify(client.TakeSingle());

            await instance.OrgDeleteMemberAsync(org, username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgDeleteProject: DELETE /orgs/{org}/projects/{id}
        /// </summary>
        [Fact]
        public async Task OrgDeleteProjectTest()
        {
            string org = "org-value";
            long id = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}/projects/{id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgDeleteProject(org, id);
            Verify(client.TakeSingle());

            await instance.OrgDeleteProjectAsync(org, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgDeleteProjectColumn: DELETE /orgs/{org}/projects/{id}/columns/{column_id}
        /// </summary>
        [Fact]
        public async Task OrgDeleteProjectColumnTest()
        {
            string org = "org-value";
            long id = 2;
            long columnId = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}/projects/{id}/columns/{column_id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgDeleteProjectColumn(org, id, columnId);
            Verify(client.TakeSingle());

            await instance.OrgDeleteProjectColumnAsync(org, id, columnId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgDeleteRepos: DELETE /orgs/{org}/repos
        /// </summary>
        [Fact]
        public async Task OrgDeleteReposTest()
        {
            string org = "org-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}/repos");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgDeleteRepos(org);
            Verify(client.TakeSingle());

            await instance.OrgDeleteReposAsync(org, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgDeleteTeam: DELETE /teams/{id}
        /// </summary>
        [Fact]
        public async Task OrgDeleteTeamTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/teams/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgDeleteTeam(id);
            Verify(client.TakeSingle());

            await instance.OrgDeleteTeamAsync(id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgEdit: PATCH /orgs/{org}
        /// </summary>
        [Fact]
        public async Task OrgEditTest()
        {
            string org = "org-value";
            EditOrgOption body = NewModel<EditOrgOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/orgs/{org}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgEdit(org, body);
            Verify(client.TakeSingle());

            await instance.OrgEditAsync(org, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgEditHook: PATCH /orgs/{org}/hooks/{id}
        /// </summary>
        [Fact]
        public async Task OrgEditHookTest()
        {
            string org = "org-value";
            long id = 2;
            EditHookOption? body = NewModel<EditHookOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/orgs/{org}/hooks/{id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgEditHook(org, id, body);
            Verify(client.TakeSingle());

            await instance.OrgEditHookAsync(org, id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgEditLabel: PATCH /orgs/{org}/labels/{id}
        /// </summary>
        [Fact]
        public async Task OrgEditLabelTest()
        {
            string org = "org-value";
            long id = 2;
            EditLabelOption? body = NewModel<EditLabelOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/orgs/{org}/labels/{id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgEditLabel(org, id, body);
            Verify(client.TakeSingle());

            await instance.OrgEditLabelAsync(org, id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgEditProject: PATCH /orgs/{org}/projects/{id}
        /// </summary>
        [Fact]
        public async Task OrgEditProjectTest()
        {
            string org = "org-value";
            long id = 2;
            EditProjectOption? body = NewModel<EditProjectOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/orgs/{org}/projects/{id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgEditProject(org, id, body);
            Verify(client.TakeSingle());

            await instance.OrgEditProjectAsync(org, id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgEditProjectColumn: PATCH /orgs/{org}/projects/{id}/columns/{column_id}
        /// </summary>
        [Fact]
        public async Task OrgEditProjectColumnTest()
        {
            string org = "org-value";
            long id = 2;
            long columnId = 3;
            EditProjectColumnOption? body = NewModel<EditProjectColumnOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/orgs/{org}/projects/{id}/columns/{column_id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgEditProjectColumn(org, id, columnId, body);
            Verify(client.TakeSingle());

            await instance.OrgEditProjectColumnAsync(org, id, columnId, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgEditTeam: PATCH /teams/{id}
        /// </summary>
        [Fact]
        public async Task OrgEditTeamTest()
        {
            int id = 1;
            EditTeamOption? body = NewModel<EditTeamOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/teams/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgEditTeam(id, body);
            Verify(client.TakeSingle());

            await instance.OrgEditTeamAsync(id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgGet: GET /orgs/{org}
        /// </summary>
        [Fact]
        public async Task OrgGetTest()
        {
            string org = "org-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgGet(org);
            Verify(client.TakeSingle());

            await instance.OrgGetAsync(org, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgGetAll: GET /orgs
        /// </summary>
        [Fact]
        public async Task OrgGetAllTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgGetAll(page, limit);
            Verify(client.TakeSingle());

            await instance.OrgGetAllAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgGetHook: GET /orgs/{org}/hooks/{id}
        /// </summary>
        [Fact]
        public async Task OrgGetHookTest()
        {
            string org = "org-value";
            long id = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/hooks/{id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgGetHook(org, id);
            Verify(client.TakeSingle());

            await instance.OrgGetHookAsync(org, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgGetLabel: GET /orgs/{org}/labels/{id}
        /// </summary>
        [Fact]
        public async Task OrgGetLabelTest()
        {
            string org = "org-value";
            long id = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/labels/{id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgGetLabel(org, id);
            Verify(client.TakeSingle());

            await instance.OrgGetLabelAsync(org, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgGetProject: GET /orgs/{org}/projects/{id}
        /// </summary>
        [Fact]
        public async Task OrgGetProjectTest()
        {
            string org = "org-value";
            long id = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/projects/{id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgGetProject(org, id);
            Verify(client.TakeSingle());

            await instance.OrgGetProjectAsync(org, id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgGetProjectColumn: GET /orgs/{org}/projects/{id}/columns/{column_id}
        /// </summary>
        [Fact]
        public async Task OrgGetProjectColumnTest()
        {
            string org = "org-value";
            long id = 2;
            long columnId = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/projects/{id}/columns/{column_id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgGetProjectColumn(org, id, columnId);
            Verify(client.TakeSingle());

            await instance.OrgGetProjectColumnAsync(org, id, columnId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgGetTeam: GET /teams/{id}
        /// </summary>
        [Fact]
        public async Task OrgGetTeamTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/teams/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgGetTeam(id);
            Verify(client.TakeSingle());

            await instance.OrgGetTeamAsync(id, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgGetUserPermissions: GET /users/{username}/orgs/{org}/permissions
        /// </summary>
        [Fact]
        public async Task OrgGetUserPermissionsTest()
        {
            string username = "username-value";
            string org = "org-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/orgs/{org}/permissions");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgGetUserPermissions(username, org);
            Verify(client.TakeSingle());

            await instance.OrgGetUserPermissionsAsync(username, org, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgIsMember: GET /orgs/{org}/members/{username}
        /// </summary>
        [Fact]
        public async Task OrgIsMemberTest()
        {
            string org = "org-value";
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/members/{username}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgIsMember(org, username);
            Verify(client.TakeSingle());

            await instance.OrgIsMemberAsync(org, username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgIsPublicMember: GET /orgs/{org}/public_members/{username}
        /// </summary>
        [Fact]
        public async Task OrgIsPublicMemberTest()
        {
            string org = "org-value";
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/public_members/{username}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgIsPublicMember(org, username);
            Verify(client.TakeSingle());

            await instance.OrgIsPublicMemberAsync(org, username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListActionsSecrets: GET /orgs/{org}/actions/secrets
        /// </summary>
        [Fact]
        public async Task OrgListActionsSecretsTest()
        {
            string org = "org-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/actions/secrets");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListActionsSecrets(org, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListActionsSecretsAsync(org, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListActivityFeeds: GET /orgs/{org}/activities/feeds
        /// </summary>
        [Fact]
        public async Task OrgListActivityFeedsTest()
        {
            string org = "org-value";
            DateTime? date = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/activities/feeds");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "date");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListActivityFeeds(org, date, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListActivityFeedsAsync(org, date, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListCurrentUserOrgs: GET /user/orgs
        /// </summary>
        [Fact]
        public async Task OrgListCurrentUserOrgsTest()
        {
            int? page = 1;
            int? limit = 2;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/user/orgs");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListCurrentUserOrgs(page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListCurrentUserOrgsAsync(page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListHooks: GET /orgs/{org}/hooks
        /// </summary>
        [Fact]
        public async Task OrgListHooksTest()
        {
            string org = "org-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/hooks");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListHooks(org, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListHooksAsync(org, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListLabels: GET /orgs/{org}/labels
        /// </summary>
        [Fact]
        public async Task OrgListLabelsTest()
        {
            string org = "org-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/labels");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListLabels(org, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListLabelsAsync(org, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListMembers: GET /orgs/{org}/members
        /// </summary>
        [Fact]
        public async Task OrgListMembersTest()
        {
            string org = "org-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/members");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListMembers(org, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListMembersAsync(org, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListProjectColumnIssues: GET /orgs/{org}/projects/{id}/columns/{column_id}/issues
        /// </summary>
        [Fact]
        public async Task OrgListProjectColumnIssuesTest()
        {
            string org = "org-value";
            long id = 2;
            long columnId = 3;
            int? page = 4;
            int? limit = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/projects/{id}/columns/{column_id}/issues");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListProjectColumnIssues(org, id, columnId, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListProjectColumnIssuesAsync(org, id, columnId, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListProjectColumns: GET /orgs/{org}/projects/{id}/columns
        /// </summary>
        [Fact]
        public async Task OrgListProjectColumnsTest()
        {
            string org = "org-value";
            long id = 2;
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/projects/{id}/columns");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListProjectColumns(org, id, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListProjectColumnsAsync(org, id, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListProjects: GET /orgs/{org}/projects
        /// </summary>
        [Fact]
        public async Task OrgListProjectsTest()
        {
            string org = "org-value";
            string? state = "state-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/projects");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "state");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListProjects(org, state, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListProjectsAsync(org, state, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListPublicMembers: GET /orgs/{org}/public_members
        /// </summary>
        [Fact]
        public async Task OrgListPublicMembersTest()
        {
            string org = "org-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/public_members");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListPublicMembers(org, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListPublicMembersAsync(org, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListRepos: GET /orgs/{org}/repos
        /// </summary>
        [Fact]
        public async Task OrgListReposTest()
        {
            string org = "org-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/repos");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListRepos(org, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListReposAsync(org, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListTeamActivityFeeds: GET /teams/{id}/activities/feeds
        /// </summary>
        [Fact]
        public async Task OrgListTeamActivityFeedsTest()
        {
            long id = 1;
            DateTime? date = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/teams/{id}/activities/feeds");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.QueryParameter(r, "date");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListTeamActivityFeeds(id, date, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListTeamActivityFeedsAsync(id, date, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListTeamMember: GET /teams/{id}/members/{username}
        /// </summary>
        [Fact]
        public async Task OrgListTeamMemberTest()
        {
            long id = 1;
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/teams/{id}/members/{username}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListTeamMember(id, username);
            Verify(client.TakeSingle());

            await instance.OrgListTeamMemberAsync(id, username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListTeamMembers: GET /teams/{id}/members
        /// </summary>
        [Fact]
        public async Task OrgListTeamMembersTest()
        {
            long id = 1;
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/teams/{id}/members");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListTeamMembers(id, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListTeamMembersAsync(id, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListTeamRepo: GET /teams/{id}/repos/{org}/{repo}
        /// </summary>
        [Fact]
        public async Task OrgListTeamRepoTest()
        {
            long id = 1;
            string org = "org-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/teams/{id}/repos/{org}/{repo}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListTeamRepo(id, org, repo);
            Verify(client.TakeSingle());

            await instance.OrgListTeamRepoAsync(id, org, repo, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListTeamRepos: GET /teams/{id}/repos
        /// </summary>
        [Fact]
        public async Task OrgListTeamReposTest()
        {
            long id = 1;
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/teams/{id}/repos");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListTeamRepos(id, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListTeamReposAsync(id, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListTeams: GET /orgs/{org}/teams
        /// </summary>
        [Fact]
        public async Task OrgListTeamsTest()
        {
            string org = "org-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/teams");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListTeams(org, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListTeamsAsync(org, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgListUserOrgs: GET /users/{username}/orgs
        /// </summary>
        [Fact]
        public async Task OrgListUserOrgsTest()
        {
            string username = "username-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/users/{username}/orgs");
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgListUserOrgs(username, page, limit);
            Verify(client.TakeSingle());

            await instance.OrgListUserOrgsAsync(username, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgMoveProjectColumns: POST /orgs/{org}/projects/{id}/columns/move
        /// </summary>
        [Fact]
        public async Task OrgMoveProjectColumnsTest()
        {
            string org = "org-value";
            long id = 2;
            MoveProjectColumnsOption? body = NewModel<MoveProjectColumnsOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/projects/{id}/columns/move");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgMoveProjectColumns(org, id, body);
            Verify(client.TakeSingle());

            await instance.OrgMoveProjectColumnsAsync(org, id, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgMoveProjectIssue: POST /orgs/{org}/projects/{id}/issues/{issue_id}/move
        /// </summary>
        [Fact]
        public async Task OrgMoveProjectIssueTest()
        {
            string org = "org-value";
            long id = 2;
            long issueId = 3;
            MoveProjectIssueOption? body = NewModel<MoveProjectIssueOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/projects/{id}/issues/{issue_id}/move");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "issue_id", issueId);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgMoveProjectIssue(org, id, issueId, body);
            Verify(client.TakeSingle());

            await instance.OrgMoveProjectIssueAsync(org, id, issueId, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgPublicizeMember: PUT /orgs/{org}/public_members/{username}
        /// </summary>
        [Fact]
        public async Task OrgPublicizeMemberTest()
        {
            string org = "org-value";
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/orgs/{org}/public_members/{username}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgPublicizeMember(org, username);
            Verify(client.TakeSingle());

            await instance.OrgPublicizeMemberAsync(org, username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgRemoveIssueFromProjectColumn: DELETE /orgs/{org}/projects/{id}/columns/{column_id}/issues/{issue_id}
        /// </summary>
        [Fact]
        public async Task OrgRemoveIssueFromProjectColumnTest()
        {
            string org = "org-value";
            long id = 2;
            long columnId = 3;
            long issueId = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}/projects/{id}/columns/{column_id}/issues/{issue_id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.PathParameter(r, "issue_id", issueId);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgRemoveIssueFromProjectColumn(org, id, columnId, issueId);
            Verify(client.TakeSingle());

            await instance.OrgRemoveIssueFromProjectColumnAsync(org, id, columnId, issueId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgRemoveTeamMember: DELETE /teams/{id}/members/{username}
        /// </summary>
        [Fact]
        public async Task OrgRemoveTeamMemberTest()
        {
            long id = 1;
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/teams/{id}/members/{username}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgRemoveTeamMember(id, username);
            Verify(client.TakeSingle());

            await instance.OrgRemoveTeamMemberAsync(id, username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgRemoveTeamRepository: DELETE /teams/{id}/repos/{org}/{repo}
        /// </summary>
        [Fact]
        public async Task OrgRemoveTeamRepositoryTest()
        {
            long id = 1;
            string org = "org-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/teams/{id}/repos/{org}/{repo}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgRemoveTeamRepository(id, org, repo);
            Verify(client.TakeSingle());

            await instance.OrgRemoveTeamRepositoryAsync(id, org, repo, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgSetDefaultProjectColumn: POST /orgs/{org}/projects/{id}/columns/{column_id}/default
        /// </summary>
        [Fact]
        public async Task OrgSetDefaultProjectColumnTest()
        {
            string org = "org-value";
            long id = 2;
            long columnId = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/projects/{id}/columns/{column_id}/default");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgSetDefaultProjectColumn(org, id, columnId);
            Verify(client.TakeSingle());

            await instance.OrgSetDefaultProjectColumnAsync(org, id, columnId, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrgUpdateAvatar: POST /orgs/{org}/avatar
        /// </summary>
        [Fact]
        public async Task OrgUpdateAvatarTest()
        {
            string org = "org-value";
            UpdateUserAvatarOption? body = NewModel<UpdateUserAvatarOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/avatar");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrgUpdateAvatar(org, body);
            Verify(client.TakeSingle());

            await instance.OrgUpdateAvatarAsync(org, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrganizationBlockUser: PUT /orgs/{org}/blocks/{username}
        /// </summary>
        [Fact]
        public async Task OrganizationBlockUserTest()
        {
            string org = "org-value";
            string username = "username-value";
            string? note = "note-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/orgs/{org}/blocks/{username}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.QueryParameter(r, "note");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrganizationBlockUser(org, username, note);
            Verify(client.TakeSingle());

            await instance.OrganizationBlockUserAsync(org, username, note, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrganizationCheckUserBlock: GET /orgs/{org}/blocks/{username}
        /// </summary>
        [Fact]
        public async Task OrganizationCheckUserBlockTest()
        {
            string org = "org-value";
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/blocks/{username}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrganizationCheckUserBlock(org, username);
            Verify(client.TakeSingle());

            await instance.OrganizationCheckUserBlockAsync(org, username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrganizationListBlocks: GET /orgs/{org}/blocks
        /// </summary>
        [Fact]
        public async Task OrganizationListBlocksTest()
        {
            string org = "org-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/blocks");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.OrganizationListBlocks(org, page, limit);
            Verify(client.TakeSingle());

            await instance.OrganizationListBlocksAsync(org, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test OrganizationUnblockUser: DELETE /orgs/{org}/blocks/{username}
        /// </summary>
        [Fact]
        public async Task OrganizationUnblockUserTest()
        {
            string org = "org-value";
            string username = "username-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/orgs/{org}/blocks/{username}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "username", username);
                RequestAssert.HasAuthToken(r);
            }

            instance.OrganizationUnblockUser(org, username);
            Verify(client.TakeSingle());

            await instance.OrganizationUnblockUserAsync(org, username, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RenameOrg: POST /orgs/{org}/rename
        /// </summary>
        [Fact]
        public async Task RenameOrgTest()
        {
            string org = "org-value";
            RenameOrgOption body = NewModel<RenameOrgOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/orgs/{org}/rename");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RenameOrg(org, body);
            Verify(client.TakeSingle());

            await instance.RenameOrgAsync(org, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test TeamSearch: GET /orgs/{org}/teams/search
        /// </summary>
        [Fact]
        public async Task TeamSearchTest()
        {
            string org = "org-value";
            string? q = "q-value";
            bool? includeDesc = true;
            int? page = 4;
            int? limit = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/orgs/{org}/teams/search");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.QueryParameter(r, "q");
                RequestAssert.QueryParameter(r, "include_desc");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.TeamSearch(org, q, includeDesc, page, limit);
            Verify(client.TakeSingle());

            await instance.TeamSearchAsync(org, q, includeDesc, page, limit, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UpdateOrgRunner: PATCH /orgs/{org}/actions/runners/{runner_id}
        /// </summary>
        [Fact]
        public async Task UpdateOrgRunnerTest()
        {
            string org = "org-value";
            string runnerId = "runnerId-value";
            EditActionRunnerOption? body = NewModel<EditActionRunnerOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/orgs/{org}/actions/runners/{runner_id}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "runner_id", runnerId);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UpdateOrgRunner(org, runnerId, body);
            Verify(client.TakeSingle());

            await instance.UpdateOrgRunnerAsync(org, runnerId, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UpdateOrgSecret: PUT /orgs/{org}/actions/secrets/{secretname}
        /// </summary>
        [Fact]
        public async Task UpdateOrgSecretTest()
        {
            string org = "org-value";
            string secretname = "secretname-value";
            CreateOrUpdateSecretOption? body = NewModel<CreateOrUpdateSecretOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/orgs/{org}/actions/secrets/{secretname}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "secretname", secretname);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UpdateOrgSecret(org, secretname, body);
            Verify(client.TakeSingle());

            await instance.UpdateOrgSecretAsync(org, secretname, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UpdateOrgVariable: PUT /orgs/{org}/actions/variables/{variablename}
        /// </summary>
        [Fact]
        public async Task UpdateOrgVariableTest()
        {
            string org = "org-value";
            string variablename = "variablename-value";
            UpdateVariableOption? body = NewModel<UpdateVariableOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/orgs/{org}/actions/variables/{variablename}");
                RequestAssert.PathParameter(r, "org", org);
                RequestAssert.PathParameter(r, "variablename", variablename);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UpdateOrgVariable(org, variablename, body);
            Verify(client.TakeSingle());

            await instance.UpdateOrgVariableAsync(org, variablename, body, cancellationToken: TestContext.Current.CancellationToken);
            Verify(client.TakeSingle());
        }
    }
}
