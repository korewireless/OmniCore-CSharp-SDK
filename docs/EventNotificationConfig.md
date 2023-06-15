# OmniCore.Model.EventNotificationConfig

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PubsubTopicName** | **string** | PubsubTopicName: A Topic name. For example, &#x60;projects/myProject/topics/deviceEvents&#x60;. | [optional] 
**IsGcpPubSub** | **bool** | Describe whether the topic is Gcp pubsub topic or Omni topic | [optional] 
**SubfolderMatches** | **string** | SubfolderMatches: If the subfolder name matches this string exactly, this configuration will be used. The string must not include the leading &#39;/&#39; character. If empty, all strings are matched. This field is used only for telemetry events; subfolders are not supported for state changes. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

