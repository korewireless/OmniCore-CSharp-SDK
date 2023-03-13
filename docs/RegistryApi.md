# OmniCore.Api.RegistryApi

All URIs are relative to *https://demo-api.omnicore.cloud.korewireless.com/model-state-management*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateRegistry**](RegistryApi.md#createregistry) | **POST** /subscriptions/{subscriptionId}/registries |  |
| [**DeleteRegistry**](RegistryApi.md#deleteregistry) | **DELETE** /subscriptions/{subscriptionId}/registries/{registryId} |  |
| [**GetRegistries**](RegistryApi.md#getregistries) | **GET** /subscriptions/{subscriptionId}/registries |  |
| [**GetRegistry**](RegistryApi.md#getregistry) | **GET** /subscriptions/{subscriptionId}/registries/{registryId} |  |
| [**UpdateRegistry**](RegistryApi.md#updateregistry) | **PATCH** /subscriptions/{subscriptionId}/registries/{registryId} |  |

<a name="createregistry"></a>
# **CreateRegistry**
> DeviceRegistry CreateRegistry (string subscriptionId, DeviceRegistry registry = null)



Create a registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class CreateRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo-api.omnicore.cloud.korewireless.com/model-state-management";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RegistryApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registry = new DeviceRegistry(); // DeviceRegistry | application/json (optional) 

            try
            {
                DeviceRegistry result = apiInstance.CreateRegistry(subscriptionId, registry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistryApi.CreateRegistry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateRegistryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeviceRegistry> response = apiInstance.CreateRegistryWithHttpInfo(subscriptionId, registry);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistryApi.CreateRegistryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **registry** | [**DeviceRegistry**](DeviceRegistry.md) | application/json | [optional]  |

### Return type

[**DeviceRegistry**](DeviceRegistry.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deleteregistry"></a>
# **DeleteRegistry**
> Info DeleteRegistry (string subscriptionId, string registryId)



Delete a registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class DeleteRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo-api.omnicore.cloud.korewireless.com/model-state-management";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RegistryApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID

            try
            {
                Info result = apiInstance.DeleteRegistry(subscriptionId, registryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistryApi.DeleteRegistry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteRegistryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Info> response = apiInstance.DeleteRegistryWithHttpInfo(subscriptionId, registryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistryApi.DeleteRegistryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |

### Return type

[**Info**](Info.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistries"></a>
# **GetRegistries**
> ListDeviceRegistries GetRegistries (string subscriptionId, int? pageNumber = null, int? pageSize = null)



Get all registries under a subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class GetRegistriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo-api.omnicore.cloud.korewireless.com/model-state-management";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RegistryApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var pageNumber = 56;  // int? | Page Number (optional) 
            var pageSize = 56;  // int? | Page Size (optional) 

            try
            {
                ListDeviceRegistries result = apiInstance.GetRegistries(subscriptionId, pageNumber, pageSize);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistryApi.GetRegistries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRegistriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListDeviceRegistries> response = apiInstance.GetRegistriesWithHttpInfo(subscriptionId, pageNumber, pageSize);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistryApi.GetRegistriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **pageNumber** | **int?** | Page Number | [optional]  |
| **pageSize** | **int?** | Page Size | [optional]  |

### Return type

[**ListDeviceRegistries**](ListDeviceRegistries.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getregistry"></a>
# **GetRegistry**
> DeviceRegistry GetRegistry (string subscriptionId, string registryId)



Get a registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class GetRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo-api.omnicore.cloud.korewireless.com/model-state-management";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RegistryApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID

            try
            {
                DeviceRegistry result = apiInstance.GetRegistry(subscriptionId, registryId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistryApi.GetRegistry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRegistryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeviceRegistry> response = apiInstance.GetRegistryWithHttpInfo(subscriptionId, registryId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistryApi.GetRegistryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |

### Return type

[**DeviceRegistry**](DeviceRegistry.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updateregistry"></a>
# **UpdateRegistry**
> DeviceRegistry UpdateRegistry (string subscriptionId, string registryId, string updateMask, DeviceRegistry registry = null)



Update a registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class UpdateRegistryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://demo-api.omnicore.cloud.korewireless.com/model-state-management";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new RegistryApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var updateMask = "eventNotificationConfigs";  // string | values to be updated: eventNotificationConfigs,stateNotificationConfig.pubsub_topic_name,logNotificationConfig.pubsub_topic_name,mqttConfig.mqtt_enabled_state,httpConfig.http_enabled_state,logLevel,credentials
            var registry = new DeviceRegistry(); // DeviceRegistry | application/json (optional) 

            try
            {
                DeviceRegistry result = apiInstance.UpdateRegistry(subscriptionId, registryId, updateMask, registry);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RegistryApi.UpdateRegistry: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateRegistryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeviceRegistry> response = apiInstance.UpdateRegistryWithHttpInfo(subscriptionId, registryId, updateMask, registry);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling RegistryApi.UpdateRegistryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **updateMask** | **string** | values to be updated: eventNotificationConfigs,stateNotificationConfig.pubsub_topic_name,logNotificationConfig.pubsub_topic_name,mqttConfig.mqtt_enabled_state,httpConfig.http_enabled_state,logLevel,credentials |  |
| **registry** | [**DeviceRegistry**](DeviceRegistry.md) | application/json | [optional]  |

### Return type

[**DeviceRegistry**](DeviceRegistry.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | Bad Request |  -  |
| **404** | Not Found |  -  |
| **500** | Internal Server Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

