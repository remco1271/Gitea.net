# Gitea.Net.Model.PayloadCommitVerification
PayloadCommitVerification represents the GPG verification of a commit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Payload** | **string** | The signed payload content | [optional] 
**Reason** | **string** | The reason for the verification status | [optional] 
**Signature** | **string** | The GPG signature of the commit | [optional] 
**Signer** | [**PayloadUser**](PayloadUser.md) |  | [optional] 
**Verified** | **bool** | Whether the commit signature is verified | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

