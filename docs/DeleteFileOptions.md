# Gitea.Net.Model.DeleteFileOptions
DeleteFileOptions options for deleting files (used for other File structs below) Note: `author` and `committer` are optional (if only one is given, it will be used for the other, otherwise the authenticated user will be used)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Author** | [**Identity**](Identity.md) |  | [optional] 
**Branch** | **string** | branch (optional) to base this file from. if not given, the default branch is used | [optional] 
**Committer** | [**Identity**](Identity.md) |  | [optional] 
**Dates** | [**CommitDateOptions**](CommitDateOptions.md) |  | [optional] 
**Message** | **string** | message (optional) for the commit of this file. if not supplied, a default message will be used | [optional] 
**NewBranch** | **string** | new_branch (optional) will make a new branch from &#x60;branch&#x60; before creating the file | [optional] 
**Sha** | **string** | sha is the SHA for the file that already exists | 
**Signoff** | **bool** | Add a Signed-off-by trailer by the committer at the end of the commit log message. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

