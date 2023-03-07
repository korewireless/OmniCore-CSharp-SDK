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
    /// NewDevice
    /// </summary>
    [DataContract(Name = "NewDevice")]
    public partial class NewDevice : IEquatable<NewDevice>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LogLevel
        /// </summary>
        [DataMember(Name = "logLevel", EmitDefaultValue = false)]
        public LogLevel? LogLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewDevice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewDevice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewDevice" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="blocked">blocked.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="gatewayConfig">gatewayConfig.</param>
        /// <param name="config">config.</param>
        /// <param name="logLevel">logLevel.</param>
        /// <param name="metadata">metadata.</param>
        public NewDevice(string id = default(string), bool blocked = default(bool), List<DeviceCredential> credentials = default(List<DeviceCredential>), GatewayConfig gatewayConfig = default(GatewayConfig), DeviceConfig config = default(DeviceConfig), LogLevel? logLevel = default(LogLevel?), Dictionary<string, string> metadata = default(Dictionary<string, string>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for NewDevice and cannot be null");
            }
            this.Id = id;
            this.Blocked = blocked;
            this.Credentials = credentials;
            this.GatewayConfig = gatewayConfig;
            this.Config = config;
            this.LogLevel = logLevel;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Blocked
        /// </summary>
        [DataMember(Name = "blocked", EmitDefaultValue = true)]
        public bool Blocked { get; set; }

        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]
        public List<DeviceCredential> Credentials { get; set; }

        /// <summary>
        /// Gets or Sets GatewayConfig
        /// </summary>
        [DataMember(Name = "gatewayConfig", EmitDefaultValue = false)]
        public GatewayConfig GatewayConfig { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public DeviceConfig Config { get; set; }

        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NewDevice {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  GatewayConfig: ").Append(GatewayConfig).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  LogLevel: ").Append(LogLevel).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
            return this.Equals(input as NewDevice);
        }

        /// <summary>
        /// Returns true if NewDevice instances are equal
        /// </summary>
        /// <param name="input">Instance of NewDevice to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewDevice input)
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
                    this.Blocked == input.Blocked ||
                    this.Blocked.Equals(input.Blocked)
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    this.Credentials != null &&
                    input.Credentials != null &&
                    this.Credentials.SequenceEqual(input.Credentials)
                ) && 
                (
                    this.GatewayConfig == input.GatewayConfig ||
                    (this.GatewayConfig != null &&
                    this.GatewayConfig.Equals(input.GatewayConfig))
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.LogLevel == input.LogLevel ||
                    this.LogLevel.Equals(input.LogLevel)
                ) && 
                (
                    this.Metadata == input.Metadata ||
                    this.Metadata != null &&
                    input.Metadata != null &&
                    this.Metadata.SequenceEqual(input.Metadata)
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
                hashCode = (hashCode * 59) + this.Blocked.GetHashCode();
                if (this.Credentials != null)
                {
                    hashCode = (hashCode * 59) + this.Credentials.GetHashCode();
                }
                if (this.GatewayConfig != null)
                {
                    hashCode = (hashCode * 59) + this.GatewayConfig.GetHashCode();
                }
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LogLevel.GetHashCode();
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
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
            // Id (string) maxLength
            if (this.Id != null && this.Id.Length > 256)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 256.", new [] { "Id" });
            }

            // Id (string) minLength
            if (this.Id != null && this.Id.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be greater than 3.", new [] { "Id" });
            }

            yield break;
        }
    }

}
