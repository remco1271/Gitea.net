# Gitea.Net.Model.GPGKey
GPGKey a user GPG key to sign commit and tag in repository

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CanCertify** | **bool** | Whether the key can be used for certification | [optional] 
**CanEncryptComms** | **bool** | Whether the key can be used for encrypting communications | [optional] 
**CanEncryptStorage** | **bool** | Whether the key can be used for encrypting storage | [optional] 
**CanSign** | **bool** | Whether the key can be used for signing | [optional] 
**CreatedAt** | **DateTime** | The date and time when the GPG key was created | [optional] 
**Emails** | [**List&lt;GPGKeyEmail&gt;**](GPGKeyEmail.md) | List of email addresses associated with this GPG key | [optional] 
**ExpiresAt** | **DateTime** | The date and time when the GPG key expires | [optional] 
**Id** | **long** | The unique identifier of the GPG key | [optional] 
**KeyId** | **string** | The key ID of the GPG key | [optional] 
**PrimaryKeyId** | **string** | The primary key ID of the GPG key | [optional] 
**PublicKey** | **string** | The public key content in armored format | [optional] 
**Subkeys** | [**List&lt;GPGKey&gt;**](GPGKey.md) | List of subkeys of this GPG key | [optional] 
**Verified** | **bool** | Whether the GPG key has been verified | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

