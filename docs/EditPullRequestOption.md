# Gitea.Net.Model.EditPullRequestOption
EditPullRequestOption options when modify pull request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowMaintainerEdit** | **bool** | Whether to allow maintainer edits | [optional] 
**Assignee** | **string** | The new primary assignee username | [optional] 
**Assignees** | **List&lt;string&gt;** | The new list of assignee usernames | [optional] 
**Base** | **string** | The new base branch for the pull request | [optional] 
**Body** | **string** | The new description body for the pull request | [optional] 
**ContentVersion** | **long** | The current version of the pull request content to detect conflicts during editing | [optional] 
**DueDate** | **DateTime** |  | [optional] 
**Labels** | **List&lt;long&gt;** | The new list of label IDs for the pull request | [optional] 
**Milestone** | **long** | The new milestone ID for the pull request | [optional] 
**State** | **string** | The new state for the pull request | [optional] 
**Title** | **string** | The new title for the pull request | [optional] 
**UnsetDueDate** | **bool** | Whether to remove the current deadline | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

