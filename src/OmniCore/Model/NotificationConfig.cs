/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: support@korewireless.com
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
    /// NotificationConfig
    /// </summary>
    [DataContract(Name = "NotificationConfig")]
    public partial class NotificationConfig : IEquatable<NotificationConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationConfig" /> class.
        /// </summary>
        /// <param name="pubsubTopicName">PubsubTopicName: A Cloud Pub/Sub topic name. For example, &#x60;projects/myProject/topics/deviceEvents&#x60;..</param>
        public NotificationConfig(string pubsubTopicName = default(string))
        {
            this.PubsubTopicName = pubsubTopicName;
        }

        /// <summary>
        /// PubsubTopicName: A Cloud Pub/Sub topic name. For example, &#x60;projects/myProject/topics/deviceEvents&#x60;.
        /// </summary>
        /// <value>PubsubTopicName: A Cloud Pub/Sub topic name. For example, &#x60;projects/myProject/topics/deviceEvents&#x60;.</value>
        [DataMember(Name = "pubsubTopicName", EmitDefaultValue = false)]
        public string PubsubTopicName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NotificationConfig {\n");
            sb.Append("  PubsubTopicName: ").Append(PubsubTopicName).Append("\n");
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
            return this.Equals(input as NotificationConfig);
        }

        /// <summary>
        /// Returns true if NotificationConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of NotificationConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NotificationConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PubsubTopicName == input.PubsubTopicName ||
                    (this.PubsubTopicName != null &&
                    this.PubsubTopicName.Equals(input.PubsubTopicName))
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
                if (this.PubsubTopicName != null)
                {
                    hashCode = (hashCode * 59) + this.PubsubTopicName.GetHashCode();
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
