# OmniCore - the C# library for the OmniCore Model and State Management API

This is an OmniCore Model and State Management server.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [http://www.korewireless.com](http://www.korewireless.com)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;
```
<a name="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using OmniCore.Api;
using OmniCore.Client;
using OmniCore.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://demo-api.omnicore.cloud.korewireless.com";
            // Configure API key authorization: apiKey
            config.ApiKey.Add("x-api-key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("x-api-key", "Bearer");
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DeviceApi(config);
            var subscriptionId = "subscriptionId_example";  // string | Subscription ID
            var registryId = "registryId_example";  // string | Registry ID
            var device = new BindRequest(); // BindRequest | application/json

            try
            {
                Info result = apiInstance.BindDevice(subscriptionId, registryId, device);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DeviceApi.BindDevice: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://demo-api.omnicore.cloud.korewireless.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DeviceApi* | [**BindDevice**](docs/DeviceApi.md#binddevice) | **POST** /model-state-management/subscriptions/{subscriptionId}/registries/{registryId}/bindDeviceToGateway | 
*DeviceApi* | [**BindDevices**](docs/DeviceApi.md#binddevices) | **POST** /model-state-management/subscriptions/{subscriptionId}/registries/{registryId}/bindDevicesToGateway | 
*DeviceApi* | [**BlockDeviceCommuncation**](docs/DeviceApi.md#blockdevicecommuncation) | **PUT** /model-state-management/subscriptions/{subscriptionid}/registries/{registryId}/devices/{deviceId}/communication | 
*DeviceApi* | [**CreateDevice**](docs/DeviceApi.md#createdevice) | **POST** /model-state-management/subscriptions/{subscriptionId}/registries/{registryId}/devices | 
*DeviceApi* | [**DeleteDevice**](docs/DeviceApi.md#deletedevice) | **DELETE** /model-state-management/subscriptions/{subscriptionId}/registries/{registryId}/devices/{deviceId} | 
*DeviceApi* | [**GetConfig**](docs/DeviceApi.md#getconfig) | **GET** /model-state-management/subscriptions/{subscriptionid}/registries/{registryId}/devices/{deviceId}/configVersions | 
*DeviceApi* | [**GetDevice**](docs/DeviceApi.md#getdevice) | **GET** /model-state-management/subscriptions/{subscriptionId}/registries/{registryId}/devices/{deviceId} | 
*DeviceApi* | [**GetDevices**](docs/DeviceApi.md#getdevices) | **GET** /model-state-management/subscriptions/{subscriptionId}/registries/{registryId}/devices | 
*DeviceApi* | [**GetStates**](docs/DeviceApi.md#getstates) | **GET** /model-state-management/subscriptions/{subscriptionid}/registries/{registryId}/devices/{deviceId}/states | 
*DeviceApi* | [**SendCommandToDevice**](docs/DeviceApi.md#sendcommandtodevice) | **POST** /model-state-management/subscriptions/{subscriptionid}/registries/{registryId}/devices/{deviceId}/sendCommandToDevice | 
*DeviceApi* | [**UnBindDevice**](docs/DeviceApi.md#unbinddevice) | **POST** /model-state-management/subscriptions/{subscriptionId}/registries/{registryId}/unbindDeviceFromGateway | 
*DeviceApi* | [**UnBindDevices**](docs/DeviceApi.md#unbinddevices) | **POST** /model-state-management/subscriptions/{subscriptionId}/registries/{registryId}/unbindDevicesFromGateway | 
*DeviceApi* | [**UpdateConfigurationToDevice**](docs/DeviceApi.md#updateconfigurationtodevice) | **POST** /model-state-management/subscriptions/{subscriptionid}/registries/{registryId}/devices/{deviceId}/updateConfigurationToDevice | 
*DeviceApi* | [**UpdateDevice**](docs/DeviceApi.md#updatedevice) | **PATCH** /model-state-management/subscriptions/{subscriptionId}/registries/{registryId}/devices/{deviceId} | 
*RegistryApi* | [**CreateRegistry**](docs/RegistryApi.md#createregistry) | **POST** /model-state-management/subscriptions/{subscriptionId}/registries | 
*RegistryApi* | [**DeleteRegistry**](docs/RegistryApi.md#deleteregistry) | **DELETE** /model-state-management/subscriptions/{subscriptionId}/registries/{registryId} | 
*RegistryApi* | [**GetRegistries**](docs/RegistryApi.md#getregistries) | **GET** /model-state-management/subscriptions/{subscriptionId}/registries | 
*RegistryApi* | [**GetRegistry**](docs/RegistryApi.md#getregistry) | **GET** /model-state-management/subscriptions/{subscriptionId}/registries/{registryId} | 
*RegistryApi* | [**UpdateRegistry**](docs/RegistryApi.md#updateregistry) | **PATCH** /model-state-management/subscriptions/{subscriptionId}/registries/{registryId} | 


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BindRequest](docs/BindRequest.md)
 - [Model.BindRequestIdsGateway](docs/BindRequestIdsGateway.md)
 - [Model.BlockCommunicationBody](docs/BlockCommunicationBody.md)
 - [Model.Device](docs/Device.md)
 - [Model.DeviceCommand](docs/DeviceCommand.md)
 - [Model.DeviceConfig](docs/DeviceConfig.md)
 - [Model.DeviceConfiguration](docs/DeviceConfiguration.md)
 - [Model.DeviceCredential](docs/DeviceCredential.md)
 - [Model.DeviceRegistry](docs/DeviceRegistry.md)
 - [Model.DeviceState](docs/DeviceState.md)
 - [Model.ErrorFrame](docs/ErrorFrame.md)
 - [Model.ErrorStatus](docs/ErrorStatus.md)
 - [Model.EventNotificationConfig](docs/EventNotificationConfig.md)
 - [Model.GatewayConfig](docs/GatewayConfig.md)
 - [Model.GenericErrorResponse](docs/GenericErrorResponse.md)
 - [Model.HttpConfig](docs/HttpConfig.md)
 - [Model.Info](docs/Info.md)
 - [Model.ListDeviceConfigVersionsResponse](docs/ListDeviceConfigVersionsResponse.md)
 - [Model.ListDeviceRegistries](docs/ListDeviceRegistries.md)
 - [Model.ListDeviceStatesResponse](docs/ListDeviceStatesResponse.md)
 - [Model.ListDevicesResponse](docs/ListDevicesResponse.md)
 - [Model.LogLevel](docs/LogLevel.md)
 - [Model.MqttConfig](docs/MqttConfig.md)
 - [Model.NotificationConfig](docs/NotificationConfig.md)
 - [Model.PublicKeyCertificate](docs/PublicKeyCertificate.md)
 - [Model.PublicKeyCredential](docs/PublicKeyCredential.md)
 - [Model.RegistryCredential](docs/RegistryCredential.md)
 - [Model.X509CertificateDetails](docs/X509CertificateDetails.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="bearerAuth"></a>
### bearerAuth

- **Type**: Bearer Authentication

<a name="apiKey"></a>
### apiKey

- **Type**: API key
- **API key parameter name**: x-api-key
- **Location**: HTTP header

