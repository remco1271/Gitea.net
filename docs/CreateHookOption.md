# Gitea.Net.Model.CreateHookOption
CreateHookOption options when create a hook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Active** | **bool** | Whether the webhook should be active upon creation | [optional] [default to false]
**AuthorizationHeader** | **string** | Authorization header to include in webhook requests | [optional] 
**BranchFilter** | **string** | Branch filter pattern to determine which branches trigger the webhook | [optional] 
**Config** | **Dictionary&lt;string, string&gt;** | CreateHookOptionConfig has all config options in it required are \&quot;content_type\&quot; and \&quot;url\&quot; Required | 
**Events** | **List&lt;string&gt;** | List of events that will trigger this webhook | [optional] 
**Name** | **string** | Optional human-readable name for the webhook | [optional] 
**Type** | **string** | The type of the webhook to create | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

