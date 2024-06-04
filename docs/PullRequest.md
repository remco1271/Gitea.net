# Org.OpenAPITools.Model.PullRequest
PullRequest represents a pull request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Additions** | **long** |  | [optional] 
**AllowMaintainerEdit** | **bool** |  | [optional] 
**Assignee** | [**User**](User.md) |  | [optional] 
**Assignees** | [**List&lt;User&gt;**](User.md) |  | [optional] 
**Base** | [**PRBranchInfo**](PRBranchInfo.md) |  | [optional] 
**Body** | **string** |  | [optional] 
**ChangedFiles** | **long** |  | [optional] 
**ClosedAt** | **DateTime** |  | [optional] 
**Comments** | **long** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**Deletions** | **long** |  | [optional] 
**DiffUrl** | **string** |  | [optional] 
**Draft** | **bool** |  | [optional] 
**DueDate** | **DateTime** |  | [optional] 
**Head** | [**PRBranchInfo**](PRBranchInfo.md) |  | [optional] 
**HtmlUrl** | **string** |  | [optional] 
**Id** | **long** |  | [optional] 
**IsLocked** | **bool** |  | [optional] 
**Labels** | [**List&lt;Label&gt;**](Label.md) |  | [optional] 
**MergeBase** | **string** |  | [optional] 
**MergeCommitSha** | **string** |  | [optional] 
**Mergeable** | **bool** |  | [optional] 
**Merged** | **bool** |  | [optional] 
**MergedAt** | **DateTime** |  | [optional] 
**MergedBy** | [**User**](User.md) |  | [optional] 
**Milestone** | [**Milestone**](Milestone.md) |  | [optional] 
**Number** | **long** |  | [optional] 
**PatchUrl** | **string** |  | [optional] 
**PinOrder** | **long** |  | [optional] 
**RequestedReviewers** | [**List&lt;User&gt;**](User.md) |  | [optional] 
**ReviewComments** | **long** | number of review comments made on the diff of a PR review (not including comments on commits or issues in a PR) | [optional] 
**State** | **string** | StateType issue state type | [optional] 
**Title** | **string** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**Url** | **string** |  | [optional] 
**User** | [**User**](User.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

