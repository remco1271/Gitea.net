# Org.OpenAPITools.Api.SettingsApi

All URIs are relative to */api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGeneralAPISettings**](SettingsApi.md#getgeneralapisettings) | **GET** /settings/api | Get instance&#39;s global settings for api |
| [**GetGeneralAttachmentSettings**](SettingsApi.md#getgeneralattachmentsettings) | **GET** /settings/attachment | Get instance&#39;s global settings for Attachment |
| [**GetGeneralRepositorySettings**](SettingsApi.md#getgeneralrepositorysettings) | **GET** /settings/repository | Get instance&#39;s global settings for repositories |
| [**GetGeneralUISettings**](SettingsApi.md#getgeneraluisettings) | **GET** /settings/ui | Get instance&#39;s global settings for ui |

<a id="getgeneralapisettings"></a>
# **GetGeneralAPISettings**
> GeneralAPISettings GetGeneralAPISettings ()

Get instance's global settings for api

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGeneralAPISettingsExample
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

            var apiInstance = new SettingsApi(config);

            try
            {
                // Get instance's global settings for api
                GeneralAPISettings result = apiInstance.GetGeneralAPISettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetGeneralAPISettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGeneralAPISettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get instance's global settings for api
    ApiResponse<GeneralAPISettings> response = apiInstance.GetGeneralAPISettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetGeneralAPISettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GeneralAPISettings**](GeneralAPISettings.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | GeneralAPISettings |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgeneralattachmentsettings"></a>
# **GetGeneralAttachmentSettings**
> GeneralAttachmentSettings GetGeneralAttachmentSettings ()

Get instance's global settings for Attachment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGeneralAttachmentSettingsExample
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

            var apiInstance = new SettingsApi(config);

            try
            {
                // Get instance's global settings for Attachment
                GeneralAttachmentSettings result = apiInstance.GetGeneralAttachmentSettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetGeneralAttachmentSettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGeneralAttachmentSettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get instance's global settings for Attachment
    ApiResponse<GeneralAttachmentSettings> response = apiInstance.GetGeneralAttachmentSettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetGeneralAttachmentSettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GeneralAttachmentSettings**](GeneralAttachmentSettings.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | GeneralAttachmentSettings |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgeneralrepositorysettings"></a>
# **GetGeneralRepositorySettings**
> GeneralRepoSettings GetGeneralRepositorySettings ()

Get instance's global settings for repositories

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGeneralRepositorySettingsExample
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

            var apiInstance = new SettingsApi(config);

            try
            {
                // Get instance's global settings for repositories
                GeneralRepoSettings result = apiInstance.GetGeneralRepositorySettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetGeneralRepositorySettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGeneralRepositorySettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get instance's global settings for repositories
    ApiResponse<GeneralRepoSettings> response = apiInstance.GetGeneralRepositorySettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetGeneralRepositorySettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GeneralRepoSettings**](GeneralRepoSettings.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | GeneralRepoSettings |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getgeneraluisettings"></a>
# **GetGeneralUISettings**
> GeneralUISettings GetGeneralUISettings ()

Get instance's global settings for ui

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGeneralUISettingsExample
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

            var apiInstance = new SettingsApi(config);

            try
            {
                // Get instance's global settings for ui
                GeneralUISettings result = apiInstance.GetGeneralUISettings();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettingsApi.GetGeneralUISettings: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGeneralUISettingsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get instance's global settings for ui
    ApiResponse<GeneralUISettings> response = apiInstance.GetGeneralUISettingsWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SettingsApi.GetGeneralUISettingsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**GeneralUISettings**](GeneralUISettings.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | GeneralUISettings |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

