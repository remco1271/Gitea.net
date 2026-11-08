# Gitea.Net.Model.CombinedStatus
CombinedStatus holds the combined state of several statuses for a single commit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CommitUrl** | **string** | CommitURL is the API URL for the commit | [optional] 
**Repository** | [**Repository**](Repository.md) |  | [optional] 
**Sha** | **string** | SHA is the commit SHA this status applies to | [optional] 
**State** | **string** | State is the overall combined status state | [optional] 
**Statuses** | [**List&lt;CommitStatus&gt;**](CommitStatus.md) | Statuses contains all individual commit statuses | [optional] 
**TotalCount** | **long** | TotalCount is the total number of statuses | [optional] 
**Url** | **string** | URL is the API URL for this combined status | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

