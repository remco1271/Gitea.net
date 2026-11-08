# Gitea.Net.Model.Activity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActUser** | [**User**](User.md) |  | [optional] 
**ActUserId** | **long** | The ID of the user who performed the action | [optional] 
**Comment** | [**Comment**](Comment.md) |  | [optional] 
**CommentId** | **long** | The ID of the comment associated with the activity (if applicable) | [optional] 
**Content** | **string** | Additional content or details about the activity | [optional] 
**Created** | **DateTime** | The date and time when the activity occurred | [optional] 
**Id** | **long** | The unique identifier of the activity | [optional] 
**IsPrivate** | **bool** | Whether this activity is from a private repository | [optional] 
**OpType** | **string** | the type of action | [optional] 
**RefName** | **string** | The name of the git reference (branch/tag) associated with the activity | [optional] 
**Repo** | [**Repository**](Repository.md) |  | [optional] 
**RepoId** | **long** | The ID of the repository associated with the activity | [optional] 
**UserId** | **long** | The ID of the user who receives/sees this activity | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

