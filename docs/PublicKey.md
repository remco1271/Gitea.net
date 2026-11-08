# Gitea.Net.Model.PublicKey
PublicKey publickey is a user key to push code to repository

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** | Created is the time when the key was added | [optional] 
**Fingerprint** | **string** | Fingerprint is the key&#39;s fingerprint | [optional] 
**Id** | **long** | ID is the unique identifier for the public key | [optional] 
**Key** | **string** | Key contains the actual SSH public key content | [optional] 
**KeyType** | **string** | KeyType indicates the type of the SSH key | [optional] 
**LastUsedAt** | **DateTime** | Updated is the time when the key was last used | [optional] 
**ReadOnly** | **bool** | ReadOnly indicates if the key has read-only access | [optional] 
**Title** | **string** | Title is the human-readable name for the key | [optional] 
**Url** | **string** | URL is the API URL for this key | [optional] 
**User** | [**User**](User.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

