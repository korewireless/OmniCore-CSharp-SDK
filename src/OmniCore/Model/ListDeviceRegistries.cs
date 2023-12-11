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
    /// ListDeviceRegistries
    /// </summary>
    [DataContract(Name = "ListDeviceRegistries")]
    public partial class ListDeviceRegistries : IEquatable<ListDeviceRegistries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeviceRegistries" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ListDeviceRegistries() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ListDeviceRegistries" /> class.
        /// </summary>
        /// <param name="deviceRegistries">deviceRegistries (required).</param>
        /// <param name="pageNumber">pageNumber.</param>
        /// <param name="pageSize">pageSize.</param>
        /// <param name="totalCount">totalCount.</param>
        public ListDeviceRegistries(List<DeviceRegistry> deviceRegistries = default(List<DeviceRegistry>), int pageNumber = default(int), int pageSize = default(int), int totalCount = default(int))
        {
            // to ensure "deviceRegistries" is required (not null)
            if (deviceRegistries == null)
            {
                throw new ArgumentNullException("deviceRegistries is a required property for ListDeviceRegistries and cannot be null");
            }
            this.DeviceRegistries = deviceRegistries;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// Gets or Sets DeviceRegistries
        /// </summary>
        [DataMember(Name = "deviceRegistries", IsRequired = true, EmitDefaultValue = true)]
        public List<DeviceRegistry> DeviceRegistries { get; set; }

        /// <summary>
        /// Gets or Sets PageNumber
        /// </summary>
        [DataMember(Name = "pageNumber", EmitDefaultValue = false)]
        public int PageNumber { get; set; }

        /// <summary>
        /// Gets or Sets PageSize
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name = "totalCount", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ListDeviceRegistries {\n");
            sb.Append("  DeviceRegistries: ").Append(DeviceRegistries).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(input as ListDeviceRegistries);
        }

        /// <summary>
        /// Returns true if ListDeviceRegistries instances are equal
        /// </summary>
        /// <param name="input">Instance of ListDeviceRegistries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ListDeviceRegistries input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeviceRegistries == input.DeviceRegistries ||
                    this.DeviceRegistries != null &&
                    input.DeviceRegistries != null &&
                    this.DeviceRegistries.SequenceEqual(input.DeviceRegistries)
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    this.PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
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
                if (this.DeviceRegistries != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceRegistries.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
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
