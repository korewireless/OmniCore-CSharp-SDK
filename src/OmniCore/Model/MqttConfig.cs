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
    /// MqttConfig
    /// </summary>
    [DataContract(Name = "MqttConfig")]
    public partial class MqttConfig : IEquatable<MqttConfig>, IValidatableObject
    {
        /// <summary>
        /// MqttEnabledState: If enabled, allows connections using the MQTT protocol. Otherwise, MQTT connections to this registry will fail.  Possible values:   \&quot;MQTT_STATE_UNSPECIFIED\&quot; - No MQTT state specified. If not specified, MQTT will be enabled by default.   \&quot;MQTT_ENABLED\&quot; - Enables a MQTT connection.   \&quot;MQTT_DISABLED\&quot; - Disables a MQTT connection.
        /// </summary>
        /// <value>MqttEnabledState: If enabled, allows connections using the MQTT protocol. Otherwise, MQTT connections to this registry will fail.  Possible values:   \&quot;MQTT_STATE_UNSPECIFIED\&quot; - No MQTT state specified. If not specified, MQTT will be enabled by default.   \&quot;MQTT_ENABLED\&quot; - Enables a MQTT connection.   \&quot;MQTT_DISABLED\&quot; - Disables a MQTT connection.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MqttEnabledStateEnum
        {
            /// <summary>
            /// Enum ENABLED for value: MQTT_ENABLED
            /// </summary>
            [EnumMember(Value = "MQTT_ENABLED")]
            ENABLED = 1,

            /// <summary>
            /// Enum DISABLED for value: MQTT_DISABLED
            /// </summary>
            [EnumMember(Value = "MQTT_DISABLED")]
            DISABLED = 2,

            /// <summary>
            /// Enum STATEUNSPECIFIED for value: MQTT_STATE_UNSPECIFIED
            /// </summary>
            [EnumMember(Value = "MQTT_STATE_UNSPECIFIED")]
            STATEUNSPECIFIED = 3

        }


        /// <summary>
        /// MqttEnabledState: If enabled, allows connections using the MQTT protocol. Otherwise, MQTT connections to this registry will fail.  Possible values:   \&quot;MQTT_STATE_UNSPECIFIED\&quot; - No MQTT state specified. If not specified, MQTT will be enabled by default.   \&quot;MQTT_ENABLED\&quot; - Enables a MQTT connection.   \&quot;MQTT_DISABLED\&quot; - Disables a MQTT connection.
        /// </summary>
        /// <value>MqttEnabledState: If enabled, allows connections using the MQTT protocol. Otherwise, MQTT connections to this registry will fail.  Possible values:   \&quot;MQTT_STATE_UNSPECIFIED\&quot; - No MQTT state specified. If not specified, MQTT will be enabled by default.   \&quot;MQTT_ENABLED\&quot; - Enables a MQTT connection.   \&quot;MQTT_DISABLED\&quot; - Disables a MQTT connection.</value>
        [DataMember(Name = "mqttEnabledState", EmitDefaultValue = false)]
        public MqttEnabledStateEnum? MqttEnabledState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MqttConfig" /> class.
        /// </summary>
        /// <param name="mqttEnabledState">MqttEnabledState: If enabled, allows connections using the MQTT protocol. Otherwise, MQTT connections to this registry will fail.  Possible values:   \&quot;MQTT_STATE_UNSPECIFIED\&quot; - No MQTT state specified. If not specified, MQTT will be enabled by default.   \&quot;MQTT_ENABLED\&quot; - Enables a MQTT connection.   \&quot;MQTT_DISABLED\&quot; - Disables a MQTT connection..</param>
        public MqttConfig(MqttEnabledStateEnum? mqttEnabledState = default(MqttEnabledStateEnum?))
        {
            this.MqttEnabledState = mqttEnabledState;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MqttConfig {\n");
            sb.Append("  MqttEnabledState: ").Append(MqttEnabledState).Append("\n");
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
            return this.Equals(input as MqttConfig);
        }

        /// <summary>
        /// Returns true if MqttConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of MqttConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MqttConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MqttEnabledState == input.MqttEnabledState ||
                    this.MqttEnabledState.Equals(input.MqttEnabledState)
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
                hashCode = (hashCode * 59) + this.MqttEnabledState.GetHashCode();
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
