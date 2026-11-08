# Gitea.Net.Model.Release
Release represents a repository release

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Assets** | [**List&lt;Attachment&gt;**](Attachment.md) | The files attached to the release | [optional] 
**Author** | [**User**](User.md) |  | [optional] 
**Body** | **string** | The release notes or description | [optional] 
**CreatedAt** | **DateTime** |  | [optional] 
**Draft** | **bool** | Whether the release is a draft | [optional] 
**HtmlUrl** | **string** | The HTML URL to view the release | [optional] 
**Id** | **long** | The unique identifier of the release | [optional] 
**Name** | **string** | The display title of the release | [optional] 
**Prerelease** | **bool** | Whether the release is a prerelease | [optional] 
**PublishedAt** | **DateTime** |  | [optional] 
**TagName** | **string** | The name of the git tag associated with the release | [optional] 
**TarballUrl** | **string** | The URL to download the tarball archive | [optional] 
**TargetCommitish** | **string** | The target commitish for the release | [optional] 
**UploadUrl** | **string** | The URL template for uploading release assets | [optional] 
**Url** | **string** | The API URL of the release | [optional] 
**ZipballUrl** | **string** | The URL to download the zip archive | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

