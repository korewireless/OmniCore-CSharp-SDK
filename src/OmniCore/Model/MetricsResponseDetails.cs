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
    /// MetricsResponseDetails
    /// </summary>
    [DataContract(Name = "MetricsResponse_details")]
    public partial class MetricsResponseDetails : IEquatable<MetricsResponseDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsResponseDetails" /> class.
        /// </summary>
        /// <param name="subscriptionId">subscriptionId.</param>
        /// <param name="noOfFiles">noOfFiles.</param>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="noofoperations">noofoperations.</param>
        /// <param name="operations">operations.</param>
        /// <param name="detailsForTimePeriod">detailsForTimePeriod.</param>
        public MetricsResponseDetails(string subscriptionId = default(string), int noOfFiles = default(int), decimal fileSize = default(decimal), int noofoperations = default(int), List<OperationMetrics> operations = default(List<OperationMetrics>), List<MetricsData> detailsForTimePeriod = default(List<MetricsData>))
        {
            this.SubscriptionId = subscriptionId;
            this.NoOfFiles = noOfFiles;
            this.FileSize = fileSize;
            this.Noofoperations = noofoperations;
            this.Operations = operations;
            this.DetailsForTimePeriod = detailsForTimePeriod;
        }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name = "subscriptionId", EmitDefaultValue = false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets NoOfFiles
        /// </summary>
        [DataMember(Name = "noOfFiles", EmitDefaultValue = false)]
        public int NoOfFiles { get; set; }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name = "fileSize", EmitDefaultValue = false)]
        public decimal FileSize { get; set; }

        /// <summary>
        /// Gets or Sets Noofoperations
        /// </summary>
        [DataMember(Name = "noofoperations", EmitDefaultValue = false)]
        public int Noofoperations { get; set; }

        /// <summary>
        /// Gets or Sets Operations
        /// </summary>
        [DataMember(Name = "Operations", EmitDefaultValue = false)]
        public List<OperationMetrics> Operations { get; set; }

        /// <summary>
        /// Gets or Sets DetailsForTimePeriod
        /// </summary>
        [DataMember(Name = "detailsForTimePeriod", EmitDefaultValue = false)]
        public List<MetricsData> DetailsForTimePeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MetricsResponseDetails {\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  NoOfFiles: ").Append(NoOfFiles).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  Noofoperations: ").Append(Noofoperations).Append("\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
            sb.Append("  DetailsForTimePeriod: ").Append(DetailsForTimePeriod).Append("\n");
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
            return this.Equals(input as MetricsResponseDetails);
        }

        /// <summary>
        /// Returns true if MetricsResponseDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of MetricsResponseDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricsResponseDetails input)
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
                    this.NoOfFiles == input.NoOfFiles ||
                    this.NoOfFiles.Equals(input.NoOfFiles)
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    this.FileSize.Equals(input.FileSize)
                ) && 
                (
                    this.Noofoperations == input.Noofoperations ||
                    this.Noofoperations.Equals(input.Noofoperations)
                ) && 
                (
                    this.Operations == input.Operations ||
                    this.Operations != null &&
                    input.Operations != null &&
                    this.Operations.SequenceEqual(input.Operations)
                ) && 
                (
                    this.DetailsForTimePeriod == input.DetailsForTimePeriod ||
                    this.DetailsForTimePeriod != null &&
                    input.DetailsForTimePeriod != null &&
                    this.DetailsForTimePeriod.SequenceEqual(input.DetailsForTimePeriod)
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
                hashCode = (hashCode * 59) + this.NoOfFiles.GetHashCode();
                hashCode = (hashCode * 59) + this.FileSize.GetHashCode();
                hashCode = (hashCode * 59) + this.Noofoperations.GetHashCode();
                if (this.Operations != null)
                {
                    hashCode = (hashCode * 59) + this.Operations.GetHashCode();
                }
                if (this.DetailsForTimePeriod != null)
                {
                    hashCode = (hashCode * 59) + this.DetailsForTimePeriod.GetHashCode();
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
