# Gitea.Net.Model.NotificationThread
NotificationThread expose Notification on API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **long** | ID is the unique identifier for the notification thread | [optional] 
**Pinned** | **bool** | Pinned indicates if the notification is pinned | [optional] 
**Repository** | [**Repository**](Repository.md) |  | [optional] 
**Subject** | [**NotificationSubject**](NotificationSubject.md) |  | [optional] 
**Unread** | **bool** | Unread indicates if the notification has been read | [optional] 
**UpdatedAt** | **DateTime** | UpdatedAt is the time when the notification was last updated | [optional] 
**Url** | **string** | URL is the API URL for this notification thread | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

