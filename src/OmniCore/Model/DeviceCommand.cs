/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.8.4
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
    /// DeviceCommand
    /// </summary>
    [DataContract(Name = "DeviceCommand")]
    public partial class DeviceCommand : IEquatable<DeviceCommand>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCommand" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceCommand() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceCommand" /> class.
        /// </summary>
        /// <param name="binaryData">Base64 Encoded Command String (required).</param>
        /// <param name="subfolder">subfolder.</param>
        public DeviceCommand(string binaryData = default(string), string subfolder = default(string))
        {
            // to ensure "binaryData" is required (not null)
            if (binaryData == null)
            {
                throw new ArgumentNullException("binaryData is a required property for DeviceCommand and cannot be null");
            }
            this.BinaryData = binaryData;
            this.Subfolder = subfolder;
        }

        /// <summary>
        /// Base64 Encoded Command String
        /// </summary>
        /// <value>Base64 Encoded Command String</value>
        [DataMember(Name = "binaryData", IsRequired = true, EmitDefaultValue = true)]
        public string BinaryData { get; set; }

        /// <summary>
        /// Gets or Sets Subfolder
        /// </summary>
        [DataMember(Name = "subfolder", EmitDefaultValue = false)]
        public string Subfolder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeviceCommand {\n");
            sb.Append("  BinaryData: ").Append(BinaryData).Append("\n");
            sb.Append("  Subfolder: ").Append(Subfolder).Append("\n");
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
            return this.Equals(input as DeviceCommand);
        }

        /// <summary>
        /// Returns true if DeviceCommand instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceCommand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceCommand input)
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
