# Gitea.Net.Model.Hook
Hook a hook is a web hook when one repository changed

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | Whether the webhook is active and will be triggered | [optional] 
**AuthorizationHeader** | **string** | Authorization header to include in webhook requests | [optional] 
**BranchFilter** | **string** | Branch filter pattern to determine which branches trigger the webhook | [optional] 
**Config** | **Dictionary&lt;string, string&gt;** | Configuration settings for the webhook | [optional] 
**CreatedAt** | **DateTime** | The date and time when the webhook was created | [optional] 
**Events** | **List&lt;string&gt;** | List of events that trigger this webhook | [optional] 
**Id** | **long** | The unique identifier of the webhook | [optional] 
**Name** | **string** | Optional human-readable name for the webhook | [optional] 
**Type** | **string** | The type of the webhook (e.g., gitea, slack, discord) | [optional] 
**UpdatedAt** | **DateTime** | The date and time when the webhook was last updated | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

