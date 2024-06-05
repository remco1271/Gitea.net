# Gitea.Net.Model.CombinedStatus
CombinedStatus holds the combined state of several statuses for a single commit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommitUrl** | **string** |  | [optional] 
**Repository** | [**Repository**](Repository.md) |  | [optional] 
**Sha** | **string** |  | [optional] 
**State** | **string** | CommitStatusState holds the state of a CommitStatus It can be \&quot;pending\&quot;, \&quot;success\&quot;, \&quot;error\&quot; and \&quot;failure\&quot; | [optional] 
**Statuses** | [**List&lt;CommitStatus&gt;**](CommitStatus.md) |  | [optional] 
**TotalCount** | **long** |  | [optional] 
**Url** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

