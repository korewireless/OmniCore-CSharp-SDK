/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.8.7
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
    /// DeviceConfig
    /// </summary>
    [DataContract(Name = "DeviceConfig")]
    public partial class DeviceConfig : IEquatable<DeviceConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceConfig" /> class.
        /// </summary>
        /// <param name="acknowledged">acknowledged.</param>
        /// <param name="binaryData">Base64 Encoded Comnfig String.</param>
        /// <param name="cloudUpdateTime">cloudUpdateTime.</param>
        /// <param name="deviceAckTime">deviceAckTime.</param>
        /// <param name="version">version.</param>
        public DeviceConfig(bool acknowledged = default(bool), string binaryData = default(string), string cloudUpdateTime = default(string), string deviceAckTime = default(string), int version = default(int))
        {
            this.Acknowledged = acknowledged;
            this.BinaryData = binaryData;
            this.CloudUpdateTime = cloudUpdateTime;
            this.DeviceAckTime = deviceAckTime;
            this._Version = version;
        }

        /// <summary>
        /// Gets or Sets Acknowledged
        /// </summary>
        [DataMember(Name = "acknowledged", EmitDefaultValue = true)]
        public bool Acknowledged { get; set; }

        /// <summary>
        /// Base64 Encoded Comnfig String
        /// </summary>
        /// <value>Base64 Encoded Comnfig String</value>
        [DataMember(Name = "binaryData", EmitDefaultValue = false)]
        public string BinaryData { get; set; }

        /// <summary>
        /// Gets or Sets CloudUpdateTime
        /// </summary>
        [DataMember(Name = "cloudUpdateTime", EmitDefaultValue = false)]
        public string CloudUpdateTime { get; set; }

        /// <summary>
        /// Gets or Sets DeviceAckTime
        /// </summary>
        [DataMember(Name = "deviceAckTime", EmitDefaultValue = false)]
        public string DeviceAckTime { get; set; }

        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int _Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceConfig {\n");
            sb.Append("  Acknowledged: ").Append(Acknowledged).Append("\n");
            sb.Append("  BinaryData: ").Append(BinaryData).Append("\n");
            sb.Append("  CloudUpdateTime: ").Append(CloudUpdateTime).Append("\n");
            sb.Append("  DeviceAckTime: ").Append(DeviceAckTime).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
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
            return this.Equals(input as DeviceConfig);
        }

        /// <summary>
        /// Returns true if DeviceConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Acknowledged == input.Acknowledged ||
                    this.Acknowledged.Equals(input.Acknowledged)
                ) && 
                (
                    this.BinaryData == input.BinaryData ||
                    (this.BinaryData != null &&
                    this.BinaryData.Equals(input.BinaryData))
                ) && 
                (
                    this.CloudUpdateTime == input.CloudUpdateTime ||
                    (this.CloudUpdateTime != null &&
                    this.CloudUpdateTime.Equals(input.CloudUpdateTime))
                ) && 
                (
                    this.DeviceAckTime == input.DeviceAckTime ||
                    (this.DeviceAckTime != null &&
                    this.DeviceAckTime.Equals(input.DeviceAckTime))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
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
                hashCode = (hashCode * 59) + this.Acknowledged.GetHashCode();
                if (this.BinaryData != null)
                {
                    hashCode = (hashCode * 59) + this.BinaryData.GetHashCode();
                }
                if (this.CloudUpdateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CloudUpdateTime.GetHashCode();
                }
                if (this.DeviceAckTime != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceAckTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
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
