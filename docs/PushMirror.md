# Gitea.Net.Model.PushMirror
PushMirror represents information of a push mirror

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Created** | **DateTime** |  | [optional] 
**Interval** | **string** | The sync interval for automatic updates | [optional] 
**LastError** | **string** | The last error message encountered during sync | [optional] 
**LastUpdate** | **DateTime** |  | [optional] 
**RemoteAddress** | **string** | The remote repository URL being mirrored to | [optional] 
**RemoteName** | **string** | The name of the remote in the git configuration | [optional] 
**RepoName** | **string** | The name of the source repository | [optional] 
**SyncOnCommit** | **bool** | Whether to sync on every commit | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

