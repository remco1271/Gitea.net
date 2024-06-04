# Org.OpenAPITools.Api.MiscellaneousApi

All URIs are relative to */api/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetGitignoreTemplateInfo**](MiscellaneousApi.md#getgitignoretemplateinfo) | **GET** /gitignore/templates/{name} | Returns information about a gitignore template |
| [**GetLabelTemplateInfo**](MiscellaneousApi.md#getlabeltemplateinfo) | **GET** /label/templates/{name} | Returns all labels in a template |
| [**GetLicenseTemplateInfo**](MiscellaneousApi.md#getlicensetemplateinfo) | **GET** /licenses/{name} | Returns information about a license template |
| [**GetNodeInfo**](MiscellaneousApi.md#getnodeinfo) | **GET** /nodeinfo | Returns the nodeinfo of the Gitea application |
| [**GetSigningKey**](MiscellaneousApi.md#getsigningkey) | **GET** /signing-key.gpg | Get default signing-key.gpg |
| [**GetVersion**](MiscellaneousApi.md#getversion) | **GET** /version | Returns the version of the Gitea application |
| [**ListGitignoresTemplates**](MiscellaneousApi.md#listgitignorestemplates) | **GET** /gitignore/templates | Returns a list of all gitignore templates |
| [**ListLabelTemplates**](MiscellaneousApi.md#listlabeltemplates) | **GET** /label/templates | Returns a list of all label templates |
| [**ListLicenseTemplates**](MiscellaneousApi.md#listlicensetemplates) | **GET** /licenses | Returns a list of all license templates |
| [**RenderMarkdown**](MiscellaneousApi.md#rendermarkdown) | **POST** /markdown | Render a markdown document as HTML |
| [**RenderMarkdownRaw**](MiscellaneousApi.md#rendermarkdownraw) | **POST** /markdown/raw | Render raw markdown as HTML |
| [**RenderMarkup**](MiscellaneousApi.md#rendermarkup) | **POST** /markup | Render a markup document as HTML |

<a id="getgitignoretemplateinfo"></a>
# **GetGitignoreTemplateInfo**
> GitignoreTemplateInfo GetGitignoreTemplateInfo (string name)

Returns information about a gitignore template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetGitignoreTemplateInfoExample
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

            var apiInstance = new MiscellaneousApi(config);
            var name = "name_example";  // string | name of the template

            try
            {
                // Returns information about a gitignore template
                GitignoreTemplateInfo result = apiInstance.GetGitignoreTemplateInfo(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetGitignoreTemplateInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetGitignoreTemplateInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns information about a gitignore template
    ApiResponse<GitignoreTemplateInfo> response = apiInstance.GetGitignoreTemplateInfoWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetGitignoreTemplateInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | name of the template |  |

### Return type

[**GitignoreTemplateInfo**](GitignoreTemplateInfo.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | GitignoreTemplateInfo |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlabeltemplateinfo"></a>
# **GetLabelTemplateInfo**
> List&lt;LabelTemplate&gt; GetLabelTemplateInfo (string name)

Returns all labels in a template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetLabelTemplateInfoExample
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

            var apiInstance = new MiscellaneousApi(config);
            var name = "name_example";  // string | name of the template

            try
            {
                // Returns all labels in a template
                List<LabelTemplate> result = apiInstance.GetLabelTemplateInfo(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetLabelTemplateInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLabelTemplateInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns all labels in a template
    ApiResponse<List<LabelTemplate>> response = apiInstance.GetLabelTemplateInfoWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetLabelTemplateInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | name of the template |  |

### Return type

[**List&lt;LabelTemplate&gt;**](LabelTemplate.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LabelTemplateInfo |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getlicensetemplateinfo"></a>
# **GetLicenseTemplateInfo**
> LicenseTemplateInfo GetLicenseTemplateInfo (string name)

Returns information about a license template

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetLicenseTemplateInfoExample
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

            var apiInstance = new MiscellaneousApi(config);
            var name = "name_example";  // string | name of the license

            try
            {
                // Returns information about a license template
                LicenseTemplateInfo result = apiInstance.GetLicenseTemplateInfo(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetLicenseTemplateInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetLicenseTemplateInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns information about a license template
    ApiResponse<LicenseTemplateInfo> response = apiInstance.GetLicenseTemplateInfoWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetLicenseTemplateInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | name of the license |  |

### Return type

[**LicenseTemplateInfo**](LicenseTemplateInfo.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LicenseTemplateInfo |  -  |
| **404** | APINotFound is a not found empty response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getnodeinfo"></a>
# **GetNodeInfo**
> NodeInfo GetNodeInfo ()

Returns the nodeinfo of the Gitea application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetNodeInfoExample
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

            var apiInstance = new MiscellaneousApi(config);

            try
            {
                // Returns the nodeinfo of the Gitea application
                NodeInfo result = apiInstance.GetNodeInfo();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetNodeInfo: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetNodeInfoWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the nodeinfo of the Gitea application
    ApiResponse<NodeInfo> response = apiInstance.GetNodeInfoWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetNodeInfoWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**NodeInfo**](NodeInfo.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | NodeInfo |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsigningkey"></a>
# **GetSigningKey**
> string GetSigningKey ()

Get default signing-key.gpg

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetSigningKeyExample
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

            var apiInstance = new MiscellaneousApi(config);

            try
            {
                // Get default signing-key.gpg
                string result = apiInstance.GetSigningKey();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetSigningKey: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSigningKeyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get default signing-key.gpg
    ApiResponse<string> response = apiInstance.GetSigningKeyWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetSigningKeyWithHttpInfo: " + e.Message);
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
| **200** | GPG armored public key |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getversion"></a>
# **GetVersion**
> ServerVersion GetVersion ()

Returns the version of the Gitea application

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetVersionExample
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

            var apiInstance = new MiscellaneousApi(config);

            try
            {
                // Returns the version of the Gitea application
                ServerVersion result = apiInstance.GetVersion();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.GetVersion: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVersionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns the version of the Gitea application
    ApiResponse<ServerVersion> response = apiInstance.GetVersionWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.GetVersionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ServerVersion**](ServerVersion.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ServerVersion |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listgitignorestemplates"></a>
# **ListGitignoresTemplates**
> List&lt;string&gt; ListGitignoresTemplates ()

Returns a list of all gitignore templates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListGitignoresTemplatesExample
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

            var apiInstance = new MiscellaneousApi(config);

            try
            {
                // Returns a list of all gitignore templates
                List<string> result = apiInstance.ListGitignoresTemplates();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.ListGitignoresTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListGitignoresTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a list of all gitignore templates
    ApiResponse<List<string>> response = apiInstance.ListGitignoresTemplatesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.ListGitignoresTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | GitignoreTemplateList |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listlabeltemplates"></a>
# **ListLabelTemplates**
> List&lt;string&gt; ListLabelTemplates ()

Returns a list of all label templates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListLabelTemplatesExample
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

            var apiInstance = new MiscellaneousApi(config);

            try
            {
                // Returns a list of all label templates
                List<string> result = apiInstance.ListLabelTemplates();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.ListLabelTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLabelTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a list of all label templates
    ApiResponse<List<string>> response = apiInstance.ListLabelTemplatesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.ListLabelTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

**List<string>**

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LabelTemplateList |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listlicensetemplates"></a>
# **ListLicenseTemplates**
> List&lt;LicensesTemplateListEntry&gt; ListLicenseTemplates ()

Returns a list of all license templates

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ListLicenseTemplatesExample
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

            var apiInstance = new MiscellaneousApi(config);

            try
            {
                // Returns a list of all license templates
                List<LicensesTemplateListEntry> result = apiInstance.ListLicenseTemplates();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.ListLicenseTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListLicenseTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Returns a list of all license templates
    ApiResponse<List<LicensesTemplateListEntry>> response = apiInstance.ListLicenseTemplatesWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.ListLicenseTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**List&lt;LicensesTemplateListEntry&gt;**](LicensesTemplateListEntry.md)

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | LicenseTemplateList |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rendermarkdown"></a>
# **RenderMarkdown**
> string RenderMarkdown (MarkdownOption? body = null)

Render a markdown document as HTML

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RenderMarkdownExample
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

            var apiInstance = new MiscellaneousApi(config);
            var body = new MarkdownOption?(); // MarkdownOption? |  (optional) 

            try
            {
                // Render a markdown document as HTML
                string result = apiInstance.RenderMarkdown(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.RenderMarkdown: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenderMarkdownWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Render a markdown document as HTML
    ApiResponse<string> response = apiInstance.RenderMarkdownWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.RenderMarkdownWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**MarkdownOption?**](MarkdownOption?.md) |  | [optional]  |

### Return type

**string**

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | MarkdownRender is a rendered markdown document |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rendermarkdownraw"></a>
# **RenderMarkdownRaw**
> string RenderMarkdownRaw (string body)

Render raw markdown as HTML

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RenderMarkdownRawExample
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

            var apiInstance = new MiscellaneousApi(config);
            var body = "body_example";  // string | Request body to render

            try
            {
                // Render raw markdown as HTML
                string result = apiInstance.RenderMarkdownRaw(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.RenderMarkdownRaw: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenderMarkdownRawWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Render raw markdown as HTML
    ApiResponse<string> response = apiInstance.RenderMarkdownRawWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.RenderMarkdownRawWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | **string** | Request body to render |  |

### Return type

**string**

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: text/plain
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | MarkdownRender is a rendered markdown document |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="rendermarkup"></a>
# **RenderMarkup**
> string RenderMarkup (MarkupOption? body = null)

Render a markup document as HTML

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class RenderMarkupExample
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

            var apiInstance = new MiscellaneousApi(config);
            var body = new MarkupOption?(); // MarkupOption? |  (optional) 

            try
            {
                // Render a markup document as HTML
                string result = apiInstance.RenderMarkup(body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MiscellaneousApi.RenderMarkup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RenderMarkupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Render a markup document as HTML
    ApiResponse<string> response = apiInstance.RenderMarkupWithHttpInfo(body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MiscellaneousApi.RenderMarkupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**MarkupOption?**](MarkupOption?.md) |  | [optional]  |

### Return type

**string**

### Authorization

[TOTPHeader](../README.md#TOTPHeader), [AuthorizationHeaderToken](../README.md#AuthorizationHeaderToken), [SudoHeader](../README.md#SudoHeader), [BasicAuth](../README.md#BasicAuth), [AccessToken](../README.md#AccessToken), [SudoParam](../README.md#SudoParam), [Token](../README.md#Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: text/html


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | MarkupRender is a rendered markup document |  -  |
| **422** | APIValidationError is error format response related to input validation |  * message -  <br>  * url -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

