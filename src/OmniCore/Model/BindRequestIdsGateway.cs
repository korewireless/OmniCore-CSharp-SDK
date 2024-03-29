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
    /// BindRequestIdsGateway
    /// </summary>
    [DataContract(Name = "bindRequestIdsGateway")]
    public partial class BindRequestIdsGateway : IEquatable<BindRequestIdsGateway>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BindRequestIdsGateway" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BindRequestIdsGateway() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BindRequestIdsGateway" /> class.
        /// </summary>
        /// <param name="deviceIds">deviceIds (required).</param>
        /// <param name="gatewayId">gatewayId (required).</param>
        public BindRequestIdsGateway(List<string> deviceIds = default(List<string>), string gatewayId = default(string))
        {
            // to ensure "deviceIds" is required (not null)
            if (deviceIds == null)
            {
                throw new ArgumentNullException("deviceIds is a required property for BindRequestIdsGateway and cannot be null");
            }
            this.DeviceIds = deviceIds;
            // to ensure "gatewayId" is required (not null)
            if (gatewayId == null)
            {
                throw new ArgumentNullException("gatewayId is a required property for BindRequestIdsGateway and cannot be null");
            }
            this.GatewayId = gatewayId;
        }

        /// <summary>
        /// Gets or Sets DeviceIds
        /// </summary>
        [DataMember(Name = "deviceIds", IsRequired = true, EmitDefaultValue = true)]
        public List<string> DeviceIds { get; set; }

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
            sb.Append("class BindRequestIdsGateway {\n");
            sb.Append("  DeviceIds: ").Append(DeviceIds).Append("\n");
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
            return this.Equals(input as BindRequestIdsGateway);
        }

        /// <summary>
        /// Returns true if BindRequestIdsGateway instances are equal
        /// </summary>
        /// <param name="input">Instance of BindRequestIdsGateway to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BindRequestIdsGateway input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeviceIds == input.DeviceIds ||
                    this.DeviceIds != null &&
                    input.DeviceIds != null &&
                    this.DeviceIds.SequenceEqual(input.DeviceIds)
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
                if (this.DeviceIds != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceIds.GetHashCode();
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
