# Org.OpenAPITools.Api.UserApi

All URIs are relative to */api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateCurrentUserRepo**](UserApi.md#createcurrentuserrepo) | **POST** /user/repos | Create a repository |
| [**CreateUserVariable**](UserApi.md#createuservariable) | **POST** /user/actions/variables/{variablename} | Create a user-level variable |
| [**DeleteUserSecret**](UserApi.md#deleteusersecret) | **DELETE** /user/actions/secrets/{secretname} | Delete a secret in a user scope |
| [**DeleteUserVariable**](UserApi.md#deleteuservariable) | **DELETE** /user/actions/variables/{variablename} | Delete a user-level variable which is created by current doer |
| [**GetUserSettings**](UserApi.md#getusersettings) | **GET** /user/settings | Get user settings |
| [**GetUserVariable**](UserApi.md#getuservariable) | **GET** /user/actions/variables/{variablename} | Get a user-level variable which is created by current doer |
| [**GetUserVariablesList**](UserApi.md#getuservariableslist) | **GET** /user/actions/variables | Get the user-level list of variables which is created by current doer |
| [**GetVerificationToken**](UserApi.md#getverificationtoken) | **GET** /user/gpg_key_token | Get a Token to verify |
| [**UpdateUserSecret**](UserApi.md#updateusersecret) | **PUT** /user/actions/secrets/{secretname} | Create or Update a secret value in a user scope |
| [**UpdateUserSettings**](UserApi.md#updateusersettings) | **PATCH** /user/settings | Update user settings |
| [**UpdateUserVariable**](UserApi.md#updateuservariable) | **PUT** /user/actions/variables/{variablename} | Update a user-level variable which is created by current doer |
| [**UserAddEmail**](UserApi.md#useraddemail) | **POST** /user/emails | Add email addresses |
| [**UserBlockUser**](UserApi.md#userblockuser) | **PUT** /user/blocks/{username} | Block a user |
| [**UserCheckFollowing**](UserApi.md#usercheckfollowing) | **GET** /users/{username}/following/{target} | Check if one user is following another user |
| [**UserCheckUserBlock**](UserApi.md#usercheckuserblock) | **GET** /user/blocks/{username} | Check if a user is blocked by the authenticated user |
| [**UserCreateHook**](UserApi.md#usercreatehook) | **POST** /user/hooks | Create a hook |
| [**UserCreateOAuth2Application**](UserApi.md#usercreateoauth2application) | **POST** /user/applications/oauth2 | creates a new OAuth2 application |
| [**UserCreateToken**](UserApi.md#usercreatetoken) | **POST** /users/{username}/tokens | Create an access token |
| [**UserCurrentCheckFollowing**](UserApi.md#usercurrentcheckfollowing) | **GET** /user/following/{username} | Check whether a user is followed by the authenticated user |
| [**UserCurrentCheckStarring**](UserApi.md#usercurrentcheckstarring) | **GET** /user/starred/{owner}/{repo} | Whether the authenticated is starring the repo |
| [**UserCurrentDeleteFollow**](UserApi.md#usercurrentdeletefollow) | **DELETE** /user/following/{username} | Unfollow a user |
| [**UserCurrentDeleteGPGKey**](UserApi.md#usercurrentdeletegpgkey) | **DELETE** /user/gpg_keys/{id} | Remove a GPG key |
| [**UserCurrentDeleteKey**](UserApi.md#usercurrentdeletekey) | **DELETE** /user/keys/{id} | Delete a public key |
| [**UserCurrentDeleteStar**](UserApi.md#usercurrentdeletestar) | **DELETE** /user/starred/{owner}/{repo} | Unstar the given repo |
| [**UserCurrentGetGPGKey**](UserApi.md#usercurrentgetgpgkey) | **GET** /user/gpg_keys/{id} | Get a GPG key |
| [**UserCurrentGetKey**](UserApi.md#usercurrentgetkey) | **GET** /user/keys/{id} | Get a public key |
| [**UserCurrentListFollowers**](UserApi.md#usercurrentlistfollowers) | **GET** /user/followers | List the authenticated user&#39;s followers |
| [**UserCurrentListFollowing**](UserApi.md#usercurrentlistfollowing) | **GET** /user/following | List the users that the authenticated user is following |
| [**UserCurrentListGPGKeys**](UserApi.md#usercurrentlistgpgkeys) | **GET** /user/gpg_keys | List the authenticated user&#39;s GPG keys |
| [**UserCurrentListKeys**](UserApi.md#usercurrentlistkeys) | **GET** /user/keys | List the authenticated user&#39;s public keys |
| [**UserCurrentListRepos**](UserApi.md#usercurrentlistrepos) | **GET** /user/repos | List the repos that the authenticated user owns |
| [**UserCurrentListStarred**](UserApi.md#usercurrentliststarred) | **GET** /user/starred | The repos that the authenticated user has starred |
| [**UserCurrentListSubscriptions**](UserApi.md#usercurrentlistsubscriptions) | **GET** /user/subscriptions | List repositories watched by the authenticated user |
| [**UserCurrentPostGPGKey**](UserApi.md#usercurrentpostgpgkey) | **POST** /user/gpg_keys | Create a GPG key |
| [**UserCurrentPostKey**](UserApi.md#usercurrentpostkey) | **POST** /user/keys | Create a public key |
| [**UserCurrentPutFollow**](UserApi.md#usercurrentputfollow) | **PUT** /user/following/{username} | Follow a user |
| [**UserCurrentPutStar**](UserApi.md#usercurrentputstar) | **PUT** /user/starred/{owner}/{repo} | Star the given repo |
| [**UserCurrentTrackedTimes**](UserApi.md#usercurrenttrackedtimes) | **GET** /user/times | List the current user&#39;s tracked times |
| [**UserDeleteAccessToken**](UserApi.md#userdeleteaccesstoken) | **DELETE** /users/{username}/tokens/{token} | delete an access token |
| [**UserDeleteAvatar**](UserApi.md#userdeleteavatar) | **DELETE** /user/avatar | Delete Avatar |
| [**UserDeleteEmail**](UserApi.md#userdeleteemail) | **DELETE** /user/emails | Delete email addresses |
| [**UserDeleteHook**](UserApi.md#userdeletehook) | **DELETE** /user/hooks/{id} | Delete a hook |
| [**UserDeleteOAuth2Application**](UserApi.md#userdeleteoauth2application) | **DELETE** /user/applications/oauth2/{id} | delete an OAuth2 Application |
| [**UserEditHook**](UserApi.md#useredithook) | **PATCH** /user/hooks/{id} | Update a hook |
| [**UserGet**](UserApi.md#userget) | **GET** /users/{username} | Get a user |
| [**UserGetCurrent**](UserApi.md#usergetcurrent) | **GET** /user | Get the authenticated user |
| [**UserGetHeatmapData**](UserApi.md#usergetheatmapdata) | **GET** /users/{username}/heatmap | Get a user&#39;s heatmap |
| [**UserGetHook**](UserApi.md#usergethook) | **GET** /user/hooks/{id} | Get a hook |
| [**UserGetOAuth2Application**](UserApi.md#usergetoauth2application) | **GET** /user/applications/oauth2/{id} | get an OAuth2 Application |
| [**UserGetOauth2Application**](UserApi.md#usergetoauth2application) | **GET** /user/applications/oauth2 | List the authenticated user&#39;s oauth2 applications |
| [**UserGetRunnerRegistrationToken**](UserApi.md#usergetrunnerregistrationtoken) | **GET** /user/actions/runners/registration-token | Get an user&#39;s actions runner registration token |
| [**UserGetStopWatches**](UserApi.md#usergetstopwatches) | **GET** /user/stopwatches | Get list of all existing stopwatches |
| [**UserGetTokens**](UserApi.md#usergettokens) | **GET** /users/{username}/tokens | List the authenticated user&#39;s access tokens |
| [**UserListActivityFeeds**](UserApi.md#userlistactivityfeeds) | **GET** /users/{username}/activities/feeds | List a user&#39;s activity feeds |
| [**UserListBlocks**](UserApi.md#userlistblocks) | **GET** /user/blocks | List users blocked by the authenticated user |
| [**UserListEmails**](UserApi.md#userlistemails) | **GET** /user/emails | List the authenticated user&#39;s email addresses |
| [**UserListFollowers**](UserApi.md#userlistfollowers) | **GET** /users/{username}/followers | List the given user&#39;s followers |
| [**UserListFollowing**](UserApi.md#userlistfollowing) | **GET** /users/{username}/following | List the users that the given user is following |
| [**UserListGPGKeys**](UserApi.md#userlistgpgkeys) | **GET** /users/{username}/gpg_keys | List the given user&#39;s GPG keys |
| [**UserListHooks**](UserApi.md#userlisthooks) | **GET** /user/hooks | List the authenticated user&#39;s webhooks |
| [**UserListKeys**](UserApi.md#userlistkeys) | **GET** /users/{username}/keys | List the given user&#39;s public keys |
| [**UserListRepos**](UserApi.md#userlistrepos) | **GET** /users/{username}/repos | List the repos owned by the given user |
| [**UserListStarred**](UserApi.md#userliststarred) | **GET** /users/{username}/starred | The repos that the given user has starred |
| [**UserListSubscriptions**](UserApi.md#userlistsubscriptions) | **GET** /users/{username}/subscriptions | List the repositories watched by a user |
| [**UserListTeams**](UserApi.md#userlistteams) | **GET** /user/teams | List all the teams a user belongs to |
| [**UserSearch**](UserApi.md#usersearch) | **GET** /users/search | Search for users |
| [**UserUnblockUser**](UserApi.md#userunblockuser) | **DELETE** /user/blocks/{username} | Unblock a user |
| [**UserUpdateAvatar**](UserApi.md#userupdateavatar) | **POST** /user/avatar | Update Avatar |
| [**UserUpdateOAuth2Application**](UserApi.md#userupdateoauth2application) | **PATCH** /user/applications/oauth2/{id} | update an OAuth2 Application, this includes regenerating the client secret |
| [**UserVerifyGPGKey**](UserApi.md#userverifygpgkey) | **POST** /user/gpg_key_verify | Verify a GPG key |

<a id="createcurrentuserrepo"></a>
# **CreateCurrentUserRepo**
> Repository CreateCurrentUserRepo (CreateRepoOption? body = null)

Create a repository

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateCurrentUserRepoExample
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

            var apiInstance = new UserApi(config);
            var body = new CreateRepoOption?(); // CreateRepoOption? |  (optional) 

            try
            {
                // Create a repository
                Repository result = apiInstance.CreateCurrentUserRepo(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.CreateCurrentUserRepo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateCurrentUserRepoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a repository
    ApiResponse<Repository> response = apiInstance.CreateCurrentUserRepoWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.CreateCurrentUserRepoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateRepoOption?**](CreateRepoOption?.md) |  | [optional]  |

### Return type

[**Repository**](Repository.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Repository |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **409** | The repository with the same name already exists. |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createuservariable"></a>
# **CreateUserVariable**
> void CreateUserVariable (string variablename, CreateVariableOption? body = null)

Create a user-level variable

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CreateUserVariableExample
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

            var apiInstance = new UserApi(config);
            var variablename = "variablename_example";  // string | name of the variable
            var body = new CreateVariableOption?(); // CreateVariableOption? |  (optional) 

            try
            {
                // Create a user-level variable
                apiInstance.CreateUserVariable(variablename, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.CreateUserVariable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateUserVariableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a user-level variable
    apiInstance.CreateUserVariableWithHttpInfo(variablename, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.CreateUserVariableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **variablename** | **string** | name of the variable |  |
| **body** | [**CreateVariableOption?**](CreateVariableOption?.md) |  | [optional]  |

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
| **201** | response when creating a variable |  -  |
| **204** | response when creating a variable |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteusersecret"></a>
# **DeleteUserSecret**
> void DeleteUserSecret (string secretname)

Delete a secret in a user scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteUserSecretExample
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

            var apiInstance = new UserApi(config);
            var secretname = "secretname_example";  // string | name of the secret

            try
            {
                // Delete a secret in a user scope
                apiInstance.DeleteUserSecret(secretname);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.DeleteUserSecret: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserSecretWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a secret in a user scope
    apiInstance.DeleteUserSecretWithHttpInfo(secretname);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.DeleteUserSecretWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **secretname** | **string** | name of the secret |  |

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
| **204** | delete one secret of the user |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteuservariable"></a>
# **DeleteUserVariable**
> void DeleteUserVariable (string variablename)

Delete a user-level variable which is created by current doer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class DeleteUserVariableExample
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

            var apiInstance = new UserApi(config);
            var variablename = "variablename_example";  // string | name of the variable

            try
            {
                // Delete a user-level variable which is created by current doer
                apiInstance.DeleteUserVariable(variablename);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.DeleteUserVariable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteUserVariableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a user-level variable which is created by current doer
    apiInstance.DeleteUserVariableWithHttpInfo(variablename);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.DeleteUserVariableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **variablename** | **string** | name of the variable |  |

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
| **201** | response when deleting a variable |  -  |
| **204** | response when deleting a variable |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getusersettings"></a>
# **GetUserSettings**
> List&lt;UserSettings&gt; GetUserSettings ()

Get user settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserSettingsExample
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

            var apiInstance = new UserApi(config);

            try
            {
                // Get user settings
                List<UserSettings> result = apiInstance.GetUserSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.GetUserSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get user settings
    ApiResponse<List<UserSettings>> response = apiInstance.GetUserSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.GetUserSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;UserSettings&gt;**](UserSettings.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | UserSettings |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuservariable"></a>
# **GetUserVariable**
> ActionVariable GetUserVariable (string variablename)

Get a user-level variable which is created by current doer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserVariableExample
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

            var apiInstance = new UserApi(config);
            var variablename = "variablename_example";  // string | name of the variable

            try
            {
                // Get a user-level variable which is created by current doer
                ActionVariable result = apiInstance.GetUserVariable(variablename);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.GetUserVariable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserVariableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a user-level variable which is created by current doer
    ApiResponse<ActionVariable> response = apiInstance.GetUserVariableWithHttpInfo(variablename);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.GetUserVariableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **variablename** | **string** | name of the variable |  |

### Return type

[**ActionVariable**](ActionVariable.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ActionVariable |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getuservariableslist"></a>
# **GetUserVariablesList**
> List&lt;ActionVariable&gt; GetUserVariablesList (int? page = null, int? limit = null)

Get the user-level list of variables which is created by current doer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetUserVariablesListExample
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

            var apiInstance = new UserApi(config);
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // Get the user-level list of variables which is created by current doer
                List<ActionVariable> result = apiInstance.GetUserVariablesList(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.GetUserVariablesList: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetUserVariablesListWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the user-level list of variables which is created by current doer
    ApiResponse<List<ActionVariable>> response = apiInstance.GetUserVariablesListWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.GetUserVariablesListWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;ActionVariable&gt;**](ActionVariable.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | VariableList |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getverificationtoken"></a>
# **GetVerificationToken**
> string GetVerificationToken ()

Get a Token to verify

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetVerificationTokenExample
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

            var apiInstance = new UserApi(config);

            try
            {
                // Get a Token to verify
                string result = apiInstance.GetVerificationToken();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.GetVerificationToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVerificationTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a Token to verify
    ApiResponse<string> response = apiInstance.GetVerificationTokenWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.GetVerificationTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**string**

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | APIString is a string response |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateusersecret"></a>
# **UpdateUserSecret**
> void UpdateUserSecret (string secretname, CreateOrUpdateSecretOption? body = null)

Create or Update a secret value in a user scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateUserSecretExample
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

            var apiInstance = new UserApi(config);
            var secretname = "secretname_example";  // string | name of the secret
            var body = new CreateOrUpdateSecretOption?(); // CreateOrUpdateSecretOption? |  (optional) 

            try
            {
                // Create or Update a secret value in a user scope
                apiInstance.UpdateUserSecret(secretname, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UpdateUserSecret: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserSecretWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create or Update a secret value in a user scope
    apiInstance.UpdateUserSecretWithHttpInfo(secretname, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UpdateUserSecretWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **secretname** | **string** | name of the secret |  |
| **body** | [**CreateOrUpdateSecretOption?**](CreateOrUpdateSecretOption?.md) |  | [optional]  |

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
| **201** | response when creating a secret |  -  |
| **204** | response when updating a secret |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateusersettings"></a>
# **UpdateUserSettings**
> List&lt;UserSettings&gt; UpdateUserSettings (UserSettingsOptions? body = null)

Update user settings

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateUserSettingsExample
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

            var apiInstance = new UserApi(config);
            var body = new UserSettingsOptions?(); // UserSettingsOptions? |  (optional) 

            try
            {
                // Update user settings
                List<UserSettings> result = apiInstance.UpdateUserSettings(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UpdateUserSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update user settings
    ApiResponse<List<UserSettings>> response = apiInstance.UpdateUserSettingsWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UpdateUserSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UserSettingsOptions?**](UserSettingsOptions?.md) |  | [optional]  |

### Return type

[**List&lt;UserSettings&gt;**](UserSettings.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | UserSettings |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateuservariable"></a>
# **UpdateUserVariable**
> void UpdateUserVariable (string variablename, UpdateVariableOption? body = null)

Update a user-level variable which is created by current doer

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UpdateUserVariableExample
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

            var apiInstance = new UserApi(config);
            var variablename = "variablename_example";  // string | name of the variable
            var body = new UpdateVariableOption?(); // UpdateVariableOption? |  (optional) 

            try
            {
                // Update a user-level variable which is created by current doer
                apiInstance.UpdateUserVariable(variablename, body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UpdateUserVariable: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateUserVariableWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a user-level variable which is created by current doer
    apiInstance.UpdateUserVariableWithHttpInfo(variablename, body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UpdateUserVariableWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **variablename** | **string** | name of the variable |  |
| **body** | [**UpdateVariableOption?**](UpdateVariableOption?.md) |  | [optional]  |

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
| **201** | response when updating a variable |  -  |
| **204** | response when updating a variable |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="useraddemail"></a>
# **UserAddEmail**
> List&lt;Email&gt; UserAddEmail (CreateEmailOption? body = null)

Add email addresses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserAddEmailExample
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

            var apiInstance = new UserApi(config);
            var body = new CreateEmailOption?(); // CreateEmailOption? |  (optional) 

            try
            {
                // Add email addresses
                List<Email> result = apiInstance.UserAddEmail(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserAddEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserAddEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Add email addresses
    ApiResponse<List<Email>> response = apiInstance.UserAddEmailWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserAddEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateEmailOption?**](CreateEmailOption?.md) |  | [optional]  |

### Return type

[**List&lt;Email&gt;**](Email.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | EmailList |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userblockuser"></a>
# **UserBlockUser**
> void UserBlockUser (string username, string? note = null)

Block a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserBlockUserExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | user to block
            var note = "note_example";  // string? | optional note for the block (optional) 

            try
            {
                // Block a user
                apiInstance.UserBlockUser(username, note);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserBlockUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserBlockUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Block a user
    apiInstance.UserBlockUserWithHttpInfo(username, note);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserBlockUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | user to block |  |
| **note** | **string?** | optional note for the block | [optional]  |

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
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercheckfollowing"></a>
# **UserCheckFollowing**
> void UserCheckFollowing (string username, string target)

Check if one user is following another user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCheckFollowingExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of following user
            var target = "target_example";  // string | username of followed user

            try
            {
                // Check if one user is following another user
                apiInstance.UserCheckFollowing(username, target);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCheckFollowing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCheckFollowingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check if one user is following another user
    apiInstance.UserCheckFollowingWithHttpInfo(username, target);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCheckFollowingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of following user |  |
| **target** | **string** | username of followed user |  |

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

<a id="usercheckuserblock"></a>
# **UserCheckUserBlock**
> void UserCheckUserBlock (string username)

Check if a user is blocked by the authenticated user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCheckUserBlockExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | user to check

            try
            {
                // Check if a user is blocked by the authenticated user
                apiInstance.UserCheckUserBlock(username);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCheckUserBlock: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCheckUserBlockWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check if a user is blocked by the authenticated user
    apiInstance.UserCheckUserBlockWithHttpInfo(username);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCheckUserBlockWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | user to check |  |

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

<a id="usercreatehook"></a>
# **UserCreateHook**
> Hook UserCreateHook (CreateHookOption body)

Create a hook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCreateHookExample
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

            var apiInstance = new UserApi(config);
            var body = new CreateHookOption(); // CreateHookOption | 

            try
            {
                // Create a hook
                Hook result = apiInstance.UserCreateHook(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCreateHook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCreateHookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a hook
    ApiResponse<Hook> response = apiInstance.UserCreateHookWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCreateHookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateHookOption**](CreateHookOption.md) |  |  |

### Return type

[**Hook**](Hook.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Hook |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercreateoauth2application"></a>
# **UserCreateOAuth2Application**
> OAuth2Application UserCreateOAuth2Application (CreateOAuth2ApplicationOptions body)

creates a new OAuth2 application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCreateOAuth2ApplicationExample
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

            var apiInstance = new UserApi(config);
            var body = new CreateOAuth2ApplicationOptions(); // CreateOAuth2ApplicationOptions | 

            try
            {
                // creates a new OAuth2 application
                OAuth2Application result = apiInstance.UserCreateOAuth2Application(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCreateOAuth2Application: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCreateOAuth2ApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // creates a new OAuth2 application
    ApiResponse<OAuth2Application> response = apiInstance.UserCreateOAuth2ApplicationWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCreateOAuth2ApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateOAuth2ApplicationOptions**](CreateOAuth2ApplicationOptions.md) |  |  |

### Return type

[**OAuth2Application**](OAuth2Application.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | OAuth2Application |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercreatetoken"></a>
# **UserCreateToken**
> AccessToken UserCreateToken (string username, CreateAccessTokenOption? body = null)

Create an access token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCreateTokenExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user
            var body = new CreateAccessTokenOption?(); // CreateAccessTokenOption? |  (optional) 

            try
            {
                // Create an access token
                AccessToken result = apiInstance.UserCreateToken(username, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCreateToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCreateTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create an access token
    ApiResponse<AccessToken> response = apiInstance.UserCreateTokenWithHttpInfo(username, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCreateTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user |  |
| **body** | [**CreateAccessTokenOption?**](CreateAccessTokenOption?.md) |  | [optional]  |

### Return type

[**AccessToken**](AccessToken.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | AccessToken represents an API access token. |  -  |
| **400** | APIError is error format response |  * message -  <br>  * url -  <br>  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercurrentcheckfollowing"></a>
# **UserCurrentCheckFollowing**
> void UserCurrentCheckFollowing (string username)

Check whether a user is followed by the authenticated user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentCheckFollowingExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of followed user

            try
            {
                // Check whether a user is followed by the authenticated user
                apiInstance.UserCurrentCheckFollowing(username);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentCheckFollowing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentCheckFollowingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Check whether a user is followed by the authenticated user
    apiInstance.UserCurrentCheckFollowingWithHttpInfo(username);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentCheckFollowingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of followed user |  |

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

<a id="usercurrentcheckstarring"></a>
# **UserCurrentCheckStarring**
> void UserCurrentCheckStarring (string owner, string repo)

Whether the authenticated is starring the repo

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentCheckStarringExample
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

            var apiInstance = new UserApi(config);
            var owner = "owner_example";  // string | owner of the repo
            var repo = "repo_example";  // string | name of the repo

            try
            {
                // Whether the authenticated is starring the repo
                apiInstance.UserCurrentCheckStarring(owner, repo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentCheckStarring: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentCheckStarringWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Whether the authenticated is starring the repo
    apiInstance.UserCurrentCheckStarringWithHttpInfo(owner, repo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentCheckStarringWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo |  |
| **repo** | **string** | name of the repo |  |

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

<a id="usercurrentdeletefollow"></a>
# **UserCurrentDeleteFollow**
> void UserCurrentDeleteFollow (string username)

Unfollow a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentDeleteFollowExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user to unfollow

            try
            {
                // Unfollow a user
                apiInstance.UserCurrentDeleteFollow(username);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentDeleteFollow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentDeleteFollowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unfollow a user
    apiInstance.UserCurrentDeleteFollowWithHttpInfo(username);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentDeleteFollowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user to unfollow |  |

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

<a id="usercurrentdeletegpgkey"></a>
# **UserCurrentDeleteGPGKey**
> void UserCurrentDeleteGPGKey (long id)

Remove a GPG key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentDeleteGPGKeyExample
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

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | id of key to delete

            try
            {
                // Remove a GPG key
                apiInstance.UserCurrentDeleteGPGKey(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentDeleteGPGKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentDeleteGPGKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Remove a GPG key
    apiInstance.UserCurrentDeleteGPGKeyWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentDeleteGPGKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of key to delete |  |

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

<a id="usercurrentdeletekey"></a>
# **UserCurrentDeleteKey**
> void UserCurrentDeleteKey (long id)

Delete a public key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentDeleteKeyExample
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

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | id of key to delete

            try
            {
                // Delete a public key
                apiInstance.UserCurrentDeleteKey(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentDeleteKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentDeleteKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a public key
    apiInstance.UserCurrentDeleteKeyWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentDeleteKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of key to delete |  |

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

<a id="usercurrentdeletestar"></a>
# **UserCurrentDeleteStar**
> void UserCurrentDeleteStar (string owner, string repo)

Unstar the given repo

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentDeleteStarExample
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

            var apiInstance = new UserApi(config);
            var owner = "owner_example";  // string | owner of the repo to unstar
            var repo = "repo_example";  // string | name of the repo to unstar

            try
            {
                // Unstar the given repo
                apiInstance.UserCurrentDeleteStar(owner, repo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentDeleteStar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentDeleteStarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unstar the given repo
    apiInstance.UserCurrentDeleteStarWithHttpInfo(owner, repo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentDeleteStarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo to unstar |  |
| **repo** | **string** | name of the repo to unstar |  |

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

<a id="usercurrentgetgpgkey"></a>
# **UserCurrentGetGPGKey**
> GPGKey UserCurrentGetGPGKey (long id)

Get a GPG key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentGetGPGKeyExample
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

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | id of key to get

            try
            {
                // Get a GPG key
                GPGKey result = apiInstance.UserCurrentGetGPGKey(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentGetGPGKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentGetGPGKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a GPG key
    ApiResponse<GPGKey> response = apiInstance.UserCurrentGetGPGKeyWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentGetGPGKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of key to get |  |

### Return type

[**GPGKey**](GPGKey.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | GPGKey |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercurrentgetkey"></a>
# **UserCurrentGetKey**
> PublicKey UserCurrentGetKey (long id)

Get a public key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentGetKeyExample
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

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | id of key to get

            try
            {
                // Get a public key
                PublicKey result = apiInstance.UserCurrentGetKey(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentGetKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentGetKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a public key
    ApiResponse<PublicKey> response = apiInstance.UserCurrentGetKeyWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentGetKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of key to get |  |

### Return type

[**PublicKey**](PublicKey.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | PublicKey |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercurrentlistfollowers"></a>
# **UserCurrentListFollowers**
> List&lt;User&gt; UserCurrentListFollowers (int? page = null, int? limit = null)

List the authenticated user's followers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentListFollowersExample
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

            var apiInstance = new UserApi(config);
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the authenticated user's followers
                List<User> result = apiInstance.UserCurrentListFollowers(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentListFollowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentListFollowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the authenticated user's followers
    ApiResponse<List<User>> response = apiInstance.UserCurrentListFollowersWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentListFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercurrentlistfollowing"></a>
# **UserCurrentListFollowing**
> List&lt;User&gt; UserCurrentListFollowing (int? page = null, int? limit = null)

List the users that the authenticated user is following

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentListFollowingExample
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

            var apiInstance = new UserApi(config);
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the users that the authenticated user is following
                List<User> result = apiInstance.UserCurrentListFollowing(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentListFollowing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentListFollowingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the users that the authenticated user is following
    ApiResponse<List<User>> response = apiInstance.UserCurrentListFollowingWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentListFollowingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercurrentlistgpgkeys"></a>
# **UserCurrentListGPGKeys**
> List&lt;GPGKey&gt; UserCurrentListGPGKeys (int? page = null, int? limit = null)

List the authenticated user's GPG keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentListGPGKeysExample
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

            var apiInstance = new UserApi(config);
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the authenticated user's GPG keys
                List<GPGKey> result = apiInstance.UserCurrentListGPGKeys(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentListGPGKeys: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentListGPGKeysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the authenticated user's GPG keys
    ApiResponse<List<GPGKey>> response = apiInstance.UserCurrentListGPGKeysWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentListGPGKeysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;GPGKey&gt;**](GPGKey.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | GPGKeyList |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercurrentlistkeys"></a>
# **UserCurrentListKeys**
> List&lt;PublicKey&gt; UserCurrentListKeys (string? fingerprint = null, int? page = null, int? limit = null)

List the authenticated user's public keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentListKeysExample
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

            var apiInstance = new UserApi(config);
            var fingerprint = "fingerprint_example";  // string? | fingerprint of the key (optional) 
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the authenticated user's public keys
                List<PublicKey> result = apiInstance.UserCurrentListKeys(fingerprint, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentListKeys: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentListKeysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the authenticated user's public keys
    ApiResponse<List<PublicKey>> response = apiInstance.UserCurrentListKeysWithHttpInfo(fingerprint, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentListKeysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **fingerprint** | **string?** | fingerprint of the key | [optional]  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;PublicKey&gt;**](PublicKey.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | PublicKeyList |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercurrentlistrepos"></a>
# **UserCurrentListRepos**
> List&lt;Repository&gt; UserCurrentListRepos (int? page = null, int? limit = null)

List the repos that the authenticated user owns

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentListReposExample
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

            var apiInstance = new UserApi(config);
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the repos that the authenticated user owns
                List<Repository> result = apiInstance.UserCurrentListRepos(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentListRepos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentListReposWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the repos that the authenticated user owns
    ApiResponse<List<Repository>> response = apiInstance.UserCurrentListReposWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentListReposWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Repository&gt;**](Repository.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | RepositoryList |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercurrentliststarred"></a>
# **UserCurrentListStarred**
> List&lt;Repository&gt; UserCurrentListStarred (int? page = null, int? limit = null)

The repos that the authenticated user has starred

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentListStarredExample
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

            var apiInstance = new UserApi(config);
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // The repos that the authenticated user has starred
                List<Repository> result = apiInstance.UserCurrentListStarred(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentListStarred: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentListStarredWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The repos that the authenticated user has starred
    ApiResponse<List<Repository>> response = apiInstance.UserCurrentListStarredWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentListStarredWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Repository&gt;**](Repository.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | RepositoryList |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercurrentlistsubscriptions"></a>
# **UserCurrentListSubscriptions**
> List&lt;Repository&gt; UserCurrentListSubscriptions (int? page = null, int? limit = null)

List repositories watched by the authenticated user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentListSubscriptionsExample
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

            var apiInstance = new UserApi(config);
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List repositories watched by the authenticated user
                List<Repository> result = apiInstance.UserCurrentListSubscriptions(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentListSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentListSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List repositories watched by the authenticated user
    ApiResponse<List<Repository>> response = apiInstance.UserCurrentListSubscriptionsWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentListSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Repository&gt;**](Repository.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | RepositoryList |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercurrentpostgpgkey"></a>
# **UserCurrentPostGPGKey**
> GPGKey UserCurrentPostGPGKey (CreateGPGKeyOption? form = null)

Create a GPG key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentPostGPGKeyExample
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

            var apiInstance = new UserApi(config);
            var form = new CreateGPGKeyOption?(); // CreateGPGKeyOption? |  (optional) 

            try
            {
                // Create a GPG key
                GPGKey result = apiInstance.UserCurrentPostGPGKey(form);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentPostGPGKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentPostGPGKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a GPG key
    ApiResponse<GPGKey> response = apiInstance.UserCurrentPostGPGKeyWithHttpInfo(form);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentPostGPGKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **form** | [**CreateGPGKeyOption?**](CreateGPGKeyOption?.md) |  | [optional]  |

### Return type

[**GPGKey**](GPGKey.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | GPGKey |  -  |
| **404** | APINotFound is a not found empty response |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercurrentpostkey"></a>
# **UserCurrentPostKey**
> PublicKey UserCurrentPostKey (CreateKeyOption? body = null)

Create a public key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentPostKeyExample
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

            var apiInstance = new UserApi(config);
            var body = new CreateKeyOption?(); // CreateKeyOption? |  (optional) 

            try
            {
                // Create a public key
                PublicKey result = apiInstance.UserCurrentPostKey(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentPostKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentPostKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create a public key
    ApiResponse<PublicKey> response = apiInstance.UserCurrentPostKeyWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentPostKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateKeyOption?**](CreateKeyOption?.md) |  | [optional]  |

### Return type

[**PublicKey**](PublicKey.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | PublicKey |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usercurrentputfollow"></a>
# **UserCurrentPutFollow**
> void UserCurrentPutFollow (string username)

Follow a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentPutFollowExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user to follow

            try
            {
                // Follow a user
                apiInstance.UserCurrentPutFollow(username);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentPutFollow: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentPutFollowWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Follow a user
    apiInstance.UserCurrentPutFollowWithHttpInfo(username);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentPutFollowWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user to follow |  |

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

<a id="usercurrentputstar"></a>
# **UserCurrentPutStar**
> void UserCurrentPutStar (string owner, string repo)

Star the given repo

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentPutStarExample
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

            var apiInstance = new UserApi(config);
            var owner = "owner_example";  // string | owner of the repo to star
            var repo = "repo_example";  // string | name of the repo to star

            try
            {
                // Star the given repo
                apiInstance.UserCurrentPutStar(owner, repo);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentPutStar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentPutStarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Star the given repo
    apiInstance.UserCurrentPutStarWithHttpInfo(owner, repo);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentPutStarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **owner** | **string** | owner of the repo to star |  |
| **repo** | **string** | name of the repo to star |  |

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

<a id="usercurrenttrackedtimes"></a>
# **UserCurrentTrackedTimes**
> List&lt;TrackedTime&gt; UserCurrentTrackedTimes (int? page = null, int? limit = null, DateTime? since = null, DateTime? before = null)

List the current user's tracked times

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserCurrentTrackedTimesExample
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

            var apiInstance = new UserApi(config);
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 
            var since = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show times updated after the given time. This is a timestamp in RFC 3339 format (optional) 
            var before = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTime? | Only show times updated before the given time. This is a timestamp in RFC 3339 format (optional) 

            try
            {
                // List the current user's tracked times
                List<TrackedTime> result = apiInstance.UserCurrentTrackedTimes(page, limit, since, before);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserCurrentTrackedTimes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserCurrentTrackedTimesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the current user's tracked times
    ApiResponse<List<TrackedTime>> response = apiInstance.UserCurrentTrackedTimesWithHttpInfo(page, limit, since, before);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserCurrentTrackedTimesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |
| **since** | **DateTime?** | Only show times updated after the given time. This is a timestamp in RFC 3339 format | [optional]  |
| **before** | **DateTime?** | Only show times updated before the given time. This is a timestamp in RFC 3339 format | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userdeleteaccesstoken"></a>
# **UserDeleteAccessToken**
> void UserDeleteAccessToken (string username, string token)

delete an access token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserDeleteAccessTokenExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user
            var token = "token_example";  // string | token to be deleted, identified by ID and if not available by name

            try
            {
                // delete an access token
                apiInstance.UserDeleteAccessToken(username, token);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserDeleteAccessToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserDeleteAccessTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete an access token
    apiInstance.UserDeleteAccessTokenWithHttpInfo(username, token);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserDeleteAccessTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user |  |
| **token** | **string** | token to be deleted, identified by ID and if not available by name |  |

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
| **422** | APIError is error format response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userdeleteavatar"></a>
# **UserDeleteAvatar**
> void UserDeleteAvatar ()

Delete Avatar

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserDeleteAvatarExample
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

            var apiInstance = new UserApi(config);

            try
            {
                // Delete Avatar
                apiInstance.UserDeleteAvatar();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserDeleteAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserDeleteAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Avatar
    apiInstance.UserDeleteAvatarWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserDeleteAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userdeleteemail"></a>
# **UserDeleteEmail**
> void UserDeleteEmail (DeleteEmailOption? body = null)

Delete email addresses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserDeleteEmailExample
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

            var apiInstance = new UserApi(config);
            var body = new DeleteEmailOption?(); // DeleteEmailOption? |  (optional) 

            try
            {
                // Delete email addresses
                apiInstance.UserDeleteEmail(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserDeleteEmail: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserDeleteEmailWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete email addresses
    apiInstance.UserDeleteEmailWithHttpInfo(body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserDeleteEmailWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**DeleteEmailOption?**](DeleteEmailOption?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userdeletehook"></a>
# **UserDeleteHook**
> void UserDeleteHook (long id)

Delete a hook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserDeleteHookExample
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

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | id of the hook to delete

            try
            {
                // Delete a hook
                apiInstance.UserDeleteHook(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserDeleteHook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserDeleteHookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete a hook
    apiInstance.UserDeleteHookWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserDeleteHookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of the hook to delete |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userdeleteoauth2application"></a>
# **UserDeleteOAuth2Application**
> void UserDeleteOAuth2Application (long id)

delete an OAuth2 Application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserDeleteOAuth2ApplicationExample
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

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | token to be deleted

            try
            {
                // delete an OAuth2 Application
                apiInstance.UserDeleteOAuth2Application(id);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserDeleteOAuth2Application: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserDeleteOAuth2ApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // delete an OAuth2 Application
    apiInstance.UserDeleteOAuth2ApplicationWithHttpInfo(id);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserDeleteOAuth2ApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | token to be deleted |  |

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

<a id="useredithook"></a>
# **UserEditHook**
> Hook UserEditHook (long id, EditHookOption? body = null)

Update a hook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserEditHookExample
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

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | id of the hook to update
            var body = new EditHookOption?(); // EditHookOption? |  (optional) 

            try
            {
                // Update a hook
                Hook result = apiInstance.UserEditHook(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserEditHook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserEditHookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update a hook
    ApiResponse<Hook> response = apiInstance.UserEditHookWithHttpInfo(id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserEditHookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of the hook to update |  |
| **body** | [**EditHookOption?**](EditHookOption?.md) |  | [optional]  |

### Return type

[**Hook**](Hook.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Hook |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userget"></a>
# **UserGet**
> User UserGet (string username)

Get a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserGetExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user to get

            try
            {
                // Get a user
                User result = apiInstance.UserGet(username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a user
    ApiResponse<User> response = apiInstance.UserGetWithHttpInfo(username);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user to get |  |

### Return type

[**User**](User.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usergetcurrent"></a>
# **UserGetCurrent**
> User UserGetCurrent ()

Get the authenticated user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserGetCurrentExample
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

            var apiInstance = new UserApi(config);

            try
            {
                // Get the authenticated user
                User result = apiInstance.UserGetCurrent();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetCurrent: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetCurrentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get the authenticated user
    ApiResponse<User> response = apiInstance.UserGetCurrentWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetCurrentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**User**](User.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | User |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usergetheatmapdata"></a>
# **UserGetHeatmapData**
> List&lt;UserHeatmapData&gt; UserGetHeatmapData (string username)

Get a user's heatmap

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserGetHeatmapDataExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user to get

            try
            {
                // Get a user's heatmap
                List<UserHeatmapData> result = apiInstance.UserGetHeatmapData(username);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetHeatmapData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetHeatmapDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a user's heatmap
    ApiResponse<List<UserHeatmapData>> response = apiInstance.UserGetHeatmapDataWithHttpInfo(username);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetHeatmapDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user to get |  |

### Return type

[**List&lt;UserHeatmapData&gt;**](UserHeatmapData.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | UserHeatmapData |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usergethook"></a>
# **UserGetHook**
> Hook UserGetHook (long id)

Get a hook

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserGetHookExample
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

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | id of the hook to get

            try
            {
                // Get a hook
                Hook result = apiInstance.UserGetHook(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetHook: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetHookWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get a hook
    ApiResponse<Hook> response = apiInstance.UserGetHookWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetHookWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | id of the hook to get |  |

### Return type

[**Hook**](Hook.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Hook |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usergetoauth2application"></a>
# **UserGetOAuth2Application**
> OAuth2Application UserGetOAuth2Application (long id)

get an OAuth2 Application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserGetOAuth2ApplicationExample
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

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | Application ID to be found

            try
            {
                // get an OAuth2 Application
                OAuth2Application result = apiInstance.UserGetOAuth2Application(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetOAuth2Application: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetOAuth2ApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // get an OAuth2 Application
    ApiResponse<OAuth2Application> response = apiInstance.UserGetOAuth2ApplicationWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetOAuth2ApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | Application ID to be found |  |

### Return type

[**OAuth2Application**](OAuth2Application.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OAuth2Application |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usergetoauth2application"></a>
# **UserGetOauth2Application**
> List&lt;OAuth2Application&gt; UserGetOauth2Application (int? page = null, int? limit = null)

List the authenticated user's oauth2 applications

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserGetOauth2ApplicationExample
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

            var apiInstance = new UserApi(config);
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the authenticated user's oauth2 applications
                List<OAuth2Application> result = apiInstance.UserGetOauth2Application(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetOauth2Application: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetOauth2ApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the authenticated user's oauth2 applications
    ApiResponse<List<OAuth2Application>> response = apiInstance.UserGetOauth2ApplicationWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetOauth2ApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;OAuth2Application&gt;**](OAuth2Application.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OAuth2ApplicationList represents a list of OAuth2 applications. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usergetrunnerregistrationtoken"></a>
# **UserGetRunnerRegistrationToken**
> void UserGetRunnerRegistrationToken ()

Get an user's actions runner registration token

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserGetRunnerRegistrationTokenExample
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

            var apiInstance = new UserApi(config);

            try
            {
                // Get an user's actions runner registration token
                apiInstance.UserGetRunnerRegistrationToken();
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetRunnerRegistrationToken: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetRunnerRegistrationTokenWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get an user's actions runner registration token
    apiInstance.UserGetRunnerRegistrationTokenWithHttpInfo();
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetRunnerRegistrationTokenWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
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
| **200** | RegistrationToken is response related to registration token |  * token -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usergetstopwatches"></a>
# **UserGetStopWatches**
> List&lt;StopWatch&gt; UserGetStopWatches (int? page = null, int? limit = null)

Get list of all existing stopwatches

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserGetStopWatchesExample
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

            var apiInstance = new UserApi(config);
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // Get list of all existing stopwatches
                List<StopWatch> result = apiInstance.UserGetStopWatches(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetStopWatches: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetStopWatchesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get list of all existing stopwatches
    ApiResponse<List<StopWatch>> response = apiInstance.UserGetStopWatchesWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetStopWatchesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;StopWatch&gt;**](StopWatch.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | StopWatchList |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usergettokens"></a>
# **UserGetTokens**
> List&lt;AccessToken&gt; UserGetTokens (string username, int? page = null, int? limit = null)

List the authenticated user's access tokens

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserGetTokensExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the authenticated user's access tokens
                List<AccessToken> result = apiInstance.UserGetTokens(username, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserGetTokens: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserGetTokensWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the authenticated user's access tokens
    ApiResponse<List<AccessToken>> response = apiInstance.UserGetTokensWithHttpInfo(username, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserGetTokensWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user |  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;AccessToken&gt;**](AccessToken.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | AccessTokenList represents a list of API access token. |  -  |
| **403** | APIForbiddenError is a forbidden error response |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userlistactivityfeeds"></a>
# **UserListActivityFeeds**
> List&lt;Activity&gt; UserListActivityFeeds (string username, bool? onlyPerformedBy = null, DateOnly? date = null, int? page = null, int? limit = null)

List a user's activity feeds

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserListActivityFeedsExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user
            var onlyPerformedBy = true;  // bool? | if true, only show actions performed by the requested user (optional) 
            var date = DateOnly.Parse("2013-10-20");  // DateOnly? | the date of the activities to be found (optional) 
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List a user's activity feeds
                List<Activity> result = apiInstance.UserListActivityFeeds(username, onlyPerformedBy, date, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserListActivityFeeds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserListActivityFeedsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List a user's activity feeds
    ApiResponse<List<Activity>> response = apiInstance.UserListActivityFeedsWithHttpInfo(username, onlyPerformedBy, date, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserListActivityFeedsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user |  |
| **onlyPerformedBy** | **bool?** | if true, only show actions performed by the requested user | [optional]  |
| **date** | **DateOnly?** | the date of the activities to be found | [optional]  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Activity&gt;**](Activity.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ActivityFeedsList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userlistblocks"></a>
# **UserListBlocks**
> List&lt;User&gt; UserListBlocks (int? page = null, int? limit = null)

List users blocked by the authenticated user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserListBlocksExample
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

            var apiInstance = new UserApi(config);
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List users blocked by the authenticated user
                List<User> result = apiInstance.UserListBlocks(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserListBlocks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserListBlocksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List users blocked by the authenticated user
    ApiResponse<List<User>> response = apiInstance.UserListBlocksWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserListBlocksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userlistemails"></a>
# **UserListEmails**
> List&lt;Email&gt; UserListEmails ()

List the authenticated user's email addresses

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserListEmailsExample
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

            var apiInstance = new UserApi(config);

            try
            {
                // List the authenticated user's email addresses
                List<Email> result = apiInstance.UserListEmails();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserListEmails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserListEmailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the authenticated user's email addresses
    ApiResponse<List<Email>> response = apiInstance.UserListEmailsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserListEmailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;Email&gt;**](Email.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | EmailList |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userlistfollowers"></a>
# **UserListFollowers**
> List&lt;User&gt; UserListFollowers (string username, int? page = null, int? limit = null)

List the given user's followers

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserListFollowersExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the given user's followers
                List<User> result = apiInstance.UserListFollowers(username, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserListFollowers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserListFollowersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the given user's followers
    ApiResponse<List<User>> response = apiInstance.UserListFollowersWithHttpInfo(username, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserListFollowersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user |  |
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

<a id="userlistfollowing"></a>
# **UserListFollowing**
> List&lt;User&gt; UserListFollowing (string username, int? page = null, int? limit = null)

List the users that the given user is following

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserListFollowingExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the users that the given user is following
                List<User> result = apiInstance.UserListFollowing(username, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserListFollowing: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserListFollowingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the users that the given user is following
    ApiResponse<List<User>> response = apiInstance.UserListFollowingWithHttpInfo(username, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserListFollowingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user |  |
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

<a id="userlistgpgkeys"></a>
# **UserListGPGKeys**
> List&lt;GPGKey&gt; UserListGPGKeys (string username, int? page = null, int? limit = null)

List the given user's GPG keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserListGPGKeysExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the given user's GPG keys
                List<GPGKey> result = apiInstance.UserListGPGKeys(username, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserListGPGKeys: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserListGPGKeysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the given user's GPG keys
    ApiResponse<List<GPGKey>> response = apiInstance.UserListGPGKeysWithHttpInfo(username, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserListGPGKeysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user |  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;GPGKey&gt;**](GPGKey.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | GPGKeyList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userlisthooks"></a>
# **UserListHooks**
> List&lt;Hook&gt; UserListHooks (int? page = null, int? limit = null)

List the authenticated user's webhooks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserListHooksExample
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

            var apiInstance = new UserApi(config);
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the authenticated user's webhooks
                List<Hook> result = apiInstance.UserListHooks(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserListHooks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserListHooksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the authenticated user's webhooks
    ApiResponse<List<Hook>> response = apiInstance.UserListHooksWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserListHooksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Hook&gt;**](Hook.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | HookList |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userlistkeys"></a>
# **UserListKeys**
> List&lt;PublicKey&gt; UserListKeys (string username, string? fingerprint = null, int? page = null, int? limit = null)

List the given user's public keys

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserListKeysExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user
            var fingerprint = "fingerprint_example";  // string? | fingerprint of the key (optional) 
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the given user's public keys
                List<PublicKey> result = apiInstance.UserListKeys(username, fingerprint, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserListKeys: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserListKeysWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the given user's public keys
    ApiResponse<List<PublicKey>> response = apiInstance.UserListKeysWithHttpInfo(username, fingerprint, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserListKeysWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user |  |
| **fingerprint** | **string?** | fingerprint of the key | [optional]  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;PublicKey&gt;**](PublicKey.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | PublicKeyList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userlistrepos"></a>
# **UserListRepos**
> List&lt;Repository&gt; UserListRepos (string username, int? page = null, int? limit = null)

List the repos owned by the given user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserListReposExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the repos owned by the given user
                List<Repository> result = apiInstance.UserListRepos(username, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserListRepos: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserListReposWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the repos owned by the given user
    ApiResponse<List<Repository>> response = apiInstance.UserListReposWithHttpInfo(username, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserListReposWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user |  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Repository&gt;**](Repository.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | RepositoryList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userliststarred"></a>
# **UserListStarred**
> List&lt;Repository&gt; UserListStarred (string username, int? page = null, int? limit = null)

The repos that the given user has starred

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserListStarredExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of user
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // The repos that the given user has starred
                List<Repository> result = apiInstance.UserListStarred(username, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserListStarred: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserListStarredWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // The repos that the given user has starred
    ApiResponse<List<Repository>> response = apiInstance.UserListStarredWithHttpInfo(username, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserListStarredWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of user |  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Repository&gt;**](Repository.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | RepositoryList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userlistsubscriptions"></a>
# **UserListSubscriptions**
> List&lt;Repository&gt; UserListSubscriptions (string username, int? page = null, int? limit = null)

List the repositories watched by a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserListSubscriptionsExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | username of the user
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List the repositories watched by a user
                List<Repository> result = apiInstance.UserListSubscriptions(username, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserListSubscriptions: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserListSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List the repositories watched by a user
    ApiResponse<List<Repository>> response = apiInstance.UserListSubscriptionsWithHttpInfo(username, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserListSubscriptionsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | username of the user |  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Repository&gt;**](Repository.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | RepositoryList |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userlistteams"></a>
# **UserListTeams**
> List&lt;Team&gt; UserListTeams (int? page = null, int? limit = null)

List all the teams a user belongs to

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserListTeamsExample
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

            var apiInstance = new UserApi(config);
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // List all the teams a user belongs to
                List<Team> result = apiInstance.UserListTeams(page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserListTeams: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserListTeamsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // List all the teams a user belongs to
    ApiResponse<List<Team>> response = apiInstance.UserListTeamsWithHttpInfo(page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserListTeamsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**List&lt;Team&gt;**](Team.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | TeamList |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="usersearch"></a>
# **UserSearch**
> UserSearch200Response UserSearch (string? q = null, long? uid = null, int? page = null, int? limit = null)

Search for users

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserSearchExample
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

            var apiInstance = new UserApi(config);
            var q = "q_example";  // string? | keyword (optional) 
            var uid = 789L;  // long? | ID of the user to search for (optional) 
            var page = 56;  // int? | page number of results to return (1-based) (optional) 
            var limit = 56;  // int? | page size of results (optional) 

            try
            {
                // Search for users
                UserSearch200Response result = apiInstance.UserSearch(q, uid, page, limit);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserSearch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserSearchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Search for users
    ApiResponse<UserSearch200Response> response = apiInstance.UserSearchWithHttpInfo(q, uid, page, limit);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserSearchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **q** | **string?** | keyword | [optional]  |
| **uid** | **long?** | ID of the user to search for | [optional]  |
| **page** | **int?** | page number of results to return (1-based) | [optional]  |
| **limit** | **int?** | page size of results | [optional]  |

### Return type

[**UserSearch200Response**](UserSearch200Response.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | SearchResults of a successful search |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userunblockuser"></a>
# **UserUnblockUser**
> void UserUnblockUser (string username)

Unblock a user

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserUnblockUserExample
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

            var apiInstance = new UserApi(config);
            var username = "username_example";  // string | user to unblock

            try
            {
                // Unblock a user
                apiInstance.UserUnblockUser(username);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserUnblockUser: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserUnblockUserWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Unblock a user
    apiInstance.UserUnblockUserWithHttpInfo(username);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserUnblockUserWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **username** | **string** | user to unblock |  |

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
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userupdateavatar"></a>
# **UserUpdateAvatar**
> void UserUpdateAvatar (UpdateUserAvatarOption? body = null)

Update Avatar

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserUpdateAvatarExample
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

            var apiInstance = new UserApi(config);
            var body = new UpdateUserAvatarOption?(); // UpdateUserAvatarOption? |  (optional) 

            try
            {
                // Update Avatar
                apiInstance.UserUpdateAvatar(body);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserUpdateAvatar: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserUpdateAvatarWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Avatar
    apiInstance.UserUpdateAvatarWithHttpInfo(body);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserUpdateAvatarWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**UpdateUserAvatarOption?**](UpdateUserAvatarOption?.md) |  | [optional]  |

### Return type

void (empty response body)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | APIEmpty is an empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userupdateoauth2application"></a>
# **UserUpdateOAuth2Application**
> OAuth2Application UserUpdateOAuth2Application (long id, CreateOAuth2ApplicationOptions body)

update an OAuth2 Application, this includes regenerating the client secret

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserUpdateOAuth2ApplicationExample
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

            var apiInstance = new UserApi(config);
            var id = 789L;  // long | application to be updated
            var body = new CreateOAuth2ApplicationOptions(); // CreateOAuth2ApplicationOptions | 

            try
            {
                // update an OAuth2 Application, this includes regenerating the client secret
                OAuth2Application result = apiInstance.UserUpdateOAuth2Application(id, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserUpdateOAuth2Application: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserUpdateOAuth2ApplicationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // update an OAuth2 Application, this includes regenerating the client secret
    ApiResponse<OAuth2Application> response = apiInstance.UserUpdateOAuth2ApplicationWithHttpInfo(id, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserUpdateOAuth2ApplicationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **long** | application to be updated |  |
| **body** | [**CreateOAuth2ApplicationOptions**](CreateOAuth2ApplicationOptions.md) |  |  |

### Return type

[**OAuth2Application**](OAuth2Application.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json, text/plain
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OAuth2Application |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="userverifygpgkey"></a>
# **UserVerifyGPGKey**
> GPGKey UserVerifyGPGKey ()

Verify a GPG key

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UserVerifyGPGKeyExample
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

            var apiInstance = new UserApi(config);

            try
            {
                // Verify a GPG key
                GPGKey result = apiInstance.UserVerifyGPGKey();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UserApi.UserVerifyGPGKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UserVerifyGPGKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Verify a GPG key
    ApiResponse<GPGKey> response = apiInstance.UserVerifyGPGKeyWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling UserApi.UserVerifyGPGKeyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GPGKey**](GPGKey.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | GPGKey |  -  |
| **404** | APINotFound is a not found empty response |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

