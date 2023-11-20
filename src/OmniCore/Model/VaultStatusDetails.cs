/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.8.3
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
    /// VaultStatusDetails
    /// </summary>
    [DataContract(Name = "VaultStatus_details")]
    public partial class VaultStatusDetails : IEquatable<VaultStatusDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VaultStatusDetails" /> class.
        /// </summary>
        /// <param name="subscriptionId">subscriptionId.</param>
        /// <param name="storageType">storageType.</param>
        /// <param name="isEnabled">isEnabled.</param>
        /// <param name="isCreated">isCreated.</param>
        /// <param name="updatedon">updatedon.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="mqttId">mqttId.</param>
        public VaultStatusDetails(string subscriptionId = default(string), string storageType = default(string), bool isEnabled = default(bool), bool isCreated = default(bool), string updatedon = default(string), string createdOn = default(string), string mqttId = default(string))
        {
            this.SubscriptionId = subscriptionId;
            this.StorageType = storageType;
            this.IsEnabled = isEnabled;
            this.IsCreated = isCreated;
            this.Updatedon = updatedon;
            this.CreatedOn = createdOn;
            this.MqttId = mqttId;
        }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name = "subscriptionId", EmitDefaultValue = false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets StorageType
        /// </summary>
        [DataMember(Name = "storageType", EmitDefaultValue = false)]
        public string StorageType { get; set; }

        /// <summary>
        /// Gets or Sets IsEnabled
        /// </summary>
        [DataMember(Name = "isEnabled", EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets IsCreated
        /// </summary>
        [DataMember(Name = "isCreated", EmitDefaultValue = true)]
        public bool IsCreated { get; set; }

        /// <summary>
        /// Gets or Sets Updatedon
        /// </summary>
        [DataMember(Name = "updatedon", EmitDefaultValue = false)]
        public string Updatedon { get; set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public string CreatedOn { get; set; }

        /// <summary>
        /// Gets or Sets MqttId
        /// </summary>
        [DataMember(Name = "MqttId", EmitDefaultValue = false)]
        public string MqttId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VaultStatusDetails {\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  StorageType: ").Append(StorageType).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  IsCreated: ").Append(IsCreated).Append("\n");
            sb.Append("  Updatedon: ").Append(Updatedon).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  MqttId: ").Append(MqttId).Append("\n");
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
            return this.Equals(input as VaultStatusDetails);
        }

        /// <summary>
        /// Returns true if VaultStatusDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of VaultStatusDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VaultStatusDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
                ) && 
                (
                    this.StorageType == input.StorageType ||
                    (this.StorageType != null &&
                    this.StorageType.Equals(input.StorageType))
                ) && 
                (
                    this.IsEnabled == input.IsEnabled ||
                    this.IsEnabled.Equals(input.IsEnabled)
                ) && 
                (
                    this.IsCreated == input.IsCreated ||
                    this.IsCreated.Equals(input.IsCreated)
                ) && 
                (
                    this.Updatedon == input.Updatedon ||
                    (this.Updatedon != null &&
                    this.Updatedon.Equals(input.Updatedon))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.MqttId == input.MqttId ||
                    (this.MqttId != null &&
                    this.MqttId.Equals(input.MqttId))
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
                if (this.SubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionId.GetHashCode();
                }
                if (this.StorageType != null)
                {
                    hashCode = (hashCode * 59) + this.StorageType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.IsCreated.GetHashCode();
                if (this.Updatedon != null)
                {
                    hashCode = (hashCode * 59) + this.Updatedon.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedOn.GetHashCode();
                }
                if (this.MqttId != null)
                {
                    hashCode = (hashCode * 59) + this.MqttId.GetHashCode();
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
