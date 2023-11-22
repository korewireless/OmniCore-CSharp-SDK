/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.8.6
 * Contact: omnicoresupport@korewireless.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = OmniCore.Client.OpenAPIDateConverter;

namespace OmniCore.Model
{
    /// <summary>
    /// PublicKeyCredential
    /// </summary>
    [DataContract(Name = "PublicKeyCredential")]
    public partial class PublicKeyCredential : IEquatable<PublicKeyCredential>, IValidatableObject
    {
        /// <summary>
        /// Format: The format of the key.  Possible values:   \&quot;UNSPECIFIED_PUBLIC_KEY_FORMAT\&quot; - The format has not been specified. This is an invalid default value and must not be used.   \&quot;RSA_PEM\&quot; - An RSA public key encoded in base64, and wrapped by &#x60;- -- --BEGIN PUBLIC KEY- -- --&#x60; and &#x60;- -- --END PUBLIC KEY- -- --&#x60;. This can be used to verify &#x60;RS256&#x60; signatures in JWT tokens ([RFC7518]( https://www.ietf.org/rfc/rfc7518.txt)).   \&quot;RSA_X509_PEM\&quot; - As RSA_PEM, but wrapped in an X.509v3 certificate ([RFC5280]( https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;.   \&quot;ES256_PEM\&quot; - Public key for the ECDSA algorithm using P-256 and SHA-256, encoded in base64, and wrapped by &#x60;- -- --BEGIN PUBLIC KEY- -- --&#x60; and &#x60;- -- --END PUBLIC KEY- -- --&#x60;. This can be used to verify JWT tokens with the &#x60;ES256&#x60; algorithm ([RFC7518](https://www.ietf.org/rfc/rfc7518.txt)). This curve is defined in [OpenSSL](https://www.openssl.org/) as the &#x60;prime256v1&#x60; curve.   \&quot;ES256_X509_PEM\&quot; - As ES256_PEM, but wrapped in an X.509v3 certificate ([RFC5280]( https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;.
        /// </summary>
        /// <value>Format: The format of the key.  Possible values:   \&quot;UNSPECIFIED_PUBLIC_KEY_FORMAT\&quot; - The format has not been specified. This is an invalid default value and must not be used.   \&quot;RSA_PEM\&quot; - An RSA public key encoded in base64, and wrapped by &#x60;- -- --BEGIN PUBLIC KEY- -- --&#x60; and &#x60;- -- --END PUBLIC KEY- -- --&#x60;. This can be used to verify &#x60;RS256&#x60; signatures in JWT tokens ([RFC7518]( https://www.ietf.org/rfc/rfc7518.txt)).   \&quot;RSA_X509_PEM\&quot; - As RSA_PEM, but wrapped in an X.509v3 certificate ([RFC5280]( https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;.   \&quot;ES256_PEM\&quot; - Public key for the ECDSA algorithm using P-256 and SHA-256, encoded in base64, and wrapped by &#x60;- -- --BEGIN PUBLIC KEY- -- --&#x60; and &#x60;- -- --END PUBLIC KEY- -- --&#x60;. This can be used to verify JWT tokens with the &#x60;ES256&#x60; algorithm ([RFC7518](https://www.ietf.org/rfc/rfc7518.txt)). This curve is defined in [OpenSSL](https://www.openssl.org/) as the &#x60;prime256v1&#x60; curve.   \&quot;ES256_X509_PEM\&quot; - As ES256_PEM, but wrapped in an X.509v3 certificate ([RFC5280]( https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            /// <summary>
            /// Enum RSAPEM for value: RSA_PEM
            /// </summary>
            [EnumMember(Value = "RSA_PEM")]
            RSAPEM = 1,

            /// <summary>
            /// Enum ES256PEM for value: ES256_PEM
            /// </summary>
            [EnumMember(Value = "ES256_PEM")]
            ES256PEM = 2,

            /// <summary>
            /// Enum RSAX509PEM for value: RSA_X509_PEM
            /// </summary>
            [EnumMember(Value = "RSA_X509_PEM")]
            RSAX509PEM = 3,

            /// <summary>
            /// Enum ES256X509PEM for value: ES256_X509_PEM
            /// </summary>
            [EnumMember(Value = "ES256_X509_PEM")]
            ES256X509PEM = 4

        }


