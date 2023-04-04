/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.0
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
    /// BlockCommunicationBody
    /// </summary>
    [DataContract(Name = "BlockCommunicationBody")]
    public partial class BlockCommunicationBody : IEquatable<BlockCommunicationBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BlockCommunicationBody" /> class.
        /// </summary>
        /// <param name="isblocked">isblocked.</param>
        public BlockCommunicationBody(bool isblocked = default(bool))
        {
            this.Isblocked = isblocked;
        }

        /// <summary>
        /// Gets or Sets Isblocked
        /// </summary>
        [DataMember(Name = "isblocked", EmitDefaultValue = true)]
        public bool Isblocked { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BlockCommunicationBody {\n");
            sb.Append("  Isblocked: ").Append(Isblocked).Append("\n");
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
            return this.Equals(input as BlockCommunicationBody);
        }

        /// <summary>
        /// Returns true if BlockCommunicationBody instances are equal
        /// </summary>
        /// <param name="input">Instance of BlockCommunicationBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BlockCommunicationBody input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Isblocked == input.Isblocked ||
                    this.Isblocked.Equals(input.Isblocked)
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
                hashCode = (hashCode * 59) + this.Isblocked.GetHashCode();
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
