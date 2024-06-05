# Gitea.Net.Model.Issue
Issue represents an issue in a repository

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Assets** | [**List&lt;Attachment&gt;**](Attachment.md) |  | [optional] 
**Assignee** | [**User**](User.md) |  | [optional] 
**Assignees** | [**List&lt;User&gt;**](User.md) |  | [optional] 
**Body** | **string** |  | [optional] 
**ClosedAt** | **DateTime** |  | [optional] 
**Comments** | **long** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**DueDate** | **DateTime** |  | [optional] 
**HtmlUrl** | **string** |  | [optional] 
**Id** | **long** |  | [optional] 
**IsLocked** | **bool** |  | [optional] 
**Labels** | [**List&lt;Label&gt;**](Label.md) |  | [optional] 
**Milestone** | [**Milestone**](Milestone.md) |  | [optional] 
**Number** | **long** |  | [optional] 
**OriginalAuthor** | **string** |  | [optional] 
**OriginalAuthorId** | **long** |  | [optional] 
**PinOrder** | **long** |  | [optional] 
**PullRequest** | [**PullRequestMeta**](PullRequestMeta.md) |  | [optional] 
**Ref** | **string** |  | [optional] 
**Repository** | [**RepositoryMeta**](RepositoryMeta.md) |  | [optional] 
**State** | **string** | StateType issue state type | [optional] 
**Title** | **string** |  | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**Url** | **string** |  | [optional] 
**User** | [**User**](User.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

