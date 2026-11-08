# Gitea.Net.Model.ActionWorkflowRun
ActionWorkflowRun represents a WorkflowRun

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Actor** | [**User**](User.md) |  | [optional] 
**ArtifactsUrl** | **string** |  | [optional] 
**CancelUrl** | **string** |  | [optional] 
**CompletedAt** | **DateTime** |  | [optional] 
**Conclusion** | **string** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**DisplayTitle** | **string** |  | [optional] 
**Event** | **string** |  | [optional] 
**HeadBranch** | **string** |  | [optional] 
**HeadRepository** | [**Repository**](Repository.md) |  | [optional] 
**HeadSha** | **string** |  | [optional] 
**HtmlUrl** | **string** |  | [optional] 
**Id** | **long** |  | [optional] 
**JobsUrl** | **string** |  | [optional] 
**LogsUrl** | **string** |  | [optional] 
**Path** | **string** |  | [optional] 
**PreviousAttemptUrl** | **string** | PreviousAttemptURL is the API URL of the previous attempt of this run, e.g. \&quot;.../actions/runs/{run_id}/attempts/{attempt-1}\&quot;. It is set only when the current attempt is &gt; 1 (i.e. a rerun). For the first attempt, or for legacy runs that pre-date ActionRunAttempt, it is null. | [optional] 
**PullRequests** | [**List&lt;PullRequestMinimal&gt;**](PullRequestMinimal.md) |  | [optional] 
**Repository** | [**Repository**](Repository.md) |  | [optional] 
**RepositoryId** | **long** |  | [optional] 
**RerunUrl** | **string** |  | [optional] 
**RunAttempt** | **long** | RunAttempt is 1-based for runs created after ActionRunAttempt was introduced. A value of 0 is a legacy-only sentinel for runs created before attempts existed and indicates no corresponding /attempts/{n} resource is available. | [optional] 
**RunNumber** | **long** |  | [optional] 
**StartedAt** | **DateTime** |  | [optional] 
**Status** | **string** |  | [optional] 
**TriggerActor** | [**User**](User.md) |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**Url** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

