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
    /// GatewayConfig
    /// </summary>
    [DataContract(Name = "GatewayConfig")]
    public partial class GatewayConfig : IEquatable<GatewayConfig>, IValidatableObject
    {
        /// <summary>
        /// Defines GatewayAuthMethod
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GatewayAuthMethodEnum
        {
            /// <summary>
            /// Enum GATEWAYAUTHMETHODUNSPECIFIED for value: GATEWAY_AUTH_METHOD_UNSPECIFIED
            /// </summary>
            [EnumMember(Value = "GATEWAY_AUTH_METHOD_UNSPECIFIED")]
            GATEWAYAUTHMETHODUNSPECIFIED = 1,

            /// <summary>
            /// Enum ASSOCIATIONONLY for value: ASSOCIATION_ONLY
            /// </summary>
            [EnumMember(Value = "ASSOCIATION_ONLY")]
            ASSOCIATIONONLY = 2,

            /// <summary>
            /// Enum DEVICEAUTHTOKENONLY for value: DEVICE_AUTH_TOKEN_ONLY
            /// </summary>
            [EnumMember(Value = "DEVICE_AUTH_TOKEN_ONLY")]
            DEVICEAUTHTOKENONLY = 3,

            /// <summary>
            /// Enum ASSOCIATIONANDDEVICEAUTHTOKEN for value: ASSOCIATION_AND_DEVICE_AUTH_TOKEN
            /// </summary>
            [EnumMember(Value = "ASSOCIATION_AND_DEVICE_AUTH_TOKEN")]
            ASSOCIATIONANDDEVICEAUTHTOKEN = 4

        }


        /// <summary>
        /// Gets or Sets GatewayAuthMethod
        /// </summary>
        [DataMember(Name = "gatewayAuthMethod", EmitDefaultValue = false)]
        public GatewayAuthMethodEnum? GatewayAuthMethod { get; set; }
        /// <summary>
        /// Defines GatewayType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GatewayTypeEnum
        {
            /// <summary>
            /// Enum NONGATEWAY for value: NON_GATEWAY
            /// </summary>
            [EnumMember(Value = "NON_GATEWAY")]
            NONGATEWAY = 1,

            /// <summary>
            /// Enum GATEWAY for value: GATEWAY
            /// </summary>
            [EnumMember(Value = "GATEWAY")]
            GATEWAY = 2

        }


        /// <summary>
        /// Gets or Sets GatewayType
        /// </summary>
        [DataMember(Name = "gatewayType", EmitDefaultValue = false)]
        public GatewayTypeEnum? GatewayType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GatewayConfig" /> class.
        /// </summary>
        /// <param name="gatewayAuthMethod">gatewayAuthMethod.</param>
        /// <param name="gatewayType">gatewayType.</param>
        public GatewayConfig(GatewayAuthMethodEnum? gatewayAuthMethod = default(GatewayAuthMethodEnum?), GatewayTypeEnum? gatewayType = default(GatewayTypeEnum?))
        {
            this.GatewayAuthMethod = gatewayAuthMethod;
            this.GatewayType = gatewayType;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GatewayConfig {\n");
            sb.Append("  GatewayAuthMethod: ").Append(GatewayAuthMethod).Append("\n");
            sb.Append("  GatewayType: ").Append(GatewayType).Append("\n");
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
            return this.Equals(input as GatewayConfig);
        }

        /// <summary>
        /// Returns true if GatewayConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of GatewayConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GatewayConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GatewayAuthMethod == input.GatewayAuthMethod ||
                    this.GatewayAuthMethod.Equals(input.GatewayAuthMethod)
                ) && 
                (
                    this.GatewayType == input.GatewayType ||
                    this.GatewayType.Equals(input.GatewayType)
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
                hashCode = (hashCode * 59) + this.GatewayAuthMethod.GetHashCode();
                hashCode = (hashCode * 59) + this.GatewayType.GetHashCode();
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
