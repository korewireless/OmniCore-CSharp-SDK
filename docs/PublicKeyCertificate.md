# OmniCore.Model.PublicKeyCertificate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Certificate** | **string** | Certificate: The certificate data. | [optional] 
**Format** | **string** | Format: The certificate format.  Possible values:   \&quot;UNSPECIFIED_PUBLIC_KEY_CERTIFICATE_FORMAT\&quot; - The format has not been specified. This is an invalid default value and must not be used.   \&quot;X509_CERTIFICATE_PEM\&quot; - An X.509v3 certificate ([RFC5280](https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;. | [optional] 
**X509Details** | [**X509CertificateDetails**](X509CertificateDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

