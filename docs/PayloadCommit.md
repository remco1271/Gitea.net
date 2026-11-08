# Gitea.Net.Model.PayloadCommit
PayloadCommit represents a commit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Added** | **List&lt;string&gt;** | List of files added in this commit | [optional] 
**Author** | [**PayloadUser**](PayloadUser.md) |  | [optional] 
**Committer** | [**PayloadUser**](PayloadUser.md) |  | [optional] 
**Id** | **string** | sha1 hash of the commit | [optional] 
**Message** | **string** | The commit message | [optional] 
**Modified** | **List&lt;string&gt;** | List of files modified in this commit | [optional] 
**Removed** | **List&lt;string&gt;** | List of files removed in this commit | [optional] 
**Timestamp** | **DateTime** | The timestamp when the commit was made | [optional] 
**Url** | **string** | The URL to view this commit | [optional] 
**Verification** | [**PayloadCommitVerification**](PayloadCommitVerification.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

