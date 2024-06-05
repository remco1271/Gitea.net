# Gitea.Net.Model.ContentsResponse
ContentsResponse contains information about a repo's entry's (dir, file, symlink, submodule) metadata and content

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**FileLinksResponse**](FileLinksResponse.md) |  | [optional] 
**Content** | **string** | &#x60;content&#x60; is populated when &#x60;type&#x60; is &#x60;file&#x60;, otherwise null | [optional] 
**DownloadUrl** | **string** |  | [optional] 
**Encoding** | **string** | &#x60;encoding&#x60; is populated when &#x60;type&#x60; is &#x60;file&#x60;, otherwise null | [optional] 
**GitUrl** | **string** |  | [optional] 
**HtmlUrl** | **string** |  | [optional] 
**LastCommitSha** | **string** |  | [optional] 
**Name** | **string** |  | [optional] 
**Path** | **string** |  | [optional] 
**Sha** | **string** |  | [optional] 
**Size** | **long** |  | [optional] 
**SubmoduleGitUrl** | **string** | &#x60;submodule_git_url&#x60; is populated when &#x60;type&#x60; is &#x60;submodule&#x60;, otherwise null | [optional] 
**Target** | **string** | &#x60;target&#x60; is populated when &#x60;type&#x60; is &#x60;symlink&#x60;, otherwise null | [optional] 
**Type** | **string** | &#x60;type&#x60; will be &#x60;file&#x60;, &#x60;dir&#x60;, &#x60;symlink&#x60;, or &#x60;submodule&#x60; | [optional] 
**Url** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

