/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.8.2
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
    /// ExportDetail
    /// </summary>
    [DataContract(Name = "ExportDetail")]
    public partial class ExportDetail : IEquatable<ExportDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportDetail" /> class.
        /// </summary>
        /// <param name="subscription">subscription.</param>
        /// <param name="name">name.</param>
        /// <param name="source">source.</param>
        /// <param name="status">status.</param>
        /// <param name="destination">destination.</param>
        /// <param name="createdOn">createdOn.</param>
        /// <param name="nooffiles">nooffiles.</param>
        /// <param name="fileSize">fileSize.</param>
        /// <param name="done">done.</param>
        public ExportDetail(string subscription = default(string), string name = default(string), string source = default(string), string status = default(string), string destination = default(string), string createdOn = default(string), int nooffiles = default(int), decimal fileSize = default(decimal), bool done = default(bool))
        {
            this.Subscription = subscription;
            this.Name = name;
            this.Source = source;
            this.Status = status;
            this.Destination = destination;
            this.CreatedOn = createdOn;
            this.Nooffiles = nooffiles;
            this.FileSize = fileSize;
            this.Done = done;
        }

        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public string Subscription { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public string CreatedOn { get; set; }

        /// <summary>
        /// Gets or Sets Nooffiles
        /// </summary>
        [DataMember(Name = "nooffiles", EmitDefaultValue = false)]
        public int Nooffiles { get; set; }

        /// <summary>
        /// Gets or Sets FileSize
        /// </summary>
        [DataMember(Name = "fileSize", EmitDefaultValue = false)]
        public decimal FileSize { get; set; }

        /// <summary>
        /// Gets or Sets Done
        /// </summary>
        [DataMember(Name = "done", EmitDefaultValue = true)]
        public bool Done { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExportDetail {\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  Nooffiles: ").Append(Nooffiles).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  Done: ").Append(Done).Append("\n");
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
            return this.Equals(input as ExportDetail);
        }

        /// <summary>
        /// Returns true if ExportDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.Nooffiles == input.Nooffiles ||
                    this.Nooffiles.Equals(input.Nooffiles)
                ) && 
                (
                    this.FileSize == input.FileSize ||
                    this.FileSize.Equals(input.FileSize)
                ) && 
                (
                    this.Done == input.Done ||
                    this.Done.Equals(input.Done)
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
                if (this.Subscription != null)
                {
                    hashCode = (hashCode * 59) + this.Subscription.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.Destination != null)
                {
                    hashCode = (hashCode * 59) + this.Destination.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedOn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Nooffiles.GetHashCode();
                hashCode = (hashCode * 59) + this.FileSize.GetHashCode();
                hashCode = (hashCode * 59) + this.Done.GetHashCode();
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
