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
    /// ReplayBody
    /// </summary>
    [DataContract(Name = "ReplayBody")]
    public partial class ReplayBody : IEquatable<ReplayBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplayBody" /> class.
        /// </summary>
        /// <param name="registry">registry.</param>
        /// <param name="startTime">startTime.</param>
        /// <param name="endTime">endTime.</param>
        /// <param name="destination">destination.</param>
        /// <param name="source">source.</param>
        public ReplayBody(string registry = default(string), int startTime = default(int), int endTime = default(int), string destination = default(string), string source = default(string))
        {
            this.Registry = registry;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Destination = destination;
            this.Source = source;
        }

        /// <summary>
        /// Gets or Sets Registry
        /// </summary>
        [DataMember(Name = "registry", EmitDefaultValue = false)]
        public string Registry { get; set; }

        /// <summary>
        /// Gets or Sets StartTime
        /// </summary>
        [DataMember(Name = "startTime", EmitDefaultValue = false)]
        public int StartTime { get; set; }

        /// <summary>
        /// Gets or Sets EndTime
        /// </summary>
        [DataMember(Name = "endTime", EmitDefaultValue = false)]
        public int EndTime { get; set; }

        /// <summary>
        /// Gets or Sets Destination
        /// </summary>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public string Destination { get; set; }

        /// <summary>
        /// Gets or Sets Source
        /// </summary>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReplayBody {\n");
            sb.Append("  Registry: ").Append(Registry).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
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
            return this.Equals(input as ReplayBody);
        }

        /// <summary>
        /// Returns true if ReplayBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplayBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplayBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Registry == input.Registry ||
                    (this.Registry != null &&
                    this.Registry.Equals(input.Registry))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    this.StartTime.Equals(input.StartTime)
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    this.EndTime.Equals(input.EndTime)
                ) && 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
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
                if (this.Registry != null)
                {
                    hashCode = (hashCode * 59) + this.Registry.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.StartTime.GetHashCode();
                hashCode = (hashCode * 59) + this.EndTime.GetHashCode();
                if (this.Destination != null)
                {
                    hashCode = (hashCode * 59) + this.Destination.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
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
