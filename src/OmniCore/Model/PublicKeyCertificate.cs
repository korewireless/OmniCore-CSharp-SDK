/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.8.10
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
    /// PublicKeyCertificate
    /// </summary>
    [DataContract(Name = "PublicKeyCertificate")]
    public partial class PublicKeyCertificate : IEquatable<PublicKeyCertificate>, IValidatableObject
    {
        /// <summary>
        /// Format: The certificate format.  Possible values:   \&quot;UNSPECIFIED_PUBLIC_KEY_CERTIFICATE_FORMAT\&quot; - The format has not been specified. This is an invalid default value and must not be used.   \&quot;X509_CERTIFICATE_PEM\&quot; - An X.509v3 certificate ([RFC5280](https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;.
        /// </summary>
        /// <value>Format: The certificate format.  Possible values:   \&quot;UNSPECIFIED_PUBLIC_KEY_CERTIFICATE_FORMAT\&quot; - The format has not been specified. This is an invalid default value and must not be used.   \&quot;X509_CERTIFICATE_PEM\&quot; - An X.509v3 certificate ([RFC5280](https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormatEnum
        {
            /// <summary>
            /// Enum X509CERTIFICATEPEM for value: X509_CERTIFICATE_PEM
            /// </summary>
            [EnumMember(Value = "X509_CERTIFICATE_PEM")]
            X509CERTIFICATEPEM = 1

        }


        /// <summary>
        /// Format: The certificate format.  Possible values:   \&quot;UNSPECIFIED_PUBLIC_KEY_CERTIFICATE_FORMAT\&quot; - The format has not been specified. This is an invalid default value and must not be used.   \&quot;X509_CERTIFICATE_PEM\&quot; - An X.509v3 certificate ([RFC5280](https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;.
        /// </summary>
        /// <value>Format: The certificate format.  Possible values:   \&quot;UNSPECIFIED_PUBLIC_KEY_CERTIFICATE_FORMAT\&quot; - The format has not been specified. This is an invalid default value and must not be used.   \&quot;X509_CERTIFICATE_PEM\&quot; - An X.509v3 certificate ([RFC5280](https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;.</value>
        [DataMember(Name = "format", EmitDefaultValue = false)]
        public FormatEnum? Format { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PublicKeyCertificate" /> class.
        /// </summary>
        /// <param name="certificate">Certificate: The certificate data..</param>
        /// <param name="format">Format: The certificate format.  Possible values:   \&quot;UNSPECIFIED_PUBLIC_KEY_CERTIFICATE_FORMAT\&quot; - The format has not been specified. This is an invalid default value and must not be used.   \&quot;X509_CERTIFICATE_PEM\&quot; - An X.509v3 certificate ([RFC5280](https://www.ietf.org/rfc/rfc5280.txt)), encoded in base64, and wrapped by &#x60;- -- --BEGIN CERTIFICATE- -- --&#x60; and &#x60;- -- --END CERTIFICATE- -- --&#x60;..</param>
        /// <param name="x509Details">x509Details.</param>
        public PublicKeyCertificate(string certificate = default(string), FormatEnum? format = default(FormatEnum?), X509CertificateDetails x509Details = default(X509CertificateDetails))
        {
            this.Certificate = certificate;
            this.Format = format;
            this.X509Details = x509Details;
        }

        /// <summary>
        /// Certificate: The certificate data.
        /// </summary>
        /// <value>Certificate: The certificate data.</value>
        [DataMember(Name = "certificate", EmitDefaultValue = false)]
        public string Certificate { get; set; }

        /// <summary>
        /// Gets or Sets X509Details
        /// </summary>
        [DataMember(Name = "x509Details", EmitDefaultValue = false)]
        public X509CertificateDetails X509Details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PublicKeyCertificate {\n");
            sb.Append("  Certificate: ").Append(Certificate).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  X509Details: ").Append(X509Details).Append("\n");
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
            return this.Equals(input as PublicKeyCertificate);
        }

        /// <summary>
        /// Returns true if PublicKeyCertificate instances are equal
        /// </summary>
        /// <param name="input">Instance of PublicKeyCertificate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PublicKeyCertificate input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Certificate == input.Certificate ||
                    (this.Certificate != null &&
                    this.Certificate.Equals(input.Certificate))
                ) && 
                (
                    this.Format == input.Format ||
                    this.Format.Equals(input.Format)
                ) && 
                (
                    this.X509Details == input.X509Details ||
                    (this.X509Details != null &&
                    this.X509Details.Equals(input.X509Details))
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
                if (this.Certificate != null)
                {
                    hashCode = (hashCode * 59) + this.Certificate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Format.GetHashCode();
                if (this.X509Details != null)
                {
                    hashCode = (hashCode * 59) + this.X509Details.GetHashCode();
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
