# Gitea.Net.Model.EditTeamOption
EditTeamOption options for editing a team

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CanCreateOrgRepo** | **bool** | Whether the team can create repositories in the organization | [optional] 
**Description** | **string** | The description of the team | [optional] 
**IncludesAllRepositories** | **bool** | Whether the team has access to all repositories in the organization | [optional] 
**Name** | **string** |  | 
**Permission** | **string** | All units have this permission (read/write/admin) | [optional] 
**Units** | **List&lt;string&gt;** | Deprecated: This variable should be replaced by UnitsMap and will be dropped in later versions. | [optional] 
**UnitsMap** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Visibility** | **string** | Team visibility within the organization. When omitted, visibility is left unchanged. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

