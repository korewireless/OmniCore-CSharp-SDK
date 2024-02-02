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
    /// MetricsData
    /// </summary>
    [DataContract(Name = "MetricsData")]
    public partial class MetricsData : IEquatable<MetricsData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsData" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="totalExportSize">totalExportSize.</param>
        /// <param name="totalReplaySize">totalReplaySize.</param>
        public MetricsData(List<MetricsLogs> data = default(List<MetricsLogs>), decimal totalExportSize = default(decimal), decimal totalReplaySize = default(decimal))
        {
            this.Data = data;
            this.TotalExportSize = totalExportSize;
            this.TotalReplaySize = totalReplaySize;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<MetricsLogs> Data { get; set; }

        /// <summary>
        /// Gets or Sets TotalExportSize
        /// </summary>
        [DataMember(Name = "TotalExportSize", EmitDefaultValue = false)]
        public decimal TotalExportSize { get; set; }

        /// <summary>
        /// Gets or Sets TotalReplaySize
        /// </summary>
        [DataMember(Name = "TotalReplaySize", EmitDefaultValue = false)]
        public decimal TotalReplaySize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MetricsData {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  TotalExportSize: ").Append(TotalExportSize).Append("\n");
            sb.Append("  TotalReplaySize: ").Append(TotalReplaySize).Append("\n");
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
            return this.Equals(input as MetricsData);
        }

        /// <summary>
        /// Returns true if MetricsData instances are equal
        /// </summary>
        /// <param name="input">Instance of MetricsData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricsData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.TotalExportSize == input.TotalExportSize ||
                    this.TotalExportSize.Equals(input.TotalExportSize)
                ) && 
                (
                    this.TotalReplaySize == input.TotalReplaySize ||
                    this.TotalReplaySize.Equals(input.TotalReplaySize)
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalExportSize.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalReplaySize.GetHashCode();
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
