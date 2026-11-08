# Gitea.Net.Model.DeployKey

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** | Created is the time when the deploy-key was added | [optional] 
**Fingerprint** | **string** | Fingerprint is the key&#39;s fingerprint | [optional] 
**Id** | **long** | ID is the unique identifier for the deploy-key | [optional] 
**Key** | **string** | Key contains the actual SSH key content | [optional] 
**KeyId** | **long** | KeyID is the associated public key ID | [optional] 
**KeyType** | **string** | Type tells whether the key authenticates over SSH or with a token over HTTPS | [optional] 
**ReadOnly** | **bool** | ReadOnly indicates if the key has read-only access | [optional] 
**Repository** | [**Repository**](Repository.md) |  | [optional] 
**Title** | **string** | Title is the human-readable name for the key | [optional] 
**Token** | **string** | Token is the plaintext token of an HTTPS key, only returned when it is created | [optional] 
**Url** | **string** | URL is the API URL for this deploy-key | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

