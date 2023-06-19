# OmniCore.Model.DeviceRegistry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | 
**Name** | **string** |  | [optional] [readonly] 
**Parent** | **string** |  | [optional] [readonly] 
**CreatedOn** | **string** |  | [optional] [readonly] 
**UpdatedOn** | **string** |  | [optional] [readonly] 
**Credentials** | [**List&lt;RegistryCredential&gt;**](RegistryCredential.md) |  | [optional] 
**HttpConfig** | [**HttpConfig**](HttpConfig.md) |  | [optional] 
**MqttConfig** | [**MqttConfig**](MqttConfig.md) |  | [optional] 
**LogLevel** | **LogLevel** |  | [optional] 
**IsNatsRoute** | **bool** |  | [optional] 
**EventNotificationConfigs** | [**List&lt;EventNotificationConfig&gt;**](EventNotificationConfig.md) |  | [optional] 
**LogNotificationConfig** | [**NotificationConfig**](NotificationConfig.md) |  | [optional] 
**StateNotificationConfig** | [**NotificationConfig**](NotificationConfig.md) |  | [optional] 
**CustomOnboardNotificationConfig** | [**NotificationConfig**](NotificationConfig.md) |  | [optional] 
**CustomOnboardEnabled** | **bool** |  | [optional] 
**NumberOfDevices** | **int** |  | [optional] [readonly] 
**NumberOfGateways** | **int** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

