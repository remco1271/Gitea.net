# Gitea.Net.Model.ContentsResponse
ContentsResponse contains information about a repo's entry's (dir, file, symlink, submodule) metadata and content

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Links** | [**FileLinksResponse**](FileLinksResponse.md) |  | [optional] 
**Content** | **string** | &#x60;content&#x60; is populated when &#x60;type&#x60; is &#x60;file&#x60;, otherwise null | [optional] 
**DownloadUrl** | **string** | DownloadURL is the direct download URL for this file | [optional] 
**Encoding** | **string** | &#x60;encoding&#x60; is populated when &#x60;type&#x60; is &#x60;file&#x60;, otherwise null | [optional] 
**GitUrl** | **string** | GitURL is the Git API URL for this blob or tree | [optional] 
**HtmlUrl** | **string** | HTMLURL is the web URL for this file or directory | [optional] 
**LastAuthorDate** | **DateTime** |  | [optional] 
**LastCommitMessage** | **string** | LastCommitMessage is the message of the last commit that affected this file | [optional] 
**LastCommitSha** | **string** | LastCommitSHA is the SHA of the last commit that affected this file | [optional] 
**LastCommitterDate** | **DateTime** |  | [optional] 
**LfsOid** | **string** | LfsOid is the Git LFS object ID if this file is stored in LFS | [optional] 
**LfsSize** | **long** | LfsSize is the file size if this file is stored in LFS | [optional] 
**Mode** | **string** | &#x60;mode&#x60; is the Git file mode as an octal string, e.g. &#x60;100644&#x60; (regular), &#x60;100755&#x60; (executable), &#x60;120000&#x60; (symlink), &#x60;160000&#x60; (submodule) | [optional] 
**Name** | **string** | Name is the file or directory name | [optional] 
**Path** | **string** | Path is the full path to the file or directory | [optional] 
**Sha** | **string** | SHA is the Git blob or tree SHA | [optional] 
**Size** | **long** | Size is the file size in bytes | [optional] 
**SubmoduleGitUrl** | **string** | &#x60;submodule_git_url&#x60; is populated when &#x60;type&#x60; is &#x60;submodule&#x60;, otherwise null | [optional] 
**Target** | **string** | &#x60;target&#x60; is populated when &#x60;type&#x60; is &#x60;symlink&#x60;, otherwise null | [optional] 
**Type** | **string** | &#x60;type&#x60; will be &#x60;file&#x60;, &#x60;dir&#x60;, &#x60;symlink&#x60;, or &#x60;submodule&#x60; | [optional] 
**Url** | **string** | URL is the API URL for this file or directory | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

