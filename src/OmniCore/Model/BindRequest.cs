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
    /// BindRequest
    /// </summary>
    [DataContract(Name = "bindRequest")]
    public partial class BindRequest : IEquatable<BindRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BindRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BindRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BindRequest" /> class.
        /// </summary>
        /// <param name="deviceId">deviceId (required).</param>
        /// <param name="gatewayId">gatewayId (required).</param>
        public BindRequest(string deviceId = default(string), string gatewayId = default(string))
        {
            // to ensure "deviceId" is required (not null)
            if (deviceId == null)
            {
                throw new ArgumentNullException("deviceId is a required property for BindRequest and cannot be null");
            }
            this.DeviceId = deviceId;
            // to ensure "gatewayId" is required (not null)
            if (gatewayId == null)
            {
                throw new ArgumentNullException("gatewayId is a required property for BindRequest and cannot be null");
            }
            this.GatewayId = gatewayId;
        }

        /// <summary>
        /// Gets or Sets DeviceId
        /// </summary>
        [DataMember(Name = "deviceId", IsRequired = true, EmitDefaultValue = true)]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or Sets GatewayId
        /// </summary>
        [DataMember(Name = "gatewayId", IsRequired = true, EmitDefaultValue = true)]
        public string GatewayId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BindRequest {\n");
            sb.Append("  DeviceId: ").Append(DeviceId).Append("\n");
            sb.Append("  GatewayId: ").Append(GatewayId).Append("\n");
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
            return this.Equals(input as BindRequest);
        }

        /// <summary>
        /// Returns true if BindRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of BindRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BindRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeviceId == input.DeviceId ||
                    (this.DeviceId != null &&
                    this.DeviceId.Equals(input.DeviceId))
                ) && 
                (
                    this.GatewayId == input.GatewayId ||
                    (this.GatewayId != null &&
                    this.GatewayId.Equals(input.GatewayId))
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
                if (this.DeviceId != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceId.GetHashCode();
                }
                if (this.GatewayId != null)
                {
                    hashCode = (hashCode * 59) + this.GatewayId.GetHashCode();
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
