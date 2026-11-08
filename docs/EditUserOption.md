# Gitea.Net.Model.EditUserOption
EditUserOption edit user options

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | Whether the user account is active | [optional] 
**Admin** | **bool** | Whether the user has administrator privileges | [optional] 
**AllowCreateOrganization** | **bool** | Whether the user can create organizations | [optional] 
**AllowGitHook** | **bool** | Whether the user can use Git hooks | [optional] 
**AllowImportLocal** | **bool** | Whether the user can import local repositories | [optional] 
**Description** | **string** | The user&#39;s personal description or bio | [optional] 
**Email** | **string** | The email address of the user | [optional] 
**FullName** | **string** | The full display name of the user | [optional] 
**Location** | **string** | The user&#39;s location or address | [optional] 
**LoginName** | **string** | identifier of the user, provided by the external authenticator (if configured) | [optional] 
**MaxRepoCreation** | **long** | Maximum number of repositories the user can create | [optional] 
**MustChangePassword** | **bool** | Whether the user must change password on next login | [optional] 
**Password** | **string** | The plain text password for the user | [optional] 
**ProhibitLogin** | **bool** | Whether the user is prohibited from logging in | [optional] 
**Restricted** | **bool** | Whether the user has restricted access privileges | [optional] 
**SourceId** | **long** | The authentication source ID to associate with the user | 
**Type** | **string** | The user type | [optional] 
**Visibility** | **string** | User visibility level: public, limited, or private | [optional] 
**Website** | **string** | The user&#39;s personal website URL | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

