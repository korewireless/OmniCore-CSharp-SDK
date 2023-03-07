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
    /// HttpConfig
    /// </summary>
    [DataContract(Name = "HttpConfig")]
    public partial class HttpConfig : IEquatable<HttpConfig>, IValidatableObject
    {
        /// <summary>
        /// HttpEnabledState: If enabled, allows devices to use DeviceService via the HTTP protocol. Otherwise, any requests to DeviceService will fail for this registry.  Possible values:   \&quot;HTTP_STATE_UNSPECIFIED\&quot; - No HTTP state specified. If not specified, DeviceService will be enabled by default.   \&quot;HTTP_ENABLED\&quot; - Enables DeviceService (HTTP) service for the registry.   \&quot;HTTP_DISABLED\&quot; - Disables DeviceService (HTTP) service for the registry.
        /// </summary>
        /// <value>HttpEnabledState: If enabled, allows devices to use DeviceService via the HTTP protocol. Otherwise, any requests to DeviceService will fail for this registry.  Possible values:   \&quot;HTTP_STATE_UNSPECIFIED\&quot; - No HTTP state specified. If not specified, DeviceService will be enabled by default.   \&quot;HTTP_ENABLED\&quot; - Enables DeviceService (HTTP) service for the registry.   \&quot;HTTP_DISABLED\&quot; - Disables DeviceService (HTTP) service for the registry.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HttpEnabledStateEnum
        {
            /// <summary>
            /// Enum ENABLED for value: HTTP_ENABLED
            /// </summary>
            [EnumMember(Value = "HTTP_ENABLED")]
            ENABLED = 1,

            /// <summary>
            /// Enum DISABLED for value: HTTP_DISABLED
            /// </summary>
            [EnumMember(Value = "HTTP_DISABLED")]
            DISABLED = 2,

            /// <summary>
            /// Enum STATEUNSPECIFIED for value: HTTP_STATE_UNSPECIFIED
            /// </summary>
            [EnumMember(Value = "HTTP_STATE_UNSPECIFIED")]
            STATEUNSPECIFIED = 3

        }


        /// <summary>
        /// HttpEnabledState: If enabled, allows devices to use DeviceService via the HTTP protocol. Otherwise, any requests to DeviceService will fail for this registry.  Possible values:   \&quot;HTTP_STATE_UNSPECIFIED\&quot; - No HTTP state specified. If not specified, DeviceService will be enabled by default.   \&quot;HTTP_ENABLED\&quot; - Enables DeviceService (HTTP) service for the registry.   \&quot;HTTP_DISABLED\&quot; - Disables DeviceService (HTTP) service for the registry.
        /// </summary>
        /// <value>HttpEnabledState: If enabled, allows devices to use DeviceService via the HTTP protocol. Otherwise, any requests to DeviceService will fail for this registry.  Possible values:   \&quot;HTTP_STATE_UNSPECIFIED\&quot; - No HTTP state specified. If not specified, DeviceService will be enabled by default.   \&quot;HTTP_ENABLED\&quot; - Enables DeviceService (HTTP) service for the registry.   \&quot;HTTP_DISABLED\&quot; - Disables DeviceService (HTTP) service for the registry.</value>
        [DataMember(Name = "httpEnabledState", EmitDefaultValue = false)]
        public HttpEnabledStateEnum? HttpEnabledState { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HttpConfig" /> class.
        /// </summary>
        /// <param name="httpEnabledState">HttpEnabledState: If enabled, allows devices to use DeviceService via the HTTP protocol. Otherwise, any requests to DeviceService will fail for this registry.  Possible values:   \&quot;HTTP_STATE_UNSPECIFIED\&quot; - No HTTP state specified. If not specified, DeviceService will be enabled by default.   \&quot;HTTP_ENABLED\&quot; - Enables DeviceService (HTTP) service for the registry.   \&quot;HTTP_DISABLED\&quot; - Disables DeviceService (HTTP) service for the registry..</param>
        public HttpConfig(HttpEnabledStateEnum? httpEnabledState = default(HttpEnabledStateEnum?))
        {
            this.HttpEnabledState = httpEnabledState;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class HttpConfig {\n");
            sb.Append("  HttpEnabledState: ").Append(HttpEnabledState).Append("\n");
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
            return this.Equals(input as HttpConfig);
        }

        /// <summary>
        /// Returns true if HttpConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of HttpConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HttpConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HttpEnabledState == input.HttpEnabledState ||
                    this.HttpEnabledState.Equals(input.HttpEnabledState)
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
                hashCode = (hashCode * 59) + this.HttpEnabledState.GetHashCode();
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
