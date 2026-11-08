# Gitea.Net.Model.ChangedFile
ChangedFile store information about files affected by the pull request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Additions** | **long** | The number of lines added to the file | [optional] 
**Changes** | **long** | The total number of changes to the file | [optional] 
**ContentsUrl** | **string** | The API URL to get the file contents | [optional] 
**Deletions** | **long** | The number of lines deleted from the file | [optional] 
**Filename** | **string** | The name of the changed file | [optional] 
**HtmlUrl** | **string** | The HTML URL to view the file changes | [optional] 
**PreviousFilename** | **string** | The previous filename if the file was renamed | [optional] 
**RawUrl** | **string** | The raw URL to download the file | [optional] 
**Status** | **string** | The status of the file change (added, modified, deleted, etc.) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

