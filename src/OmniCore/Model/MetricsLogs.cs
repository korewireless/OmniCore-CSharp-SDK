/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.8.6
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
    /// MetricsLogs
    /// </summary>
    [DataContract(Name = "MetricsLogs")]
    public partial class MetricsLogs : IEquatable<MetricsLogs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsLogs" /> class.
        /// </summary>
        /// <param name="noOfFiles">noOfFiles.</param>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="noofoperations">noofoperations.</param>
        /// <param name="updatedon">updatedon.</param>
        /// <param name="replayFileSize">replayFileSize.</param>
        /// <param name="exportFileSize">exportFileSize.</param>
        public MetricsLogs(int noOfFiles = default(int), decimal fileSize = default(decimal), int noofoperations = default(int), string updatedon = default(string), decimal replayFileSize = default(decimal), decimal exportFileSize = default(decimal))
        {
            this.NoOfFiles = noOfFiles;
            this.FileSize = fileSize;
            this.Noofoperations = noofoperations;
            this.Updatedon = updatedon;
            this.ReplayFileSize = replayFileSize;
            this.ExportFileSize = exportFileSize;
        }

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
        /// Gets or Sets Updatedon
        /// </summary>
        [DataMember(Name = "updatedon", EmitDefaultValue = false)]
        public string Updatedon { get; set; }

        /// <summary>
        /// Gets or Sets ReplayFileSize
        /// </summary>
        [DataMember(Name = "replayFileSize", EmitDefaultValue = false)]
        public decimal ReplayFileSize { get; set; }

        /// <summary>
        /// Gets or Sets ExportFileSize
        /// </summary>
        [DataMember(Name = "exportFileSize", EmitDefaultValue = false)]
        public decimal ExportFileSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MetricsLogs {\n");
            sb.Append("  NoOfFiles: ").Append(NoOfFiles).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  Noofoperations: ").Append(Noofoperations).Append("\n");
            sb.Append("  Updatedon: ").Append(Updatedon).Append("\n");
            sb.Append("  ReplayFileSize: ").Append(ReplayFileSize).Append("\n");
            sb.Append("  ExportFileSize: ").Append(ExportFileSize).Append("\n");
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
            return this.Equals(input as MetricsLogs);
        }

        /// <summary>
        /// Returns true if MetricsLogs instances are equal
        /// </summary>
        /// <param name="input">Instance of MetricsLogs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricsLogs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Updatedon == input.Updatedon ||
                    (this.Updatedon != null &&
                    this.Updatedon.Equals(input.Updatedon))
                ) && 
                (
                    this.ReplayFileSize == input.ReplayFileSize ||
                    this.ReplayFileSize.Equals(input.ReplayFileSize)
                ) && 
                (
                    this.ExportFileSize == input.ExportFileSize ||
                    this.ExportFileSize.Equals(input.ExportFileSize)
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
                hashCode = (hashCode * 59) + this.NoOfFiles.GetHashCode();
                hashCode = (hashCode * 59) + this.FileSize.GetHashCode();
                hashCode = (hashCode * 59) + this.Noofoperations.GetHashCode();
                if (this.Updatedon != null)
                {
                    hashCode = (hashCode * 59) + this.Updatedon.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ReplayFileSize.GetHashCode();
                hashCode = (hashCode * 59) + this.ExportFileSize.GetHashCode();
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
