# Gitea.Net.Model.CreateUserOption
CreateUserOption create user options

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CreatedAt** | **DateTime** | For explicitly setting the user creation timestamp. Useful when users are migrated from other systems. When omitted, the user&#39;s creation timestamp will be set to \&quot;now\&quot;. | [optional] 
**Email** | **string** |  | 
**FullName** | **string** | The full display name of the user | [optional] 
**LoginName** | **string** | identifier of the user, provided by the external authenticator (if configured) | [optional] 
**MustChangePassword** | **bool** | Whether the user must change password on first login | [optional] 
**Password** | **string** | The plain text password for the user | [optional] 
**Restricted** | **bool** | Whether the user has restricted access privileges | [optional] 
**SendNotify** | **bool** | Whether to send welcome notification email to the user | [optional] 
**SourceId** | **long** | The authentication source ID to associate with the user | [optional] 
**Username** | **string** | username of the user | 
**Visibility** | **string** | User visibility level: public, limited, or private | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

