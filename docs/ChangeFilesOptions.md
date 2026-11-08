# Gitea.Net.Model.ChangeFilesOptions
ChangeFilesOptions options for creating, updating or deleting multiple files Note: `author` and `committer` are optional (if only one is given, it will be used for the other, otherwise the authenticated user will be used)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Author** | [**Identity**](Identity.md) |  | [optional] 
**Branch** | **string** | branch (optional) is the base branch for the changes. If not supplied, the default branch is used | [optional] 
**Committer** | [**Identity**](Identity.md) |  | [optional] 
**Dates** | [**CommitDateOptions**](CommitDateOptions.md) |  | [optional] 
**Files** | [**List&lt;ChangeFileOperation&gt;**](ChangeFileOperation.md) | list of file operations | 
**ForcePush** | **bool** | force_push (optional) will do a force-push if the new branch already exists | [optional] 
**Message** | **string** | message (optional) is the commit message of the changes. If not supplied, a default message will be used | [optional] 
**NewBranch** | **string** | new_branch (optional) will make a new branch from base branch for the changes. If not supplied, the changes will be committed to the base branch | [optional] 
**Signoff** | **bool** | Add a Signed-off-by trailer by the committer at the end of the commit log message. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

