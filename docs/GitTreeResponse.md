# Gitea.Net.Model.GitTreeResponse
GitTreeResponse returns a git tree

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Page** | **long** | Page is the current page number for pagination | [optional] 
**Sha** | **string** | SHA is the tree object SHA | [optional] 
**TotalCount** | **long** | TotalCount is the total number of entries in the tree | [optional] 
**Tree** | [**List&lt;GitEntry&gt;**](GitEntry.md) | Entries contains the tree entries (files and directories) | [optional] 
**Truncated** | **bool** | Truncated indicates if the response was truncated due to size | [optional] 
**Url** | **string** | URL is the API URL for this tree | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

