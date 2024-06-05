# Gitea.Net.Model.EditRepoOption
EditRepoOption options when editing a repository's properties

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllowFastForwardOnlyMerge** | **bool** | either &#x60;true&#x60; to allow fast-forward-only merging pull requests, or &#x60;false&#x60; to prevent fast-forward-only merging. | [optional] 
**AllowManualMerge** | **bool** | either &#x60;true&#x60; to allow mark pr as merged manually, or &#x60;false&#x60; to prevent it. | [optional] 
**AllowMergeCommits** | **bool** | either &#x60;true&#x60; to allow merging pull requests with a merge commit, or &#x60;false&#x60; to prevent merging pull requests with merge commits. | [optional] 
**AllowRebase** | **bool** | either &#x60;true&#x60; to allow rebase-merging pull requests, or &#x60;false&#x60; to prevent rebase-merging. | [optional] 
**AllowRebaseExplicit** | **bool** | either &#x60;true&#x60; to allow rebase with explicit merge commits (- -no-ff), or &#x60;false&#x60; to prevent rebase with explicit merge commits. | [optional] 
**AllowRebaseUpdate** | **bool** | either &#x60;true&#x60; to allow updating pull request branch by rebase, or &#x60;false&#x60; to prevent it. | [optional] 
**AllowSquashMerge** | **bool** | either &#x60;true&#x60; to allow squash-merging pull requests, or &#x60;false&#x60; to prevent squash-merging. | [optional] 
**Archived** | **bool** | set to &#x60;true&#x60; to archive this repository. | [optional] 
**AutodetectManualMerge** | **bool** | either &#x60;true&#x60; to enable AutodetectManualMerge, or &#x60;false&#x60; to prevent it. Note: In some special cases, misjudgments can occur. | [optional] 
**DefaultAllowMaintainerEdit** | **bool** | set to &#x60;true&#x60; to allow edits from maintainers by default | [optional] 
**DefaultBranch** | **string** | sets the default branch for this repository. | [optional] 
**DefaultDeleteBranchAfterMerge** | **bool** | set to &#x60;true&#x60; to delete pr branch after merge by default | [optional] 
**DefaultMergeStyle** | **string** | set to a merge style to be used by this repository: \&quot;merge\&quot;, \&quot;rebase\&quot;, \&quot;rebase-merge\&quot;, \&quot;squash\&quot;, or \&quot;fast-forward-only\&quot;. | [optional] 
**Description** | **string** | a short description of the repository. | [optional] 
**EnablePrune** | **bool** | enable prune - remove obsolete remote-tracking references when mirroring | [optional] 
**ExternalTracker** | [**ExternalTracker**](ExternalTracker.md) |  | [optional] 
**ExternalWiki** | [**ExternalWiki**](ExternalWiki.md) |  | [optional] 
**HasActions** | **bool** | either &#x60;true&#x60; to enable actions unit, or &#x60;false&#x60; to disable them. | [optional] 
**HasIssues** | **bool** | either &#x60;true&#x60; to enable issues for this repository or &#x60;false&#x60; to disable them. | [optional] 
**HasPackages** | **bool** | either &#x60;true&#x60; to enable packages unit, or &#x60;false&#x60; to disable them. | [optional] 
**HasProjects** | **bool** | either &#x60;true&#x60; to enable project unit, or &#x60;false&#x60; to disable them. | [optional] 
**HasPullRequests** | **bool** | either &#x60;true&#x60; to allow pull requests, or &#x60;false&#x60; to prevent pull request. | [optional] 
**HasReleases** | **bool** | either &#x60;true&#x60; to enable releases unit, or &#x60;false&#x60; to disable them. | [optional] 
**HasWiki** | **bool** | either &#x60;true&#x60; to enable the wiki for this repository or &#x60;false&#x60; to disable it. | [optional] 
**IgnoreWhitespaceConflicts** | **bool** | either &#x60;true&#x60; to ignore whitespace for conflicts, or &#x60;false&#x60; to not ignore whitespace. | [optional] 
**InternalTracker** | [**InternalTracker**](InternalTracker.md) |  | [optional] 
**MirrorInterval** | **string** | set to a string like &#x60;8h30m0s&#x60; to set the mirror interval time | [optional] 
**Name** | **string** | name of the repository | [optional] 
**Private** | **bool** | either &#x60;true&#x60; to make the repository private or &#x60;false&#x60; to make it public. Note: you will get a 422 error if the organization restricts changing repository visibility to organization owners and a non-owner tries to change the value of private. | [optional] 
**ProjectsMode** | **string** | &#x60;repo&#x60; to only allow repo-level projects, &#x60;owner&#x60; to only allow owner projects, &#x60;all&#x60; to allow both. | [optional] 
**Template** | **bool** | either &#x60;true&#x60; to make this repository a template or &#x60;false&#x60; to make it a normal repository | [optional] 
**Website** | **string** | a URL with more information about the repository. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

