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
    /// DeviceRegistry
    /// </summary>
    [DataContract(Name = "DeviceRegistry")]
    public partial class DeviceRegistry : IEquatable<DeviceRegistry>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LogLevel
        /// </summary>
        [DataMember(Name = "logLevel", EmitDefaultValue = false)]
        public LogLevel? LogLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRegistry" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeviceRegistry() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeviceRegistry" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="httpConfig">httpConfig.</param>
        /// <param name="mqttConfig">mqttConfig.</param>
        /// <param name="logLevel">logLevel.</param>
        /// <param name="isNatsRoute">isNatsRoute.</param>
        /// <param name="eventNotificationConfigs">eventNotificationConfigs.</param>
        /// <param name="logNotificationConfig">logNotificationConfig.</param>
        /// <param name="stateNotificationConfig">stateNotificationConfig.</param>
        /// <param name="customOnboardNotificationConfig">customOnboardNotificationConfig.</param>
        /// <param name="customOnboardEnabled">customOnboardEnabled.</param>
        public DeviceRegistry(string id = default(string), List<RegistryCredential> credentials = default(List<RegistryCredential>), HttpConfig httpConfig = default(HttpConfig), MqttConfig mqttConfig = default(MqttConfig), LogLevel? logLevel = default(LogLevel?), bool isNatsRoute = default(bool), List<EventNotificationConfig> eventNotificationConfigs = default(List<EventNotificationConfig>), NotificationConfig logNotificationConfig = default(NotificationConfig), NotificationConfig stateNotificationConfig = default(NotificationConfig), NotificationConfig customOnboardNotificationConfig = default(NotificationConfig), bool customOnboardEnabled = default(bool))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for DeviceRegistry and cannot be null");
            }
            this.Id = id;
            this.Credentials = credentials;
            this.HttpConfig = httpConfig;
            this.MqttConfig = mqttConfig;
            this.LogLevel = logLevel;
            this.IsNatsRoute = isNatsRoute;
            this.EventNotificationConfigs = eventNotificationConfigs;
            this.LogNotificationConfig = logNotificationConfig;
            this.StateNotificationConfig = stateNotificationConfig;
            this.CustomOnboardNotificationConfig = customOnboardNotificationConfig;
            this.CustomOnboardEnabled = customOnboardEnabled;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; private set; }

        /// <summary>
        /// Returns false as Name should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeName()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Parent
        /// </summary>
        [DataMember(Name = "parent", EmitDefaultValue = false)]
        public string Parent { get; private set; }

        /// <summary>
        /// Returns false as Parent should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeParent()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        [DataMember(Name = "createdOn", EmitDefaultValue = false)]
        public string CreatedOn { get; private set; }

        /// <summary>
        /// Returns false as CreatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCreatedOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets UpdatedOn
        /// </summary>
        [DataMember(Name = "updatedOn", EmitDefaultValue = false)]
        public string UpdatedOn { get; private set; }

        /// <summary>
        /// Returns false as UpdatedOn should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeUpdatedOn()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Credentials
        /// </summary>
        [DataMember(Name = "credentials", EmitDefaultValue = false)]
        public List<RegistryCredential> Credentials { get; set; }

        /// <summary>
        /// Gets or Sets HttpConfig
        /// </summary>
        [DataMember(Name = "httpConfig", EmitDefaultValue = false)]
        public HttpConfig HttpConfig { get; set; }

        /// <summary>
        /// Gets or Sets MqttConfig
        /// </summary>
        [DataMember(Name = "mqttConfig", EmitDefaultValue = false)]
        public MqttConfig MqttConfig { get; set; }

        /// <summary>
        /// Gets or Sets IsNatsRoute
        /// </summary>
        [DataMember(Name = "isNatsRoute", EmitDefaultValue = true)]
        public bool IsNatsRoute { get; set; }

        /// <summary>
        /// Gets or Sets EventNotificationConfigs
        /// </summary>
        [DataMember(Name = "eventNotificationConfigs", EmitDefaultValue = false)]
        public List<EventNotificationConfig> EventNotificationConfigs { get; set; }

        /// <summary>
        /// Gets or Sets LogNotificationConfig
        /// </summary>
        [DataMember(Name = "logNotificationConfig", EmitDefaultValue = false)]
        public NotificationConfig LogNotificationConfig { get; set; }

        /// <summary>
        /// Gets or Sets StateNotificationConfig
        /// </summary>
        [DataMember(Name = "stateNotificationConfig", EmitDefaultValue = false)]
        public NotificationConfig StateNotificationConfig { get; set; }

        /// <summary>
        /// Gets or Sets CustomOnboardNotificationConfig
        /// </summary>
        [DataMember(Name = "customOnboardNotificationConfig", EmitDefaultValue = false)]
        public NotificationConfig CustomOnboardNotificationConfig { get; set; }

        /// <summary>
        /// Gets or Sets CustomOnboardEnabled
        /// </summary>
        [DataMember(Name = "customOnboardEnabled", EmitDefaultValue = true)]
        public bool CustomOnboardEnabled { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfDevices
        /// </summary>
        [DataMember(Name = "numberOfDevices", EmitDefaultValue = false)]
        public int NumberOfDevices { get; private set; }

        /// <summary>
        /// Returns false as NumberOfDevices should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumberOfDevices()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets NumberOfGateways
        /// </summary>
        [DataMember(Name = "numberOfGateways", EmitDefaultValue = false)]
        public int NumberOfGateways { get; private set; }

        /// <summary>
        /// Returns false as NumberOfGateways should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumberOfGateways()
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
            sb.Append("class DeviceRegistry {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  HttpConfig: ").Append(HttpConfig).Append("\n");
            sb.Append("  MqttConfig: ").Append(MqttConfig).Append("\n");
            sb.Append("  LogLevel: ").Append(LogLevel).Append("\n");
            sb.Append("  IsNatsRoute: ").Append(IsNatsRoute).Append("\n");
            sb.Append("  EventNotificationConfigs: ").Append(EventNotificationConfigs).Append("\n");
            sb.Append("  LogNotificationConfig: ").Append(LogNotificationConfig).Append("\n");
            sb.Append("  StateNotificationConfig: ").Append(StateNotificationConfig).Append("\n");
            sb.Append("  CustomOnboardNotificationConfig: ").Append(CustomOnboardNotificationConfig).Append("\n");
            sb.Append("  CustomOnboardEnabled: ").Append(CustomOnboardEnabled).Append("\n");
            sb.Append("  NumberOfDevices: ").Append(NumberOfDevices).Append("\n");
            sb.Append("  NumberOfGateways: ").Append(NumberOfGateways).Append("\n");
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
            return this.Equals(input as DeviceRegistry);
        }

        /// <summary>
        /// Returns true if DeviceRegistry instances are equal
        /// </summary>
        /// <param name="input">Instance of DeviceRegistry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeviceRegistry input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.CreatedOn == input.CreatedOn ||
                    (this.CreatedOn != null &&
                    this.CreatedOn.Equals(input.CreatedOn))
                ) && 
                (
                    this.UpdatedOn == input.UpdatedOn ||
                    (this.UpdatedOn != null &&
                    this.UpdatedOn.Equals(input.UpdatedOn))
                ) && 
                (
                    this.Credentials == input.Credentials ||
                    this.Credentials != null &&
                    input.Credentials != null &&
                    this.Credentials.SequenceEqual(input.Credentials)
                ) && 
                (
                    this.HttpConfig == input.HttpConfig ||
                    (this.HttpConfig != null &&
                    this.HttpConfig.Equals(input.HttpConfig))
                ) && 
                (
                    this.MqttConfig == input.MqttConfig ||
                    (this.MqttConfig != null &&
                    this.MqttConfig.Equals(input.MqttConfig))
                ) && 
                (
                    this.LogLevel == input.LogLevel ||
                    this.LogLevel.Equals(input.LogLevel)
                ) && 
                (
                    this.IsNatsRoute == input.IsNatsRoute ||
                    this.IsNatsRoute.Equals(input.IsNatsRoute)
                ) && 
                (
                    this.EventNotificationConfigs == input.EventNotificationConfigs ||
                    this.EventNotificationConfigs != null &&
                    input.EventNotificationConfigs != null &&
                    this.EventNotificationConfigs.SequenceEqual(input.EventNotificationConfigs)
                ) && 
                (
                    this.LogNotificationConfig == input.LogNotificationConfig ||
                    (this.LogNotificationConfig != null &&
                    this.LogNotificationConfig.Equals(input.LogNotificationConfig))
                ) && 
                (
                    this.StateNotificationConfig == input.StateNotificationConfig ||
                    (this.StateNotificationConfig != null &&
                    this.StateNotificationConfig.Equals(input.StateNotificationConfig))
                ) && 
                (
                    this.CustomOnboardNotificationConfig == input.CustomOnboardNotificationConfig ||
                    (this.CustomOnboardNotificationConfig != null &&
                    this.CustomOnboardNotificationConfig.Equals(input.CustomOnboardNotificationConfig))
                ) && 
                (
                    this.CustomOnboardEnabled == input.CustomOnboardEnabled ||
                    this.CustomOnboardEnabled.Equals(input.CustomOnboardEnabled)
                ) && 
                (
                    this.NumberOfDevices == input.NumberOfDevices ||
                    this.NumberOfDevices.Equals(input.NumberOfDevices)
                ) && 
                (
                    this.NumberOfGateways == input.NumberOfGateways ||
                    this.NumberOfGateways.Equals(input.NumberOfGateways)
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Parent != null)
                {
                    hashCode = (hashCode * 59) + this.Parent.GetHashCode();
                }
                if (this.CreatedOn != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedOn.GetHashCode();
                }
                if (this.UpdatedOn != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedOn.GetHashCode();
                }
                if (this.Credentials != null)
                {
                    hashCode = (hashCode * 59) + this.Credentials.GetHashCode();
                }
                if (this.HttpConfig != null)
                {
                    hashCode = (hashCode * 59) + this.HttpConfig.GetHashCode();
                }
                if (this.MqttConfig != null)
                {
                    hashCode = (hashCode * 59) + this.MqttConfig.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LogLevel.GetHashCode();
                hashCode = (hashCode * 59) + this.IsNatsRoute.GetHashCode();
                if (this.EventNotificationConfigs != null)
                {
                    hashCode = (hashCode * 59) + this.EventNotificationConfigs.GetHashCode();
                }
                if (this.LogNotificationConfig != null)
                {
                    hashCode = (hashCode * 59) + this.LogNotificationConfig.GetHashCode();
                }
                if (this.StateNotificationConfig != null)
                {
                    hashCode = (hashCode * 59) + this.StateNotificationConfig.GetHashCode();
                }
                if (this.CustomOnboardNotificationConfig != null)
                {
                    hashCode = (hashCode * 59) + this.CustomOnboardNotificationConfig.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CustomOnboardEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.NumberOfDevices.GetHashCode();
                hashCode = (hashCode * 59) + this.NumberOfGateways.GetHashCode();
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
