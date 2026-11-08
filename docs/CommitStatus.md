# Gitea.Net.Model.CommitStatus
CommitStatus holds a single status of a single Commit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Context** | **string** | Context is the unique context identifier for the status | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**Creator** | [**User**](User.md) |  | [optional] 
**Description** | **string** | Description provides a brief description of the status | [optional] 
**Id** | **long** | ID is the unique identifier for the commit status | [optional] 
**Status** | **string** | State represents the status state (pending, success, error, failure) | [optional] 
**TargetUrl** | **string** | TargetURL is the URL to link to for more details | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**Url** | **string** | URL is the API URL for this status | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

