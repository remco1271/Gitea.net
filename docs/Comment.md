# Gitea.Net.Model.Comment
Comment represents a comment on a commit or issue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Assets** | [**List&lt;Attachment&gt;**](Attachment.md) | Attachments contains files attached to the comment | [optional] 
**Body** | **string** | Body contains the comment text content | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**HtmlUrl** | **string** | HTMLURL is the web URL for viewing the comment | [optional] 
**Id** | **long** | ID is the unique identifier for the comment | [optional] 
**IssueUrl** | **string** | IssueURL is the API URL for the issue | [optional] 
**OriginalAuthor** | **string** | OriginalAuthor is the original author name (for imported comments) | [optional] 
**OriginalAuthorId** | **long** | OriginalAuthorID is the original author ID (for imported comments) | [optional] 
**PullRequestUrl** | **string** | PRURL is the API URL for the pull request (if applicable) | [optional] 
**UpdatedAt** | **DateTime** |  | [optional] 
**User** | [**User**](User.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

