# Gitea.Net.Model.TimelineComment
TimelineComment represents a timeline comment (comment of any type) on a commit or issue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Assignee** | [**User**](User.md) |  | [optional] 
**AssigneeTeam** | [**Team**](Team.md) |  | [optional] 
**Body** | **string** | Body contains the timeline event content | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**DependentIssue** | [**Issue**](Issue.md) |  | [optional] 
**HtmlUrl** | **string** | HTMLURL is the web URL for viewing the comment | [optional] 
**Id** | **long** | ID is the unique identifier for the timeline comment | [optional] 
**IssueUrl** | **string** | IssueURL is the API URL for the issue | [optional] 
**Label** | [**Label**](Label.md) |  | [optional] 
**Milestone** | [**Milestone**](Milestone.md) |  | [optional] 
**NewRef** | **string** |  | [optional] 
**NewTitle** | **string** |  | [optional] 
**OldMilestone** | [**Milestone**](Milestone.md) |  | [optional] 
**OldProjectId** | **long** |  | [optional] 
**OldRef** | **string** |  | [optional] 
**OldTitle** | **string** |  | [optional] 
**ProjectId** | **long** |  | [optional] 
**PullRequestUrl** | **string** | PRURL is the API URL for the pull request (if applicable) | [optional] 
**RefAction** | **string** |  | [optional] 
**RefComment** | [**Comment**](Comment.md) |  | [optional] 
**RefCommitSha** | **string** | commit SHA where issue/PR was referenced | [optional] 
**RefIssue** | [**Issue**](Issue.md) |  | [optional] 
**RemovedAssignee** | **bool** | whether the assignees were removed or added | [optional] 
**ResolveDoer** | [**User**](User.md) |  | [optional] 
**ReviewId** | **long** |  | [optional] 
**TrackedTime** | [**TrackedTime**](TrackedTime.md) |  | [optional] 
**Type** | **string** | Type indicates the type of timeline event | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**User** | [**User**](User.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

