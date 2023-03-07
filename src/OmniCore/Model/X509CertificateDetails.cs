/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: support@korewireless.com
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
    /// X509CertificateDetails
    /// </summary>
    [DataContract(Name = "X509CertificateDetails")]
    public partial class X509CertificateDetails : IEquatable<X509CertificateDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="X509CertificateDetails" /> class.
        /// </summary>
        /// <param name="expiryTime">ExpiryTime: The time the certificate becomes invalid..</param>
        /// <param name="issuer">Issuer: The entity that signed the certificate..</param>
        /// <param name="publicKeyType">PublicKeyType: The type of public key in the certificate..</param>
        /// <param name="signatureAlgorithm">SignatureAlgorithm: The algorithm used to sign the certificate..</param>
        /// <param name="startTime">StartTime: The time the certificate becomes valid..</param>
        /// <param name="subject">Subject: The entity the certificate and public key belong to..</param>
        public X509CertificateDetails(string expiryTime = default(string), string issuer = default(string), string publicKeyType = default(string), string signatureAlgorithm = default(string), string startTime = default(string), string subject = default(string))
        {
            this.ExpiryTime = expiryTime;
            this.Issuer = issuer;
            this.PublicKeyType = publicKeyType;
            this.SignatureAlgorithm = signatureAlgorithm;
            this.StartTime = startTime;
            this.Subject = subject;
        }

        /// <summary>
        /// ExpiryTime: The time the certificate becomes invalid.
        /// </summary>
        /// <value>ExpiryTime: The time the certificate becomes invalid.</value>
        [DataMember(Name = "expiryTime", EmitDefaultValue = false)]
        public string ExpiryTime { get; set; }

        /// <summary>
        /// Issuer: The entity that signed the certificate.
        /// </summary>
        /// <value>Issuer: The entity that signed the certificate.</value>
        [DataMember(Name = "issuer", EmitDefaultValue = false)]
        public string Issuer { get; set; }

        /// <summary>
        /// PublicKeyType: The type of public key in the certificate.
        /// </summary>
        /// <value>PublicKeyType: The type of public key in the certificate.</value>
        [DataMember(Name = "publicKeyType", EmitDefaultValue = false)]
        public string PublicKeyType { get; set; }

        /// <summary>
        /// SignatureAlgorithm: The algorithm used to sign the certificate.
        /// </summary>
        /// <value>SignatureAlgorithm: The algorithm used to sign the certificate.</value>
        [DataMember(Name = "signatureAlgorithm", EmitDefaultValue = false)]
        public string SignatureAlgorithm { get; set; }

        /// <summary>
        /// StartTime: The time the certificate becomes valid.
        /// </summary>
        /// <value>StartTime: The time the certificate becomes valid.</value>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public string StartTime { get; set; }

        /// <summary>
        /// Subject: The entity the certificate and public key belong to.
        /// </summary>
        /// <value>Subject: The entity the certificate and public key belong to.</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class X509CertificateDetails {\n");
            sb.Append("  ExpiryTime: ").Append(ExpiryTime).Append("\n");
            sb.Append("  Issuer: ").Append(Issuer).Append("\n");
            sb.Append("  PublicKeyType: ").Append(PublicKeyType).Append("\n");
            sb.Append("  SignatureAlgorithm: ").Append(SignatureAlgorithm).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as X509CertificateDetails);
        }

        /// <summary>
        /// Returns true if X509CertificateDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of X509CertificateDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(X509CertificateDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExpiryTime == input.ExpiryTime ||
                    (this.ExpiryTime != null &&
                    this.ExpiryTime.Equals(input.ExpiryTime))
                ) && 
                (
                    this.Issuer == input.Issuer ||
                    (this.Issuer != null &&
                    this.Issuer.Equals(input.Issuer))
                ) && 
                (
                    this.PublicKeyType == input.PublicKeyType ||
                    (this.PublicKeyType != null &&
                    this.PublicKeyType.Equals(input.PublicKeyType))
                ) && 
                (
                    this.SignatureAlgorithm == input.SignatureAlgorithm ||
                    (this.SignatureAlgorithm != null &&
                    this.SignatureAlgorithm.Equals(input.SignatureAlgorithm))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                if (this.ExpiryTime != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiryTime.GetHashCode();
                }
                if (this.Issuer != null)
                {
                    hashCode = (hashCode * 59) + this.Issuer.GetHashCode();
                }
                if (this.PublicKeyType != null)
                {
                    hashCode = (hashCode * 59) + this.PublicKeyType.GetHashCode();
                }
                if (this.SignatureAlgorithm != null)
                {
                    hashCode = (hashCode * 59) + this.SignatureAlgorithm.GetHashCode();
                }
                if (this.StartTime != null)
                {
                    hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
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
