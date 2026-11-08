# Gitea.Net.Model.Team
Team represents a team in an organization

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CanCreateOrgRepo** | **bool** | Whether the team can create repositories in the organization | [optional] 
**Description** | **string** | The description of the team | [optional] 
**Id** | **long** | The unique identifier of the team | [optional] 
**IncludesAllRepositories** | **bool** | Whether the team has access to all repositories in the organization | [optional] 
**Name** | **string** | The name of the team | [optional] 
**Organization** | [**Organization**](Organization.md) |  | [optional] 
**Permission** | **string** |  | [optional] 
**Units** | **List&lt;string&gt;** | Deprecated: This variable should be replaced by UnitsMap and will be dropped in later versions. | [optional] 
**UnitsMap** | **Dictionary&lt;string, string&gt;** |  | [optional] 
**Visibility** | **string** | Team visibility within the organization. \&quot;private\&quot; teams are only listable by members and org owners; \&quot;limited\&quot; teams are listable by any organization member; \&quot;public\&quot; teams are listable by any signed-in user. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

