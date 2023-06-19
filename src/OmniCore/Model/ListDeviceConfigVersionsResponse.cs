/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.8.1
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
    /// ListDeviceConfigVersionsResponse
    /// </summary>
    [DataContract(Name = "ListDeviceConfigVersionsResponse")]
    public partial class ListDeviceConfigVersionsResponse : IEquatable<ListDeviceConfigVersionsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeviceConfigVersionsResponse" /> class.
        /// </summary>
        /// <param name="deviceConfigs">deviceConfigs.</param>
        public ListDeviceConfigVersionsResponse(List<DeviceConfig> deviceConfigs = default(List<DeviceConfig>))
        {
            this.DeviceConfigs = deviceConfigs;
        }

        /// <summary>
        /// Gets or Sets DeviceConfigs
        /// </summary>
        [DataMember(Name = "deviceConfigs", EmitDefaultValue = false)]
        public List<DeviceConfig> DeviceConfigs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListDeviceConfigVersionsResponse {\n");
            sb.Append("  DeviceConfigs: ").Append(DeviceConfigs).Append("\n");
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
            return this.Equals(input as ListDeviceConfigVersionsResponse);
        }

        /// <summary>
        /// Returns true if ListDeviceConfigVersionsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ListDeviceConfigVersionsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListDeviceConfigVersionsResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeviceConfigs == input.DeviceConfigs ||
                    this.DeviceConfigs != null &&
                    input.DeviceConfigs != null &&
                    this.DeviceConfigs.SequenceEqual(input.DeviceConfigs)
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
                if (this.DeviceConfigs != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceConfigs.GetHashCode();
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
