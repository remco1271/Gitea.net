# Gitea.Net.Model.PullRequest
PullRequest represents a pull request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Additions** | **long** | The number of lines added in the pull request | [optional] 
**AllowMaintainerEdit** | **bool** | Whether maintainers can edit the pull request | [optional] 
**Assignee** | [**User**](User.md) |  | [optional] 
**Assignees** | [**List&lt;User&gt;**](User.md) | The list of users assigned to the pull request | [optional] 
**Base** | [**PRBranchInfo**](PRBranchInfo.md) |  | [optional] 
**Body** | **string** | The description body of the pull request | [optional] 
**ChangedFiles** | **long** | The number of files changed in the pull request | [optional] 
**ClosedAt** | **DateTime** |  | [optional] 
**Comments** | **long** | The number of comments on the pull request | [optional] 
**ContentVersion** | **long** | The version of the pull request content for optimistic locking | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**Deletions** | **long** | The number of lines deleted in the pull request | [optional] 
**DiffUrl** | **string** | The URL to download the diff patch | [optional] 
**Draft** | **bool** | Whether the pull request is a draft | [optional] 
**DueDate** | **DateTime** |  | [optional] 
**Head** | [**PRBranchInfo**](PRBranchInfo.md) |  | [optional] 
**HtmlUrl** | **string** | The HTML URL to view the pull request | [optional] 
**Id** | **long** | The unique identifier of the pull request | [optional] 
**IsLocked** | **bool** | Whether the pull request conversation is locked | [optional] 
**Labels** | [**List&lt;Label&gt;**](Label.md) | The labels attached to the pull request | [optional] 
**MergeBase** | **string** | The merge base commit SHA | [optional] 
**MergeCommitSha** | **string** | The SHA of the merge commit | [optional] 
**Mergeable** | **bool** | Whether the pull request can be merged | [optional] 
**Merged** | **bool** | Whether the pull request has been merged | [optional] 
**MergedAt** | **DateTime** |  | [optional] 
**MergedBy** | [**User**](User.md) |  | [optional] 
**Milestone** | [**Milestone**](Milestone.md) |  | [optional] 
**Number** | **long** | The pull request number | [optional] 
**PatchUrl** | **string** | The URL to download the patch file | [optional] 
**PinOrder** | **long** | The pin order for the pull request | [optional] 
**RequestedReviewers** | [**List&lt;User&gt;**](User.md) | The users requested to review the pull request | [optional] 
**RequestedReviewersTeams** | [**List&lt;Team&gt;**](Team.md) | The teams requested to review the pull request | [optional] 
**ReviewComments** | **long** | number of review comments made on the diff of a PR review (not including comments on commits or issues in a PR) | [optional] 
**State** | **string** | The current state of the pull request | [optional] 
**Title** | **string** | The title of the pull request | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**Url** | **string** | The API URL of the pull request | [optional] 
**User** | [**User**](User.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

