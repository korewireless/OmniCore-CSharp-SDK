/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.8.5
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
    /// Sink
    /// </summary>
    [DataContract(Name = "Sink")]
    public partial class Sink : IEquatable<Sink>, IValidatableObject
    {
        /// <summary>
        /// Defines _Sink
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SinkEnum
        {
            /// <summary>
            /// Enum Pubsub for value: pubsub
            /// </summary>
            [EnumMember(Value = "pubsub")]
            Pubsub = 1

        }


        /// <summary>
        /// Gets or Sets _Sink
        /// </summary>
        [DataMember(Name = "sink", EmitDefaultValue = false)]
        public SinkEnum? _Sink { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Sink" /> class.
        /// </summary>
        /// <param name="sink">sink.</param>
        /// <param name="config">config.</param>
        public Sink(SinkEnum? sink = default(SinkEnum?), Config config = default(Config))
        {
            this._Sink = sink;
            this.Config = config;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Subscription
        /// </summary>
        [DataMember(Name = "subscription", EmitDefaultValue = false)]
        public string Subscription { get; private set; }

        /// <summary>
        /// Returns false as Subscription should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSubscription()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public Config Config { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public bool Status { get; private set; }

        /// <summary>
        /// Returns false as Status should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeStatus()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Createdon
        /// </summary>
        [DataMember(Name = "createdon", EmitDefaultValue = false)]
        public string Createdon { get; private set; }

        /// <summary>
        /// Returns false as Createdon should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedon()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Updatedon
        /// </summary>
        [DataMember(Name = "updatedon", EmitDefaultValue = false)]
        public string Updatedon { get; private set; }

        /// <summary>
        /// Returns false as Updatedon should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedon()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Sink {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  _Sink: ").Append(_Sink).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Createdon: ").Append(Createdon).Append("\n");
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
            return this.Equals(input as Sink);
        }

        /// <summary>
        /// Returns true if Sink instances are equal
        /// </summary>
        /// <param name="input">Instance of Sink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sink input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
                ) && 
                (
                    this._Sink == input._Sink ||
                    this._Sink.Equals(input._Sink)
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Createdon == input.Createdon ||
                    (this.Createdon != null &&
                    this.Createdon.Equals(input.Createdon))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Subscription != null)
                {
                    hashCode = (hashCode * 59) + this.Subscription.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Sink.GetHashCode();
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.Createdon != null)
                {
                    hashCode = (hashCode * 59) + this.Createdon.GetHashCode();
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
