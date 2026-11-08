# Gitea.Net.Model.Project
Projects track issues and pull requests, standalone note cards are not supported.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardType** | **string** | Card type: \&quot;text_only\&quot; or \&quot;images_and_text\&quot; | [optional] 
**ClosedAt** | **DateTime** |  | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**Creator** | [**User**](User.md) |  | [optional] 
**CreatorId** | **long** | Deprecated: use Creator instead | [optional] 
**Description** | **string** |  | [optional] 
**HtmlUrl** | **string** |  | [optional] 
**Id** | **long** |  | [optional] 
**IsClosed** | **bool** | Deprecated: use State instead | [optional] 
**NumClosedIssues** | **long** |  | [optional] 
**NumIssues** | **long** |  | [optional] 
**NumOpenIssues** | **long** |  | [optional] 
**OwnerId** | **long** |  | [optional] 
**RepoId** | **long** |  | [optional] 
**State** | **string** |  | [optional] 
**TemplateType** | **string** | Template type: \&quot;none\&quot;, \&quot;basic_kanban\&quot; or \&quot;bug_triage\&quot; | [optional] 
**Title** | **string** |  | [optional] 
**Type** | **string** | Project type: \&quot;individual\&quot;, \&quot;repository\&quot; or \&quot;organization\&quot; | [optional] 
**UpdatedAt** | **DateTime** | null only for legacy rows that carry no update timestamp | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

