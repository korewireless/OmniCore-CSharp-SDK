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
    /// ListDeviceStatesResponse
    /// </summary>
    [DataContract(Name = "ListDeviceStatesResponse")]
    public partial class ListDeviceStatesResponse : IEquatable<ListDeviceStatesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeviceStatesResponse" /> class.
        /// </summary>
        /// <param name="deviceStates">deviceStates.</param>
        public ListDeviceStatesResponse(List<DeviceState> deviceStates = default(List<DeviceState>))
        {
            this.DeviceStates = deviceStates;
        }

        /// <summary>
        /// Gets or Sets DeviceStates
        /// </summary>
        [DataMember(Name = "deviceStates", EmitDefaultValue = false)]
        public List<DeviceState> DeviceStates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListDeviceStatesResponse {\n");
            sb.Append("  DeviceStates: ").Append(DeviceStates).Append("\n");
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
            return this.Equals(input as ListDeviceStatesResponse);
        }

        /// <summary>
        /// Returns true if ListDeviceStatesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListDeviceStatesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListDeviceStatesResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeviceStates == input.DeviceStates ||
                    this.DeviceStates != null &&
                    input.DeviceStates != null &&
                    this.DeviceStates.SequenceEqual(input.DeviceStates)
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
                if (this.DeviceStates != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceStates.GetHashCode();
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