        /// <summary>
        /// Format: The format of the key.  Possible values:   \&quot;UNSPECIFIED_PUBLIC_KEY_FORMAT\&quot; - The format has not been specified. This is an invalid default value and must not be used.   \&quot;RSA_PEM\&quot; - An RSA public key encoded in base64, and wrapped by &#x60;- -- --BEGIN PUBLIC KEY- -- --&#x60; and &#x60;- -- --END PUBLIC KEY- -- --&#x60;. This can be used to verify &#x60;RS256&#x60; signatures in JWT tokens ([RFC7518]( https://www.ietf.org/rfc/rfc7518.txt)).   \&quot;RSA_X509_PEM\&quot; - As RSA_PEM, but wrapped in an X.509v3 certificate ([RFC5280]( https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;.   \&quot;ES256_PEM\&quot; - Public key for the ECDSA algorithm using P-256 and SHA-256, encoded in base64, and wrapped by &#x60;- -- --BEGIN PUBLIC KEY- -- --&#x60; and &#x60;- -- --END PUBLIC KEY- -- --&#x60;. This can be used to verify JWT tokens with the &#x60;ES256&#x60; algorithm ([RFC7518](https://www.ietf.org/rfc/rfc7518.txt)). This curve is defined in [OpenSSL](https://www.openssl.org/) as the &#x60;prime256v1&#x60; curve.   \&quot;ES256_X509_PEM\&quot; - As ES256_PEM, but wrapped in an X.509v3 certificate ([RFC5280]( https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;.
        /// </summary>
        /// <value>Format: The format of the key.  Possible values:   \&quot;UNSPECIFIED_PUBLIC_KEY_FORMAT\&quot; - The format has not been specified. This is an invalid default value and must not be used.   \&quot;RSA_PEM\&quot; - An RSA public key encoded in base64, and wrapped by &#x60;- -- --BEGIN PUBLIC KEY- -- --&#x60; and &#x60;- -- --END PUBLIC KEY- -- --&#x60;. This can be used to verify &#x60;RS256&#x60; signatures in JWT tokens ([RFC7518]( https://www.ietf.org/rfc/rfc7518.txt)).   \&quot;RSA_X509_PEM\&quot; - As RSA_PEM, but wrapped in an X.509v3 certificate ([RFC5280]( https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;.   \&quot;ES256_PEM\&quot; - Public key for the ECDSA algorithm using P-256 and SHA-256, encoded in base64, and wrapped by &#x60;- -- --BEGIN PUBLIC KEY- -- --&#x60; and &#x60;- -- --END PUBLIC KEY- -- --&#x60;. This can be used to verify JWT tokens with the &#x60;ES256&#x60; algorithm ([RFC7518](https://www.ietf.org/rfc/rfc7518.txt)). This curve is defined in [OpenSSL](https://www.openssl.org/) as the &#x60;prime256v1&#x60; curve.   \&quot;ES256_X509_PEM\&quot; - As ES256_PEM, but wrapped in an X.509v3 certificate ([RFC5280]( https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;.</value>
        [DataMember(Name = "format", IsRequired = true, EmitDefaultValue = true)]
        public FormatEnum Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyCredential" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PublicKeyCredential() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyCredential" /> class.
        /// </summary>
        /// <param name="format">Format: The format of the key.  Possible values:   \&quot;UNSPECIFIED_PUBLIC_KEY_FORMAT\&quot; - The format has not been specified. This is an invalid default value and must not be used.   \&quot;RSA_PEM\&quot; - An RSA public key encoded in base64, and wrapped by &#x60;- -- --BEGIN PUBLIC KEY- -- --&#x60; and &#x60;- -- --END PUBLIC KEY- -- --&#x60;. This can be used to verify &#x60;RS256&#x60; signatures in JWT tokens ([RFC7518]( https://www.ietf.org/rfc/rfc7518.txt)).   \&quot;RSA_X509_PEM\&quot; - As RSA_PEM, but wrapped in an X.509v3 certificate ([RFC5280]( https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;.   \&quot;ES256_PEM\&quot; - Public key for the ECDSA algorithm using P-256 and SHA-256, encoded in base64, and wrapped by &#x60;- -- --BEGIN PUBLIC KEY- -- --&#x60; and &#x60;- -- --END PUBLIC KEY- -- --&#x60;. This can be used to verify JWT tokens with the &#x60;ES256&#x60; algorithm ([RFC7518](https://www.ietf.org/rfc/rfc7518.txt)). This curve is defined in [OpenSSL](https://www.openssl.org/) as the &#x60;prime256v1&#x60; curve.   \&quot;ES256_X509_PEM\&quot; - As ES256_PEM, but wrapped in an X.509v3 certificate ([RFC5280]( https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;. (required).</param>
        /// <param name="key">Key: The key data..</param>
        public PublicKeyCredential(FormatEnum format = default(FormatEnum), string key = default(string))
        {
            this.Format = format;
            this.Key = key;
        }

        /// <summary>
        /// Key: The key data.
        /// </summary>
        /// <value>Key: The key data.</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublicKeyCredential {\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicKeyCredential);
        }

        /// <summary>
        /// Returns true if PublicKeyCredential instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicKeyCredential to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicKeyCredential input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Format == input.Format ||
                    this.Format.Equals(input.Format)
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Format.GetHashCode();
                if (this.Key != null)
                {
                    hashCode = (hashCode * 59) + this.Key.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
