# Gitea.Net.Model.CreatePullRequestOption
CreatePullRequestOption options when creating a pull request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowMaintainerEdit** | **bool** | Whether maintainers can edit the pull request | [optional] 
**Assignee** | **string** | The primary assignee username | [optional] 
**Assignees** | **List&lt;string&gt;** | The list of assignee usernames | [optional] 
**Base** | **string** | The base branch for the pull request | [optional] 
**Body** | **string** | The description body of the pull request | [optional] 
**DueDate** | **DateTime** |  | [optional] 
**Head** | **string** | The head branch for the pull request, it could be a branch name on the base repository or a form like &#x60;&lt;username&gt;:&lt;branch&gt;&#x60; which refers to the user&#39;s fork repository&#39;s branch. | [optional] 
**Labels** | **List&lt;long&gt;** | The list of label IDs to assign to the pull request | [optional] 
**Milestone** | **long** | The milestone ID to assign to the pull request | [optional] 
**Reviewers** | **List&lt;string&gt;** | The list of reviewer usernames | [optional] 
**TeamReviewers** | **List&lt;string&gt;** | The list of team reviewer names | [optional] 
**Title** | **string** | The title of the pull request | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

