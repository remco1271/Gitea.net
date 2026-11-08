# Gitea.Net.Model.Branch
Branch represents a repository branch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Commit** | [**PayloadCommit**](PayloadCommit.md) |  | [optional] 
**EffectiveBranchProtectionName** | **string** | EffectiveBranchProtectionName is the name of the effective branch protection rule | [optional] 
**EnableStatusCheck** | **bool** | EnableStatusCheck indicates if status checks are enabled | [optional] 
**Name** | **string** | Name is the branch name | [optional] 
**Protected** | **bool** | Protected indicates if the branch is protected | [optional] 
**RequiredApprovals** | **long** | RequiredApprovals is the number of required approvals for pull requests | [optional] 
**StatusCheckContexts** | **List&lt;string&gt;** | StatusCheckContexts contains the list of required status check contexts | [optional] 
**UserCanMerge** | **bool** | UserCanMerge indicates if the current user can merge to this branch | [optional] 
**UserCanPush** | **bool** | UserCanPush indicates if the current user can push to this branch | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

