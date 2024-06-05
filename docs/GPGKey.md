# Gitea.Net.Model.GPGKey
GPGKey a user GPG key to sign commit and tag in repository

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CanCertify** | **bool** |  | [optional] 
**CanEncryptComms** | **bool** |  | [optional] 
**CanEncryptStorage** | **bool** |  | [optional] 
**CanSign** | **bool** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**Emails** | [**List&lt;GPGKeyEmail&gt;**](GPGKeyEmail.md) |  | [optional] 
**ExpiresAt** | **DateTime** |  | [optional] 
**Id** | **long** |  | [optional] 
**KeyId** | **string** |  | [optional] 
**PrimaryKeyId** | **string** |  | [optional] 
**PublicKey** | **string** |  | [optional] 
**Subkeys** | [**List&lt;GPGKey&gt;**](GPGKey.md) |  | [optional] 
**Verified** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

