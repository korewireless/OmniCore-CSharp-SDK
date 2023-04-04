/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.0
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
    /// DeviceConfiguration
    /// </summary>
    [DataContract(Name = "DeviceConfiguration")]
    public partial class DeviceConfiguration : IEquatable<DeviceConfiguration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceConfiguration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceConfiguration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceConfiguration" /> class.
        /// </summary>
        /// <param name="binaryData">Base64 Encoded Config String (required).</param>
        /// <param name="subfolder">subfolder.</param>
        /// <param name="versionToUpdate">versionToUpdate.</param>
        public DeviceConfiguration(string binaryData = default(string), string subfolder = default(string), string versionToUpdate = default(string))
        {
            // to ensure "binaryData" is required (not null)
            if (binaryData == null)
            {
                throw new ArgumentNullException("binaryData is a required property for DeviceConfiguration and cannot be null");
            }
            this.BinaryData = binaryData;
            this.Subfolder = subfolder;
            this.VersionToUpdate = versionToUpdate;
        }

        /// <summary>
        /// Base64 Encoded Config String
        /// </summary>
        /// <value>Base64 Encoded Config String</value>
        [DataMember(Name = "binaryData", IsRequired = true, EmitDefaultValue = true)]
        public string BinaryData { get; set; }

        /// <summary>
        /// Gets or Sets Subfolder
        /// </summary>
        [DataMember(Name = "subfolder", EmitDefaultValue = false)]
        public string Subfolder { get; set; }

        /// <summary>
        /// Gets or Sets VersionToUpdate
        /// </summary>
        [DataMember(Name = "versionToUpdate", EmitDefaultValue = false)]
        public string VersionToUpdate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceConfiguration {\n");
            sb.Append("  BinaryData: ").Append(BinaryData).Append("\n");
            sb.Append("  Subfolder: ").Append(Subfolder).Append("\n");
            sb.Append("  VersionToUpdate: ").Append(VersionToUpdate).Append("\n");
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
            return this.Equals(input as DeviceConfiguration);
        }

        /// <summary>
        /// Returns true if DeviceConfiguration instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceConfiguration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceConfiguration input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BinaryData == input.BinaryData ||
                    (this.BinaryData != null &&
                    this.BinaryData.Equals(input.BinaryData))
                ) && 
                (
                    this.Subfolder == input.Subfolder ||
                    (this.Subfolder != null &&
                    this.Subfolder.Equals(input.Subfolder))
                ) && 
                (
                    this.VersionToUpdate == input.VersionToUpdate ||
                    (this.VersionToUpdate != null &&
                    this.VersionToUpdate.Equals(input.VersionToUpdate))
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
                if (this.BinaryData != null)
                {
                    hashCode = (hashCode * 59) + this.BinaryData.GetHashCode();
                }
                if (this.Subfolder != null)
                {
                    hashCode = (hashCode * 59) + this.Subfolder.GetHashCode();
                }
                if (this.VersionToUpdate != null)
                {
                    hashCode = (hashCode * 59) + this.VersionToUpdate.GetHashCode();
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
