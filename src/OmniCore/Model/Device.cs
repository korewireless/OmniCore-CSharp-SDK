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
    /// Device
    /// </summary>
    [DataContract(Name = "Device")]
    public partial class Device : IEquatable<Device>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets LogLevel
        /// </summary>
        [DataMember(Name = "logLevel", EmitDefaultValue = false)]
        public LogLevel? LogLevel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Device() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Device" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="blocked">blocked.</param>
        /// <param name="credentials">credentials.</param>
        /// <param name="gateway">gateway.</param>
        /// <param name="gatewayConfig">gatewayConfig.</param>
        /// <param name="isGateway">isGateway.</param>
        /// <param name="lastErrorStatus">lastErrorStatus.</param>
        /// <param name="logLevel">logLevel.</param>
        /// <param name="metadata">metadata.</param>
        /// <param name="config">config.</param>
        /// <param name="state">state.</param>
        /// <param name="policy">policy.</param>
        public Device(string id = default(string), bool blocked = default(bool), List<DeviceCredential> credentials = default(List<DeviceCredential>), List<string> gateway = default(List<string>), GatewayConfig gatewayConfig = default(GatewayConfig), bool isGateway = default(bool), ErrorStatus lastErrorStatus = default(ErrorStatus), LogLevel? logLevel = default(LogLevel?), Dictionary<string, string> metadata = default(Dictionary<string, string>), DeviceConfig config = default(DeviceConfig), DeviceState state = default(DeviceState), Policy policy = default(Policy))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Device and cannot be null");
            }
            this.Id = id;
            this.Blocked = blocked;
            this.Credentials = credentials;
            this.Gateway = gateway;
            this.GatewayConfig = gatewayConfig;
            this.IsGateway = isGateway;
            this.LastErrorStatus = lastErrorStatus;
            this.LogLevel = logLevel;
            this.Metadata = metadata;
            this.Config = config;
            this.State = state;
            this.Policy = policy;
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
        /// Gets or Sets NumId
        /// </summary>
        [DataMember(Name = "numId", EmitDefaultValue = false)]
        public string NumId { get; private set; }

        /// <summary>
        /// Returns false as NumId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeNumId()
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
        /// Gets or Sets Registry
        /// </summary>
        [DataMember(Name = "registry", EmitDefaultValue = false)]
        public string Registry { get; private set; }

        /// <summary>
        /// Returns false as Registry should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRegistry()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Blocked
        /// </summary>
        [DataMember(Name = "blocked", EmitDefaultValue = true)]
        public bool Blocked { get; set; }

        /// <summary>
        /// Gets or Sets Capresent
        /// </summary>
        [DataMember(Name = "capresent", EmitDefaultValue = true)]
        public bool Capresent { get; private set; }

        /// <summary>
        /// Returns false as Capresent should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCapresent()
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
        public List<DeviceCredential> Credentials { get; set; }

        /// <summary>
        /// Gets or Sets Gateway
        /// </summary>
        [DataMember(Name = "gateway", EmitDefaultValue = false)]
        public List<string> Gateway { get; set; }

        /// <summary>
        /// Gets or Sets GatewayConfig
        /// </summary>
        [DataMember(Name = "gatewayConfig", EmitDefaultValue = false)]
        public GatewayConfig GatewayConfig { get; set; }

        /// <summary>
        /// Gets or Sets IsGateway
        /// </summary>
        [DataMember(Name = "isGateway", EmitDefaultValue = true)]
        public bool IsGateway { get; set; }

        /// <summary>
        /// Gets or Sets DeviceErrors
        /// </summary>
        [DataMember(Name = "deviceErrors", EmitDefaultValue = false)]
        public string DeviceErrors { get; private set; }

        /// <summary>
        /// Returns false as DeviceErrors should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDeviceErrors()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets ClientOnline
        /// </summary>
        [DataMember(Name = "clientOnline", EmitDefaultValue = true)]
        public bool ClientOnline { get; private set; }

        /// <summary>
        /// Returns false as ClientOnline should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeClientOnline()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastConfigAckTime
        /// </summary>
        [DataMember(Name = "lastConfigAckTime", EmitDefaultValue = false)]
        public string LastConfigAckTime { get; private set; }

        /// <summary>
        /// Returns false as LastConfigAckTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastConfigAckTime()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastConfigSendTime
        /// </summary>
        [DataMember(Name = "lastConfigSendTime", EmitDefaultValue = false)]
        public string LastConfigSendTime { get; private set; }

        /// <summary>
        /// Returns false as LastConfigSendTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastConfigSendTime()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastErrorStatus
        /// </summary>
        [DataMember(Name = "lastErrorStatus", EmitDefaultValue = false)]
        public ErrorStatus LastErrorStatus { get; set; }

        /// <summary>
        /// Gets or Sets LastErrorTime
        /// </summary>
        [DataMember(Name = "lastErrorTime", EmitDefaultValue = false)]
        public string LastErrorTime { get; private set; }

        /// <summary>
        /// Returns false as LastErrorTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastErrorTime()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastEventTime
        /// </summary>
        [DataMember(Name = "lastEventTime", EmitDefaultValue = false)]
        public string LastEventTime { get; private set; }

        /// <summary>
        /// Returns false as LastEventTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastEventTime()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastHeartbeatTime
        /// </summary>
        [DataMember(Name = "lastHeartbeatTime", EmitDefaultValue = false)]
        public string LastHeartbeatTime { get; private set; }

        /// <summary>
        /// Returns false as LastHeartbeatTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastHeartbeatTime()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets LastStateTime
        /// </summary>
        [DataMember(Name = "lastStateTime", EmitDefaultValue = false)]
        public string LastStateTime { get; private set; }

        /// <summary>
        /// Returns false as LastStateTime should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeLastStateTime()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets Metadata
        /// </summary>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public DeviceConfig Config { get; set; }

        /// <summary>
        /// Gets or Sets State
        /// </summary>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public DeviceState State { get; set; }

        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name = "policy", EmitDefaultValue = false)]
        public Policy Policy { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Device {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  NumId: ").Append(NumId).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Registry: ").Append(Registry).Append("\n");
            sb.Append("  Blocked: ").Append(Blocked).Append("\n");
            sb.Append("  Capresent: ").Append(Capresent).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  UpdatedOn: ").Append(UpdatedOn).Append("\n");
            sb.Append("  Credentials: ").Append(Credentials).Append("\n");
            sb.Append("  Gateway: ").Append(Gateway).Append("\n");
            sb.Append("  GatewayConfig: ").Append(GatewayConfig).Append("\n");
            sb.Append("  IsGateway: ").Append(IsGateway).Append("\n");
            sb.Append("  DeviceErrors: ").Append(DeviceErrors).Append("\n");
            sb.Append("  ClientOnline: ").Append(ClientOnline).Append("\n");
            sb.Append("  LastConfigAckTime: ").Append(LastConfigAckTime).Append("\n");
            sb.Append("  LastConfigSendTime: ").Append(LastConfigSendTime).Append("\n");
            sb.Append("  LastErrorStatus: ").Append(LastErrorStatus).Append("\n");
            sb.Append("  LastErrorTime: ").Append(LastErrorTime).Append("\n");
            sb.Append("  LastEventTime: ").Append(LastEventTime).Append("\n");
            sb.Append("  LastHeartbeatTime: ").Append(LastHeartbeatTime).Append("\n");
            sb.Append("  LastStateTime: ").Append(LastStateTime).Append("\n");
            sb.Append("  LogLevel: ").Append(LogLevel).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
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
            return this.Equals(input as Device);
        }

        /// <summary>
        /// Returns true if Device instances are equal
        /// </summary>
        /// <param name="input">Instance of Device to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Device input)
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
                    this.NumId == input.NumId ||
                    (this.NumId != null &&
                    this.NumId.Equals(input.NumId))
                ) && 
                (
                    this.Parent == input.Parent ||
                    (this.Parent != null &&
                    this.Parent.Equals(input.Parent))
                ) && 
                (
                    this.Registry == input.Registry ||
                    (this.Registry != null &&
                    this.Registry.Equals(input.Registry))
                ) && 
                (
                    this.Blocked == input.Blocked ||
                    this.Blocked.Equals(input.Blocked)
                ) && 
                (
                    this.Capresent == input.Capresent ||
                    this.Capresent.Equals(input.Capresent)
                ) && 
                (
                    this.Subscription == input.Subscription ||
                    (this.Subscription != null &&
                    this.Subscription.Equals(input.Subscription))
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
                    this.Gateway == input.Gateway ||
                    this.Gateway != null &&
                    input.Gateway != null &&
                    this.Gateway.SequenceEqual(input.Gateway)
                ) && 
                (
                    this.GatewayConfig == input.GatewayConfig ||
                    (this.GatewayConfig != null &&
                    this.GatewayConfig.Equals(input.GatewayConfig))
                ) && 
                (
                    this.IsGateway == input.IsGateway ||
                    this.IsGateway.Equals(input.IsGateway)
                ) && 
                (
                    this.DeviceErrors == input.DeviceErrors ||
                    (this.DeviceErrors != null &&
                    this.DeviceErrors.Equals(input.DeviceErrors))
                ) && 
                (
                    this.ClientOnline == input.ClientOnline ||
                    this.ClientOnline.Equals(input.ClientOnline)
                ) && 
                (
                    this.LastConfigAckTime == input.LastConfigAckTime ||
                    (this.LastConfigAckTime != null &&
                    this.LastConfigAckTime.Equals(input.LastConfigAckTime))
                ) && 
                (
                    this.LastConfigSendTime == input.LastConfigSendTime ||
                    (this.LastConfigSendTime != null &&
                    this.LastConfigSendTime.Equals(input.LastConfigSendTime))
                ) && 
                (
                    this.LastErrorStatus == input.LastErrorStatus ||
                    (this.LastErrorStatus != null &&
                    this.LastErrorStatus.Equals(input.LastErrorStatus))
                ) && 
                (
                    this.LastErrorTime == input.LastErrorTime ||
                    (this.LastErrorTime != null &&
                    this.LastErrorTime.Equals(input.LastErrorTime))
                ) && 
                (
                    this.LastEventTime == input.LastEventTime ||
                    (this.LastEventTime != null &&
                    this.LastEventTime.Equals(input.LastEventTime))
                ) && 
                (
                    this.LastHeartbeatTime == input.LastHeartbeatTime ||
                    (this.LastHeartbeatTime != null &&
                    this.LastHeartbeatTime.Equals(input.LastHeartbeatTime))
                ) && 
                (
                    this.LastStateTime == input.LastStateTime ||
                    (this.LastStateTime != null &&
                    this.LastStateTime.Equals(input.LastStateTime))
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
                ) && 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.Policy == input.Policy ||
                    (this.Policy != null &&
                    this.Policy.Equals(input.Policy))
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
                if (this.NumId != null)
                {
                    hashCode = (hashCode * 59) + this.NumId.GetHashCode();
                }
                if (this.Parent != null)
                {
                    hashCode = (hashCode * 59) + this.Parent.GetHashCode();
                }
                if (this.Registry != null)
                {
                    hashCode = (hashCode * 59) + this.Registry.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Blocked.GetHashCode();
                hashCode = (hashCode * 59) + this.Capresent.GetHashCode();
                if (this.Subscription != null)
                {
                    hashCode = (hashCode * 59) + this.Subscription.GetHashCode();
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
                if (this.Gateway != null)
                {
                    hashCode = (hashCode * 59) + this.Gateway.GetHashCode();
                }
                if (this.GatewayConfig != null)
                {
                    hashCode = (hashCode * 59) + this.GatewayConfig.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsGateway.GetHashCode();
                if (this.DeviceErrors != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceErrors.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ClientOnline.GetHashCode();
                if (this.LastConfigAckTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastConfigAckTime.GetHashCode();
                }
                if (this.LastConfigSendTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastConfigSendTime.GetHashCode();
                }
                if (this.LastErrorStatus != null)
                {
                    hashCode = (hashCode * 59) + this.LastErrorStatus.GetHashCode();
                }
                if (this.LastErrorTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastErrorTime.GetHashCode();
                }
                if (this.LastEventTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastEventTime.GetHashCode();
                }
                if (this.LastHeartbeatTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastHeartbeatTime.GetHashCode();
                }
                if (this.LastStateTime != null)
                {
                    hashCode = (hashCode * 59) + this.LastStateTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LogLevel.GetHashCode();
                if (this.Metadata != null)
                {
                    hashCode = (hashCode * 59) + this.Metadata.GetHashCode();
                }
                if (this.Config != null)
                {
                    hashCode = (hashCode * 59) + this.Config.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                if (this.Policy != null)
                {
                    hashCode = (hashCode * 59) + this.Policy.GetHashCode();
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
