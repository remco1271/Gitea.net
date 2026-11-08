# Gitea.Net.Model.MarkupOption
MarkupOption markup options

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Context** | **string** | URL path for rendering issue, media and file links Expected format: /subpath/{user}/{repo}/src/{branch, commit, tag}/{identifier/path}/{file/dir} | [optional] 
**FilePath** | **string** | File path for detecting extension in file mode | [optional] 
**Mode** | **string** | Mode to render (markdown, comment, wiki, file) | [optional] 
**Text** | **string** | Text markup to render | [optional] 
**Wiki** | **bool** | Is it a wiki page? (use mode&#x3D;wiki instead) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

