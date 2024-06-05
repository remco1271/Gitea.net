# Gitea.Net.Model.ChangeFileOperation
ChangeFileOperation for creating, updating or deleting a file

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | **string** | new or updated file content, must be base64 encoded | [optional] 
**FromPath** | **string** | old path of the file to move | [optional] 
**Operation** | **string** | indicates what to do with the file | 
**Path** | **string** | path to the existing or new file | 
**Sha** | **string** | sha is the SHA for the file that already exists, required for update or delete | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

