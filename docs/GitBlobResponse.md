# Gitea.Net.Model.GitBlobResponse
GitBlobResponse represents a git blob

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Content** | **string** | The content of the git blob (may be base64 encoded) | [optional] 
**Encoding** | **string** | The encoding used for the content (e.g., \&quot;base64\&quot;) | [optional] 
**LfsOid** | **string** | The LFS object ID if this blob is stored in LFS | [optional] 
**LfsSize** | **long** | The size of the LFS object if this blob is stored in LFS | [optional] 
**Sha** | **string** | The SHA hash of the git blob | [optional] 
**Size** | **long** | The size of the git blob in bytes | [optional] 
**Url** | **string** | The URL to access this git blob | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

