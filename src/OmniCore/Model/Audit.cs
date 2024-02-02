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
    /// Audit
    /// </summary>
    [DataContract(Name = "Audit")]
    public partial class Audit : IEquatable<Audit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Audit" /> class.
        /// </summary>
        /// <param name="subscriptionId">subscriptionId.</param>
        /// <param name="operation">operation.</param>
        /// <param name="actor">actor.</param>
        /// <param name="updatedon">updatedon.</param>
        public Audit(string subscriptionId = default(string), string operation = default(string), string actor = default(string), string updatedon = default(string))
        {
            this.SubscriptionId = subscriptionId;
            this.Operation = operation;
            this.Actor = actor;
            this.Updatedon = updatedon;
        }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name = "subscriptionId", EmitDefaultValue = false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "operation", EmitDefaultValue = false)]
        public string Operation { get; set; }

        /// <summary>
        /// Gets or Sets Actor
        /// </summary>
        [DataMember(Name = "actor", EmitDefaultValue = false)]
        public string Actor { get; set; }

        /// <summary>
        /// Gets or Sets Updatedon
        /// </summary>
        [DataMember(Name = "updatedon", EmitDefaultValue = false)]
        public string Updatedon { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Audit {\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Actor: ").Append(Actor).Append("\n");
            sb.Append("  Updatedon: ").Append(Updatedon).Append("\n");
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
            return this.Equals(input as Audit);
        }

        /// <summary>
        /// Returns true if Audit instances are equal
        /// </summary>
        /// <param name="input">Instance of Audit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Audit input)
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
                    this.Operation == input.Operation ||
                    (this.Operation != null &&
                    this.Operation.Equals(input.Operation))
                ) && 
                (
                    this.Actor == input.Actor ||
                    (this.Actor != null &&
                    this.Actor.Equals(input.Actor))
                ) && 
                (
                    this.Updatedon == input.Updatedon ||
                    (this.Updatedon != null &&
                    this.Updatedon.Equals(input.Updatedon))
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
                if (this.Operation != null)
                {
                    hashCode = (hashCode * 59) + this.Operation.GetHashCode();
                }
                if (this.Actor != null)
                {
                    hashCode = (hashCode * 59) + this.Actor.GetHashCode();
                }
                if (this.Updatedon != null)
                {
                    hashCode = (hashCode * 59) + this.Updatedon.GetHashCode();
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
