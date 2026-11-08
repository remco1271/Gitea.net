/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 28.3.0
 *
 * Request-shape tests for RepositoryApi. Every call is sent to RecordingApiClient, so no
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
    ///  Class for testing RepositoryApi
    /// </summary>
    public class RepositoryApiTests
    {
        private readonly RecordingApiClient client;
        private readonly RepositoryApi instance;

        public RepositoryApiTests()
        {
            client = new RecordingApiClient();
            instance = new RepositoryApi(client, client, RecordingApiClient.CreateConfiguration());
        }

        // Creates a model without running its constructor, so required-field checks don't fire.
        private static T NewModel<T>() => (T)System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(typeof(T));

        /// <summary>
        /// Test an instance of RepositoryApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<RepositoryApi>(instance);
        }

        /// <summary>
        /// Test AcceptRepoTransfer: POST /repos/{owner}/{repo}/transfer/accept
        /// </summary>
        [Fact]
        public async Task AcceptRepoTransferTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/transfer/accept");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.AcceptRepoTransfer(owner, repo);
            Verify(client.TakeSingle());

            await instance.AcceptRepoTransferAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ActionsDisableWorkflow: PUT /repos/{owner}/{repo}/actions/workflows/{workflow_id}/disable
        /// </summary>
        [Fact]
        public async Task ActionsDisableWorkflowTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string workflowId = "workflowId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/actions/workflows/{workflow_id}/disable");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "workflow_id", workflowId);
                RequestAssert.HasAuthToken(r);
            }

            instance.ActionsDisableWorkflow(owner, repo, workflowId);
            Verify(client.TakeSingle());

            await instance.ActionsDisableWorkflowAsync(owner, repo, workflowId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ActionsDispatchWorkflow: POST /repos/{owner}/{repo}/actions/workflows/{workflow_id}/dispatches
        /// </summary>
        [Fact]
        public async Task ActionsDispatchWorkflowTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string workflowId = "workflowId-value";
            bool? returnRunDetails = true;
            long? scopedWorkflowSourceRepoId = 5;
            CreateActionWorkflowDispatch? body = NewModel<CreateActionWorkflowDispatch>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/actions/workflows/{workflow_id}/dispatches");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "workflow_id", workflowId);
                RequestAssert.QueryParameter(r, "return_run_details");
                RequestAssert.QueryParameter(r, "scoped_workflow_source_repo_id");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.ActionsDispatchWorkflow(owner, repo, workflowId, returnRunDetails, scopedWorkflowSourceRepoId, body);
            Verify(client.TakeSingle());

            await instance.ActionsDispatchWorkflowAsync(owner, repo, workflowId, returnRunDetails, scopedWorkflowSourceRepoId, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ActionsEnableWorkflow: PUT /repos/{owner}/{repo}/actions/workflows/{workflow_id}/enable
        /// </summary>
        [Fact]
        public async Task ActionsEnableWorkflowTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string workflowId = "workflowId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/actions/workflows/{workflow_id}/enable");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "workflow_id", workflowId);
                RequestAssert.HasAuthToken(r);
            }

            instance.ActionsEnableWorkflow(owner, repo, workflowId);
            Verify(client.TakeSingle());

            await instance.ActionsEnableWorkflowAsync(owner, repo, workflowId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ActionsGetWorkflow: GET /repos/{owner}/{repo}/actions/workflows/{workflow_id}
        /// </summary>
        [Fact]
        public async Task ActionsGetWorkflowTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string workflowId = "workflowId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/workflows/{workflow_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "workflow_id", workflowId);
                RequestAssert.HasAuthToken(r);
            }

            instance.ActionsGetWorkflow(owner, repo, workflowId);
            Verify(client.TakeSingle());

            await instance.ActionsGetWorkflowAsync(owner, repo, workflowId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ActionsListRepositoryWorkflows: GET /repos/{owner}/{repo}/actions/workflows
        /// </summary>
        [Fact]
        public async Task ActionsListRepositoryWorkflowsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/workflows");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.ActionsListRepositoryWorkflows(owner, repo);
            Verify(client.TakeSingle());

            await instance.ActionsListRepositoryWorkflowsAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ActionsListWorkflowRuns: GET /repos/{owner}/{repo}/actions/workflows/{workflow_id}/runs
        /// </summary>
        [Fact]
        public async Task ActionsListWorkflowRunsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string workflowId = "workflowId-value";
            string? varEvent = "varEvent-value";
            string? branch = "branch-value";
            string? status = "status-value";
            string? actor = "actor-value";
            string? headSha = "headSha-value";
            bool? excludePullRequests = true;
            long? scopedWorkflowSourceRepoId = 10;
            int? page = 11;
            int? limit = 12;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/workflows/{workflow_id}/runs");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "workflow_id", workflowId);
                RequestAssert.QueryParameter(r, "event");
                RequestAssert.QueryParameter(r, "branch");
                RequestAssert.QueryParameter(r, "status");
                RequestAssert.QueryParameter(r, "actor");
                RequestAssert.QueryParameter(r, "head_sha");
                RequestAssert.QueryParameter(r, "exclude_pull_requests");
                RequestAssert.QueryParameter(r, "scoped_workflow_source_repo_id");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.ActionsListWorkflowRuns(owner, repo, workflowId, varEvent, branch, status, actor, headSha, excludePullRequests, scopedWorkflowSourceRepoId, page, limit);
            Verify(client.TakeSingle());

            await instance.ActionsListWorkflowRunsAsync(owner, repo, workflowId, varEvent, branch, status, actor, headSha, excludePullRequests, scopedWorkflowSourceRepoId, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ApproveWorkflowRun: POST /repos/{owner}/{repo}/actions/runs/{run}/approve
        /// </summary>
        [Fact]
        public async Task ApproveWorkflowRunTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int run = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/actions/runs/{run}/approve");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "run", run);
                RequestAssert.HasAuthToken(r);
            }

            instance.ApproveWorkflowRun(owner, repo, run);
            Verify(client.TakeSingle());

            await instance.ApproveWorkflowRunAsync(owner, repo, run);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test CancelWorkflowRun: POST /repos/{owner}/{repo}/actions/runs/{run}/cancel
        /// </summary>
        [Fact]
        public async Task CancelWorkflowRunTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int run = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/actions/runs/{run}/cancel");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "run", run);
                RequestAssert.HasAuthToken(r);
            }

            instance.CancelWorkflowRun(owner, repo, run);
            Verify(client.TakeSingle());

            await instance.CancelWorkflowRunAsync(owner, repo, run);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test CreateFork: POST /repos/{owner}/{repo}/forks
        /// </summary>
        [Fact]
        public async Task CreateForkTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateForkOption? body = NewModel<CreateForkOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/forks");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.CreateFork(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.CreateForkAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test CreateRepoVariable: POST /repos/{owner}/{repo}/actions/variables/{variablename}
        /// </summary>
        [Fact]
        public async Task CreateRepoVariableTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string variablename = "variablename-value";
            CreateVariableOption? body = NewModel<CreateVariableOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/actions/variables/{variablename}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "variablename", variablename);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.CreateRepoVariable(owner, repo, variablename, body);
            Verify(client.TakeSingle());

            await instance.CreateRepoVariableAsync(owner, repo, variablename, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DeleteActionRun: DELETE /repos/{owner}/{repo}/actions/runs/{run}
        /// </summary>
        [Fact]
        public async Task DeleteActionRunTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int run = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/actions/runs/{run}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "run", run);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeleteActionRun(owner, repo, run);
            Verify(client.TakeSingle());

            await instance.DeleteActionRunAsync(owner, repo, run);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DeleteArtifact: DELETE /repos/{owner}/{repo}/actions/artifacts/{artifact_id}
        /// </summary>
        [Fact]
        public async Task DeleteArtifactTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string artifactId = "artifactId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/actions/artifacts/{artifact_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "artifact_id", artifactId);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeleteArtifact(owner, repo, artifactId);
            Verify(client.TakeSingle());

            await instance.DeleteArtifactAsync(owner, repo, artifactId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DeleteRepoRunner: DELETE /repos/{owner}/{repo}/actions/runners/{runner_id}
        /// </summary>
        [Fact]
        public async Task DeleteRepoRunnerTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string runnerId = "runnerId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/actions/runners/{runner_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "runner_id", runnerId);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeleteRepoRunner(owner, repo, runnerId);
            Verify(client.TakeSingle());

            await instance.DeleteRepoRunnerAsync(owner, repo, runnerId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DeleteRepoSecret: DELETE /repos/{owner}/{repo}/actions/secrets/{secretname}
        /// </summary>
        [Fact]
        public async Task DeleteRepoSecretTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string secretname = "secretname-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/actions/secrets/{secretname}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "secretname", secretname);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeleteRepoSecret(owner, repo, secretname);
            Verify(client.TakeSingle());

            await instance.DeleteRepoSecretAsync(owner, repo, secretname);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DeleteRepoVariable: DELETE /repos/{owner}/{repo}/actions/variables/{variablename}
        /// </summary>
        [Fact]
        public async Task DeleteRepoVariableTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string variablename = "variablename-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/actions/variables/{variablename}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "variablename", variablename);
                RequestAssert.HasAuthToken(r);
            }

            instance.DeleteRepoVariable(owner, repo, variablename);
            Verify(client.TakeSingle());

            await instance.DeleteRepoVariableAsync(owner, repo, variablename);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DownloadActionsRunJobLogs: GET /repos/{owner}/{repo}/actions/jobs/{job_id}/logs
        /// </summary>
        [Fact]
        public async Task DownloadActionsRunJobLogsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int jobId = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/jobs/{job_id}/logs");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "job_id", jobId);
                RequestAssert.HasAuthToken(r);
            }

            instance.DownloadActionsRunJobLogs(owner, repo, jobId);
            Verify(client.TakeSingle());

            await instance.DownloadActionsRunJobLogsAsync(owner, repo, jobId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test DownloadArtifact: GET /repos/{owner}/{repo}/actions/artifacts/{artifact_id}/zip
        /// </summary>
        [Fact]
        public async Task DownloadArtifactTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string artifactId = "artifactId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/artifacts/{artifact_id}/zip");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "artifact_id", artifactId);
                RequestAssert.HasAuthToken(r);
            }

            instance.DownloadArtifact(owner, repo, artifactId);
            Verify(client.TakeSingle());

            await instance.DownloadArtifactAsync(owner, repo, artifactId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ForceCancelWorkflowRun: POST /repos/{owner}/{repo}/actions/runs/{run}/force-cancel
        /// </summary>
        [Fact]
        public async Task ForceCancelWorkflowRunTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int run = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/actions/runs/{run}/force-cancel");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "run", run);
                RequestAssert.HasAuthToken(r);
            }

            instance.ForceCancelWorkflowRun(owner, repo, run);
            Verify(client.TakeSingle());

            await instance.ForceCancelWorkflowRunAsync(owner, repo, run);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GenerateRepo: POST /repos/{template_owner}/{template_repo}/generate
        /// </summary>
        [Fact]
        public async Task GenerateRepoTest()
        {
            string templateOwner = "templateOwner-value";
            string templateRepo = "templateRepo-value";
            GenerateRepoOption? body = NewModel<GenerateRepoOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{template_owner}/{template_repo}/generate");
                RequestAssert.PathParameter(r, "template_owner", templateOwner);
                RequestAssert.PathParameter(r, "template_repo", templateRepo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.GenerateRepo(templateOwner, templateRepo, body);
            Verify(client.TakeSingle());

            await instance.GenerateRepoAsync(templateOwner, templateRepo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetAnnotatedTag: GET /repos/{owner}/{repo}/git/tags/{sha}
        /// </summary>
        [Fact]
        public async Task GetAnnotatedTagTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string sha = "sha-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/git/tags/{sha}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "sha", sha);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetAnnotatedTag(owner, repo, sha);
            Verify(client.TakeSingle());

            await instance.GetAnnotatedTagAsync(owner, repo, sha);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetArtifact: GET /repos/{owner}/{repo}/actions/artifacts/{artifact_id}
        /// </summary>
        [Fact]
        public async Task GetArtifactTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string artifactId = "artifactId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/artifacts/{artifact_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "artifact_id", artifactId);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetArtifact(owner, repo, artifactId);
            Verify(client.TakeSingle());

            await instance.GetArtifactAsync(owner, repo, artifactId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetArtifacts: GET /repos/{owner}/{repo}/actions/artifacts
        /// </summary>
        [Fact]
        public async Task GetArtifactsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string? name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/artifacts");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "name");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetArtifacts(owner, repo, name);
            Verify(client.TakeSingle());

            await instance.GetArtifactsAsync(owner, repo, name);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetArtifactsOfRun: GET /repos/{owner}/{repo}/actions/runs/{run}/artifacts
        /// </summary>
        [Fact]
        public async Task GetArtifactsOfRunTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int run = 3;
            string? name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/runs/{run}/artifacts");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "run", run);
                RequestAssert.QueryParameter(r, "name");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetArtifactsOfRun(owner, repo, run, name);
            Verify(client.TakeSingle());

            await instance.GetArtifactsOfRunAsync(owner, repo, run, name);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetBlob: GET /repos/{owner}/{repo}/git/blobs/{sha}
        /// </summary>
        [Fact]
        public async Task GetBlobTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string sha = "sha-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/git/blobs/{sha}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "sha", sha);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetBlob(owner, repo, sha);
            Verify(client.TakeSingle());

            await instance.GetBlobAsync(owner, repo, sha);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetRepoRunner: GET /repos/{owner}/{repo}/actions/runners/{runner_id}
        /// </summary>
        [Fact]
        public async Task GetRepoRunnerTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string runnerId = "runnerId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/runners/{runner_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "runner_id", runnerId);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetRepoRunner(owner, repo, runnerId);
            Verify(client.TakeSingle());

            await instance.GetRepoRunnerAsync(owner, repo, runnerId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetRepoRunners: GET /repos/{owner}/{repo}/actions/runners
        /// </summary>
        [Fact]
        public async Task GetRepoRunnersTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            bool? disabled = true;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/runners");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "disabled");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetRepoRunners(owner, repo, disabled);
            Verify(client.TakeSingle());

            await instance.GetRepoRunnersAsync(owner, repo, disabled);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetRepoVariable: GET /repos/{owner}/{repo}/actions/variables/{variablename}
        /// </summary>
        [Fact]
        public async Task GetRepoVariableTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string variablename = "variablename-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/variables/{variablename}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "variablename", variablename);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetRepoVariable(owner, repo, variablename);
            Verify(client.TakeSingle());

            await instance.GetRepoVariableAsync(owner, repo, variablename);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetRepoVariablesList: GET /repos/{owner}/{repo}/actions/variables
        /// </summary>
        [Fact]
        public async Task GetRepoVariablesListTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/variables");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetRepoVariablesList(owner, repo, page, limit);
            Verify(client.TakeSingle());

            await instance.GetRepoVariablesListAsync(owner, repo, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetTree: GET /repos/{owner}/{repo}/git/trees/{sha}
        /// </summary>
        [Fact]
        public async Task GetTreeTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string sha = "sha-value";
            bool? recursive = true;
            int? page = 5;
            int? perPage = 6;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/git/trees/{sha}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "sha", sha);
                RequestAssert.QueryParameter(r, "recursive");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "per_page");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetTree(owner, repo, sha, recursive, page, perPage);
            Verify(client.TakeSingle());

            await instance.GetTreeAsync(owner, repo, sha, recursive, page, perPage);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetWorkflowJob: GET /repos/{owner}/{repo}/actions/jobs/{job_id}
        /// </summary>
        [Fact]
        public async Task GetWorkflowJobTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string jobId = "jobId-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/jobs/{job_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "job_id", jobId);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetWorkflowJob(owner, repo, jobId);
            Verify(client.TakeSingle());

            await instance.GetWorkflowJobAsync(owner, repo, jobId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetWorkflowRun: GET /repos/{owner}/{repo}/actions/runs/{run}
        /// </summary>
        [Fact]
        public async Task GetWorkflowRunTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int run = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/runs/{run}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "run", run);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetWorkflowRun(owner, repo, run);
            Verify(client.TakeSingle());

            await instance.GetWorkflowRunAsync(owner, repo, run);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetWorkflowRunAttempt: GET /repos/{owner}/{repo}/actions/runs/{run}/attempts/{attempt}
        /// </summary>
        [Fact]
        public async Task GetWorkflowRunAttemptTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int run = 3;
            int attempt = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/runs/{run}/attempts/{attempt}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "run", run);
                RequestAssert.PathParameter(r, "attempt", attempt);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetWorkflowRunAttempt(owner, repo, run, attempt);
            Verify(client.TakeSingle());

            await instance.GetWorkflowRunAttemptAsync(owner, repo, run, attempt);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetWorkflowRunLogs: GET /repos/{owner}/{repo}/actions/runs/{run}/logs
        /// </summary>
        [Fact]
        public async Task GetWorkflowRunLogsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int run = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/runs/{run}/logs");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "run", run);
                RequestAssert.HasAuthToken(r);
            }

            instance.GetWorkflowRunLogs(owner, repo, run);
            Verify(client.TakeSingle());

            await instance.GetWorkflowRunLogsAsync(owner, repo, run);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetWorkflowRuns: GET /repos/{owner}/{repo}/actions/runs
        /// </summary>
        [Fact]
        public async Task GetWorkflowRunsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string? varEvent = "varEvent-value";
            string? branch = "branch-value";
            string? status = "status-value";
            string? actor = "actor-value";
            string? headSha = "headSha-value";
            bool? excludePullRequests = true;
            int? page = 9;
            int? limit = 10;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/runs");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "event");
                RequestAssert.QueryParameter(r, "branch");
                RequestAssert.QueryParameter(r, "status");
                RequestAssert.QueryParameter(r, "actor");
                RequestAssert.QueryParameter(r, "head_sha");
                RequestAssert.QueryParameter(r, "exclude_pull_requests");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetWorkflowRuns(owner, repo, varEvent, branch, status, actor, headSha, excludePullRequests, page, limit);
            Verify(client.TakeSingle());

            await instance.GetWorkflowRunsAsync(owner, repo, varEvent, branch, status, actor, headSha, excludePullRequests, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ListActionTasks: GET /repos/{owner}/{repo}/actions/tasks
        /// </summary>
        [Fact]
        public async Task ListActionTasksTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/tasks");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.ListActionTasks(owner, repo, page, limit);
            Verify(client.TakeSingle());

            await instance.ListActionTasksAsync(owner, repo, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ListForks: GET /repos/{owner}/{repo}/forks
        /// </summary>
        [Fact]
        public async Task ListForksTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/forks");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.ListForks(owner, repo, page, limit);
            Verify(client.TakeSingle());

            await instance.ListForksAsync(owner, repo, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ListWorkflowJobs: GET /repos/{owner}/{repo}/actions/jobs
        /// </summary>
        [Fact]
        public async Task ListWorkflowJobsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string? status = "status-value";
            int? page = 4;
            int? limit = 5;
            string? sort = "sort-value";
            string? order = "order-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/jobs");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "status");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "sort");
                RequestAssert.QueryParameter(r, "order");
                RequestAssert.HasAuthToken(r);
            }

            instance.ListWorkflowJobs(owner, repo, status, page, limit, sort, order);
            Verify(client.TakeSingle());

            await instance.ListWorkflowJobsAsync(owner, repo, status, page, limit, sort, order);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ListWorkflowRunAttemptJobs: GET /repos/{owner}/{repo}/actions/runs/{run}/attempts/{attempt}/jobs
        /// </summary>
        [Fact]
        public async Task ListWorkflowRunAttemptJobsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int run = 3;
            int attempt = 4;
            string? status = "status-value";
            int? page = 6;
            int? limit = 7;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/runs/{run}/attempts/{attempt}/jobs");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "run", run);
                RequestAssert.PathParameter(r, "attempt", attempt);
                RequestAssert.QueryParameter(r, "status");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.ListWorkflowRunAttemptJobs(owner, repo, run, attempt, status, page, limit);
            Verify(client.TakeSingle());

            await instance.ListWorkflowRunAttemptJobsAsync(owner, repo, run, attempt, status, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test ListWorkflowRunJobs: GET /repos/{owner}/{repo}/actions/runs/{run}/jobs
        /// </summary>
        [Fact]
        public async Task ListWorkflowRunJobsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int run = 3;
            string? status = "status-value";
            int? page = 5;
            int? limit = 6;
            string? sort = "sort-value";
            string? order = "order-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/runs/{run}/jobs");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "run", run);
                RequestAssert.QueryParameter(r, "status");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "sort");
                RequestAssert.QueryParameter(r, "order");
                RequestAssert.HasAuthToken(r);
            }

            instance.ListWorkflowRunJobs(owner, repo, run, status, page, limit, sort, order);
            Verify(client.TakeSingle());

            await instance.ListWorkflowRunJobsAsync(owner, repo, run, status, page, limit, sort, order);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RejectRepoTransfer: POST /repos/{owner}/{repo}/transfer/reject
        /// </summary>
        [Fact]
        public async Task RejectRepoTransferTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/transfer/reject");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RejectRepoTransfer(owner, repo);
            Verify(client.TakeSingle());

            await instance.RejectRepoTransferAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoAddCollaborator: PUT /repos/{owner}/{repo}/collaborators/{collaborator}
        /// </summary>
        [Fact]
        public async Task RepoAddCollaboratorTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string collaborator = "collaborator-value";
            AddCollaboratorOption? body = NewModel<AddCollaboratorOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/collaborators/{collaborator}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "collaborator", collaborator);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoAddCollaborator(owner, repo, collaborator, body);
            Verify(client.TakeSingle());

            await instance.RepoAddCollaboratorAsync(owner, repo, collaborator, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoAddIssueToProjectColumn: POST /repos/{owner}/{repo}/projects/{id}/columns/{column_id}/issues/{issue_id}
        /// </summary>
        [Fact]
        public async Task RepoAddIssueToProjectColumnTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long columnId = 4;
            long issueId = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/projects/{id}/columns/{column_id}/issues/{issue_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.PathParameter(r, "issue_id", issueId);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoAddIssueToProjectColumn(owner, repo, id, columnId, issueId);
            Verify(client.TakeSingle());

            await instance.RepoAddIssueToProjectColumnAsync(owner, repo, id, columnId, issueId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoAddPushMirror: POST /repos/{owner}/{repo}/push_mirrors
        /// </summary>
        [Fact]
        public async Task RepoAddPushMirrorTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreatePushMirrorOption? body = NewModel<CreatePushMirrorOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/push_mirrors");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoAddPushMirror(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoAddPushMirrorAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoAddTeam: PUT /repos/{owner}/{repo}/teams/{team}
        /// </summary>
        [Fact]
        public async Task RepoAddTeamTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string team = "team-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/teams/{team}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "team", team);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoAddTeam(owner, repo, team);
            Verify(client.TakeSingle());

            await instance.RepoAddTeamAsync(owner, repo, team);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoAddTopic: PUT /repos/{owner}/{repo}/topics/{topic}
        /// </summary>
        [Fact]
        public async Task RepoAddTopicTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string topic = "topic-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/topics/{topic}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "topic", topic);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoAddTopic(owner, repo, topic);
            Verify(client.TakeSingle());

            await instance.RepoAddTopicAsync(owner, repo, topic);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoApplyDiffPatch: POST /repos/{owner}/{repo}/diffpatch
        /// </summary>
        [Fact]
        public async Task RepoApplyDiffPatchTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            ApplyDiffPatchFileOptions body = NewModel<ApplyDiffPatchFileOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/diffpatch");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoApplyDiffPatch(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoApplyDiffPatchAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCancelScheduledAutoMerge: DELETE /repos/{owner}/{repo}/pulls/{index}/merge
        /// </summary>
        [Fact]
        public async Task RepoCancelScheduledAutoMergeTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/pulls/{index}/merge");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCancelScheduledAutoMerge(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.RepoCancelScheduledAutoMergeAsync(owner, repo, index);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoChangeFiles: POST /repos/{owner}/{repo}/contents
        /// </summary>
        [Fact]
        public async Task RepoChangeFilesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            ChangeFilesOptions body = NewModel<ChangeFilesOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/contents");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoChangeFiles(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoChangeFilesAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCheckAssignee: GET /repos/{owner}/{repo}/assignees/{assignee}
        /// </summary>
        [Fact]
        public async Task RepoCheckAssigneeTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string assignee = "assignee-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/assignees/{assignee}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "assignee", assignee);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCheckAssignee(owner, repo, assignee);
            Verify(client.TakeSingle());

            await instance.RepoCheckAssigneeAsync(owner, repo, assignee);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCheckCollaborator: GET /repos/{owner}/{repo}/collaborators/{collaborator}
        /// </summary>
        [Fact]
        public async Task RepoCheckCollaboratorTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string collaborator = "collaborator-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/collaborators/{collaborator}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "collaborator", collaborator);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCheckCollaborator(owner, repo, collaborator);
            Verify(client.TakeSingle());

            await instance.RepoCheckCollaboratorAsync(owner, repo, collaborator);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCheckTeam: GET /repos/{owner}/{repo}/teams/{team}
        /// </summary>
        [Fact]
        public async Task RepoCheckTeamTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string team = "team-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/teams/{team}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "team", team);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCheckTeam(owner, repo, team);
            Verify(client.TakeSingle());

            await instance.RepoCheckTeamAsync(owner, repo, team);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCompareDiff: GET /repos/{owner}/{repo}/compare/{basehead}
        /// </summary>
        [Fact]
        public async Task RepoCompareDiffTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string basehead = "basehead-value";
            string? output = "output-value";
            bool? verification = true;
            bool? files = true;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/compare/{basehead}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "basehead", basehead);
                RequestAssert.QueryParameter(r, "output");
                RequestAssert.QueryParameter(r, "verification");
                RequestAssert.QueryParameter(r, "files");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCompareDiff(owner, repo, basehead, output, verification, files);
            Verify(client.TakeSingle());

            await instance.RepoCompareDiffAsync(owner, repo, basehead, output, verification, files);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateBranch: POST /repos/{owner}/{repo}/branches
        /// </summary>
        [Fact]
        public async Task RepoCreateBranchTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateBranchRepoOption? body = NewModel<CreateBranchRepoOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/branches");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateBranch(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoCreateBranchAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateBranchProtection: POST /repos/{owner}/{repo}/branch_protections
        /// </summary>
        [Fact]
        public async Task RepoCreateBranchProtectionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateBranchProtectionOption? body = NewModel<CreateBranchProtectionOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/branch_protections");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateBranchProtection(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoCreateBranchProtectionAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateDeployToken: POST /repos/{owner}/{repo}/keys/tokens
        /// </summary>
        [Fact]
        public async Task RepoCreateDeployTokenTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateDeployKeyTokenOption? body = NewModel<CreateDeployKeyTokenOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/keys/tokens");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateDeployToken(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoCreateDeployTokenAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateFile: POST /repos/{owner}/{repo}/contents/{filepath}
        /// </summary>
        [Fact]
        public async Task RepoCreateFileTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string filepath = "filepath-value";
            CreateFileOptions body = NewModel<CreateFileOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/contents/{filepath}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "filepath", filepath);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateFile(owner, repo, filepath, body);
            Verify(client.TakeSingle());

            await instance.RepoCreateFileAsync(owner, repo, filepath, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateHook: POST /repos/{owner}/{repo}/hooks
        /// </summary>
        [Fact]
        public async Task RepoCreateHookTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateHookOption? body = NewModel<CreateHookOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/hooks");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateHook(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoCreateHookAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateKey: POST /repos/{owner}/{repo}/keys
        /// </summary>
        [Fact]
        public async Task RepoCreateKeyTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateKeyOption? body = NewModel<CreateKeyOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/keys");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateKey(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoCreateKeyAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateProject: POST /repos/{owner}/{repo}/projects
        /// </summary>
        [Fact]
        public async Task RepoCreateProjectTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateProjectOption? body = NewModel<CreateProjectOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/projects");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateProject(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoCreateProjectAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateProjectColumn: POST /repos/{owner}/{repo}/projects/{id}/columns
        /// </summary>
        [Fact]
        public async Task RepoCreateProjectColumnTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            CreateProjectColumnOption? body = NewModel<CreateProjectColumnOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/projects/{id}/columns");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateProjectColumn(owner, repo, id, body);
            Verify(client.TakeSingle());

            await instance.RepoCreateProjectColumnAsync(owner, repo, id, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreatePullRequest: POST /repos/{owner}/{repo}/pulls
        /// </summary>
        [Fact]
        public async Task RepoCreatePullRequestTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreatePullRequestOption? body = NewModel<CreatePullRequestOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/pulls");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreatePullRequest(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoCreatePullRequestAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreatePullReview: POST /repos/{owner}/{repo}/pulls/{index}/reviews
        /// </summary>
        [Fact]
        public async Task RepoCreatePullReviewTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            CreatePullReviewOptions body = NewModel<CreatePullReviewOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/pulls/{index}/reviews");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreatePullReview(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.RepoCreatePullReviewAsync(owner, repo, index, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreatePullReviewCommentReply: POST /repos/{owner}/{repo}/pulls/{index}/comments/{id}/replies
        /// </summary>
        [Fact]
        public async Task RepoCreatePullReviewCommentReplyTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            long id = 4;
            CreatePullReviewCommentReplyOptions body = NewModel<CreatePullReviewCommentReplyOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/pulls/{index}/comments/{id}/replies");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreatePullReviewCommentReply(owner, repo, index, id, body);
            Verify(client.TakeSingle());

            await instance.RepoCreatePullReviewCommentReplyAsync(owner, repo, index, id, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreatePullReviewRequests: POST /repos/{owner}/{repo}/pulls/{index}/requested_reviewers
        /// </summary>
        [Fact]
        public async Task RepoCreatePullReviewRequestsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            PullReviewRequestOptions body = NewModel<PullReviewRequestOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/pulls/{index}/requested_reviewers");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreatePullReviewRequests(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.RepoCreatePullReviewRequestsAsync(owner, repo, index, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateRelease: POST /repos/{owner}/{repo}/releases
        /// </summary>
        [Fact]
        public async Task RepoCreateReleaseTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateReleaseOption? body = NewModel<CreateReleaseOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/releases");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateRelease(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoCreateReleaseAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateReleaseAttachment: POST /repos/{owner}/{repo}/releases/{id}/assets
        /// </summary>
        [Fact]
        public async Task RepoCreateReleaseAttachmentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            string? name = "name-value";
            System.IO.Stream? attachment = new System.IO.MemoryStream(new byte[] { 1, 2, 3 });

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/releases/{id}/assets");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.QueryParameter(r, "name");
                RequestAssert.FormParameter(r, "attachment");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateReleaseAttachment(owner, repo, id, name, attachment);
            Verify(client.TakeSingle());

            await instance.RepoCreateReleaseAttachmentAsync(owner, repo, id, name, attachment);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateRunnerRegistrationToken: POST /repos/{owner}/{repo}/actions/runners/registration-token
        /// </summary>
        [Fact]
        public async Task RepoCreateRunnerRegistrationTokenTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/actions/runners/registration-token");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateRunnerRegistrationToken(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoCreateRunnerRegistrationTokenAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateStatus: POST /repos/{owner}/{repo}/statuses/{sha}
        /// </summary>
        [Fact]
        public async Task RepoCreateStatusTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string sha = "sha-value";
            CreateStatusOption? body = NewModel<CreateStatusOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/statuses/{sha}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "sha", sha);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateStatus(owner, repo, sha, body);
            Verify(client.TakeSingle());

            await instance.RepoCreateStatusAsync(owner, repo, sha, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateTag: POST /repos/{owner}/{repo}/tags
        /// </summary>
        [Fact]
        public async Task RepoCreateTagTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateTagOption? body = NewModel<CreateTagOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/tags");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateTag(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoCreateTagAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateTagProtection: POST /repos/{owner}/{repo}/tag_protections
        /// </summary>
        [Fact]
        public async Task RepoCreateTagProtectionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateTagProtectionOption? body = NewModel<CreateTagProtectionOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/tag_protections");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateTagProtection(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoCreateTagProtectionAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoCreateWikiPage: POST /repos/{owner}/{repo}/wiki/new
        /// </summary>
        [Fact]
        public async Task RepoCreateWikiPageTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            CreateWikiPageOptions? body = NewModel<CreateWikiPageOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/wiki/new");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoCreateWikiPage(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoCreateWikiPageAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDelete: DELETE /repos/{owner}/{repo}
        /// </summary>
        [Fact]
        public async Task RepoDeleteTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDelete(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoDeleteAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteAvatar: DELETE /repos/{owner}/{repo}/avatar
        /// </summary>
        [Fact]
        public async Task RepoDeleteAvatarTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/avatar");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteAvatar(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoDeleteAvatarAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteBranch: DELETE /repos/{owner}/{repo}/branches/{branch}
        /// </summary>
        [Fact]
        public async Task RepoDeleteBranchTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string branch = "branch-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/branches/{branch}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "branch", branch);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteBranch(owner, repo, branch);
            Verify(client.TakeSingle());

            await instance.RepoDeleteBranchAsync(owner, repo, branch);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteBranchProtection: DELETE /repos/{owner}/{repo}/branch_protections/{name}
        /// </summary>
        [Fact]
        public async Task RepoDeleteBranchProtectionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/branch_protections/{name}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteBranchProtection(owner, repo, name);
            Verify(client.TakeSingle());

            await instance.RepoDeleteBranchProtectionAsync(owner, repo, name);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteCollaborator: DELETE /repos/{owner}/{repo}/collaborators/{collaborator}
        /// </summary>
        [Fact]
        public async Task RepoDeleteCollaboratorTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string collaborator = "collaborator-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/collaborators/{collaborator}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "collaborator", collaborator);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteCollaborator(owner, repo, collaborator);
            Verify(client.TakeSingle());

            await instance.RepoDeleteCollaboratorAsync(owner, repo, collaborator);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteFile: DELETE /repos/{owner}/{repo}/contents/{filepath}
        /// </summary>
        [Fact]
        public async Task RepoDeleteFileTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string filepath = "filepath-value";
            DeleteFileOptions body = NewModel<DeleteFileOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/contents/{filepath}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "filepath", filepath);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteFile(owner, repo, filepath, body);
            Verify(client.TakeSingle());

            await instance.RepoDeleteFileAsync(owner, repo, filepath, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteGitHook: DELETE /repos/{owner}/{repo}/hooks/git/{id}
        /// </summary>
        [Fact]
        public async Task RepoDeleteGitHookTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string id = "id-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/hooks/git/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteGitHook(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoDeleteGitHookAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteHook: DELETE /repos/{owner}/{repo}/hooks/{id}
        /// </summary>
        [Fact]
        public async Task RepoDeleteHookTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/hooks/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteHook(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoDeleteHookAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteKey: DELETE /repos/{owner}/{repo}/keys/{id}
        /// </summary>
        [Fact]
        public async Task RepoDeleteKeyTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/keys/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteKey(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoDeleteKeyAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteProject: DELETE /repos/{owner}/{repo}/projects/{id}
        /// </summary>
        [Fact]
        public async Task RepoDeleteProjectTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/projects/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteProject(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoDeleteProjectAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteProjectColumn: DELETE /repos/{owner}/{repo}/projects/{id}/columns/{column_id}
        /// </summary>
        [Fact]
        public async Task RepoDeleteProjectColumnTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long columnId = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/projects/{id}/columns/{column_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteProjectColumn(owner, repo, id, columnId);
            Verify(client.TakeSingle());

            await instance.RepoDeleteProjectColumnAsync(owner, repo, id, columnId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeletePullReview: DELETE /repos/{owner}/{repo}/pulls/{index}/reviews/{id}
        /// </summary>
        [Fact]
        public async Task RepoDeletePullReviewTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            long id = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/pulls/{index}/reviews/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeletePullReview(owner, repo, index, id);
            Verify(client.TakeSingle());

            await instance.RepoDeletePullReviewAsync(owner, repo, index, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeletePullReviewRequests: DELETE /repos/{owner}/{repo}/pulls/{index}/requested_reviewers
        /// </summary>
        [Fact]
        public async Task RepoDeletePullReviewRequestsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            PullReviewRequestOptions body = NewModel<PullReviewRequestOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/pulls/{index}/requested_reviewers");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeletePullReviewRequests(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.RepoDeletePullReviewRequestsAsync(owner, repo, index, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeletePushMirror: DELETE /repos/{owner}/{repo}/push_mirrors/{name}
        /// </summary>
        [Fact]
        public async Task RepoDeletePushMirrorTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/push_mirrors/{name}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeletePushMirror(owner, repo, name);
            Verify(client.TakeSingle());

            await instance.RepoDeletePushMirrorAsync(owner, repo, name);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteRelease: DELETE /repos/{owner}/{repo}/releases/{id}
        /// </summary>
        [Fact]
        public async Task RepoDeleteReleaseTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/releases/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteRelease(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoDeleteReleaseAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteReleaseAttachment: DELETE /repos/{owner}/{repo}/releases/{id}/assets/{attachment_id}
        /// </summary>
        [Fact]
        public async Task RepoDeleteReleaseAttachmentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long attachmentId = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/releases/{id}/assets/{attachment_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "attachment_id", attachmentId);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteReleaseAttachment(owner, repo, id, attachmentId);
            Verify(client.TakeSingle());

            await instance.RepoDeleteReleaseAttachmentAsync(owner, repo, id, attachmentId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteReleaseByTag: DELETE /repos/{owner}/{repo}/releases/tags/{tag}
        /// </summary>
        [Fact]
        public async Task RepoDeleteReleaseByTagTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string tag = "tag-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/releases/tags/{tag}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "tag", tag);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteReleaseByTag(owner, repo, tag);
            Verify(client.TakeSingle());

            await instance.RepoDeleteReleaseByTagAsync(owner, repo, tag);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteTag: DELETE /repos/{owner}/{repo}/tags/{tag}
        /// </summary>
        [Fact]
        public async Task RepoDeleteTagTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string tag = "tag-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/tags/{tag}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "tag", tag);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteTag(owner, repo, tag);
            Verify(client.TakeSingle());

            await instance.RepoDeleteTagAsync(owner, repo, tag);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteTagProtection: DELETE /repos/{owner}/{repo}/tag_protections/{id}
        /// </summary>
        [Fact]
        public async Task RepoDeleteTagProtectionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/tag_protections/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteTagProtection(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoDeleteTagProtectionAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteTeam: DELETE /repos/{owner}/{repo}/teams/{team}
        /// </summary>
        [Fact]
        public async Task RepoDeleteTeamTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string team = "team-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/teams/{team}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "team", team);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteTeam(owner, repo, team);
            Verify(client.TakeSingle());

            await instance.RepoDeleteTeamAsync(owner, repo, team);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteTopic: DELETE /repos/{owner}/{repo}/topics/{topic}
        /// </summary>
        [Fact]
        public async Task RepoDeleteTopicTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string topic = "topic-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/topics/{topic}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "topic", topic);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteTopic(owner, repo, topic);
            Verify(client.TakeSingle());

            await instance.RepoDeleteTopicAsync(owner, repo, topic);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDeleteWikiPage: DELETE /repos/{owner}/{repo}/wiki/page/{pageName}
        /// </summary>
        [Fact]
        public async Task RepoDeleteWikiPageTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string pageName = "pageName-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/wiki/page/{pageName}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "pageName", pageName);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDeleteWikiPage(owner, repo, pageName);
            Verify(client.TakeSingle());

            await instance.RepoDeleteWikiPageAsync(owner, repo, pageName);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDismissPullReview: POST /repos/{owner}/{repo}/pulls/{index}/reviews/{id}/dismissals
        /// </summary>
        [Fact]
        public async Task RepoDismissPullReviewTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            long id = 4;
            DismissPullReviewOptions body = NewModel<DismissPullReviewOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/pulls/{index}/reviews/{id}/dismissals");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDismissPullReview(owner, repo, index, id, body);
            Verify(client.TakeSingle());

            await instance.RepoDismissPullReviewAsync(owner, repo, index, id, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDownloadCommitDiffOrPatch: GET /repos/{owner}/{repo}/git/commits/{sha}.{diffType}
        /// </summary>
        [Fact]
        public async Task RepoDownloadCommitDiffOrPatchTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string sha = "sha-value";
            string diffType = "diffType-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/git/commits/{sha}.{diffType}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "sha", sha);
                RequestAssert.PathParameter(r, "diffType", diffType);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDownloadCommitDiffOrPatch(owner, repo, sha, diffType);
            Verify(client.TakeSingle());

            await instance.RepoDownloadCommitDiffOrPatchAsync(owner, repo, sha, diffType);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoDownloadPullDiffOrPatch: GET /repos/{owner}/{repo}/pulls/{index}.{diffType}
        /// </summary>
        [Fact]
        public async Task RepoDownloadPullDiffOrPatchTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            string diffType = "diffType-value";
            bool? binary = true;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/pulls/{index}.{diffType}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "diffType", diffType);
                RequestAssert.QueryParameter(r, "binary");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoDownloadPullDiffOrPatch(owner, repo, index, diffType, binary);
            Verify(client.TakeSingle());

            await instance.RepoDownloadPullDiffOrPatchAsync(owner, repo, index, diffType, binary);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoEdit: PATCH /repos/{owner}/{repo}
        /// </summary>
        [Fact]
        public async Task RepoEditTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            EditRepoOption? body = NewModel<EditRepoOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoEdit(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoEditAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoEditBranchProtection: PATCH /repos/{owner}/{repo}/branch_protections/{name}
        /// </summary>
        [Fact]
        public async Task RepoEditBranchProtectionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string name = "name-value";
            EditBranchProtectionOption? body = NewModel<EditBranchProtectionOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/branch_protections/{name}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoEditBranchProtection(owner, repo, name, body);
            Verify(client.TakeSingle());

            await instance.RepoEditBranchProtectionAsync(owner, repo, name, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoEditGitHook: PATCH /repos/{owner}/{repo}/hooks/git/{id}
        /// </summary>
        [Fact]
        public async Task RepoEditGitHookTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string id = "id-value";
            EditGitHookOption? body = NewModel<EditGitHookOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/hooks/git/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoEditGitHook(owner, repo, id, body);
            Verify(client.TakeSingle());

            await instance.RepoEditGitHookAsync(owner, repo, id, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoEditHook: PATCH /repos/{owner}/{repo}/hooks/{id}
        /// </summary>
        [Fact]
        public async Task RepoEditHookTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            EditHookOption? body = NewModel<EditHookOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/hooks/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoEditHook(owner, repo, id, body);
            Verify(client.TakeSingle());

            await instance.RepoEditHookAsync(owner, repo, id, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoEditProject: PATCH /repos/{owner}/{repo}/projects/{id}
        /// </summary>
        [Fact]
        public async Task RepoEditProjectTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            EditProjectOption? body = NewModel<EditProjectOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/projects/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoEditProject(owner, repo, id, body);
            Verify(client.TakeSingle());

            await instance.RepoEditProjectAsync(owner, repo, id, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoEditProjectColumn: PATCH /repos/{owner}/{repo}/projects/{id}/columns/{column_id}
        /// </summary>
        [Fact]
        public async Task RepoEditProjectColumnTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long columnId = 4;
            EditProjectColumnOption? body = NewModel<EditProjectColumnOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/projects/{id}/columns/{column_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoEditProjectColumn(owner, repo, id, columnId, body);
            Verify(client.TakeSingle());

            await instance.RepoEditProjectColumnAsync(owner, repo, id, columnId, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoEditPullRequest: PATCH /repos/{owner}/{repo}/pulls/{index}
        /// </summary>
        [Fact]
        public async Task RepoEditPullRequestTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            EditPullRequestOption? body = NewModel<EditPullRequestOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/pulls/{index}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoEditPullRequest(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.RepoEditPullRequestAsync(owner, repo, index, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoEditRelease: PATCH /repos/{owner}/{repo}/releases/{id}
        /// </summary>
        [Fact]
        public async Task RepoEditReleaseTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            EditReleaseOption? body = NewModel<EditReleaseOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/releases/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoEditRelease(owner, repo, id, body);
            Verify(client.TakeSingle());

            await instance.RepoEditReleaseAsync(owner, repo, id, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoEditReleaseAttachment: PATCH /repos/{owner}/{repo}/releases/{id}/assets/{attachment_id}
        /// </summary>
        [Fact]
        public async Task RepoEditReleaseAttachmentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long attachmentId = 4;
            EditAttachmentOptions? body = NewModel<EditAttachmentOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/releases/{id}/assets/{attachment_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "attachment_id", attachmentId);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoEditReleaseAttachment(owner, repo, id, attachmentId, body);
            Verify(client.TakeSingle());

            await instance.RepoEditReleaseAttachmentAsync(owner, repo, id, attachmentId, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoEditTagProtection: PATCH /repos/{owner}/{repo}/tag_protections/{id}
        /// </summary>
        [Fact]
        public async Task RepoEditTagProtectionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int id = 3;
            EditTagProtectionOption? body = NewModel<EditTagProtectionOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/tag_protections/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoEditTagProtection(owner, repo, id, body);
            Verify(client.TakeSingle());

            await instance.RepoEditTagProtectionAsync(owner, repo, id, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoEditWikiPage: PATCH /repos/{owner}/{repo}/wiki/page/{pageName}
        /// </summary>
        [Fact]
        public async Task RepoEditWikiPageTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string pageName = "pageName-value";
            CreateWikiPageOptions? body = NewModel<CreateWikiPageOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/wiki/page/{pageName}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "pageName", pageName);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoEditWikiPage(owner, repo, pageName, body);
            Verify(client.TakeSingle());

            await instance.RepoEditWikiPageAsync(owner, repo, pageName, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGet: GET /repos/{owner}/{repo}
        /// </summary>
        [Fact]
        public async Task RepoGetTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGet(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoGetAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetAllCommits: GET /repos/{owner}/{repo}/commits
        /// </summary>
        [Fact]
        public async Task RepoGetAllCommitsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string? sha = "sha-value";
            string? path = "path-value";
            DateTime? since = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            DateTime? until = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            bool? stat = true;
            bool? verification = true;
            bool? files = true;
            int? page = 10;
            int? limit = 11;
            string? not = "not-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/commits");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "sha");
                RequestAssert.QueryParameter(r, "path");
                RequestAssert.QueryParameter(r, "since");
                RequestAssert.QueryParameter(r, "until");
                RequestAssert.QueryParameter(r, "stat");
                RequestAssert.QueryParameter(r, "verification");
                RequestAssert.QueryParameter(r, "files");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "not");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetAllCommits(owner, repo, sha, path, since, until, stat, verification, files, page, limit, not);
            Verify(client.TakeSingle());

            await instance.RepoGetAllCommitsAsync(owner, repo, sha, path, since, until, stat, verification, files, page, limit, not);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetArchive: GET /repos/{owner}/{repo}/archive/{archive}
        /// </summary>
        [Fact]
        public async Task RepoGetArchiveTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string archive = "archive-value";
            List<string>? path = new List<string> { "path1-value", "path2-value" };

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/archive/{archive}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "archive", archive);
                RequestAssert.QueryParameter(r, "path");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetArchive(owner, repo, archive, path);
            Verify(client.TakeSingle());

            await instance.RepoGetArchiveAsync(owner, repo, archive, path);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetAssignees: GET /repos/{owner}/{repo}/assignees
        /// </summary>
        [Fact]
        public async Task RepoGetAssigneesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/assignees");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetAssignees(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoGetAssigneesAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetBranch: GET /repos/{owner}/{repo}/branches/{branch}
        /// </summary>
        [Fact]
        public async Task RepoGetBranchTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string branch = "branch-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/branches/{branch}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "branch", branch);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetBranch(owner, repo, branch);
            Verify(client.TakeSingle());

            await instance.RepoGetBranchAsync(owner, repo, branch);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetBranchProtection: GET /repos/{owner}/{repo}/branch_protections/{name}
        /// </summary>
        [Fact]
        public async Task RepoGetBranchProtectionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/branch_protections/{name}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetBranchProtection(owner, repo, name);
            Verify(client.TakeSingle());

            await instance.RepoGetBranchProtectionAsync(owner, repo, name);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetByID: GET /repositories/{id}
        /// </summary>
        [Fact]
        public async Task RepoGetByIDTest()
        {
            long id = 1;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repositories/{id}");
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetByID(id);
            Verify(client.TakeSingle());

            await instance.RepoGetByIDAsync(id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetCombinedStatusByRef: GET /repos/{owner}/{repo}/commits/{ref}/status
        /// </summary>
        [Fact]
        public async Task RepoGetCombinedStatusByRefTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string varRef = "varRef-value";
            int? page = 4;
            int? limit = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/commits/{ref}/status");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "ref", varRef);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetCombinedStatusByRef(owner, repo, varRef, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoGetCombinedStatusByRefAsync(owner, repo, varRef, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetCommitPullRequest: GET /repos/{owner}/{repo}/commits/{sha}/pull
        /// </summary>
        [Fact]
        public async Task RepoGetCommitPullRequestTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string sha = "sha-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/commits/{sha}/pull");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "sha", sha);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetCommitPullRequest(owner, repo, sha);
            Verify(client.TakeSingle());

            await instance.RepoGetCommitPullRequestAsync(owner, repo, sha);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetContents: GET /repos/{owner}/{repo}/contents/{filepath}
        /// </summary>
        [Fact]
        public async Task RepoGetContentsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string filepath = "filepath-value";
            string? varRef = "varRef-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/contents/{filepath}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "filepath", filepath);
                RequestAssert.QueryParameter(r, "ref");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetContents(owner, repo, filepath, varRef);
            Verify(client.TakeSingle());

            await instance.RepoGetContentsAsync(owner, repo, filepath, varRef);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetContentsExt: GET /repos/{owner}/{repo}/contents-ext/{filepath}
        /// </summary>
        [Fact]
        public async Task RepoGetContentsExtTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string filepath = "filepath-value";
            string? varRef = "varRef-value";
            string? includes = "includes-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/contents-ext/{filepath}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "filepath", filepath);
                RequestAssert.QueryParameter(r, "ref");
                RequestAssert.QueryParameter(r, "includes");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetContentsExt(owner, repo, filepath, varRef, includes);
            Verify(client.TakeSingle());

            await instance.RepoGetContentsExtAsync(owner, repo, filepath, varRef, includes);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetContentsList: GET /repos/{owner}/{repo}/contents
        /// </summary>
        [Fact]
        public async Task RepoGetContentsListTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string? varRef = "varRef-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/contents");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "ref");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetContentsList(owner, repo, varRef);
            Verify(client.TakeSingle());

            await instance.RepoGetContentsListAsync(owner, repo, varRef);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetEditorConfig: GET /repos/{owner}/{repo}/editorconfig/{filepath}
        /// </summary>
        [Fact]
        public async Task RepoGetEditorConfigTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string filepath = "filepath-value";
            string? varRef = "varRef-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/editorconfig/{filepath}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "filepath", filepath);
                RequestAssert.QueryParameter(r, "ref");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetEditorConfig(owner, repo, filepath, varRef);
            Verify(client.TakeSingle());

            await instance.RepoGetEditorConfigAsync(owner, repo, filepath, varRef);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetFileContents: GET /repos/{owner}/{repo}/file-contents
        /// </summary>
        [Fact]
        public async Task RepoGetFileContentsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string body = "body-value";
            string? varRef = "varRef-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/file-contents");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "body");
                RequestAssert.QueryParameter(r, "ref");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetFileContents(owner, repo, body, varRef);
            Verify(client.TakeSingle());

            await instance.RepoGetFileContentsAsync(owner, repo, body, varRef);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetFileContentsPost: POST /repos/{owner}/{repo}/file-contents
        /// </summary>
        [Fact]
        public async Task RepoGetFileContentsPostTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            GetFilesOptions body = NewModel<GetFilesOptions>();
            string? varRef = "varRef-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/file-contents");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.QueryParameter(r, "ref");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetFileContentsPost(owner, repo, body, varRef);
            Verify(client.TakeSingle());

            await instance.RepoGetFileContentsPostAsync(owner, repo, body, varRef);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetGitHook: GET /repos/{owner}/{repo}/hooks/git/{id}
        /// </summary>
        [Fact]
        public async Task RepoGetGitHookTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string id = "id-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/hooks/git/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetGitHook(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoGetGitHookAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetHook: GET /repos/{owner}/{repo}/hooks/{id}
        /// </summary>
        [Fact]
        public async Task RepoGetHookTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/hooks/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetHook(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoGetHookAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetIssueConfig: GET /repos/{owner}/{repo}/issue_config
        /// </summary>
        [Fact]
        public async Task RepoGetIssueConfigTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issue_config");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetIssueConfig(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoGetIssueConfigAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetIssueTemplates: GET /repos/{owner}/{repo}/issue_templates
        /// </summary>
        [Fact]
        public async Task RepoGetIssueTemplatesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issue_templates");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetIssueTemplates(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoGetIssueTemplatesAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetKey: GET /repos/{owner}/{repo}/keys/{id}
        /// </summary>
        [Fact]
        public async Task RepoGetKeyTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/keys/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetKey(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoGetKeyAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetLanguages: GET /repos/{owner}/{repo}/languages
        /// </summary>
        [Fact]
        public async Task RepoGetLanguagesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/languages");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetLanguages(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoGetLanguagesAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetLatestRelease: GET /repos/{owner}/{repo}/releases/latest
        /// </summary>
        [Fact]
        public async Task RepoGetLatestReleaseTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/releases/latest");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetLatestRelease(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoGetLatestReleaseAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetLicenses: GET /repos/{owner}/{repo}/licenses
        /// </summary>
        [Fact]
        public async Task RepoGetLicensesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/licenses");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetLicenses(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoGetLicensesAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetNote: GET /repos/{owner}/{repo}/git/notes/{sha}
        /// </summary>
        [Fact]
        public async Task RepoGetNoteTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string sha = "sha-value";
            bool? verification = true;
            bool? files = true;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/git/notes/{sha}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "sha", sha);
                RequestAssert.QueryParameter(r, "verification");
                RequestAssert.QueryParameter(r, "files");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetNote(owner, repo, sha, verification, files);
            Verify(client.TakeSingle());

            await instance.RepoGetNoteAsync(owner, repo, sha, verification, files);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetProject: GET /repos/{owner}/{repo}/projects/{id}
        /// </summary>
        [Fact]
        public async Task RepoGetProjectTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/projects/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetProject(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoGetProjectAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetProjectColumn: GET /repos/{owner}/{repo}/projects/{id}/columns/{column_id}
        /// </summary>
        [Fact]
        public async Task RepoGetProjectColumnTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long columnId = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/projects/{id}/columns/{column_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetProjectColumn(owner, repo, id, columnId);
            Verify(client.TakeSingle());

            await instance.RepoGetProjectColumnAsync(owner, repo, id, columnId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetPullRequest: GET /repos/{owner}/{repo}/pulls/{index}
        /// </summary>
        [Fact]
        public async Task RepoGetPullRequestTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/pulls/{index}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetPullRequest(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.RepoGetPullRequestAsync(owner, repo, index);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetPullRequestByBaseHead: GET /repos/{owner}/{repo}/pulls/{base}/{head}
        /// </summary>
        [Fact]
        public async Task RepoGetPullRequestByBaseHeadTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string varBase = "varBase-value";
            string head = "head-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/pulls/{base}/{head}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "base", varBase);
                RequestAssert.PathParameter(r, "head", head);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetPullRequestByBaseHead(owner, repo, varBase, head);
            Verify(client.TakeSingle());

            await instance.RepoGetPullRequestByBaseHeadAsync(owner, repo, varBase, head);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetPullRequestCommits: GET /repos/{owner}/{repo}/pulls/{index}/commits
        /// </summary>
        [Fact]
        public async Task RepoGetPullRequestCommitsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            int? page = 4;
            int? limit = 5;
            bool? verification = true;
            bool? files = true;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/pulls/{index}/commits");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "verification");
                RequestAssert.QueryParameter(r, "files");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetPullRequestCommits(owner, repo, index, page, limit, verification, files);
            Verify(client.TakeSingle());

            await instance.RepoGetPullRequestCommitsAsync(owner, repo, index, page, limit, verification, files);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetPullRequestFiles: GET /repos/{owner}/{repo}/pulls/{index}/files
        /// </summary>
        [Fact]
        public async Task RepoGetPullRequestFilesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            string? skipTo = "skipTo-value";
            string? whitespace = "whitespace-value";
            int? page = 6;
            int? limit = 7;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/pulls/{index}/files");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.QueryParameter(r, "skip-to");
                RequestAssert.QueryParameter(r, "whitespace");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetPullRequestFiles(owner, repo, index, skipTo, whitespace, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoGetPullRequestFilesAsync(owner, repo, index, skipTo, whitespace, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetPullReview: GET /repos/{owner}/{repo}/pulls/{index}/reviews/{id}
        /// </summary>
        [Fact]
        public async Task RepoGetPullReviewTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            long id = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/pulls/{index}/reviews/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetPullReview(owner, repo, index, id);
            Verify(client.TakeSingle());

            await instance.RepoGetPullReviewAsync(owner, repo, index, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetPullReviewComments: GET /repos/{owner}/{repo}/pulls/{index}/reviews/{id}/comments
        /// </summary>
        [Fact]
        public async Task RepoGetPullReviewCommentsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            long id = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/pulls/{index}/reviews/{id}/comments");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetPullReviewComments(owner, repo, index, id);
            Verify(client.TakeSingle());

            await instance.RepoGetPullReviewCommentsAsync(owner, repo, index, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetPushMirrorByRemoteName: GET /repos/{owner}/{repo}/push_mirrors/{name}
        /// </summary>
        [Fact]
        public async Task RepoGetPushMirrorByRemoteNameTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string name = "name-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/push_mirrors/{name}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "name", name);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetPushMirrorByRemoteName(owner, repo, name);
            Verify(client.TakeSingle());

            await instance.RepoGetPushMirrorByRemoteNameAsync(owner, repo, name);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetRawFile: GET /repos/{owner}/{repo}/raw/{filepath}
        /// </summary>
        [Fact]
        public async Task RepoGetRawFileTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string filepath = "filepath-value";
            string? varRef = "varRef-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/raw/{filepath}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "filepath", filepath);
                RequestAssert.QueryParameter(r, "ref");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetRawFile(owner, repo, filepath, varRef);
            Verify(client.TakeSingle());

            await instance.RepoGetRawFileAsync(owner, repo, filepath, varRef);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetRawFileOrLFS: GET /repos/{owner}/{repo}/media/{filepath}
        /// </summary>
        [Fact]
        public async Task RepoGetRawFileOrLFSTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string filepath = "filepath-value";
            string? varRef = "varRef-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/media/{filepath}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "filepath", filepath);
                RequestAssert.QueryParameter(r, "ref");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetRawFileOrLFS(owner, repo, filepath, varRef);
            Verify(client.TakeSingle());

            await instance.RepoGetRawFileOrLFSAsync(owner, repo, filepath, varRef);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetRelease: GET /repos/{owner}/{repo}/releases/{id}
        /// </summary>
        [Fact]
        public async Task RepoGetReleaseTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/releases/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetRelease(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoGetReleaseAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetReleaseAttachment: GET /repos/{owner}/{repo}/releases/{id}/assets/{attachment_id}
        /// </summary>
        [Fact]
        public async Task RepoGetReleaseAttachmentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long attachmentId = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/releases/{id}/assets/{attachment_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "attachment_id", attachmentId);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetReleaseAttachment(owner, repo, id, attachmentId);
            Verify(client.TakeSingle());

            await instance.RepoGetReleaseAttachmentAsync(owner, repo, id, attachmentId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetReleaseByTag: GET /repos/{owner}/{repo}/releases/tags/{tag}
        /// </summary>
        [Fact]
        public async Task RepoGetReleaseByTagTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string tag = "tag-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/releases/tags/{tag}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "tag", tag);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetReleaseByTag(owner, repo, tag);
            Verify(client.TakeSingle());

            await instance.RepoGetReleaseByTagAsync(owner, repo, tag);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetRepoPermissions: GET /repos/{owner}/{repo}/collaborators/{collaborator}/permission
        /// </summary>
        [Fact]
        public async Task RepoGetRepoPermissionsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string collaborator = "collaborator-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/collaborators/{collaborator}/permission");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "collaborator", collaborator);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetRepoPermissions(owner, repo, collaborator);
            Verify(client.TakeSingle());

            await instance.RepoGetRepoPermissionsAsync(owner, repo, collaborator);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetReviewers: GET /repos/{owner}/{repo}/reviewers
        /// </summary>
        [Fact]
        public async Task RepoGetReviewersTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/reviewers");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetReviewers(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoGetReviewersAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetSingleCommit: GET /repos/{owner}/{repo}/git/commits/{sha}
        /// </summary>
        [Fact]
        public async Task RepoGetSingleCommitTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string sha = "sha-value";
            bool? stat = true;
            bool? verification = true;
            bool? files = true;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/git/commits/{sha}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "sha", sha);
                RequestAssert.QueryParameter(r, "stat");
                RequestAssert.QueryParameter(r, "verification");
                RequestAssert.QueryParameter(r, "files");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetSingleCommit(owner, repo, sha, stat, verification, files);
            Verify(client.TakeSingle());

            await instance.RepoGetSingleCommitAsync(owner, repo, sha, stat, verification, files);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetTag: GET /repos/{owner}/{repo}/tags/{tag}
        /// </summary>
        [Fact]
        public async Task RepoGetTagTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string tag = "tag-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/tags/{tag}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "tag", tag);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetTag(owner, repo, tag);
            Verify(client.TakeSingle());

            await instance.RepoGetTagAsync(owner, repo, tag);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetTagProtection: GET /repos/{owner}/{repo}/tag_protections/{id}
        /// </summary>
        [Fact]
        public async Task RepoGetTagProtectionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/tag_protections/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetTagProtection(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoGetTagProtectionAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetWikiPage: GET /repos/{owner}/{repo}/wiki/page/{pageName}
        /// </summary>
        [Fact]
        public async Task RepoGetWikiPageTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string pageName = "pageName-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/wiki/page/{pageName}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "pageName", pageName);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetWikiPage(owner, repo, pageName);
            Verify(client.TakeSingle());

            await instance.RepoGetWikiPageAsync(owner, repo, pageName);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetWikiPageRevisions: GET /repos/{owner}/{repo}/wiki/revisions/{pageName}
        /// </summary>
        [Fact]
        public async Task RepoGetWikiPageRevisionsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string pageName = "pageName-value";
            int? page = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/wiki/revisions/{pageName}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "pageName", pageName);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetWikiPageRevisions(owner, repo, pageName, page);
            Verify(client.TakeSingle());

            await instance.RepoGetWikiPageRevisionsAsync(owner, repo, pageName, page);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoGetWikiPages: GET /repos/{owner}/{repo}/wiki/pages
        /// </summary>
        [Fact]
        public async Task RepoGetWikiPagesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/wiki/pages");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoGetWikiPages(owner, repo, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoGetWikiPagesAsync(owner, repo, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListActionsSecrets: GET /repos/{owner}/{repo}/actions/secrets
        /// </summary>
        [Fact]
        public async Task RepoListActionsSecretsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/actions/secrets");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListActionsSecrets(owner, repo, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListActionsSecretsAsync(owner, repo, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListActivityFeeds: GET /repos/{owner}/{repo}/activities/feeds
        /// </summary>
        [Fact]
        public async Task RepoListActivityFeedsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            DateTime? date = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            int? page = 4;
            int? limit = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/activities/feeds");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "date");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListActivityFeeds(owner, repo, date, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListActivityFeedsAsync(owner, repo, date, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListAllGitRefs: GET /repos/{owner}/{repo}/git/refs
        /// </summary>
        [Fact]
        public async Task RepoListAllGitRefsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/git/refs");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListAllGitRefs(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoListAllGitRefsAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListBranchProtection: GET /repos/{owner}/{repo}/branch_protections
        /// </summary>
        [Fact]
        public async Task RepoListBranchProtectionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/branch_protections");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListBranchProtection(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoListBranchProtectionAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListBranches: GET /repos/{owner}/{repo}/branches
        /// </summary>
        [Fact]
        public async Task RepoListBranchesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;
            string? q = "q-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/branches");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.QueryParameter(r, "q");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListBranches(owner, repo, page, limit, q);
            Verify(client.TakeSingle());

            await instance.RepoListBranchesAsync(owner, repo, page, limit, q);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListCollaborators: GET /repos/{owner}/{repo}/collaborators
        /// </summary>
        [Fact]
        public async Task RepoListCollaboratorsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/collaborators");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListCollaborators(owner, repo, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListCollaboratorsAsync(owner, repo, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListGitHooks: GET /repos/{owner}/{repo}/hooks/git
        /// </summary>
        [Fact]
        public async Task RepoListGitHooksTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/hooks/git");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListGitHooks(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoListGitHooksAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListGitRefs: GET /repos/{owner}/{repo}/git/refs/{ref}
        /// </summary>
        [Fact]
        public async Task RepoListGitRefsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string varRef = "varRef-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/git/refs/{ref}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "ref", varRef);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListGitRefs(owner, repo, varRef);
            Verify(client.TakeSingle());

            await instance.RepoListGitRefsAsync(owner, repo, varRef);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListHooks: GET /repos/{owner}/{repo}/hooks
        /// </summary>
        [Fact]
        public async Task RepoListHooksTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/hooks");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListHooks(owner, repo, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListHooksAsync(owner, repo, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListKeys: GET /repos/{owner}/{repo}/keys
        /// </summary>
        [Fact]
        public async Task RepoListKeysTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? keyId = 3;
            string? fingerprint = "fingerprint-value";
            int? page = 5;
            int? limit = 6;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/keys");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "key_id");
                RequestAssert.QueryParameter(r, "fingerprint");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListKeys(owner, repo, keyId, fingerprint, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListKeysAsync(owner, repo, keyId, fingerprint, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListPinnedIssues: GET /repos/{owner}/{repo}/issues/pinned
        /// </summary>
        [Fact]
        public async Task RepoListPinnedIssuesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issues/pinned");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListPinnedIssues(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoListPinnedIssuesAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListPinnedPullRequests: GET /repos/{owner}/{repo}/pulls/pinned
        /// </summary>
        [Fact]
        public async Task RepoListPinnedPullRequestsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/pulls/pinned");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListPinnedPullRequests(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoListPinnedPullRequestsAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListProjectColumnIssues: GET /repos/{owner}/{repo}/projects/{id}/columns/{column_id}/issues
        /// </summary>
        [Fact]
        public async Task RepoListProjectColumnIssuesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long columnId = 4;
            int? page = 5;
            int? limit = 6;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/projects/{id}/columns/{column_id}/issues");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListProjectColumnIssues(owner, repo, id, columnId, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListProjectColumnIssuesAsync(owner, repo, id, columnId, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListProjectColumns: GET /repos/{owner}/{repo}/projects/{id}/columns
        /// </summary>
        [Fact]
        public async Task RepoListProjectColumnsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            int? page = 4;
            int? limit = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/projects/{id}/columns");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListProjectColumns(owner, repo, id, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListProjectColumnsAsync(owner, repo, id, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListProjects: GET /repos/{owner}/{repo}/projects
        /// </summary>
        [Fact]
        public async Task RepoListProjectsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string? state = "state-value";
            int? page = 4;
            int? limit = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/projects");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "state");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListProjects(owner, repo, state, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListProjectsAsync(owner, repo, state, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListPullRequests: GET /repos/{owner}/{repo}/pulls
        /// </summary>
        [Fact]
        public async Task RepoListPullRequestsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string? baseBranch = "baseBranch-value";
            string? state = "state-value";
            string? sort = "sort-value";
            long? milestone = 6;
            List<long>? labels = new List<long> { 8, 9 };
            string? poster = "poster-value";
            int? page = 11;
            int? limit = 12;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/pulls");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "base_branch");
                RequestAssert.QueryParameter(r, "state");
                RequestAssert.QueryParameter(r, "sort");
                RequestAssert.QueryParameter(r, "milestone");
                RequestAssert.QueryParameter(r, "labels");
                RequestAssert.QueryParameter(r, "poster");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListPullRequests(owner, repo, baseBranch, state, sort, milestone, labels, poster, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListPullRequestsAsync(owner, repo, baseBranch, state, sort, milestone, labels, poster, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListPullReviews: GET /repos/{owner}/{repo}/pulls/{index}/reviews
        /// </summary>
        [Fact]
        public async Task RepoListPullReviewsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            int? page = 4;
            int? limit = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/pulls/{index}/reviews");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListPullReviews(owner, repo, index, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListPullReviewsAsync(owner, repo, index, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListPushMirrors: GET /repos/{owner}/{repo}/push_mirrors
        /// </summary>
        [Fact]
        public async Task RepoListPushMirrorsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/push_mirrors");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListPushMirrors(owner, repo, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListPushMirrorsAsync(owner, repo, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListReleaseAttachments: GET /repos/{owner}/{repo}/releases/{id}/assets
        /// </summary>
        [Fact]
        public async Task RepoListReleaseAttachmentsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/releases/{id}/assets");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListReleaseAttachments(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoListReleaseAttachmentsAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListReleases: GET /repos/{owner}/{repo}/releases
        /// </summary>
        [Fact]
        public async Task RepoListReleasesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            bool? draft = true;
            bool? preRelease = true;
            string? tagFilter = "tagFilter-value";
            int? page = 6;
            int? limit = 7;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/releases");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "draft");
                RequestAssert.QueryParameter(r, "pre-release");
                RequestAssert.QueryParameter(r, "tag_filter");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListReleases(owner, repo, draft, preRelease, tagFilter, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListReleasesAsync(owner, repo, draft, preRelease, tagFilter, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListStargazers: GET /repos/{owner}/{repo}/stargazers
        /// </summary>
        [Fact]
        public async Task RepoListStargazersTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/stargazers");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListStargazers(owner, repo, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListStargazersAsync(owner, repo, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListStatuses: GET /repos/{owner}/{repo}/statuses/{sha}
        /// </summary>
        [Fact]
        public async Task RepoListStatusesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string sha = "sha-value";
            string? sort = "sort-value";
            string? state = "state-value";
            int? page = 6;
            int? limit = 7;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/statuses/{sha}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "sha", sha);
                RequestAssert.QueryParameter(r, "sort");
                RequestAssert.QueryParameter(r, "state");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListStatuses(owner, repo, sha, sort, state, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListStatusesAsync(owner, repo, sha, sort, state, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListStatusesByRef: GET /repos/{owner}/{repo}/commits/{ref}/statuses
        /// </summary>
        [Fact]
        public async Task RepoListStatusesByRefTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string varRef = "varRef-value";
            string? sort = "sort-value";
            string? state = "state-value";
            int? page = 6;
            int? limit = 7;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/commits/{ref}/statuses");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "ref", varRef);
                RequestAssert.QueryParameter(r, "sort");
                RequestAssert.QueryParameter(r, "state");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListStatusesByRef(owner, repo, varRef, sort, state, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListStatusesByRefAsync(owner, repo, varRef, sort, state, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListSubscribers: GET /repos/{owner}/{repo}/subscribers
        /// </summary>
        [Fact]
        public async Task RepoListSubscribersTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/subscribers");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListSubscribers(owner, repo, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListSubscribersAsync(owner, repo, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListTagProtection: GET /repos/{owner}/{repo}/tag_protections
        /// </summary>
        [Fact]
        public async Task RepoListTagProtectionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/tag_protections");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListTagProtection(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoListTagProtectionAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListTags: GET /repos/{owner}/{repo}/tags
        /// </summary>
        [Fact]
        public async Task RepoListTagsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/tags");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListTags(owner, repo, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListTagsAsync(owner, repo, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListTeams: GET /repos/{owner}/{repo}/teams
        /// </summary>
        [Fact]
        public async Task RepoListTeamsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/teams");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListTeams(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoListTeamsAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoListTopics: GET /repos/{owner}/{repo}/topics
        /// </summary>
        [Fact]
        public async Task RepoListTopicsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int? page = 3;
            int? limit = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/topics");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoListTopics(owner, repo, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoListTopicsAsync(owner, repo, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoMergePullRequest: POST /repos/{owner}/{repo}/pulls/{index}/merge
        /// </summary>
        [Fact]
        public async Task RepoMergePullRequestTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            MergePullRequestOption? body = NewModel<MergePullRequestOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/pulls/{index}/merge");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoMergePullRequest(owner, repo, index, body);
            Verify(client.TakeSingle());

            await instance.RepoMergePullRequestAsync(owner, repo, index, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoMergeUpstream: POST /repos/{owner}/{repo}/merge-upstream
        /// </summary>
        [Fact]
        public async Task RepoMergeUpstreamTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            MergeUpstreamRequest? body = NewModel<MergeUpstreamRequest>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/merge-upstream");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoMergeUpstream(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoMergeUpstreamAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoMigrate: POST /repos/migrate
        /// </summary>
        [Fact]
        public async Task RepoMigrateTest()
        {
            MigrateRepoOptions? body = NewModel<MigrateRepoOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/migrate");
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoMigrate(body);
            Verify(client.TakeSingle());

            await instance.RepoMigrateAsync(body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoMirrorSync: POST /repos/{owner}/{repo}/mirror-sync
        /// </summary>
        [Fact]
        public async Task RepoMirrorSyncTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/mirror-sync");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoMirrorSync(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoMirrorSyncAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoMoveProjectColumns: POST /repos/{owner}/{repo}/projects/{id}/columns/move
        /// </summary>
        [Fact]
        public async Task RepoMoveProjectColumnsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            MoveProjectColumnsOption? body = NewModel<MoveProjectColumnsOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/projects/{id}/columns/move");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoMoveProjectColumns(owner, repo, id, body);
            Verify(client.TakeSingle());

            await instance.RepoMoveProjectColumnsAsync(owner, repo, id, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoMoveProjectIssue: POST /repos/{owner}/{repo}/projects/{id}/issues/{issue_id}/move
        /// </summary>
        [Fact]
        public async Task RepoMoveProjectIssueTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long issueId = 4;
            MoveProjectIssueOption? body = NewModel<MoveProjectIssueOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/projects/{id}/issues/{issue_id}/move");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "issue_id", issueId);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoMoveProjectIssue(owner, repo, id, issueId, body);
            Verify(client.TakeSingle());

            await instance.RepoMoveProjectIssueAsync(owner, repo, id, issueId, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoNewPinAllowed: GET /repos/{owner}/{repo}/new_pin_allowed
        /// </summary>
        [Fact]
        public async Task RepoNewPinAllowedTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/new_pin_allowed");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoNewPinAllowed(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoNewPinAllowedAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoPullRequestIsMerged: GET /repos/{owner}/{repo}/pulls/{index}/merge
        /// </summary>
        [Fact]
        public async Task RepoPullRequestIsMergedTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/pulls/{index}/merge");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoPullRequestIsMerged(owner, repo, index);
            Verify(client.TakeSingle());

            await instance.RepoPullRequestIsMergedAsync(owner, repo, index);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoPushMirrorSync: POST /repos/{owner}/{repo}/push_mirrors-sync
        /// </summary>
        [Fact]
        public async Task RepoPushMirrorSyncTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/push_mirrors-sync");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoPushMirrorSync(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoPushMirrorSyncAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoRemoveIssueFromProjectColumn: DELETE /repos/{owner}/{repo}/projects/{id}/columns/{column_id}/issues/{issue_id}
        /// </summary>
        [Fact]
        public async Task RepoRemoveIssueFromProjectColumnTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long columnId = 4;
            long issueId = 5;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/projects/{id}/columns/{column_id}/issues/{issue_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.PathParameter(r, "issue_id", issueId);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoRemoveIssueFromProjectColumn(owner, repo, id, columnId, issueId);
            Verify(client.TakeSingle());

            await instance.RepoRemoveIssueFromProjectColumnAsync(owner, repo, id, columnId, issueId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoRenameBranch: PATCH /repos/{owner}/{repo}/branches/{branch}
        /// </summary>
        [Fact]
        public async Task RepoRenameBranchTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string branch = "branch-value";
            RenameBranchRepoOption? body = NewModel<RenameBranchRepoOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/branches/{branch}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "branch", branch);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoRenameBranch(owner, repo, branch, body);
            Verify(client.TakeSingle());

            await instance.RepoRenameBranchAsync(owner, repo, branch, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoResolvePullReviewComment: POST /repos/{owner}/{repo}/pulls/comments/{id}/resolve
        /// </summary>
        [Fact]
        public async Task RepoResolvePullReviewCommentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/pulls/comments/{id}/resolve");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoResolvePullReviewComment(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoResolvePullReviewCommentAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoSearch: GET /repos/search
        /// </summary>
        [Fact]
        public async Task RepoSearchTest()
        {
            string? q = "q-value";
            bool? topic = true;
            bool? includeDesc = true;
            long? uid = 4;
            long? priorityOwnerId = 5;
            long? teamId = 6;
            long? starredBy = 7;
            bool? varPrivate = true;
            bool? isPrivate = true;
            bool? template = true;
            bool? archived = true;
            string? mode = "mode-value";
            bool? exclusive = true;
            string? sort = "sort-value";
            string? order = "order-value";
            int? page = 16;
            int? limit = 17;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/search");
                RequestAssert.QueryParameter(r, "q");
                RequestAssert.QueryParameter(r, "topic");
                RequestAssert.QueryParameter(r, "includeDesc");
                RequestAssert.QueryParameter(r, "uid");
                RequestAssert.QueryParameter(r, "priority_owner_id");
                RequestAssert.QueryParameter(r, "team_id");
                RequestAssert.QueryParameter(r, "starredBy");
                RequestAssert.QueryParameter(r, "private");
                RequestAssert.QueryParameter(r, "is_private");
                RequestAssert.QueryParameter(r, "template");
                RequestAssert.QueryParameter(r, "archived");
                RequestAssert.QueryParameter(r, "mode");
                RequestAssert.QueryParameter(r, "exclusive");
                RequestAssert.QueryParameter(r, "sort");
                RequestAssert.QueryParameter(r, "order");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoSearch(q, topic, includeDesc, uid, priorityOwnerId, teamId, starredBy, varPrivate, isPrivate, template, archived, mode, exclusive, sort, order, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoSearchAsync(q, topic, includeDesc, uid, priorityOwnerId, teamId, starredBy, varPrivate, isPrivate, template, archived, mode, exclusive, sort, order, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoSetDefaultProjectColumn: POST /repos/{owner}/{repo}/projects/{id}/columns/{column_id}/default
        /// </summary>
        [Fact]
        public async Task RepoSetDefaultProjectColumnTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            long columnId = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/projects/{id}/columns/{column_id}/default");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.PathParameter(r, "column_id", columnId);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoSetDefaultProjectColumn(owner, repo, id, columnId);
            Verify(client.TakeSingle());

            await instance.RepoSetDefaultProjectColumnAsync(owner, repo, id, columnId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoSigningKey: GET /repos/{owner}/{repo}/signing-key.gpg
        /// </summary>
        [Fact]
        public async Task RepoSigningKeyTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/signing-key.gpg");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoSigningKey(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoSigningKeyAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoSigningKeySSH: GET /repos/{owner}/{repo}/signing-key.pub
        /// </summary>
        [Fact]
        public async Task RepoSigningKeySSHTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/signing-key.pub");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoSigningKeySSH(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoSigningKeySSHAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoSubmitPullReview: POST /repos/{owner}/{repo}/pulls/{index}/reviews/{id}
        /// </summary>
        [Fact]
        public async Task RepoSubmitPullReviewTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            long id = 4;
            SubmitPullReviewOptions body = NewModel<SubmitPullReviewOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/pulls/{index}/reviews/{id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoSubmitPullReview(owner, repo, index, id, body);
            Verify(client.TakeSingle());

            await instance.RepoSubmitPullReviewAsync(owner, repo, index, id, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoTestHook: POST /repos/{owner}/{repo}/hooks/{id}/tests
        /// </summary>
        [Fact]
        public async Task RepoTestHookTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;
            string? varRef = "varRef-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/hooks/{id}/tests");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.QueryParameter(r, "ref");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoTestHook(owner, repo, id, varRef);
            Verify(client.TakeSingle());

            await instance.RepoTestHookAsync(owner, repo, id, varRef);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoTrackedTimes: GET /repos/{owner}/{repo}/times
        /// </summary>
        [Fact]
        public async Task RepoTrackedTimesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string? user = "user-value";
            DateTime? since = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            DateTime? before = new DateTime(2024, 1, 2, 3, 4, 5, DateTimeKind.Utc);
            int? page = 6;
            int? limit = 7;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/times");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.QueryParameter(r, "user");
                RequestAssert.QueryParameter(r, "since");
                RequestAssert.QueryParameter(r, "before");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoTrackedTimes(owner, repo, user, since, before, page, limit);
            Verify(client.TakeSingle());

            await instance.RepoTrackedTimesAsync(owner, repo, user, since, before, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoTransfer: POST /repos/{owner}/{repo}/transfer
        /// </summary>
        [Fact]
        public async Task RepoTransferTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            TransferRepoOption body = NewModel<TransferRepoOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/transfer");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoTransfer(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoTransferAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoUnDismissPullReview: POST /repos/{owner}/{repo}/pulls/{index}/reviews/{id}/undismissals
        /// </summary>
        [Fact]
        public async Task RepoUnDismissPullReviewTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            long id = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/pulls/{index}/reviews/{id}/undismissals");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoUnDismissPullReview(owner, repo, index, id);
            Verify(client.TakeSingle());

            await instance.RepoUnDismissPullReviewAsync(owner, repo, index, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoUnresolvePullReviewComment: POST /repos/{owner}/{repo}/pulls/comments/{id}/unresolve
        /// </summary>
        [Fact]
        public async Task RepoUnresolvePullReviewCommentTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long id = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/pulls/comments/{id}/unresolve");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "id", id);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoUnresolvePullReviewComment(owner, repo, id);
            Verify(client.TakeSingle());

            await instance.RepoUnresolvePullReviewCommentAsync(owner, repo, id);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoUpdateAvatar: POST /repos/{owner}/{repo}/avatar
        /// </summary>
        [Fact]
        public async Task RepoUpdateAvatarTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            UpdateRepoAvatarOption? body = NewModel<UpdateRepoAvatarOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/avatar");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoUpdateAvatar(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoUpdateAvatarAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoUpdateBranch: PUT /repos/{owner}/{repo}/branches/{branch}
        /// </summary>
        [Fact]
        public async Task RepoUpdateBranchTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string branch = "branch-value";
            UpdateBranchRepoOption? body = NewModel<UpdateBranchRepoOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/branches/{branch}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "branch", branch);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoUpdateBranch(owner, repo, branch, body);
            Verify(client.TakeSingle());

            await instance.RepoUpdateBranchAsync(owner, repo, branch, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoUpdateBranchProtectionPriories: POST /repos/{owner}/{repo}/branch_protections/priority
        /// </summary>
        [Fact]
        public async Task RepoUpdateBranchProtectionPrioriesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            UpdateBranchProtectionPriories? body = NewModel<UpdateBranchProtectionPriories>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/branch_protections/priority");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoUpdateBranchProtectionPriories(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoUpdateBranchProtectionPrioriesAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoUpdateFile: PUT /repos/{owner}/{repo}/contents/{filepath}
        /// </summary>
        [Fact]
        public async Task RepoUpdateFileTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string filepath = "filepath-value";
            UpdateFileOptions body = NewModel<UpdateFileOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/contents/{filepath}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "filepath", filepath);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoUpdateFile(owner, repo, filepath, body);
            Verify(client.TakeSingle());

            await instance.RepoUpdateFileAsync(owner, repo, filepath, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoUpdatePullRequest: POST /repos/{owner}/{repo}/pulls/{index}/update
        /// </summary>
        [Fact]
        public async Task RepoUpdatePullRequestTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            long index = 3;
            string? style = "style-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/pulls/{index}/update");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "index", index);
                RequestAssert.QueryParameter(r, "style");
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoUpdatePullRequest(owner, repo, index, style);
            Verify(client.TakeSingle());

            await instance.RepoUpdatePullRequestAsync(owner, repo, index, style);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoUpdateTopics: PUT /repos/{owner}/{repo}/topics
        /// </summary>
        [Fact]
        public async Task RepoUpdateTopicsTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            RepoTopicOptions? body = NewModel<RepoTopicOptions>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/topics");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoUpdateTopics(owner, repo, body);
            Verify(client.TakeSingle());

            await instance.RepoUpdateTopicsAsync(owner, repo, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RepoValidateIssueConfig: GET /repos/{owner}/{repo}/issue_config/validate
        /// </summary>
        [Fact]
        public async Task RepoValidateIssueConfigTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/issue_config/validate");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.RepoValidateIssueConfig(owner, repo);
            Verify(client.TakeSingle());

            await instance.RepoValidateIssueConfigAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RerunFailedWorkflowRun: POST /repos/{owner}/{repo}/actions/runs/{run}/rerun-failed-jobs
        /// </summary>
        [Fact]
        public async Task RerunFailedWorkflowRunTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int run = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/actions/runs/{run}/rerun-failed-jobs");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "run", run);
                RequestAssert.HasAuthToken(r);
            }

            instance.RerunFailedWorkflowRun(owner, repo, run);
            Verify(client.TakeSingle());

            await instance.RerunFailedWorkflowRunAsync(owner, repo, run);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RerunWorkflowJob: POST /repos/{owner}/{repo}/actions/runs/{run}/jobs/{job_id}/rerun
        /// </summary>
        [Fact]
        public async Task RerunWorkflowJobTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int run = 3;
            int jobId = 4;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/actions/runs/{run}/jobs/{job_id}/rerun");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "run", run);
                RequestAssert.PathParameter(r, "job_id", jobId);
                RequestAssert.HasAuthToken(r);
            }

            instance.RerunWorkflowJob(owner, repo, run, jobId);
            Verify(client.TakeSingle());

            await instance.RerunWorkflowJobAsync(owner, repo, run, jobId);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test RerunWorkflowRun: POST /repos/{owner}/{repo}/actions/runs/{run}/rerun
        /// </summary>
        [Fact]
        public async Task RerunWorkflowRunTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            int run = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "POST", "/repos/{owner}/{repo}/actions/runs/{run}/rerun");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "run", run);
                RequestAssert.HasAuthToken(r);
            }

            instance.RerunWorkflowRun(owner, repo, run);
            Verify(client.TakeSingle());

            await instance.RerunWorkflowRunAsync(owner, repo, run);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test TopicSearch: GET /topics/search
        /// </summary>
        [Fact]
        public async Task TopicSearchTest()
        {
            string q = "q-value";
            int? page = 2;
            int? limit = 3;

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/topics/search");
                RequestAssert.QueryParameter(r, "q");
                RequestAssert.QueryParameter(r, "page");
                RequestAssert.QueryParameter(r, "limit");
                RequestAssert.HasAuthToken(r);
            }

            instance.TopicSearch(q, page, limit);
            Verify(client.TakeSingle());

            await instance.TopicSearchAsync(q, page, limit);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UpdateRepoRunner: PATCH /repos/{owner}/{repo}/actions/runners/{runner_id}
        /// </summary>
        [Fact]
        public async Task UpdateRepoRunnerTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string runnerId = "runnerId-value";
            EditActionRunnerOption? body = NewModel<EditActionRunnerOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PATCH", "/repos/{owner}/{repo}/actions/runners/{runner_id}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "runner_id", runnerId);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UpdateRepoRunner(owner, repo, runnerId, body);
            Verify(client.TakeSingle());

            await instance.UpdateRepoRunnerAsync(owner, repo, runnerId, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UpdateRepoSecret: PUT /repos/{owner}/{repo}/actions/secrets/{secretname}
        /// </summary>
        [Fact]
        public async Task UpdateRepoSecretTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string secretname = "secretname-value";
            CreateOrUpdateSecretOption? body = NewModel<CreateOrUpdateSecretOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/actions/secrets/{secretname}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "secretname", secretname);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UpdateRepoSecret(owner, repo, secretname, body);
            Verify(client.TakeSingle());

            await instance.UpdateRepoSecretAsync(owner, repo, secretname, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UpdateRepoVariable: PUT /repos/{owner}/{repo}/actions/variables/{variablename}
        /// </summary>
        [Fact]
        public async Task UpdateRepoVariableTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string variablename = "variablename-value";
            UpdateVariableOption? body = NewModel<UpdateVariableOption>();

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/actions/variables/{variablename}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "variablename", variablename);
                RequestAssert.Body(r, body);
                RequestAssert.HasAuthToken(r);
            }

            instance.UpdateRepoVariable(owner, repo, variablename, body);
            Verify(client.TakeSingle());

            await instance.UpdateRepoVariableAsync(owner, repo, variablename, body);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentCheckSubscription: GET /repos/{owner}/{repo}/subscription
        /// </summary>
        [Fact]
        public async Task UserCurrentCheckSubscriptionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/subscription");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentCheckSubscription(owner, repo);
            Verify(client.TakeSingle());

            await instance.UserCurrentCheckSubscriptionAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentDeleteSubscription: DELETE /repos/{owner}/{repo}/subscription
        /// </summary>
        [Fact]
        public async Task UserCurrentDeleteSubscriptionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "DELETE", "/repos/{owner}/{repo}/subscription");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentDeleteSubscription(owner, repo);
            Verify(client.TakeSingle());

            await instance.UserCurrentDeleteSubscriptionAsync(owner, repo);
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test UserCurrentPutSubscription: PUT /repos/{owner}/{repo}/subscription
        /// </summary>
        [Fact]
        public async Task UserCurrentPutSubscriptionTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "PUT", "/repos/{owner}/{repo}/subscription");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserCurrentPutSubscription(owner, repo);
            Verify(client.TakeSingle());

            await instance.UserCurrentPutSubscriptionAsync(owner, repo);
            Verify(client.TakeSingle());
        }

#pragma warning disable CS0612 // deprecated endpoint
        /// <summary>
        /// Test UserTrackedTimes: GET /repos/{owner}/{repo}/times/{user}
        /// </summary>
        [Fact]
        public async Task UserTrackedTimesTest()
        {
            string owner = "owner-value";
            string repo = "repo-value";
            string user = "user-value";

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/repos/{owner}/{repo}/times/{user}");
                RequestAssert.PathParameter(r, "owner", owner);
                RequestAssert.PathParameter(r, "repo", repo);
                RequestAssert.PathParameter(r, "user", user);
                RequestAssert.HasAuthToken(r);
            }

            instance.UserTrackedTimes(owner, repo, user);
            Verify(client.TakeSingle());

            await instance.UserTrackedTimesAsync(owner, repo, user);
            Verify(client.TakeSingle());
        }
#pragma warning restore CS0612
    }
}
