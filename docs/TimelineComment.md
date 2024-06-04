# Org.OpenAPITools.Model.TimelineComment
TimelineComment represents a timeline comment (comment of any type) on a commit or issue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Assignee** | [**User**](User.md) |  | [optional] 
**AssigneeTeam** | [**Team**](Team.md) |  | [optional] 
**Body** | **string** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**DependentIssue** | [**Issue**](Issue.md) |  | [optional] 
**HtmlUrl** | **string** |  | [optional] 
**Id** | **long** |  | [optional] 
**IssueUrl** | **string** |  | [optional] 
**Label** | [**Label**](Label.md) |  | [optional] 
**Milestone** | [**Milestone**](Milestone.md) |  | [optional] 
**NewRef** | **string** |  | [optional] 
**NewTitle** | **string** |  | [optional] 
**OldMilestone** | [**Milestone**](Milestone.md) |  | [optional] 
**OldProjectId** | **long** |  | [optional] 
**OldRef** | **string** |  | [optional] 
**OldTitle** | **string** |  | [optional] 
**ProjectId** | **long** |  | [optional] 
**PullRequestUrl** | **string** |  | [optional] 
**RefAction** | **string** |  | [optional] 
**RefComment** | [**Comment**](Comment.md) |  | [optional] 
**RefCommitSha** | **string** | commit SHA where issue/PR was referenced | [optional] 
**RefIssue** | [**Issue**](Issue.md) |  | [optional] 
**RemovedAssignee** | **bool** | whether the assignees were removed or added | [optional] 
**ResolveDoer** | [**User**](User.md) |  | [optional] 
**ReviewId** | **long** |  | [optional] 
**TrackedTime** | [**TrackedTime**](TrackedTime.md) |  | [optional] 
**Type** | **string** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**User** | [**User**](User.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

