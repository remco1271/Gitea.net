# Gitea.Net.Model.UpdateBranchRepoOption
UpdateBranchRepoOption options when updating a branch reference in a repository

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Force** | **bool** | Force update even if the change is not a fast-forward | [optional] 
**NewCommitId** | **string** | New commit SHA (or any ref) the branch should point to | 
**OldCommitId** | **string** | Expected old commit SHA of the branch; if provided it must match the current tip | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

