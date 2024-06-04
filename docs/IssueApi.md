# Org.OpenAPITools.Api.IssueApi

All URIs are relative to */api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**IssueAddLabel**](IssueApi.md#issueaddlabel) | **POST** /repos/{owner}/{repo}/issues/{index}/labels | Add a label to an issue |
| [**IssueAddSubscription**](IssueApi.md#issueaddsubscription) | **PUT** /repos/{owner}/{repo}/issues/{index}/subscriptions/{user} | Subscribe user to issue |
| [**IssueAddTime**](IssueApi.md#issueaddtime) | **POST** /repos/{owner}/{repo}/issues/{index}/times | Add tracked time to a issue |
| [**IssueCheckSubscription**](IssueApi.md#issuechecksubscription) | **GET** /repos/{owner}/{repo}/issues/{index}/subscriptions/check | Check if user is subscribed to an issue |
| [**IssueClearLabels**](IssueApi.md#issueclearlabels) | **DELETE** /repos/{owner}/{repo}/issues/{index}/labels | Remove all labels from an issue |
| [**IssueCreateComment**](IssueApi.md#issuecreatecomment) | **POST** /repos/{owner}/{repo}/issues/{index}/comments | Add a comment to an issue |
| [**IssueCreateIssue**](IssueApi.md#issuecreateissue) | **POST** /repos/{owner}/{repo}/issues | Create an issue. If using deadline only the date will be taken into account, and time of day ignored. |
| [**IssueCreateIssueAttachment**](IssueApi.md#issuecreateissueattachment) | **POST** /repos/{owner}/{repo}/issues/{index}/assets | Create an issue attachment |
| [**IssueCreateIssueBlocking**](IssueApi.md#issuecreateissueblocking) | **POST** /repos/{owner}/{repo}/issues/{index}/blocks | Block the issue given in the body by the issue in path |
| [**IssueCreateIssueCommentAttachment**](IssueApi.md#issuecreateissuecommentattachment) | **POST** /repos/{owner}/{repo}/issues/comments/{id}/assets | Create a comment attachment |
| [**IssueCreateIssueDependencies**](IssueApi.md#issuecreateissuedependencies) | **POST** /repos/{owner}/{repo}/issues/{index}/dependencies | Make the issue in the url depend on the issue in the form. |
| [**IssueCreateLabel**](IssueApi.md#issuecreatelabel) | **POST** /repos/{owner}/{repo}/labels | Create a label |
| [**IssueCreateMilestone**](IssueApi.md#issuecreatemilestone) | **POST** /repos/{owner}/{repo}/milestones | Create a milestone |
| [**IssueDelete**](IssueApi.md#issuedelete) | **DELETE** /repos/{owner}/{repo}/issues/{index} | Delete an issue |
| [**IssueDeleteComment**](IssueApi.md#issuedeletecomment) | **DELETE** /repos/{owner}/{repo}/issues/comments/{id} | Delete a comment |
| [**IssueDeleteCommentDeprecated**](IssueApi.md#issuedeletecommentdeprecated) | **DELETE** /repos/{owner}/{repo}/issues/{index}/comments/{id} | Delete a comment |
| [**IssueDeleteCommentReaction**](IssueApi.md#issuedeletecommentreaction) | **DELETE** /repos/{owner}/{repo}/issues/comments/{id}/reactions | Remove a reaction from a comment of an issue |
| [**IssueDeleteIssueAttachment**](IssueApi.md#issuedeleteissueattachment) | **DELETE** /repos/{owner}/{repo}/issues/{index}/assets/{attachment_id} | Delete an issue attachment |
| [**IssueDeleteIssueCommentAttachment**](IssueApi.md#issuedeleteissuecommentattachment) | **DELETE** /repos/{owner}/{repo}/issues/comments/{id}/assets/{attachment_id} | Delete a comment attachment |
| [**IssueDeleteIssueReaction**](IssueApi.md#issuedeleteissuereaction) | **DELETE** /repos/{owner}/{repo}/issues/{index}/reactions | Remove a reaction from an issue |
| [**IssueDeleteLabel**](IssueApi.md#issuedeletelabel) | **DELETE** /repos/{owner}/{repo}/labels/{id} | Delete a label |
| [**IssueDeleteMilestone**](IssueApi.md#issuedeletemilestone) | **DELETE** /repos/{owner}/{repo}/milestones/{id} | Delete a milestone |
| [**IssueDeleteStopWatch**](IssueApi.md#issuedeletestopwatch) | **DELETE** /repos/{owner}/{repo}/issues/{index}/stopwatch/delete | Delete an issue&#39;s existing stopwatch. |
| [**IssueDeleteSubscription**](IssueApi.md#issuedeletesubscription) | **DELETE** /repos/{owner}/{repo}/issues/{index}/subscriptions/{user} | Unsubscribe user from issue |
| [**IssueDeleteTime**](IssueApi.md#issuedeletetime) | **DELETE** /repos/{owner}/{repo}/issues/{index}/times/{id} | Delete specific tracked time |
| [**IssueEditComment**](IssueApi.md#issueeditcomment) | **PATCH** /repos/{owner}/{repo}/issues/comments/{id} | Edit a comment |
| [**IssueEditCommentDeprecated**](IssueApi.md#issueeditcommentdeprecated) | **PATCH** /repos/{owner}/{repo}/issues/{index}/comments/{id} | Edit a comment |
| [**IssueEditIssue**](IssueApi.md#issueeditissue) | **PATCH** /repos/{owner}/{repo}/issues/{index} | Edit an issue. If using deadline only the date will be taken into account, and time of day ignored. |
| [**IssueEditIssueAttachment**](IssueApi.md#issueeditissueattachment) | **PATCH** /repos/{owner}/{repo}/issues/{index}/assets/{attachment_id} | Edit an issue attachment |
| [**IssueEditIssueCommentAttachment**](IssueApi.md#issueeditissuecommentattachment) | **PATCH** /repos/{owner}/{repo}/issues/comments/{id}/assets/{attachment_id} | Edit a comment attachment |
| [**IssueEditIssueDeadline**](IssueApi.md#issueeditissuedeadline) | **POST** /repos/{owner}/{repo}/issues/{index}/deadline | Set an issue deadline. If set to null, the deadline is deleted. If using deadline only the date will be taken into account, and time of day ignored. |
| [**IssueEditLabel**](IssueApi.md#issueeditlabel) | **PATCH** /repos/{owner}/{repo}/labels/{id} | Update a label |
| [**IssueEditMilestone**](IssueApi.md#issueeditmilestone) | **PATCH** /repos/{owner}/{repo}/milestones/{id} | Update a milestone |
| [**IssueGetComment**](IssueApi.md#issuegetcomment) | **GET** /repos/{owner}/{repo}/issues/comments/{id} | Get a comment |
| [**IssueGetCommentReactions**](IssueApi.md#issuegetcommentreactions) | **GET** /repos/{owner}/{repo}/issues/comments/{id}/reactions | Get a list of reactions from a comment of an issue |
| [**IssueGetComments**](IssueApi.md#issuegetcomments) | **GET** /repos/{owner}/{repo}/issues/{index}/comments | List all comments on an issue |
| [**IssueGetCommentsAndTimeline**](IssueApi.md#issuegetcommentsandtimeline) | **GET** /repos/{owner}/{repo}/issues/{index}/timeline | List all comments and events on an issue |
| [**IssueGetIssue**](IssueApi.md#issuegetissue) | **GET** /repos/{owner}/{repo}/issues/{index} | Get an issue |
| [**IssueGetIssueAttachment**](IssueApi.md#issuegetissueattachment) | **GET** /repos/{owner}/{repo}/issues/{index}/assets/{attachment_id} | Get an issue attachment |
| [**IssueGetIssueCommentAttachment**](IssueApi.md#issuegetissuecommentattachment) | **GET** /repos/{owner}/{repo}/issues/comments/{id}/assets/{attachment_id} | Get a comment attachment |
| [**IssueGetIssueReactions**](IssueApi.md#issuegetissuereactions) | **GET** /repos/{owner}/{repo}/issues/{index}/reactions | Get a list reactions of an issue |
| [**IssueGetLabel**](IssueApi.md#issuegetlabel) | **GET** /repos/{owner}/{repo}/labels/{id} | Get a single label |
| [**IssueGetLabels**](IssueApi.md#issuegetlabels) | **GET** /repos/{owner}/{repo}/issues/{index}/labels | Get an issue&#39;s labels |
| [**IssueGetMilestone**](IssueApi.md#issuegetmilestone) | **GET** /repos/{owner}/{repo}/milestones/{id} | Get a milestone |
| [**IssueGetMilestonesList**](IssueApi.md#issuegetmilestoneslist) | **GET** /repos/{owner}/{repo}/milestones | Get all of a repository&#39;s opened milestones |
| [**IssueGetRepoComments**](IssueApi.md#issuegetrepocomments) | **GET** /repos/{owner}/{repo}/issues/comments | List all comments in a repository |
| [**IssueListBlocks**](IssueApi.md#issuelistblocks) | **GET** /repos/{owner}/{repo}/issues/{index}/blocks | List issues that are blocked by this issue |
| [**IssueListIssueAttachments**](IssueApi.md#issuelistissueattachments) | **GET** /repos/{owner}/{repo}/issues/{index}/assets | List issue&#39;s attachments |
| [**IssueListIssueCommentAttachments**](IssueApi.md#issuelistissuecommentattachments) | **GET** /repos/{owner}/{repo}/issues/comments/{id}/assets | List comment&#39;s attachments |
| [**IssueListIssueDependencies**](IssueApi.md#issuelistissuedependencies) | **GET** /repos/{owner}/{repo}/issues/{index}/dependencies | List an issue&#39;s dependencies, i.e all issues that block this issue. |
| [**IssueListIssues**](IssueApi.md#issuelistissues) | **GET** /repos/{owner}/{repo}/issues | List a repository&#39;s issues |
| [**IssueListLabels**](IssueApi.md#issuelistlabels) | **GET** /repos/{owner}/{repo}/labels | Get all of a repository&#39;s labels |
| [**IssuePostCommentReaction**](IssueApi.md#issuepostcommentreaction) | **POST** /repos/{owner}/{repo}/issues/comments/{id}/reactions | Add a reaction to a comment of an issue |
| [**IssuePostIssueReaction**](IssueApi.md#issuepostissuereaction) | **POST** /repos/{owner}/{repo}/issues/{index}/reactions | Add a reaction to an issue |
| [**IssueRemoveIssueBlocking**](IssueApi.md#issueremoveissueblocking) | **DELETE** /repos/{owner}/{repo}/issues/{index}/blocks | Unblock the issue given in the body by the issue in path |
| [**IssueRemoveIssueDependencies**](IssueApi.md#issueremoveissuedependencies) | **DELETE** /repos/{owner}/{repo}/issues/{index}/dependencies | Remove an issue dependency |
| [**IssueRemoveLabel**](IssueApi.md#issueremovelabel) | **DELETE** /repos/{owner}/{repo}/issues/{index}/labels/{id} | Remove a label from an issue |
| [**IssueReplaceLabels**](IssueApi.md#issuereplacelabels) | **PUT** /repos/{owner}/{repo}/issues/{index}/labels | Replace an issue&#39;s labels |
| [**IssueResetTime**](IssueApi.md#issueresettime) | **DELETE** /repos/{owner}/{repo}/issues/{index}/times | Reset a tracked time of an issue |
| [**IssueSearchIssues**](IssueApi.md#issuesearchissues) | **GET** /repos/issues/search | Search for issues across the repositories that the user has access to |
| [**IssueStartStopWatch**](IssueApi.md#issuestartstopwatch) | **POST** /repos/{owner}/{repo}/issues/{index}/stopwatch/start | Start stopwatch on an issue. |
| [**IssueStopStopWatch**](IssueApi.md#issuestopstopwatch) | **POST** /repos/{owner}/{repo}/issues/{index}/stopwatch/stop | Stop an issue&#39;s existing stopwatch. |
| [**IssueSubscriptions**](IssueApi.md#issuesubscriptions) | **GET** /repos/{owner}/{repo}/issues/{index}/subscriptions | Get users who subscribed on an issue. |
| [**IssueTrackedTimes**](IssueApi.md#issuetrackedtimes) | **GET** /repos/{owner}/{repo}/issues/{index}/times | List an issue&#39;s tracked times |
| [**MoveIssuePin**](IssueApi.md#moveissuepin) | **PATCH** /repos/{owner}/{repo}/issues/{index}/pin/{position} | Moves the Pin to the given Position |
| [**PinIssue**](IssueApi.md#pinissue) | **POST** /repos/{owner}/{repo}/issues/{index}/pin | Pin an Issue |
| [**UnpinIssue**](IssueApi.md#unpinissue) | **DELETE** /repos/{owner}/{repo}/issues/{index}/pin | Unpin an Issue |

<a id="issueaddlabel"></a>
# **IssueAddLabel**
> List&lt;Label&gt; IssueAddLabel (string owner, string repo, long index, IssueLabelsOption? body = null)

Add a label to an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueAddLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var body = new IssueLabelsOption?(); // IssueLabelsOption? |  (optional) 

            try
            {
                // Add a label to an issue
                List<Label> result = apiInstance.IssueAddLabel(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueAddLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueAddLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a label to an issue
    ApiResponse<List<Label>> response = apiInstance.IssueAddLabelWithHttpInfo(owner, repo, index, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueAddLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **body** | [**IssueLabelsOption?**](IssueLabelsOption?.md) |  | [optional]  |

### Return type

[**List&lt;Label&gt;**](Label.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LabelList |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueaddsubscription"></a>
# **IssueAddSubscription**
> void IssueAddSubscription (string owner, string repo, long index, string user)

Subscribe user to issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueAddSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var user = "user_example";  // string | user to subscribe

            try
            {
                // Subscribe user to issue
                apiInstance.IssueAddSubscription(owner, repo, index, user);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueAddSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueAddSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Subscribe user to issue
    apiInstance.IssueAddSubscriptionWithHttpInfo(owner, repo, index, user);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueAddSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **user** | **string** | user to subscribe |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Already subscribed |  -  |
| **201** | Successfully Subscribed |  -  |
| **304** | User can only subscribe itself if he is no admin |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueaddtime"></a>
# **IssueAddTime**
> TrackedTime IssueAddTime (string owner, string repo, long index, AddTimeOption? body = null)

Add tracked time to a issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueAddTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var body = new AddTimeOption?(); // AddTimeOption? |  (optional) 

            try
            {
                // Add tracked time to a issue
                TrackedTime result = apiInstance.IssueAddTime(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueAddTime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueAddTimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add tracked time to a issue
    ApiResponse<TrackedTime> response = apiInstance.IssueAddTimeWithHttpInfo(owner, repo, index, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueAddTimeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **body** | [**AddTimeOption?**](AddTimeOption?.md) |  | [optional]  |

### Return type

[**TrackedTime**](TrackedTime.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | TrackedTime |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuechecksubscription"></a>
# **IssueCheckSubscription**
> WatchInfo IssueCheckSubscription (string owner, string repo, long index)

Check if user is subscribed to an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueCheckSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue

            try
            {
                // Check if user is subscribed to an issue
                WatchInfo result = apiInstance.IssueCheckSubscription(owner, repo, index);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCheckSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueCheckSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check if user is subscribed to an issue
    ApiResponse<WatchInfo> response = apiInstance.IssueCheckSubscriptionWithHttpInfo(owner, repo, index);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueCheckSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |

### Return type

[**WatchInfo**](WatchInfo.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | WatchInfo |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueclearlabels"></a>
# **IssueClearLabels**
> void IssueClearLabels (string owner, string repo, long index)

Remove all labels from an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueClearLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue

            try
            {
                // Remove all labels from an issue
                apiInstance.IssueClearLabels(owner, repo, index);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueClearLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueClearLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove all labels from an issue
    apiInstance.IssueClearLabelsWithHttpInfo(owner, repo, index);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueClearLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuecreatecomment"></a>
# **IssueCreateComment**
> Comment IssueCreateComment (string owner, string repo, long index, CreateIssueCommentOption? body = null)

Add a comment to an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueCreateCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var body = new CreateIssueCommentOption?(); // CreateIssueCommentOption? |  (optional) 

            try
            {
                // Add a comment to an issue
                Comment result = apiInstance.IssueCreateComment(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCreateComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueCreateCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a comment to an issue
    ApiResponse<Comment> response = apiInstance.IssueCreateCommentWithHttpInfo(owner, repo, index, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueCreateCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **body** | [**CreateIssueCommentOption?**](CreateIssueCommentOption?.md) |  | [optional]  |

### Return type

[**Comment**](Comment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Comment |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |
| **423** | APIRepoArchivedError is an error that is raised when an archived repo should be modified |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuecreateissue"></a>
# **IssueCreateIssue**
> Issue IssueCreateIssue (string owner, string repo, CreateIssueOption? body = null)

Create an issue. If using deadline only the date will be taken into account, and time of day ignored.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueCreateIssueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var body = new CreateIssueOption?(); // CreateIssueOption? |  (optional) 

            try
            {
                // Create an issue. If using deadline only the date will be taken into account, and time of day ignored.
                Issue result = apiInstance.IssueCreateIssue(owner, repo, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCreateIssue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueCreateIssueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an issue. If using deadline only the date will be taken into account, and time of day ignored.
    ApiResponse<Issue> response = apiInstance.IssueCreateIssueWithHttpInfo(owner, repo, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueCreateIssueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **body** | [**CreateIssueOption?**](CreateIssueOption?.md) |  | [optional]  |

### Return type

[**Issue**](Issue.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Issue |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |
| **412** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |
| **423** | APIRepoArchivedError is an error that is raised when an archived repo should be modified |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuecreateissueattachment"></a>
# **IssueCreateIssueAttachment**
> Attachment IssueCreateIssueAttachment (string owner, string repo, long index, System.IO.Stream attachment, string? name = null)

Create an issue attachment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueCreateIssueAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var attachment = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | attachment to upload
            var name = "name_example";  // string? | name of the attachment (optional) 

            try
            {
                // Create an issue attachment
                Attachment result = apiInstance.IssueCreateIssueAttachment(owner, repo, index, attachment, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCreateIssueAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueCreateIssueAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an issue attachment
    ApiResponse<Attachment> response = apiInstance.IssueCreateIssueAttachmentWithHttpInfo(owner, repo, index, attachment, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueCreateIssueAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **attachment** | **System.IO.Stream****System.IO.Stream** | attachment to upload |  |
| **name** | **string?** | name of the attachment | [optional]  |

### Return type

[**Attachment**](Attachment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Attachment |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **404** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |
| **423** | APIRepoArchivedError is an error that is raised when an archived repo should be modified |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuecreateissueblocking"></a>
# **IssueCreateIssueBlocking**
> Issue IssueCreateIssueBlocking (string owner, string repo, string index, IssueMeta? body = null)

Block the issue given in the body by the issue in path

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueCreateIssueBlockingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = "index_example";  // string | index of the issue
            var body = new IssueMeta?(); // IssueMeta? |  (optional) 

            try
            {
                // Block the issue given in the body by the issue in path
                Issue result = apiInstance.IssueCreateIssueBlocking(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCreateIssueBlocking: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueCreateIssueBlockingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Block the issue given in the body by the issue in path
    ApiResponse<Issue> response = apiInstance.IssueCreateIssueBlockingWithHttpInfo(owner, repo, index, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueCreateIssueBlockingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **string** | index of the issue |  |
| **body** | [**IssueMeta?**](IssueMeta?.md) |  | [optional]  |

### Return type

[**Issue**](Issue.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Issue |  -  |
| **404** | the issue does not exist |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuecreateissuecommentattachment"></a>
# **IssueCreateIssueCommentAttachment**
> Attachment IssueCreateIssueCommentAttachment (string owner, string repo, long id, System.IO.Stream attachment, string? name = null)

Create a comment attachment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueCreateIssueCommentAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of the comment
            var attachment = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream | attachment to upload
            var name = "name_example";  // string? | name of the attachment (optional) 

            try
            {
                // Create a comment attachment
                Attachment result = apiInstance.IssueCreateIssueCommentAttachment(owner, repo, id, attachment, name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCreateIssueCommentAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueCreateIssueCommentAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a comment attachment
    ApiResponse<Attachment> response = apiInstance.IssueCreateIssueCommentAttachmentWithHttpInfo(owner, repo, id, attachment, name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueCreateIssueCommentAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of the comment |  |
| **attachment** | **System.IO.Stream****System.IO.Stream** | attachment to upload |  |
| **name** | **string?** | name of the attachment | [optional]  |

### Return type

[**Attachment**](Attachment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Attachment |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |
| **423** | APIRepoArchivedError is an error that is raised when an archived repo should be modified |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuecreateissuedependencies"></a>
# **IssueCreateIssueDependencies**
> Issue IssueCreateIssueDependencies (string owner, string repo, string index, IssueMeta? body = null)

Make the issue in the url depend on the issue in the form.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueCreateIssueDependenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = "index_example";  // string | index of the issue
            var body = new IssueMeta?(); // IssueMeta? |  (optional) 

            try
            {
                // Make the issue in the url depend on the issue in the form.
                Issue result = apiInstance.IssueCreateIssueDependencies(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCreateIssueDependencies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueCreateIssueDependenciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Make the issue in the url depend on the issue in the form.
    ApiResponse<Issue> response = apiInstance.IssueCreateIssueDependenciesWithHttpInfo(owner, repo, index, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueCreateIssueDependenciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **string** | index of the issue |  |
| **body** | [**IssueMeta?**](IssueMeta?.md) |  | [optional]  |

### Return type

[**Issue**](Issue.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Issue |  -  |
| **404** | the issue does not exist |  -  |
| **423** | APIRepoArchivedError is an error that is raised when an archived repo should be modified |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuecreatelabel"></a>
# **IssueCreateLabel**
> Label IssueCreateLabel (string owner, string repo, CreateLabelOption? body = null)

Create a label

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueCreateLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var body = new CreateLabelOption?(); // CreateLabelOption? |  (optional) 

            try
            {
                // Create a label
                Label result = apiInstance.IssueCreateLabel(owner, repo, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCreateLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueCreateLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a label
    ApiResponse<Label> response = apiInstance.IssueCreateLabelWithHttpInfo(owner, repo, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueCreateLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **body** | [**CreateLabelOption?**](CreateLabelOption?.md) |  | [optional]  |

### Return type

[**Label**](Label.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Label |  -  |
| **404** | APINotFound is a not found empty response |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuecreatemilestone"></a>
# **IssueCreateMilestone**
> Milestone IssueCreateMilestone (string owner, string repo, CreateMilestoneOption? body = null)

Create a milestone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueCreateMilestoneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var body = new CreateMilestoneOption?(); // CreateMilestoneOption? |  (optional) 

            try
            {
                // Create a milestone
                Milestone result = apiInstance.IssueCreateMilestone(owner, repo, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueCreateMilestone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueCreateMilestoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a milestone
    ApiResponse<Milestone> response = apiInstance.IssueCreateMilestoneWithHttpInfo(owner, repo, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueCreateMilestoneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **body** | [**CreateMilestoneOption?**](CreateMilestoneOption?.md) |  | [optional]  |

### Return type

[**Milestone**](Milestone.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Milestone |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuedelete"></a>
# **IssueDelete**
> void IssueDelete (string owner, string repo, long index)

Delete an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of issue to delete

            try
            {
                // Delete an issue
                apiInstance.IssueDelete(owner, repo, index);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an issue
    apiInstance.IssueDeleteWithHttpInfo(owner, repo, index);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of issue to delete |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuedeletecomment"></a>
# **IssueDeleteComment**
> void IssueDeleteComment (string owner, string repo, long id)

Delete a comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueDeleteCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of comment to delete

            try
            {
                // Delete a comment
                apiInstance.IssueDeleteComment(owner, repo, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueDeleteCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a comment
    apiInstance.IssueDeleteCommentWithHttpInfo(owner, repo, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueDeleteCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of comment to delete |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuedeletecommentdeprecated"></a>
# **IssueDeleteCommentDeprecated**
> void IssueDeleteCommentDeprecated (string owner, string repo, int index, long id)

Delete a comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueDeleteCommentDeprecatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 56;  // int | this parameter is ignored
            var id = 789L;  // long | id of comment to delete

            try
            {
                // Delete a comment
                apiInstance.IssueDeleteCommentDeprecated(owner, repo, index, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteCommentDeprecated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueDeleteCommentDeprecatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a comment
    apiInstance.IssueDeleteCommentDeprecatedWithHttpInfo(owner, repo, index, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueDeleteCommentDeprecatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **int** | this parameter is ignored |  |
| **id** | **long** | id of comment to delete |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuedeletecommentreaction"></a>
# **IssueDeleteCommentReaction**
> void IssueDeleteCommentReaction (string owner, string repo, long id, EditReactionOption? content = null)

Remove a reaction from a comment of an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueDeleteCommentReactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of the comment to edit
            var content = new EditReactionOption?(); // EditReactionOption? |  (optional) 

            try
            {
                // Remove a reaction from a comment of an issue
                apiInstance.IssueDeleteCommentReaction(owner, repo, id, content);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteCommentReaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueDeleteCommentReactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a reaction from a comment of an issue
    apiInstance.IssueDeleteCommentReactionWithHttpInfo(owner, repo, id, content);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueDeleteCommentReactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of the comment to edit |  |
| **content** | [**EditReactionOption?**](EditReactionOption?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuedeleteissueattachment"></a>
# **IssueDeleteIssueAttachment**
> void IssueDeleteIssueAttachment (string owner, string repo, long index, long attachmentId)

Delete an issue attachment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueDeleteIssueAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var attachmentId = 789L;  // long | id of the attachment to delete

            try
            {
                // Delete an issue attachment
                apiInstance.IssueDeleteIssueAttachment(owner, repo, index, attachmentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteIssueAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueDeleteIssueAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an issue attachment
    apiInstance.IssueDeleteIssueAttachmentWithHttpInfo(owner, repo, index, attachmentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueDeleteIssueAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **attachmentId** | **long** | id of the attachment to delete |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **404** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **423** | APIRepoArchivedError is an error that is raised when an archived repo should be modified |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuedeleteissuecommentattachment"></a>
# **IssueDeleteIssueCommentAttachment**
> void IssueDeleteIssueCommentAttachment (string owner, string repo, long id, long attachmentId)

Delete a comment attachment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueDeleteIssueCommentAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of the comment
            var attachmentId = 789L;  // long | id of the attachment to delete

            try
            {
                // Delete a comment attachment
                apiInstance.IssueDeleteIssueCommentAttachment(owner, repo, id, attachmentId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteIssueCommentAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueDeleteIssueCommentAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a comment attachment
    apiInstance.IssueDeleteIssueCommentAttachmentWithHttpInfo(owner, repo, id, attachmentId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueDeleteIssueCommentAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of the comment |  |
| **attachmentId** | **long** | id of the attachment to delete |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **404** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **423** | APIRepoArchivedError is an error that is raised when an archived repo should be modified |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuedeleteissuereaction"></a>
# **IssueDeleteIssueReaction**
> void IssueDeleteIssueReaction (string owner, string repo, long index, EditReactionOption? content = null)

Remove a reaction from an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueDeleteIssueReactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var content = new EditReactionOption?(); // EditReactionOption? |  (optional) 

            try
            {
                // Remove a reaction from an issue
                apiInstance.IssueDeleteIssueReaction(owner, repo, index, content);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteIssueReaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueDeleteIssueReactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a reaction from an issue
    apiInstance.IssueDeleteIssueReactionWithHttpInfo(owner, repo, index, content);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueDeleteIssueReactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **content** | [**EditReactionOption?**](EditReactionOption?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuedeletelabel"></a>
# **IssueDeleteLabel**
> void IssueDeleteLabel (string owner, string repo, long id)

Delete a label

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueDeleteLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of the label to delete

            try
            {
                // Delete a label
                apiInstance.IssueDeleteLabel(owner, repo, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueDeleteLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a label
    apiInstance.IssueDeleteLabelWithHttpInfo(owner, repo, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueDeleteLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of the label to delete |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuedeletemilestone"></a>
# **IssueDeleteMilestone**
> void IssueDeleteMilestone (string owner, string repo, string id)

Delete a milestone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueDeleteMilestoneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = "id_example";  // string | the milestone to delete, identified by ID and if not available by name

            try
            {
                // Delete a milestone
                apiInstance.IssueDeleteMilestone(owner, repo, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteMilestone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueDeleteMilestoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a milestone
    apiInstance.IssueDeleteMilestoneWithHttpInfo(owner, repo, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueDeleteMilestoneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **string** | the milestone to delete, identified by ID and if not available by name |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuedeletestopwatch"></a>
# **IssueDeleteStopWatch**
> void IssueDeleteStopWatch (string owner, string repo, long index)

Delete an issue's existing stopwatch.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueDeleteStopWatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue to stop the stopwatch on

            try
            {
                // Delete an issue's existing stopwatch.
                apiInstance.IssueDeleteStopWatch(owner, repo, index);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteStopWatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueDeleteStopWatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete an issue's existing stopwatch.
    apiInstance.IssueDeleteStopWatchWithHttpInfo(owner, repo, index);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueDeleteStopWatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue to stop the stopwatch on |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | Not repo writer, user does not have rights to toggle stopwatch |  -  |
| **404** | APINotFound is a not found empty response |  -  |
| **409** | Cannot cancel a non existent stopwatch |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuedeletesubscription"></a>
# **IssueDeleteSubscription**
> void IssueDeleteSubscription (string owner, string repo, long index, string user)

Unsubscribe user from issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueDeleteSubscriptionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var user = "user_example";  // string | user witch unsubscribe

            try
            {
                // Unsubscribe user from issue
                apiInstance.IssueDeleteSubscription(owner, repo, index, user);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteSubscription: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueDeleteSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unsubscribe user from issue
    apiInstance.IssueDeleteSubscriptionWithHttpInfo(owner, repo, index, user);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueDeleteSubscriptionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **user** | **string** | user witch unsubscribe |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Already unsubscribed |  -  |
| **201** | Successfully Unsubscribed |  -  |
| **304** | User can only subscribe itself if he is no admin |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuedeletetime"></a>
# **IssueDeleteTime**
> void IssueDeleteTime (string owner, string repo, long index, long id)

Delete specific tracked time

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueDeleteTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var id = 789L;  // long | id of time to delete

            try
            {
                // Delete specific tracked time
                apiInstance.IssueDeleteTime(owner, repo, index, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueDeleteTime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueDeleteTimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete specific tracked time
    apiInstance.IssueDeleteTimeWithHttpInfo(owner, repo, index, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueDeleteTimeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **id** | **long** | id of time to delete |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueeditcomment"></a>
# **IssueEditComment**
> Comment IssueEditComment (string owner, string repo, long id, EditIssueCommentOption? body = null)

Edit a comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueEditCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of the comment to edit
            var body = new EditIssueCommentOption?(); // EditIssueCommentOption? |  (optional) 

            try
            {
                // Edit a comment
                Comment result = apiInstance.IssueEditComment(owner, repo, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueEditCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit a comment
    ApiResponse<Comment> response = apiInstance.IssueEditCommentWithHttpInfo(owner, repo, id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueEditCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of the comment to edit |  |
| **body** | [**EditIssueCommentOption?**](EditIssueCommentOption?.md) |  | [optional]  |

### Return type

[**Comment**](Comment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Comment |  -  |
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |
| **423** | APIRepoArchivedError is an error that is raised when an archived repo should be modified |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueeditcommentdeprecated"></a>
# **IssueEditCommentDeprecated**
> Comment IssueEditCommentDeprecated (string owner, string repo, int index, long id, EditIssueCommentOption? body = null)

Edit a comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueEditCommentDeprecatedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 56;  // int | this parameter is ignored
            var id = 789L;  // long | id of the comment to edit
            var body = new EditIssueCommentOption?(); // EditIssueCommentOption? |  (optional) 

            try
            {
                // Edit a comment
                Comment result = apiInstance.IssueEditCommentDeprecated(owner, repo, index, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditCommentDeprecated: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueEditCommentDeprecatedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit a comment
    ApiResponse<Comment> response = apiInstance.IssueEditCommentDeprecatedWithHttpInfo(owner, repo, index, id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueEditCommentDeprecatedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **int** | this parameter is ignored |  |
| **id** | **long** | id of the comment to edit |  |
| **body** | [**EditIssueCommentOption?**](EditIssueCommentOption?.md) |  | [optional]  |

### Return type

[**Comment**](Comment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Comment |  -  |
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueeditissue"></a>
# **IssueEditIssue**
> Issue IssueEditIssue (string owner, string repo, long index, EditIssueOption? body = null)

Edit an issue. If using deadline only the date will be taken into account, and time of day ignored.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueEditIssueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue to edit
            var body = new EditIssueOption?(); // EditIssueOption? |  (optional) 

            try
            {
                // Edit an issue. If using deadline only the date will be taken into account, and time of day ignored.
                Issue result = apiInstance.IssueEditIssue(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditIssue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueEditIssueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an issue. If using deadline only the date will be taken into account, and time of day ignored.
    ApiResponse<Issue> response = apiInstance.IssueEditIssueWithHttpInfo(owner, repo, index, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueEditIssueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue to edit |  |
| **body** | [**EditIssueOption?**](EditIssueOption?.md) |  | [optional]  |

### Return type

[**Issue**](Issue.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Issue |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |
| **412** | APIError is error format response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueeditissueattachment"></a>
# **IssueEditIssueAttachment**
> Attachment IssueEditIssueAttachment (string owner, string repo, long index, long attachmentId, EditAttachmentOptions? body = null)

Edit an issue attachment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueEditIssueAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var attachmentId = 789L;  // long | id of the attachment to edit
            var body = new EditAttachmentOptions?(); // EditAttachmentOptions? |  (optional) 

            try
            {
                // Edit an issue attachment
                Attachment result = apiInstance.IssueEditIssueAttachment(owner, repo, index, attachmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditIssueAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueEditIssueAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit an issue attachment
    ApiResponse<Attachment> response = apiInstance.IssueEditIssueAttachmentWithHttpInfo(owner, repo, index, attachmentId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueEditIssueAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **attachmentId** | **long** | id of the attachment to edit |  |
| **body** | [**EditAttachmentOptions?**](EditAttachmentOptions?.md) |  | [optional]  |

### Return type

[**Attachment**](Attachment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Attachment |  -  |
| **404** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **423** | APIRepoArchivedError is an error that is raised when an archived repo should be modified |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueeditissuecommentattachment"></a>
# **IssueEditIssueCommentAttachment**
> Attachment IssueEditIssueCommentAttachment (string owner, string repo, long id, long attachmentId, EditAttachmentOptions? body = null)

Edit a comment attachment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueEditIssueCommentAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of the comment
            var attachmentId = 789L;  // long | id of the attachment to edit
            var body = new EditAttachmentOptions?(); // EditAttachmentOptions? |  (optional) 

            try
            {
                // Edit a comment attachment
                Attachment result = apiInstance.IssueEditIssueCommentAttachment(owner, repo, id, attachmentId, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditIssueCommentAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueEditIssueCommentAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Edit a comment attachment
    ApiResponse<Attachment> response = apiInstance.IssueEditIssueCommentAttachmentWithHttpInfo(owner, repo, id, attachmentId, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueEditIssueCommentAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of the comment |  |
| **attachmentId** | **long** | id of the attachment to edit |  |
| **body** | [**EditAttachmentOptions?**](EditAttachmentOptions?.md) |  | [optional]  |

### Return type

[**Attachment**](Attachment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Attachment |  -  |
| **404** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **423** | APIRepoArchivedError is an error that is raised when an archived repo should be modified |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueeditissuedeadline"></a>
# **IssueEditIssueDeadline**
> IssueDeadline IssueEditIssueDeadline (string owner, string repo, long index, EditDeadlineOption? body = null)

Set an issue deadline. If set to null, the deadline is deleted. If using deadline only the date will be taken into account, and time of day ignored.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueEditIssueDeadlineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue to create or update a deadline on
            var body = new EditDeadlineOption?(); // EditDeadlineOption? |  (optional) 

            try
            {
                // Set an issue deadline. If set to null, the deadline is deleted. If using deadline only the date will be taken into account, and time of day ignored.
                IssueDeadline result = apiInstance.IssueEditIssueDeadline(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditIssueDeadline: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueEditIssueDeadlineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Set an issue deadline. If set to null, the deadline is deleted. If using deadline only the date will be taken into account, and time of day ignored.
    ApiResponse<IssueDeadline> response = apiInstance.IssueEditIssueDeadlineWithHttpInfo(owner, repo, index, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueEditIssueDeadlineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue to create or update a deadline on |  |
| **body** | [**EditDeadlineOption?**](EditDeadlineOption?.md) |  | [optional]  |

### Return type

[**IssueDeadline**](IssueDeadline.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | IssueDeadline |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueeditlabel"></a>
# **IssueEditLabel**
> Label IssueEditLabel (string owner, string repo, long id, EditLabelOption? body = null)

Update a label

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueEditLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of the label to edit
            var body = new EditLabelOption?(); // EditLabelOption? |  (optional) 

            try
            {
                // Update a label
                Label result = apiInstance.IssueEditLabel(owner, repo, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueEditLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a label
    ApiResponse<Label> response = apiInstance.IssueEditLabelWithHttpInfo(owner, repo, id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueEditLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of the label to edit |  |
| **body** | [**EditLabelOption?**](EditLabelOption?.md) |  | [optional]  |

### Return type

[**Label**](Label.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Label |  -  |
| **404** | APINotFound is a not found empty response |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueeditmilestone"></a>
# **IssueEditMilestone**
> Milestone IssueEditMilestone (string owner, string repo, string id, EditMilestoneOption? body = null)

Update a milestone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueEditMilestoneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = "id_example";  // string | the milestone to edit, identified by ID and if not available by name
            var body = new EditMilestoneOption?(); // EditMilestoneOption? |  (optional) 

            try
            {
                // Update a milestone
                Milestone result = apiInstance.IssueEditMilestone(owner, repo, id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueEditMilestone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueEditMilestoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a milestone
    ApiResponse<Milestone> response = apiInstance.IssueEditMilestoneWithHttpInfo(owner, repo, id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueEditMilestoneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **string** | the milestone to edit, identified by ID and if not available by name |  |
| **body** | [**EditMilestoneOption?**](EditMilestoneOption?.md) |  | [optional]  |

### Return type

[**Milestone**](Milestone.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Milestone |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuegetcomment"></a>
# **IssueGetComment**
> Comment IssueGetComment (string owner, string repo, long id)

Get a comment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueGetCommentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of the comment

            try
            {
                // Get a comment
                Comment result = apiInstance.IssueGetComment(owner, repo, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetComment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueGetCommentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a comment
    ApiResponse<Comment> response = apiInstance.IssueGetCommentWithHttpInfo(owner, repo, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueGetCommentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of the comment |  |

### Return type

[**Comment**](Comment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Comment |  -  |
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuegetcommentreactions"></a>
# **IssueGetCommentReactions**
> List&lt;Reaction&gt; IssueGetCommentReactions (string owner, string repo, long id)

Get a list of reactions from a comment of an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueGetCommentReactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of the comment to edit

            try
            {
                // Get a list of reactions from a comment of an issue
                List<Reaction> result = apiInstance.IssueGetCommentReactions(owner, repo, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetCommentReactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueGetCommentReactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list of reactions from a comment of an issue
    ApiResponse<List<Reaction>> response = apiInstance.IssueGetCommentReactionsWithHttpInfo(owner, repo, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueGetCommentReactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of the comment to edit |  |

### Return type

[**List&lt;Reaction&gt;**](Reaction.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ReactionList |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuegetcomments"></a>
# **IssueGetComments**
> List&lt;Comment&gt; IssueGetComments (string owner, string repo, long index, DateTime? since = null, DateTime? before = null)

List all comments on an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueGetCommentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | if provided, only comments updated since the specified time are returned. (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | if provided, only comments updated before the provided time are returned. (optional) 

            try
            {
                // List all comments on an issue
                List<Comment> result = apiInstance.IssueGetComments(owner, repo, index, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetComments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueGetCommentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all comments on an issue
    ApiResponse<List<Comment>> response = apiInstance.IssueGetCommentsWithHttpInfo(owner, repo, index, since, before);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueGetCommentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **since** | **DateTime?** | if provided, only comments updated since the specified time are returned. | [optional]  |
| **before** | **DateTime?** | if provided, only comments updated before the provided time are returned. | [optional]  |

### Return type

[**List&lt;Comment&gt;**](Comment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | CommentList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuegetcommentsandtimeline"></a>
# **IssueGetCommentsAndTimeline**
> List&lt;TimelineComment&gt; IssueGetCommentsAndTimeline (string owner, string repo, long index, DateTime? since = null, int? page = null, int? limit = null, DateTime? before = null)

List all comments and events on an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueGetCommentsAndTimelineExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | if provided, only comments updated since the specified time are returned. (optional) 
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | if provided, only comments updated before the provided time are returned. (optional) 

            try
            {
                // List all comments and events on an issue
                List<TimelineComment> result = apiInstance.IssueGetCommentsAndTimeline(owner, repo, index, since, page, limit, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetCommentsAndTimeline: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueGetCommentsAndTimelineWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all comments and events on an issue
    ApiResponse<List<TimelineComment>> response = apiInstance.IssueGetCommentsAndTimelineWithHttpInfo(owner, repo, index, since, page, limit, before);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueGetCommentsAndTimelineWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **since** | **DateTime?** | if provided, only comments updated since the specified time are returned. | [optional]  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |
| **before** | **DateTime?** | if provided, only comments updated before the provided time are returned. | [optional]  |

### Return type

[**List&lt;TimelineComment&gt;**](TimelineComment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | TimelineList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuegetissue"></a>
# **IssueGetIssue**
> Issue IssueGetIssue (string owner, string repo, long index)

Get an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueGetIssueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue to get

            try
            {
                // Get an issue
                Issue result = apiInstance.IssueGetIssue(owner, repo, index);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetIssue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueGetIssueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an issue
    ApiResponse<Issue> response = apiInstance.IssueGetIssueWithHttpInfo(owner, repo, index);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueGetIssueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue to get |  |

### Return type

[**Issue**](Issue.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Issue |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuegetissueattachment"></a>
# **IssueGetIssueAttachment**
> Attachment IssueGetIssueAttachment (string owner, string repo, long index, long attachmentId)

Get an issue attachment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueGetIssueAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var attachmentId = 789L;  // long | id of the attachment to get

            try
            {
                // Get an issue attachment
                Attachment result = apiInstance.IssueGetIssueAttachment(owner, repo, index, attachmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetIssueAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueGetIssueAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an issue attachment
    ApiResponse<Attachment> response = apiInstance.IssueGetIssueAttachmentWithHttpInfo(owner, repo, index, attachmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueGetIssueAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **attachmentId** | **long** | id of the attachment to get |  |

### Return type

[**Attachment**](Attachment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Attachment |  -  |
| **404** | APIError is error format response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuegetissuecommentattachment"></a>
# **IssueGetIssueCommentAttachment**
> Attachment IssueGetIssueCommentAttachment (string owner, string repo, long id, long attachmentId)

Get a comment attachment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueGetIssueCommentAttachmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of the comment
            var attachmentId = 789L;  // long | id of the attachment to get

            try
            {
                // Get a comment attachment
                Attachment result = apiInstance.IssueGetIssueCommentAttachment(owner, repo, id, attachmentId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetIssueCommentAttachment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueGetIssueCommentAttachmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a comment attachment
    ApiResponse<Attachment> response = apiInstance.IssueGetIssueCommentAttachmentWithHttpInfo(owner, repo, id, attachmentId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueGetIssueCommentAttachmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of the comment |  |
| **attachmentId** | **long** | id of the attachment to get |  |

### Return type

[**Attachment**](Attachment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Attachment |  -  |
| **404** | APIError is error format response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuegetissuereactions"></a>
# **IssueGetIssueReactions**
> List&lt;Reaction&gt; IssueGetIssueReactions (string owner, string repo, long index, int? page = null, int? limit = null)

Get a list reactions of an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueGetIssueReactionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // Get a list reactions of an issue
                List<Reaction> result = apiInstance.IssueGetIssueReactions(owner, repo, index, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetIssueReactions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueGetIssueReactionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a list reactions of an issue
    ApiResponse<List<Reaction>> response = apiInstance.IssueGetIssueReactionsWithHttpInfo(owner, repo, index, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueGetIssueReactionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Reaction&gt;**](Reaction.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ReactionList |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuegetlabel"></a>
# **IssueGetLabel**
> Label IssueGetLabel (string owner, string repo, long id)

Get a single label

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueGetLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of the label to get

            try
            {
                // Get a single label
                Label result = apiInstance.IssueGetLabel(owner, repo, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueGetLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a single label
    ApiResponse<Label> response = apiInstance.IssueGetLabelWithHttpInfo(owner, repo, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueGetLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of the label to get |  |

### Return type

[**Label**](Label.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Label |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuegetlabels"></a>
# **IssueGetLabels**
> List&lt;Label&gt; IssueGetLabels (string owner, string repo, long index)

Get an issue's labels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueGetLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue

            try
            {
                // Get an issue's labels
                List<Label> result = apiInstance.IssueGetLabels(owner, repo, index);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueGetLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an issue's labels
    ApiResponse<List<Label>> response = apiInstance.IssueGetLabelsWithHttpInfo(owner, repo, index);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueGetLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |

### Return type

[**List&lt;Label&gt;**](Label.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LabelList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuegetmilestone"></a>
# **IssueGetMilestone**
> Milestone IssueGetMilestone (string owner, string repo, string id)

Get a milestone

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueGetMilestoneExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = "id_example";  // string | the milestone to get, identified by ID and if not available by name

            try
            {
                // Get a milestone
                Milestone result = apiInstance.IssueGetMilestone(owner, repo, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetMilestone: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueGetMilestoneWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a milestone
    ApiResponse<Milestone> response = apiInstance.IssueGetMilestoneWithHttpInfo(owner, repo, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueGetMilestoneWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **string** | the milestone to get, identified by ID and if not available by name |  |

### Return type

[**Milestone**](Milestone.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Milestone |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuegetmilestoneslist"></a>
# **IssueGetMilestonesList**
> List&lt;Milestone&gt; IssueGetMilestonesList (string owner, string repo, string? state = null, string? name = null, int? page = null, int? limit = null)

Get all of a repository's opened milestones

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueGetMilestonesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var state = "state_example";  // string? | Milestone state, Recognized values are open, closed and all. Defaults to \"open\" (optional) 
            var name = "name_example";  // string? | filter by milestone name (optional) 
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // Get all of a repository's opened milestones
                List<Milestone> result = apiInstance.IssueGetMilestonesList(owner, repo, state, name, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetMilestonesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueGetMilestonesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all of a repository's opened milestones
    ApiResponse<List<Milestone>> response = apiInstance.IssueGetMilestonesListWithHttpInfo(owner, repo, state, name, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueGetMilestonesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **state** | **string?** | Milestone state, Recognized values are open, closed and all. Defaults to \&quot;open\&quot; | [optional]  |
| **name** | **string?** | filter by milestone name | [optional]  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Milestone&gt;**](Milestone.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | MilestoneList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuegetrepocomments"></a>
# **IssueGetRepoComments**
> List&lt;Comment&gt; IssueGetRepoComments (string owner, string repo, DateTime? since = null, DateTime? before = null, int? page = null, int? limit = null)

List all comments in a repository

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueGetRepoCommentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | if provided, only comments updated since the provided time are returned. (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | if provided, only comments updated before the provided time are returned. (optional) 
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List all comments in a repository
                List<Comment> result = apiInstance.IssueGetRepoComments(owner, repo, since, before, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueGetRepoComments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueGetRepoCommentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all comments in a repository
    ApiResponse<List<Comment>> response = apiInstance.IssueGetRepoCommentsWithHttpInfo(owner, repo, since, before, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueGetRepoCommentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **since** | **DateTime?** | if provided, only comments updated since the provided time are returned. | [optional]  |
| **before** | **DateTime?** | if provided, only comments updated before the provided time are returned. | [optional]  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Comment&gt;**](Comment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | CommentList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuelistblocks"></a>
# **IssueListBlocks**
> List&lt;Issue&gt; IssueListBlocks (string owner, string repo, string index, int? page = null, int? limit = null)

List issues that are blocked by this issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueListBlocksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = "index_example";  // string | index of the issue
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List issues that are blocked by this issue
                List<Issue> result = apiInstance.IssueListBlocks(owner, repo, index, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueListBlocks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueListBlocksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List issues that are blocked by this issue
    ApiResponse<List<Issue>> response = apiInstance.IssueListBlocksWithHttpInfo(owner, repo, index, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueListBlocksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **string** | index of the issue |  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Issue&gt;**](Issue.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | IssueList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuelistissueattachments"></a>
# **IssueListIssueAttachments**
> List&lt;Attachment&gt; IssueListIssueAttachments (string owner, string repo, long index)

List issue's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueListIssueAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue

            try
            {
                // List issue's attachments
                List<Attachment> result = apiInstance.IssueListIssueAttachments(owner, repo, index);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueListIssueAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueListIssueAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List issue's attachments
    ApiResponse<List<Attachment>> response = apiInstance.IssueListIssueAttachmentsWithHttpInfo(owner, repo, index);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueListIssueAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |

### Return type

[**List&lt;Attachment&gt;**](Attachment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | AttachmentList |  -  |
| **404** | APIError is error format response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuelistissuecommentattachments"></a>
# **IssueListIssueCommentAttachments**
> List&lt;Attachment&gt; IssueListIssueCommentAttachments (string owner, string repo, long id)

List comment's attachments

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueListIssueCommentAttachmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of the comment

            try
            {
                // List comment's attachments
                List<Attachment> result = apiInstance.IssueListIssueCommentAttachments(owner, repo, id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueListIssueCommentAttachments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueListIssueCommentAttachmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List comment's attachments
    ApiResponse<List<Attachment>> response = apiInstance.IssueListIssueCommentAttachmentsWithHttpInfo(owner, repo, id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueListIssueCommentAttachmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of the comment |  |

### Return type

[**List&lt;Attachment&gt;**](Attachment.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | AttachmentList |  -  |
| **404** | APIError is error format response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuelistissuedependencies"></a>
# **IssueListIssueDependencies**
> List&lt;Issue&gt; IssueListIssueDependencies (string owner, string repo, string index, int? page = null, int? limit = null)

List an issue's dependencies, i.e all issues that block this issue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueListIssueDependenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = "index_example";  // string | index of the issue
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List an issue's dependencies, i.e all issues that block this issue.
                List<Issue> result = apiInstance.IssueListIssueDependencies(owner, repo, index, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueListIssueDependencies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueListIssueDependenciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List an issue's dependencies, i.e all issues that block this issue.
    ApiResponse<List<Issue>> response = apiInstance.IssueListIssueDependenciesWithHttpInfo(owner, repo, index, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueListIssueDependenciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **string** | index of the issue |  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Issue&gt;**](Issue.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | IssueList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuelistissues"></a>
# **IssueListIssues**
> List&lt;Issue&gt; IssueListIssues (string owner, string repo, string? state = null, string? labels = null, string? q = null, string? type = null, string? milestones = null, DateTime? since = null, DateTime? before = null, string? createdBy = null, string? assignedBy = null, string? mentionedBy = null, int? page = null, int? limit = null)

List a repository's issues

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueListIssuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var state = "closed";  // string? | whether issue is open or closed (optional) 
            var labels = "labels_example";  // string? | comma separated list of labels. Fetch only issues that have any of this labels. Non existent labels are discarded (optional) 
            var q = "q_example";  // string? | search string (optional) 
            var type = "issues";  // string? | filter by type (issues / pulls) if set (optional) 
            var milestones = "milestones_example";  // string? | comma separated list of milestone names or ids. It uses names and fall back to ids. Fetch only issues that have any of this milestones. Non existent milestones are discarded (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show items updated after the given time. This is a timestamp in RFC 3339 format (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show items updated before the given time. This is a timestamp in RFC 3339 format (optional) 
            var createdBy = "createdBy_example";  // string? | Only show items which were created by the given user (optional) 
            var assignedBy = "assignedBy_example";  // string? | Only show items for which the given user is assigned (optional) 
            var mentionedBy = "mentionedBy_example";  // string? | Only show items in which the given user was mentioned (optional) 
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List a repository's issues
                List<Issue> result = apiInstance.IssueListIssues(owner, repo, state, labels, q, type, milestones, since, before, createdBy, assignedBy, mentionedBy, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueListIssues: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueListIssuesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List a repository's issues
    ApiResponse<List<Issue>> response = apiInstance.IssueListIssuesWithHttpInfo(owner, repo, state, labels, q, type, milestones, since, before, createdBy, assignedBy, mentionedBy, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueListIssuesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **state** | **string?** | whether issue is open or closed | [optional]  |
| **labels** | **string?** | comma separated list of labels. Fetch only issues that have any of this labels. Non existent labels are discarded | [optional]  |
| **q** | **string?** | search string | [optional]  |
| **type** | **string?** | filter by type (issues / pulls) if set | [optional]  |
| **milestones** | **string?** | comma separated list of milestone names or ids. It uses names and fall back to ids. Fetch only issues that have any of this milestones. Non existent milestones are discarded | [optional]  |
| **since** | **DateTime?** | Only show items updated after the given time. This is a timestamp in RFC 3339 format | [optional]  |
| **before** | **DateTime?** | Only show items updated before the given time. This is a timestamp in RFC 3339 format | [optional]  |
| **createdBy** | **string?** | Only show items which were created by the given user | [optional]  |
| **assignedBy** | **string?** | Only show items for which the given user is assigned | [optional]  |
| **mentionedBy** | **string?** | Only show items in which the given user was mentioned | [optional]  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Issue&gt;**](Issue.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | IssueList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuelistlabels"></a>
# **IssueListLabels**
> List&lt;Label&gt; IssueListLabels (string owner, string repo, int? page = null, int? limit = null)

Get all of a repository's labels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueListLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // Get all of a repository's labels
                List<Label> result = apiInstance.IssueListLabels(owner, repo, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueListLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueListLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get all of a repository's labels
    ApiResponse<List<Label>> response = apiInstance.IssueListLabelsWithHttpInfo(owner, repo, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueListLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Label&gt;**](Label.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LabelList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuepostcommentreaction"></a>
# **IssuePostCommentReaction**
> Reaction IssuePostCommentReaction (string owner, string repo, long id, EditReactionOption? content = null)

Add a reaction to a comment of an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuePostCommentReactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var id = 789L;  // long | id of the comment to edit
            var content = new EditReactionOption?(); // EditReactionOption? |  (optional) 

            try
            {
                // Add a reaction to a comment of an issue
                Reaction result = apiInstance.IssuePostCommentReaction(owner, repo, id, content);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssuePostCommentReaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssuePostCommentReactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a reaction to a comment of an issue
    ApiResponse<Reaction> response = apiInstance.IssuePostCommentReactionWithHttpInfo(owner, repo, id, content);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssuePostCommentReactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **id** | **long** | id of the comment to edit |  |
| **content** | [**EditReactionOption?**](EditReactionOption?.md) |  | [optional]  |

### Return type

[**Reaction**](Reaction.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Reaction |  -  |
| **201** | Reaction |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuepostissuereaction"></a>
# **IssuePostIssueReaction**
> Reaction IssuePostIssueReaction (string owner, string repo, long index, EditReactionOption? content = null)

Add a reaction to an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssuePostIssueReactionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var content = new EditReactionOption?(); // EditReactionOption? |  (optional) 

            try
            {
                // Add a reaction to an issue
                Reaction result = apiInstance.IssuePostIssueReaction(owner, repo, index, content);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssuePostIssueReaction: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssuePostIssueReactionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add a reaction to an issue
    ApiResponse<Reaction> response = apiInstance.IssuePostIssueReactionWithHttpInfo(owner, repo, index, content);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssuePostIssueReactionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **content** | [**EditReactionOption?**](EditReactionOption?.md) |  | [optional]  |

### Return type

[**Reaction**](Reaction.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Reaction |  -  |
| **201** | Reaction |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueremoveissueblocking"></a>
# **IssueRemoveIssueBlocking**
> Issue IssueRemoveIssueBlocking (string owner, string repo, string index, IssueMeta? body = null)

Unblock the issue given in the body by the issue in path

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueRemoveIssueBlockingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = "index_example";  // string | index of the issue
            var body = new IssueMeta?(); // IssueMeta? |  (optional) 

            try
            {
                // Unblock the issue given in the body by the issue in path
                Issue result = apiInstance.IssueRemoveIssueBlocking(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueRemoveIssueBlocking: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueRemoveIssueBlockingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unblock the issue given in the body by the issue in path
    ApiResponse<Issue> response = apiInstance.IssueRemoveIssueBlockingWithHttpInfo(owner, repo, index, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueRemoveIssueBlockingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **string** | index of the issue |  |
| **body** | [**IssueMeta?**](IssueMeta?.md) |  | [optional]  |

### Return type

[**Issue**](Issue.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Issue |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueremoveissuedependencies"></a>
# **IssueRemoveIssueDependencies**
> Issue IssueRemoveIssueDependencies (string owner, string repo, string index, IssueMeta? body = null)

Remove an issue dependency

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueRemoveIssueDependenciesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = "index_example";  // string | index of the issue
            var body = new IssueMeta?(); // IssueMeta? |  (optional) 

            try
            {
                // Remove an issue dependency
                Issue result = apiInstance.IssueRemoveIssueDependencies(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueRemoveIssueDependencies: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueRemoveIssueDependenciesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove an issue dependency
    ApiResponse<Issue> response = apiInstance.IssueRemoveIssueDependenciesWithHttpInfo(owner, repo, index, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueRemoveIssueDependenciesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **string** | index of the issue |  |
| **body** | [**IssueMeta?**](IssueMeta?.md) |  | [optional]  |

### Return type

[**Issue**](Issue.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Issue |  -  |
| **404** | APINotFound is a not found empty response |  -  |
| **423** | APIRepoArchivedError is an error that is raised when an archived repo should be modified |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueremovelabel"></a>
# **IssueRemoveLabel**
> void IssueRemoveLabel (string owner, string repo, long index, long id)

Remove a label from an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueRemoveLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var id = 789L;  // long | id of the label to remove

            try
            {
                // Remove a label from an issue
                apiInstance.IssueRemoveLabel(owner, repo, index, id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueRemoveLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueRemoveLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a label from an issue
    apiInstance.IssueRemoveLabelWithHttpInfo(owner, repo, index, id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueRemoveLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **id** | **long** | id of the label to remove |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuereplacelabels"></a>
# **IssueReplaceLabels**
> List&lt;Label&gt; IssueReplaceLabels (string owner, string repo, long index, IssueLabelsOption? body = null)

Replace an issue's labels

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueReplaceLabelsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var body = new IssueLabelsOption?(); // IssueLabelsOption? |  (optional) 

            try
            {
                // Replace an issue's labels
                List<Label> result = apiInstance.IssueReplaceLabels(owner, repo, index, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueReplaceLabels: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueReplaceLabelsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Replace an issue's labels
    ApiResponse<List<Label>> response = apiInstance.IssueReplaceLabelsWithHttpInfo(owner, repo, index, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueReplaceLabelsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **body** | [**IssueLabelsOption?**](IssueLabelsOption?.md) |  | [optional]  |

### Return type

[**List&lt;Label&gt;**](Label.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LabelList |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issueresettime"></a>
# **IssueResetTime**
> void IssueResetTime (string owner, string repo, long index)

Reset a tracked time of an issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueResetTimeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue to add tracked time to

            try
            {
                // Reset a tracked time of an issue
                apiInstance.IssueResetTime(owner, repo, index);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueResetTime: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueResetTimeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reset a tracked time of an issue
    apiInstance.IssueResetTimeWithHttpInfo(owner, repo, index);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueResetTimeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue to add tracked time to |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuesearchissues"></a>
# **IssueSearchIssues**
> List&lt;Issue&gt; IssueSearchIssues (string? state = null, string? labels = null, string? milestones = null, string? q = null, long? priorityRepoId = null, string? type = null, DateTime? since = null, DateTime? before = null, bool? assigned = null, bool? created = null, bool? mentioned = null, bool? reviewRequested = null, bool? reviewed = null, string? owner = null, string? team = null, int? page = null, int? limit = null)

Search for issues across the repositories that the user has access to

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueSearchIssuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var state = "state_example";  // string? | whether issue is open or closed (optional) 
            var labels = "labels_example";  // string? | comma separated list of labels. Fetch only issues that have any of this labels. Non existent labels are discarded (optional) 
            var milestones = "milestones_example";  // string? | comma separated list of milestone names. Fetch only issues that have any of this milestones. Non existent are discarded (optional) 
            var q = "q_example";  // string? | search string (optional) 
            var priorityRepoId = 789L;  // long? | repository to prioritize in the results (optional) 
            var type = "type_example";  // string? | filter by type (issues / pulls) if set (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated after the given time. This is a timestamp in RFC 3339 format (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show notifications updated before the given time. This is a timestamp in RFC 3339 format (optional) 
            var assigned = true;  // bool? | filter (issues / pulls) assigned to you, default is false (optional) 
            var created = true;  // bool? | filter (issues / pulls) created by you, default is false (optional) 
            var mentioned = true;  // bool? | filter (issues / pulls) mentioning you, default is false (optional) 
            var reviewRequested = true;  // bool? | filter pulls requesting your review, default is false (optional) 
            var reviewed = true;  // bool? | filter pulls reviewed by you, default is false (optional) 
            var owner = "owner_example";  // string? | filter by owner (optional) 
            var team = "team_example";  // string? | filter by team (requires organization owner parameter to be provided) (optional) 
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // Search for issues across the repositories that the user has access to
                List<Issue> result = apiInstance.IssueSearchIssues(state, labels, milestones, q, priorityRepoId, type, since, before, assigned, created, mentioned, reviewRequested, reviewed, owner, team, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueSearchIssues: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueSearchIssuesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for issues across the repositories that the user has access to
    ApiResponse<List<Issue>> response = apiInstance.IssueSearchIssuesWithHttpInfo(state, labels, milestones, q, priorityRepoId, type, since, before, assigned, created, mentioned, reviewRequested, reviewed, owner, team, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueSearchIssuesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **state** | **string?** | whether issue is open or closed | [optional]  |
| **labels** | **string?** | comma separated list of labels. Fetch only issues that have any of this labels. Non existent labels are discarded | [optional]  |
| **milestones** | **string?** | comma separated list of milestone names. Fetch only issues that have any of this milestones. Non existent are discarded | [optional]  |
| **q** | **string?** | search string | [optional]  |
| **priorityRepoId** | **long?** | repository to prioritize in the results | [optional]  |
| **type** | **string?** | filter by type (issues / pulls) if set | [optional]  |
| **since** | **DateTime?** | Only show notifications updated after the given time. This is a timestamp in RFC 3339 format | [optional]  |
| **before** | **DateTime?** | Only show notifications updated before the given time. This is a timestamp in RFC 3339 format | [optional]  |
| **assigned** | **bool?** | filter (issues / pulls) assigned to you, default is false | [optional]  |
| **created** | **bool?** | filter (issues / pulls) created by you, default is false | [optional]  |
| **mentioned** | **bool?** | filter (issues / pulls) mentioning you, default is false | [optional]  |
| **reviewRequested** | **bool?** | filter pulls requesting your review, default is false | [optional]  |
| **reviewed** | **bool?** | filter pulls reviewed by you, default is false | [optional]  |
| **owner** | **string?** | filter by owner | [optional]  |
| **team** | **string?** | filter by team (requires organization owner parameter to be provided) | [optional]  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Issue&gt;**](Issue.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | IssueList |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuestartstopwatch"></a>
# **IssueStartStopWatch**
> void IssueStartStopWatch (string owner, string repo, long index)

Start stopwatch on an issue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueStartStopWatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue to create the stopwatch on

            try
            {
                // Start stopwatch on an issue.
                apiInstance.IssueStartStopWatch(owner, repo, index);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueStartStopWatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueStartStopWatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Start stopwatch on an issue.
    apiInstance.IssueStartStopWatchWithHttpInfo(owner, repo, index);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueStartStopWatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue to create the stopwatch on |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | APIEmpty is an empty response |  -  |
| **403** | Not repo writer, user does not have rights to toggle stopwatch |  -  |
| **404** | APINotFound is a not found empty response |  -  |
| **409** | Cannot start a stopwatch again if it already exists |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuestopstopwatch"></a>
# **IssueStopStopWatch**
> void IssueStopStopWatch (string owner, string repo, long index)

Stop an issue's existing stopwatch.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueStopStopWatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue to stop the stopwatch on

            try
            {
                // Stop an issue's existing stopwatch.
                apiInstance.IssueStopStopWatch(owner, repo, index);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueStopStopWatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueStopStopWatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Stop an issue's existing stopwatch.
    apiInstance.IssueStopStopWatchWithHttpInfo(owner, repo, index);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueStopStopWatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue to stop the stopwatch on |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | APIEmpty is an empty response |  -  |
| **403** | Not repo writer, user does not have rights to toggle stopwatch |  -  |
| **404** | APINotFound is a not found empty response |  -  |
| **409** | Cannot stop a non existent stopwatch |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuesubscriptions"></a>
# **IssueSubscriptions**
> List&lt;User&gt; IssueSubscriptions (string owner, string repo, long index, int? page = null, int? limit = null)

Get users who subscribed on an issue.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueSubscriptionsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // Get users who subscribed on an issue.
                List<User> result = apiInstance.IssueSubscriptions(owner, repo, index, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get users who subscribed on an issue.
    ApiResponse<List<User>> response = apiInstance.IssueSubscriptionsWithHttpInfo(owner, repo, index, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;User&gt;**](User.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | UserList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="issuetrackedtimes"></a>
# **IssueTrackedTimes**
> List&lt;TrackedTime&gt; IssueTrackedTimes (string owner, string repo, long index, string? user = null, DateTime? since = null, DateTime? before = null, int? page = null, int? limit = null)

List an issue's tracked times

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class IssueTrackedTimesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of the issue
            var user = "user_example";  // string? | optional filter by user (available for issue managers) (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show times updated after the given time. This is a timestamp in RFC 3339 format (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show times updated before the given time. This is a timestamp in RFC 3339 format (optional) 
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List an issue's tracked times
                List<TrackedTime> result = apiInstance.IssueTrackedTimes(owner, repo, index, user, since, before, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.IssueTrackedTimes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the IssueTrackedTimesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List an issue's tracked times
    ApiResponse<List<TrackedTime>> response = apiInstance.IssueTrackedTimesWithHttpInfo(owner, repo, index, user, since, before, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.IssueTrackedTimesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of the issue |  |
| **user** | **string?** | optional filter by user (available for issue managers) | [optional]  |
| **since** | **DateTime?** | Only show times updated after the given time. This is a timestamp in RFC 3339 format | [optional]  |
| **before** | **DateTime?** | Only show times updated before the given time. This is a timestamp in RFC 3339 format | [optional]  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;TrackedTime&gt;**](TrackedTime.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | TrackedTimeList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="moveissuepin"></a>
# **MoveIssuePin**
> void MoveIssuePin (string owner, string repo, long index, long position)

Moves the Pin to the given Position

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class MoveIssuePinExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of issue
            var position = 789L;  // long | the new position

            try
            {
                // Moves the Pin to the given Position
                apiInstance.MoveIssuePin(owner, repo, index, position);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.MoveIssuePin: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MoveIssuePinWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Moves the Pin to the given Position
    apiInstance.MoveIssuePinWithHttpInfo(owner, repo, index, position);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.MoveIssuePinWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of issue |  |
| **position** | **long** | the new position |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pinissue"></a>
# **PinIssue**
> void PinIssue (string owner, string repo, long index)

Pin an Issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class PinIssueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of issue to pin

            try
            {
                // Pin an Issue
                apiInstance.PinIssue(owner, repo, index);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.PinIssue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PinIssueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Pin an Issue
    apiInstance.PinIssueWithHttpInfo(owner, repo, index);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.PinIssueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of issue to pin |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="unpinissue"></a>
# **UnpinIssue**
> void UnpinIssue (string owner, string repo, long index)

Unpin an Issue

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UnpinIssueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "/api/v1";
            // Configure API key authorization: TOTPHeader
            config.AddApiKey("X-GITEA-OTP", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("X-GITEA-OTP", "Bearer");
            // Configure API key authorization: AuthorizationHeaderToken
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");
            // Configure API key authorization: SudoHeader
            config.AddApiKey("Sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Sudo", "Bearer");
            // Configure HTTP basic authorization: BasicAuth
            config.Username = "YOUR_USERNAME";
            config.Password = "YOUR_PASSWORD";
            // Configure API key authorization: AccessToken
            config.AddApiKey("access_token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("access_token", "Bearer");
            // Configure API key authorization: SudoParam
            config.AddApiKey("sudo", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("sudo", "Bearer");
            // Configure API key authorization: Token
            config.AddApiKey("token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("token", "Bearer");

            var apiInstance = new IssueApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo
            var index = 789L;  // long | index of issue to unpin

            try
            {
                // Unpin an Issue
                apiInstance.UnpinIssue(owner, repo, index);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling IssueApi.UnpinIssue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnpinIssueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unpin an Issue
    apiInstance.UnpinIssueWithHttpInfo(owner, repo, index);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling IssueApi.UnpinIssueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |
| **index** | **long** | index of issue to unpin |  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

