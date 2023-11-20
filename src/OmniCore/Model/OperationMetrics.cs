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
    /// OperationMetrics
    /// </summary>
    [DataContract(Name = "OperationMetrics")]
    public partial class OperationMetrics : IEquatable<OperationMetrics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationMetrics" /> class.
        /// </summary>
        /// <param name="noOfFiles">noOfFiles.</param>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="operation">operation.</param>
        /// <param name="noofoperations">noofoperations.</param>
        /// <param name="updatedon">updatedon.</param>
        /// <param name="registryid">registryid.</param>
        public OperationMetrics(int noOfFiles = default(int), decimal fileSize = default(decimal), string operation = default(string), int noofoperations = default(int), string updatedon = default(string), string registryid = default(string))
        {
            this.NoOfFiles = noOfFiles;
            this.FileSize = fileSize;
            this.Operation = operation;
            this.Noofoperations = noofoperations;
            this.Updatedon = updatedon;
            this.Registryid = registryid;
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
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "operation", EmitDefaultValue = false)]
        public string Operation { get; set; }

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
        /// Gets or Sets Registryid
        /// </summary>
        [DataMember(Name = "registryid", EmitDefaultValue = false)]
        public string Registryid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OperationMetrics {\n");
            sb.Append("  NoOfFiles: ").Append(NoOfFiles).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Noofoperations: ").Append(Noofoperations).Append("\n");
            sb.Append("  Updatedon: ").Append(Updatedon).Append("\n");
            sb.Append("  Registryid: ").Append(Registryid).Append("\n");
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
            return this.Equals(input as OperationMetrics);
        }

        /// <summary>
        /// Returns true if OperationMetrics instances are equal
        /// </summary>
        /// <param name="input">Instance of OperationMetrics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OperationMetrics input)
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
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
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
                    this.Registryid == input.Registryid ||
                    (this.Registryid != null &&
                    this.Registryid.Equals(input.Registryid))
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
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Noofoperations.GetHashCode();
                if (this.Updatedon != null)
                {
                    hashCode = (hashCode * 59) + this.Updatedon.GetHashCode();
                }
                if (this.Registryid != null)
                {
                    hashCode = (hashCode * 59) + this.Registryid.GetHashCode();
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
