# Gitea.Net.Model.Commit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Author** | [**User**](User.md) |  | [optional] 
**VarCommit** | [**RepoCommit**](RepoCommit.md) |  | [optional] 
**Committer** | [**User**](User.md) |  | [optional] 
**Created** | **DateTime** | Created is the time when the commit was created | [optional] 
**Files** | [**List&lt;CommitAffectedFiles&gt;**](CommitAffectedFiles.md) | Files contains information about files affected by the commit | [optional] 
**HtmlUrl** | **string** | HTMLURL is the web URL for viewing the commit | [optional] 
**Parents** | [**List&lt;CommitMeta&gt;**](CommitMeta.md) | Parents contains the parent commit information | [optional] 
**Sha** | **string** | SHA is the commit SHA hash | [optional] 
**Stats** | [**CommitStats**](CommitStats.md) |  | [optional] 
**Url** | **string** | URL is the API URL for the commit | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

