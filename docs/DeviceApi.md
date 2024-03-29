# OmniCore.Api.DeviceApi

All URIs are relative to *https://api.korewireless.com*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BindDevice**](DeviceApi.md#binddevice) | **POST** /omnicore/subscriptions/{subscriptionId}/registries/{registryId}/bindDeviceToGateway |  |
| [**BindDevices**](DeviceApi.md#binddevices) | **POST** /omnicore/subscriptions/{subscriptionId}/registries/{registryId}/bindDevicesToGateway |  |
| [**BlockDeviceCommuncation**](DeviceApi.md#blockdevicecommuncation) | **PUT** /omnicore/subscriptions/{subscriptionid}/registries/{registryId}/devices/{deviceId}/communication |  |
| [**CreateDevice**](DeviceApi.md#createdevice) | **POST** /omnicore/subscriptions/{subscriptionId}/registries/{registryId}/devices |  |
| [**DeleteDevice**](DeviceApi.md#deletedevice) | **DELETE** /omnicore/subscriptions/{subscriptionId}/registries/{registryId}/devices/{deviceId} |  |
| [**GetConfig**](DeviceApi.md#getconfig) | **GET** /omnicore/subscriptions/{subscriptionid}/registries/{registryId}/devices/{deviceId}/configVersions |  |
| [**GetDevice**](DeviceApi.md#getdevice) | **GET** /omnicore/subscriptions/{subscriptionId}/registries/{registryId}/devices/{deviceId} |  |
| [**GetDevices**](DeviceApi.md#getdevices) | **GET** /omnicore/subscriptions/{subscriptionId}/registries/{registryId}/devices |  |
| [**GetStates**](DeviceApi.md#getstates) | **GET** /omnicore/subscriptions/{subscriptionid}/registries/{registryId}/devices/{deviceId}/states |  |
| [**GetSubscriptionDevices**](DeviceApi.md#getsubscriptiondevices) | **GET** /omnicore/subscriptions/{subscriptionId}/devices |  |
| [**SendCommandToDevice**](DeviceApi.md#sendcommandtodevice) | **POST** /omnicore/subscriptions/{subscriptionid}/registries/{registryId}/devices/{deviceId}/sendCommandToDevice |  |
| [**UnBindDevice**](DeviceApi.md#unbinddevice) | **POST** /omnicore/subscriptions/{subscriptionId}/registries/{registryId}/unbindDeviceFromGateway |  |
| [**UnBindDevices**](DeviceApi.md#unbinddevices) | **POST** /omnicore/subscriptions/{subscriptionId}/registries/{registryId}/unbindDevicesFromGateway |  |
| [**UpdateConfigurationToDevice**](DeviceApi.md#updateconfigurationtodevice) | **POST** /omnicore/subscriptions/{subscriptionid}/registries/{registryId}/devices/{deviceId}/updateConfigurationToDevice |  |
| [**UpdateCustomOnboardRequest**](DeviceApi.md#updatecustomonboardrequest) | **POST** /omnicore/subscriptions/{subscriptionid}/registries/{registryId}/devices/{deviceId}/updateCustomOnboardRequest |  |
| [**UpdateDevice**](DeviceApi.md#updatedevice) | **PATCH** /omnicore/subscriptions/{subscriptionId}/registries/{registryId}/devices/{deviceId} |  |

<a name="binddevice"></a>
# **BindDevice**
> Info BindDevice (string subscriptionId, string registryId, BindRequest bind)



Bind  a device to a gateway under a registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class BindDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var bind = new BindRequest(); // BindRequest | application/json

            try
            {
                Info result = apiInstance.BindDevice(subscriptionId, registryId, bind);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.BindDevice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BindDeviceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Info> response = apiInstance.BindDeviceWithHttpInfo(subscriptionId, registryId, bind);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.BindDeviceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **bind** | [**BindRequest**](BindRequest.md) | application/json |  |

### Return type

[**Info**](Info.md)

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="binddevices"></a>
# **BindDevices**
> Info BindDevices (string subscriptionId, string registryId, BindRequestIdsGateway bind)



Bind devices to a gateway under a registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class BindDevicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var bind = new BindRequestIdsGateway(); // BindRequestIdsGateway | application/json

            try
            {
                Info result = apiInstance.BindDevices(subscriptionId, registryId, bind);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.BindDevices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BindDevicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Info> response = apiInstance.BindDevicesWithHttpInfo(subscriptionId, registryId, bind);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.BindDevicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **bind** | [**BindRequestIdsGateway**](BindRequestIdsGateway.md) | application/json |  |

### Return type

[**Info**](Info.md)

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="blockdevicecommuncation"></a>
# **BlockDeviceCommuncation**
> Object BlockDeviceCommuncation (string subscriptionid, string registryId, string deviceId, BlockCommunicationBody block)



Blocks All Communication From A Device

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class BlockDeviceCommuncationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionid = "subscriptionid_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var deviceId = "deviceId_example";  // string | Device ID
            var block = new BlockCommunicationBody(); // BlockCommunicationBody | application/json

            try
            {
                Object result = apiInstance.BlockDeviceCommuncation(subscriptionid, registryId, deviceId, block);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.BlockDeviceCommuncation: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BlockDeviceCommuncationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.BlockDeviceCommuncationWithHttpInfo(subscriptionid, registryId, deviceId, block);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.BlockDeviceCommuncationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionid** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **deviceId** | **string** | Device ID |  |
| **block** | [**BlockCommunicationBody**](BlockCommunicationBody.md) | application/json |  |

### Return type

**Object**

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="createdevice"></a>
# **CreateDevice**
> Device CreateDevice (string subscriptionId, string registryId, Device device)



Create a device under a registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class CreateDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var device = new Device(); // Device | application/json

            try
            {
                Device result = apiInstance.CreateDevice(subscriptionId, registryId, device);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.CreateDevice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDeviceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Device> response = apiInstance.CreateDeviceWithHttpInfo(subscriptionId, registryId, device);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.CreateDeviceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **device** | [**Device**](Device.md) | application/json |  |

### Return type

[**Device**](Device.md)

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="deletedevice"></a>
# **DeleteDevice**
> Object DeleteDevice (string subscriptionId, string registryId, string deviceId)



Delete a device under a registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class DeleteDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var deviceId = "deviceId_example";  // string | Device ID

            try
            {
                Object result = apiInstance.DeleteDevice(subscriptionId, registryId, deviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.DeleteDevice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDeviceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.DeleteDeviceWithHttpInfo(subscriptionId, registryId, deviceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.DeleteDeviceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **deviceId** | **string** | Device ID |  |

### Return type

**Object**

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="getconfig"></a>
# **GetConfig**
> ListDeviceConfigVersionsResponse GetConfig (string subscriptionid, string registryId, string deviceId, int? numVersions = null)



Get Configs Of Devices

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class GetConfigExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionid = "subscriptionid_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var deviceId = "deviceId_example";  // string | Device ID
            var numVersions = 56;  // int? | The number of versions to list. Versions are listed in decreasing order of the version number. The maximum number of versions retained is 10. If this value is zero, it will return all the versions available. (optional) 

            try
            {
                ListDeviceConfigVersionsResponse result = apiInstance.GetConfig(subscriptionid, registryId, deviceId, numVersions);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.GetConfig: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetConfigWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListDeviceConfigVersionsResponse> response = apiInstance.GetConfigWithHttpInfo(subscriptionid, registryId, deviceId, numVersions);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.GetConfigWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionid** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **deviceId** | **string** | Device ID |  |
| **numVersions** | **int?** | The number of versions to list. Versions are listed in decreasing order of the version number. The maximum number of versions retained is 10. If this value is zero, it will return all the versions available. | [optional]  |

### Return type

[**ListDeviceConfigVersionsResponse**](ListDeviceConfigVersionsResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="getdevice"></a>
# **GetDevice**
> Device GetDevice (string subscriptionId, string registryId, string deviceId)



Get a device under a registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class GetDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var deviceId = "deviceId_example";  // string | Device ID

            try
            {
                Device result = apiInstance.GetDevice(subscriptionId, registryId, deviceId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.GetDevice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDeviceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Device> response = apiInstance.GetDeviceWithHttpInfo(subscriptionId, registryId, deviceId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.GetDeviceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **deviceId** | **string** | Device ID |  |

### Return type

[**Device**](Device.md)

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="getdevices"></a>
# **GetDevices**
> ListDevicesResponse GetDevices (string subscriptionId, string registryId, int? pageNumber = null, int? pageSize = null, string fieldMask = null, List<string> deviceIds = null, List<string> deviceNumIds = null, string gatewayListOptionsAssociationsDeviceId = null, string gatewayListOptionsAssociationsGatewayId = null, string gatewayListOptionsGatewayType = null)



Get all devices under a registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class GetDevicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var pageNumber = 56;  // int? | Page Number (optional) 
            var pageSize = 56;  // int? | The maximum number of devices to return in the response. If this value is zero, the service will select a default size.  (optional) 
            var fieldMask = "fieldMask_example";  // string | The fields of the Device resource to be returned to the response. The fields id and numId are always returned, along with any other fields specified. A comma-separated list of fully qualified names of fields. Example:  (optional) 
            var deviceIds = new List<string>(); // List<string> | A list of device string IDs. For example, ['device0', 'device12']. If empty, this field is ignored. Maximum IDs: 10,000 (optional) 
            var deviceNumIds = new List<string>(); // List<string> | A list of device numeric IDs. If empty, this field is ignored. Maximum IDs: 10,000. (optional) 
            var gatewayListOptionsAssociationsDeviceId = "gatewayListOptionsAssociationsDeviceId_example";  // string | If set, returns only the gateways with which the specified device is associated. The device ID can be numeric (num_id) or the user-defined string (id). For example, if 456 is specified, returns only the gateways to which the device with num_id 456 is bound. (optional) 
            var gatewayListOptionsAssociationsGatewayId = "gatewayListOptionsAssociationsGatewayId_example";  // string | If set, only devices associated with the specified gateway are returned. The gateway ID can be numeric (num_id) or the user-defined string (id). For example, if 123 is specified, only devices bound to the gateway with num_id 123 are returned (optional) 
            var gatewayListOptionsGatewayType = "gatewayListOptionsGatewayType_example";  // string | If GATEWAY is specified, only gateways are returned. If NON_GATEWAY is specified, only non-gateway devices are returned. If GATEWAY_TYPE_UNSPECIFIED is specified, all devices are returned. (optional) 

            try
            {
                ListDevicesResponse result = apiInstance.GetDevices(subscriptionId, registryId, pageNumber, pageSize, fieldMask, deviceIds, deviceNumIds, gatewayListOptionsAssociationsDeviceId, gatewayListOptionsAssociationsGatewayId, gatewayListOptionsGatewayType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.GetDevices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDevicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListDevicesResponse> response = apiInstance.GetDevicesWithHttpInfo(subscriptionId, registryId, pageNumber, pageSize, fieldMask, deviceIds, deviceNumIds, gatewayListOptionsAssociationsDeviceId, gatewayListOptionsAssociationsGatewayId, gatewayListOptionsGatewayType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.GetDevicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **pageNumber** | **int?** | Page Number | [optional]  |
| **pageSize** | **int?** | The maximum number of devices to return in the response. If this value is zero, the service will select a default size.  | [optional]  |
| **fieldMask** | **string** | The fields of the Device resource to be returned to the response. The fields id and numId are always returned, along with any other fields specified. A comma-separated list of fully qualified names of fields. Example:  | [optional]  |
| **deviceIds** | [**List&lt;string&gt;**](string.md) | A list of device string IDs. For example, [&#39;device0&#39;, &#39;device12&#39;]. If empty, this field is ignored. Maximum IDs: 10,000 | [optional]  |
| **deviceNumIds** | [**List&lt;string&gt;**](string.md) | A list of device numeric IDs. If empty, this field is ignored. Maximum IDs: 10,000. | [optional]  |
| **gatewayListOptionsAssociationsDeviceId** | **string** | If set, returns only the gateways with which the specified device is associated. The device ID can be numeric (num_id) or the user-defined string (id). For example, if 456 is specified, returns only the gateways to which the device with num_id 456 is bound. | [optional]  |
| **gatewayListOptionsAssociationsGatewayId** | **string** | If set, only devices associated with the specified gateway are returned. The gateway ID can be numeric (num_id) or the user-defined string (id). For example, if 123 is specified, only devices bound to the gateway with num_id 123 are returned | [optional]  |
| **gatewayListOptionsGatewayType** | **string** | If GATEWAY is specified, only gateways are returned. If NON_GATEWAY is specified, only non-gateway devices are returned. If GATEWAY_TYPE_UNSPECIFIED is specified, all devices are returned. | [optional]  |

### Return type

[**ListDevicesResponse**](ListDevicesResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="getstates"></a>
# **GetStates**
> ListDeviceStatesResponse GetStates (string subscriptionid, string registryId, string deviceId, int? numStates = null)



Get States Of Devices

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class GetStatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionid = "subscriptionid_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var deviceId = "deviceId_example";  // string | Device ID
            var numStates = 56;  // int? | The number of states to list. States are listed in descending order of update time. The maximum number of states retained is 10. If this value is zero, it will return all the states available. (optional) 

            try
            {
                ListDeviceStatesResponse result = apiInstance.GetStates(subscriptionid, registryId, deviceId, numStates);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.GetStates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListDeviceStatesResponse> response = apiInstance.GetStatesWithHttpInfo(subscriptionid, registryId, deviceId, numStates);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.GetStatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionid** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **deviceId** | **string** | Device ID |  |
| **numStates** | **int?** | The number of states to list. States are listed in descending order of update time. The maximum number of states retained is 10. If this value is zero, it will return all the states available. | [optional]  |

### Return type

[**ListDeviceStatesResponse**](ListDeviceStatesResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="getsubscriptiondevices"></a>
# **GetSubscriptionDevices**
> ListDevicesOnlineResponse GetSubscriptionDevices (string subscriptionId, int? pageNumber = null, int? pageSize = null, string fieldMask = null, bool? sortByClientOnline = null, List<string> deviceIds = null, List<string> deviceNumIds = null, string gatewayListOptionsAssociationsDeviceId = null, string gatewayListOptionsAssociationsGatewayId = null, string gatewayListOptionsGatewayType = null)



Get all devices under a subscription

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class GetSubscriptionDevicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var pageNumber = 56;  // int? | Page Number (optional) 
            var pageSize = 56;  // int? | The maximum number of devices to return in the response. If this value is zero, the service will select a default size.  (optional) 
            var fieldMask = "fieldMask_example";  // string | The fields of the Device resource to be returned to the response. The fields id and numId are always returned, along with any other fields specified. A comma-separated list of fully qualified names of fields. Example:  (optional) 
            var sortByClientOnline = true;  // bool? | Set to true to return devices sorted by last heartbeat  (optional) 
            var deviceIds = new List<string>(); // List<string> | A list of device string IDs. For example, ['device0', 'device12']. If empty, this field is ignored. Maximum IDs: 10,000 (optional) 
            var deviceNumIds = new List<string>(); // List<string> | A list of device numeric IDs. If empty, this field is ignored. Maximum IDs: 10,000. (optional) 
            var gatewayListOptionsAssociationsDeviceId = "gatewayListOptionsAssociationsDeviceId_example";  // string | If set, returns only the gateways with which the specified device is associated. The device ID can be numeric (num_id) or the user-defined string (id). For example, if 456 is specified, returns only the gateways to which the device with num_id 456 is bound. (optional) 
            var gatewayListOptionsAssociationsGatewayId = "gatewayListOptionsAssociationsGatewayId_example";  // string | If set, only devices associated with the specified gateway are returned. The gateway ID can be numeric (num_id) or the user-defined string (id). For example, if 123 is specified, only devices bound to the gateway with num_id 123 are returned (optional) 
            var gatewayListOptionsGatewayType = "gatewayListOptionsGatewayType_example";  // string | If GATEWAY is specified, only gateways are returned. If NON_GATEWAY is specified, only non-gateway devices are returned. If GATEWAY_TYPE_UNSPECIFIED is specified, all devices are returned. (optional) 

            try
            {
                ListDevicesOnlineResponse result = apiInstance.GetSubscriptionDevices(subscriptionId, pageNumber, pageSize, fieldMask, sortByClientOnline, deviceIds, deviceNumIds, gatewayListOptionsAssociationsDeviceId, gatewayListOptionsAssociationsGatewayId, gatewayListOptionsGatewayType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.GetSubscriptionDevices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSubscriptionDevicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ListDevicesOnlineResponse> response = apiInstance.GetSubscriptionDevicesWithHttpInfo(subscriptionId, pageNumber, pageSize, fieldMask, sortByClientOnline, deviceIds, deviceNumIds, gatewayListOptionsAssociationsDeviceId, gatewayListOptionsAssociationsGatewayId, gatewayListOptionsGatewayType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.GetSubscriptionDevicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **pageNumber** | **int?** | Page Number | [optional]  |
| **pageSize** | **int?** | The maximum number of devices to return in the response. If this value is zero, the service will select a default size.  | [optional]  |
| **fieldMask** | **string** | The fields of the Device resource to be returned to the response. The fields id and numId are always returned, along with any other fields specified. A comma-separated list of fully qualified names of fields. Example:  | [optional]  |
| **sortByClientOnline** | **bool?** | Set to true to return devices sorted by last heartbeat  | [optional]  |
| **deviceIds** | [**List&lt;string&gt;**](string.md) | A list of device string IDs. For example, [&#39;device0&#39;, &#39;device12&#39;]. If empty, this field is ignored. Maximum IDs: 10,000 | [optional]  |
| **deviceNumIds** | [**List&lt;string&gt;**](string.md) | A list of device numeric IDs. If empty, this field is ignored. Maximum IDs: 10,000. | [optional]  |
| **gatewayListOptionsAssociationsDeviceId** | **string** | If set, returns only the gateways with which the specified device is associated. The device ID can be numeric (num_id) or the user-defined string (id). For example, if 456 is specified, returns only the gateways to which the device with num_id 456 is bound. | [optional]  |
| **gatewayListOptionsAssociationsGatewayId** | **string** | If set, only devices associated with the specified gateway are returned. The gateway ID can be numeric (num_id) or the user-defined string (id). For example, if 123 is specified, only devices bound to the gateway with num_id 123 are returned | [optional]  |
| **gatewayListOptionsGatewayType** | **string** | If GATEWAY is specified, only gateways are returned. If NON_GATEWAY is specified, only non-gateway devices are returned. If GATEWAY_TYPE_UNSPECIFIED is specified, all devices are returned. | [optional]  |

### Return type

[**ListDevicesOnlineResponse**](ListDevicesOnlineResponse.md)

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="sendcommandtodevice"></a>
# **SendCommandToDevice**
> Object SendCommandToDevice (string subscriptionid, string registryId, string deviceId, DeviceCommand command)



Send A Command To A Device

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class SendCommandToDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionid = "subscriptionid_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var deviceId = "deviceId_example";  // string | Device ID
            var command = new DeviceCommand(); // DeviceCommand | application/json

            try
            {
                Object result = apiInstance.SendCommandToDevice(subscriptionid, registryId, deviceId, command);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.SendCommandToDevice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendCommandToDeviceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Object> response = apiInstance.SendCommandToDeviceWithHttpInfo(subscriptionid, registryId, deviceId, command);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.SendCommandToDeviceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionid** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **deviceId** | **string** | Device ID |  |
| **command** | [**DeviceCommand**](DeviceCommand.md) | application/json |  |

### Return type

**Object**

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="unbinddevice"></a>
# **UnBindDevice**
> Info UnBindDevice (string subscriptionId, string registryId, BindRequest unbind)



UnBind  a device from a gateway under a registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class UnBindDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var unbind = new BindRequest(); // BindRequest | application/json

            try
            {
                Info result = apiInstance.UnBindDevice(subscriptionId, registryId, unbind);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.UnBindDevice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnBindDeviceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Info> response = apiInstance.UnBindDeviceWithHttpInfo(subscriptionId, registryId, unbind);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.UnBindDeviceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **unbind** | [**BindRequest**](BindRequest.md) | application/json |  |

### Return type

[**Info**](Info.md)

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="unbinddevices"></a>
# **UnBindDevices**
> Info UnBindDevices (string subscriptionId, string registryId, BindRequestIdsGateway unbind)



UnBind devices from a gateway under a registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class UnBindDevicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var unbind = new BindRequestIdsGateway(); // BindRequestIdsGateway | application/json

            try
            {
                Info result = apiInstance.UnBindDevices(subscriptionId, registryId, unbind);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.UnBindDevices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UnBindDevicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Info> response = apiInstance.UnBindDevicesWithHttpInfo(subscriptionId, registryId, unbind);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.UnBindDevicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **unbind** | [**BindRequestIdsGateway**](BindRequestIdsGateway.md) | application/json |  |

### Return type

[**Info**](Info.md)

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="updateconfigurationtodevice"></a>
# **UpdateConfigurationToDevice**
> DeviceConfig UpdateConfigurationToDevice (string subscriptionid, string registryId, string deviceId, DeviceConfiguration configuration)



Update A Configuration Of A Device

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class UpdateConfigurationToDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionid = "subscriptionid_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var deviceId = "deviceId_example";  // string | Device ID
            var configuration = new DeviceConfiguration(); // DeviceConfiguration | application/json

            try
            {
                DeviceConfig result = apiInstance.UpdateConfigurationToDevice(subscriptionid, registryId, deviceId, configuration);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.UpdateConfigurationToDevice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateConfigurationToDeviceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeviceConfig> response = apiInstance.UpdateConfigurationToDeviceWithHttpInfo(subscriptionid, registryId, deviceId, configuration);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.UpdateConfigurationToDeviceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionid** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **deviceId** | **string** | Device ID |  |
| **configuration** | [**DeviceConfiguration**](DeviceConfiguration.md) | application/json |  |

### Return type

[**DeviceConfig**](DeviceConfig.md)

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="updatecustomonboardrequest"></a>
# **UpdateCustomOnboardRequest**
> Info UpdateCustomOnboardRequest (string subscriptionid, string registryId, string deviceId, CustomOnboard customOnboard)



Approve/Reject a Custom Onboard Request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class UpdateCustomOnboardRequestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionid = "subscriptionid_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var deviceId = "deviceId_example";  // string | Device ID
            var customOnboard = new CustomOnboard(); // CustomOnboard | application/json

            try
            {
                Info result = apiInstance.UpdateCustomOnboardRequest(subscriptionid, registryId, deviceId, customOnboard);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.UpdateCustomOnboardRequest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateCustomOnboardRequestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Info> response = apiInstance.UpdateCustomOnboardRequestWithHttpInfo(subscriptionid, registryId, deviceId, customOnboard);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.UpdateCustomOnboardRequestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionid** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **deviceId** | **string** | Device ID |  |
| **customOnboard** | [**CustomOnboard**](CustomOnboard.md) | application/json |  |

### Return type

[**Info**](Info.md)

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

<a name="updatedevice"></a>
# **UpdateDevice**
> Device UpdateDevice (string subscriptionId, string registryId, string deviceId, string updateMask, Device device)



Modify device under a registry

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class UpdateDeviceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.korewireless.com";
            // Configure API key authorization: apiKey
            config.AddApiKey("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var deviceId = "deviceId_example";  // string | Device ID
            var updateMask = "logLevel";  // string | Required. Only updates the device fields indicated by this mask. The field mask must not be empty, and it must not contain fields that are immutable or only set by the server. Mutable top-level fields: credentials,logLevel, blocked,policy and metadata
            var device = new Device(); // Device | application/json

            try
            {
                Device result = apiInstance.UpdateDevice(subscriptionId, registryId, deviceId, updateMask, device);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DeviceApi.UpdateDevice: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateDeviceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<Device> response = apiInstance.UpdateDeviceWithHttpInfo(subscriptionId, registryId, deviceId, updateMask, device);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DeviceApi.UpdateDeviceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **subscriptionId** | **string** | Subscription ID |  |
| **registryId** | **string** | Registry ID |  |
| **deviceId** | **string** | Device ID |  |
| **updateMask** | **string** | Required. Only updates the device fields indicated by this mask. The field mask must not be empty, and it must not contain fields that are immutable or only set by the server. Mutable top-level fields: credentials,logLevel, blocked,policy and metadata |  |
| **device** | [**Device**](Device.md) | application/json |  |

### Return type

[**Device**](Device.md)

### Authorization

[apiKey](../README.md#apiKey), [bearerAuth](../README.md#bearerAuth)

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

