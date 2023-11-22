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
    /// MetricsDetails
    /// </summary>
    [DataContract(Name = "Metrics_details")]
    public partial class MetricsDetails : IEquatable<MetricsDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricsDetails" /> class.
        /// </summary>
        /// <param name="noOfMessagesFor30Minutes">noOfMessagesFor30Minutes.</param>
        /// <param name="noOfMessagesFor48Hours">noOfMessagesFor48Hours.</param>
        /// <param name="billableBytesReceived">billableBytesReceived.</param>
        /// <param name="billableBytesSent">billableBytesSent.</param>
        /// <param name="billableMessageSize">billableMessageSize.</param>
        /// <param name="bytesReceived">bytesReceived.</param>
        /// <param name="bytesSent">bytesSent.</param>
        /// <param name="messageSize">messageSize.</param>
        /// <param name="noOfAckMessages">noOfAckMessages.</param>
        /// <param name="noOfCommandMessages">noOfCommandMessages.</param>
        /// <param name="noOfConfigMessages">noOfConfigMessages.</param>
        /// <param name="noOfDeviceConnectionsFailed">noOfDeviceConnectionsFailed.</param>
        /// <param name="noOfDevices">noOfDevices.</param>
        /// <param name="noOfDisConnections">noOfDisConnections.</param>
        /// <param name="noOfEventMessages">noOfEventMessages.</param>
        /// <param name="noOfGatewayConnectionsFailed">noOfGatewayConnectionsFailed.</param>
        /// <param name="noOfGateways">noOfGateways.</param>
        /// <param name="noOfLoopBackMessages">noOfLoopBackMessages.</param>
        /// <param name="noOfMessages">noOfMessages.</param>
        /// <param name="noOfPublishErrors">noOfPublishErrors.</param>
        /// <param name="noOfRegistries">noOfRegistries.</param>
        /// <param name="noOfStateMessages">noOfStateMessages.</param>
        /// <param name="noOfSubscribe">noOfSubscribe.</param>
        /// <param name="noOfSuccessfulConnections">noOfSuccessfulConnections.</param>
        /// <param name="noOfUnSubscribe">noOfUnSubscribe.</param>
        /// <param name="subscriptionId">subscriptionId.</param>
        public MetricsDetails(List<Object> noOfMessagesFor30Minutes = default(List<Object>), List<Object> noOfMessagesFor48Hours = default(List<Object>), int billableBytesReceived = default(int), int billableBytesSent = default(int), int billableMessageSize = default(int), int bytesReceived = default(int), int bytesSent = default(int), int messageSize = default(int), int noOfAckMessages = default(int), int noOfCommandMessages = default(int), int noOfConfigMessages = default(int), int noOfDeviceConnectionsFailed = default(int), int noOfDevices = default(int), int noOfDisConnections = default(int), int noOfEventMessages = default(int), int noOfGatewayConnectionsFailed = default(int), int noOfGateways = default(int), int noOfLoopBackMessages = default(int), int noOfMessages = default(int), int noOfPublishErrors = default(int), int noOfRegistries = default(int), int noOfStateMessages = default(int), int noOfSubscribe = default(int), int noOfSuccessfulConnections = default(int), int noOfUnSubscribe = default(int), string subscriptionId = default(string))
        {
            this.NoOfMessagesFor30Minutes = noOfMessagesFor30Minutes;
            this.NoOfMessagesFor48Hours = noOfMessagesFor48Hours;
            this.BillableBytesReceived = billableBytesReceived;
            this.BillableBytesSent = billableBytesSent;
            this.BillableMessageSize = billableMessageSize;
            this.BytesReceived = bytesReceived;
            this.BytesSent = bytesSent;
            this.MessageSize = messageSize;
            this.NoOfAckMessages = noOfAckMessages;
            this.NoOfCommandMessages = noOfCommandMessages;
            this.NoOfConfigMessages = noOfConfigMessages;
            this.NoOfDeviceConnectionsFailed = noOfDeviceConnectionsFailed;
            this.NoOfDevices = noOfDevices;
            this.NoOfDisConnections = noOfDisConnections;
            this.NoOfEventMessages = noOfEventMessages;
            this.NoOfGatewayConnectionsFailed = noOfGatewayConnectionsFailed;
            this.NoOfGateways = noOfGateways;
            this.NoOfLoopBackMessages = noOfLoopBackMessages;
            this.NoOfMessages = noOfMessages;
            this.NoOfPublishErrors = noOfPublishErrors;
            this.NoOfRegistries = noOfRegistries;
            this.NoOfStateMessages = noOfStateMessages;
            this.NoOfSubscribe = noOfSubscribe;
            this.NoOfSuccessfulConnections = noOfSuccessfulConnections;
            this.NoOfUnSubscribe = noOfUnSubscribe;
            this.SubscriptionId = subscriptionId;
        }

        /// <summary>
        /// Gets or Sets NoOfMessagesFor30Minutes
        /// </summary>
        [DataMember(Name = "NoOfMessagesFor30Minutes", EmitDefaultValue = false)]
        public List<Object> NoOfMessagesFor30Minutes { get; set; }

        /// <summary>
        /// Gets or Sets NoOfMessagesFor48Hours
        /// </summary>
        [DataMember(Name = "NoOfMessagesFor48Hours", EmitDefaultValue = false)]
        public List<Object> NoOfMessagesFor48Hours { get; set; }

        /// <summary>
        /// Gets or Sets BillableBytesReceived
        /// </summary>
        [DataMember(Name = "billableBytesReceived", EmitDefaultValue = false)]
        public int BillableBytesReceived { get; set; }

        /// <summary>
        /// Gets or Sets BillableBytesSent
        /// </summary>
        [DataMember(Name = "billableBytesSent", EmitDefaultValue = false)]
        public int BillableBytesSent { get; set; }

        /// <summary>
        /// Gets or Sets BillableMessageSize
        /// </summary>
        [DataMember(Name = "billableMessageSize", EmitDefaultValue = false)]
        public int BillableMessageSize { get; set; }

        /// <summary>
        /// Gets or Sets BytesReceived
        /// </summary>
        [DataMember(Name = "bytesReceived", EmitDefaultValue = false)]
        public int BytesReceived { get; set; }

        /// <summary>
        /// Gets or Sets BytesSent
        /// </summary>
        [DataMember(Name = "bytesSent", EmitDefaultValue = false)]
        public int BytesSent { get; set; }

        /// <summary>
        /// Gets or Sets MessageSize
        /// </summary>
        [DataMember(Name = "messageSize", EmitDefaultValue = false)]
        public int MessageSize { get; set; }

        /// <summary>
        /// Gets or Sets NoOfAckMessages
        /// </summary>
        [DataMember(Name = "noOfAckMessages", EmitDefaultValue = false)]
        public int NoOfAckMessages { get; set; }

        /// <summary>
        /// Gets or Sets NoOfCommandMessages
        /// </summary>
        [DataMember(Name = "noOfCommandMessages", EmitDefaultValue = false)]
        public int NoOfCommandMessages { get; set; }

        /// <summary>
        /// Gets or Sets NoOfConfigMessages
        /// </summary>
        [DataMember(Name = "noOfConfigMessages", EmitDefaultValue = false)]
        public int NoOfConfigMessages { get; set; }

        /// <summary>
        /// Gets or Sets NoOfDeviceConnectionsFailed
        /// </summary>
        [DataMember(Name = "noOfDeviceConnectionsFailed", EmitDefaultValue = false)]
        public int NoOfDeviceConnectionsFailed { get; set; }

        /// <summary>
        /// Gets or Sets NoOfDevices
        /// </summary>
        [DataMember(Name = "noOfDevices", EmitDefaultValue = false)]
        public int NoOfDevices { get; set; }

        /// <summary>
        /// Gets or Sets NoOfDisConnections
        /// </summary>
        [DataMember(Name = "noOfDisConnections", EmitDefaultValue = false)]
        public int NoOfDisConnections { get; set; }

        /// <summary>
        /// Gets or Sets NoOfEventMessages
        /// </summary>
        [DataMember(Name = "noOfEventMessages", EmitDefaultValue = false)]
        public int NoOfEventMessages { get; set; }

        /// <summary>
        /// Gets or Sets NoOfGatewayConnectionsFailed
        /// </summary>
        [DataMember(Name = "noOfGatewayConnectionsFailed", EmitDefaultValue = false)]
        public int NoOfGatewayConnectionsFailed { get; set; }

        /// <summary>
        /// Gets or Sets NoOfGateways
        /// </summary>
        [DataMember(Name = "noOfGateways", EmitDefaultValue = false)]
        public int NoOfGateways { get; set; }

        /// <summary>
        /// Gets or Sets NoOfLoopBackMessages
        /// </summary>
        [DataMember(Name = "noOfLoopBackMessages", EmitDefaultValue = false)]
        public int NoOfLoopBackMessages { get; set; }

        /// <summary>
        /// Gets or Sets NoOfMessages
        /// </summary>
        [DataMember(Name = "noOfMessages", EmitDefaultValue = false)]
        public int NoOfMessages { get; set; }

        /// <summary>
        /// Gets or Sets NoOfPublishErrors
        /// </summary>
        [DataMember(Name = "noOfPublishErrors", EmitDefaultValue = false)]
        public int NoOfPublishErrors { get; set; }

        /// <summary>
        /// Gets or Sets NoOfRegistries
        /// </summary>
        [DataMember(Name = "noOfRegistries", EmitDefaultValue = false)]
        public int NoOfRegistries { get; set; }

        /// <summary>
        /// Gets or Sets NoOfStateMessages
        /// </summary>
        [DataMember(Name = "noOfStateMessages", EmitDefaultValue = false)]
        public int NoOfStateMessages { get; set; }

        /// <summary>
        /// Gets or Sets NoOfSubscribe
        /// </summary>
        [DataMember(Name = "noOfSubscribe", EmitDefaultValue = false)]
        public int NoOfSubscribe { get; set; }

        /// <summary>
        /// Gets or Sets NoOfSuccessfulConnections
        /// </summary>
        [DataMember(Name = "noOfSuccessfulConnections", EmitDefaultValue = false)]
        public int NoOfSuccessfulConnections { get; set; }

        /// <summary>
        /// Gets or Sets NoOfUnSubscribe
        /// </summary>
        [DataMember(Name = "noOfUnSubscribe", EmitDefaultValue = false)]
        public int NoOfUnSubscribe { get; set; }

        /// <summary>
        /// Gets or Sets SubscriptionId
        /// </summary>
        [DataMember(Name = "subscriptionId", EmitDefaultValue = false)]
        public string SubscriptionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MetricsDetails {\n");
            sb.Append("  NoOfMessagesFor30Minutes: ").Append(NoOfMessagesFor30Minutes).Append("\n");
            sb.Append("  NoOfMessagesFor48Hours: ").Append(NoOfMessagesFor48Hours).Append("\n");
            sb.Append("  BillableBytesReceived: ").Append(BillableBytesReceived).Append("\n");
            sb.Append("  BillableBytesSent: ").Append(BillableBytesSent).Append("\n");
            sb.Append("  BillableMessageSize: ").Append(BillableMessageSize).Append("\n");
            sb.Append("  BytesReceived: ").Append(BytesReceived).Append("\n");
            sb.Append("  BytesSent: ").Append(BytesSent).Append("\n");
            sb.Append("  MessageSize: ").Append(MessageSize).Append("\n");
            sb.Append("  NoOfAckMessages: ").Append(NoOfAckMessages).Append("\n");
            sb.Append("  NoOfCommandMessages: ").Append(NoOfCommandMessages).Append("\n");
            sb.Append("  NoOfConfigMessages: ").Append(NoOfConfigMessages).Append("\n");
            sb.Append("  NoOfDeviceConnectionsFailed: ").Append(NoOfDeviceConnectionsFailed).Append("\n");
            sb.Append("  NoOfDevices: ").Append(NoOfDevices).Append("\n");
            sb.Append("  NoOfDisConnections: ").Append(NoOfDisConnections).Append("\n");
            sb.Append("  NoOfEventMessages: ").Append(NoOfEventMessages).Append("\n");
            sb.Append("  NoOfGatewayConnectionsFailed: ").Append(NoOfGatewayConnectionsFailed).Append("\n");
            sb.Append("  NoOfGateways: ").Append(NoOfGateways).Append("\n");
            sb.Append("  NoOfLoopBackMessages: ").Append(NoOfLoopBackMessages).Append("\n");
            sb.Append("  NoOfMessages: ").Append(NoOfMessages).Append("\n");
            sb.Append("  NoOfPublishErrors: ").Append(NoOfPublishErrors).Append("\n");
            sb.Append("  NoOfRegistries: ").Append(NoOfRegistries).Append("\n");
            sb.Append("  NoOfStateMessages: ").Append(NoOfStateMessages).Append("\n");
            sb.Append("  NoOfSubscribe: ").Append(NoOfSubscribe).Append("\n");
            sb.Append("  NoOfSuccessfulConnections: ").Append(NoOfSuccessfulConnections).Append("\n");
            sb.Append("  NoOfUnSubscribe: ").Append(NoOfUnSubscribe).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
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
            return this.Equals(input as MetricsDetails);
        }

        /// <summary>
        /// Returns true if MetricsDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of MetricsDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetricsDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NoOfMessagesFor30Minutes == input.NoOfMessagesFor30Minutes ||
                    this.NoOfMessagesFor30Minutes != null &&
                    input.NoOfMessagesFor30Minutes != null &&
                    this.NoOfMessagesFor30Minutes.SequenceEqual(input.NoOfMessagesFor30Minutes)
                ) && 
                (
                    this.NoOfMessagesFor48Hours == input.NoOfMessagesFor48Hours ||
                    this.NoOfMessagesFor48Hours != null &&
                    input.NoOfMessagesFor48Hours != null &&
                    this.NoOfMessagesFor48Hours.SequenceEqual(input.NoOfMessagesFor48Hours)
                ) && 
                (
                    this.BillableBytesReceived == input.BillableBytesReceived ||
                    this.BillableBytesReceived.Equals(input.BillableBytesReceived)
                ) && 
                (
                    this.BillableBytesSent == input.BillableBytesSent ||
                    this.BillableBytesSent.Equals(input.BillableBytesSent)
                ) && 
                (
                    this.BillableMessageSize == input.BillableMessageSize ||
                    this.BillableMessageSize.Equals(input.BillableMessageSize)
                ) && 
                (
                    this.BytesReceived == input.BytesReceived ||
                    this.BytesReceived.Equals(input.BytesReceived)
                ) && 
                (
                    this.BytesSent == input.BytesSent ||
                    this.BytesSent.Equals(input.BytesSent)
                ) && 
                (
                    this.MessageSize == input.MessageSize ||
                    this.MessageSize.Equals(input.MessageSize)
                ) && 
                (
                    this.NoOfAckMessages == input.NoOfAckMessages ||
                    this.NoOfAckMessages.Equals(input.NoOfAckMessages)
                ) && 
                (
                    this.NoOfCommandMessages == input.NoOfCommandMessages ||
                    this.NoOfCommandMessages.Equals(input.NoOfCommandMessages)
                ) && 
                (
                    this.NoOfConfigMessages == input.NoOfConfigMessages ||
                    this.NoOfConfigMessages.Equals(input.NoOfConfigMessages)
                ) && 
                (
                    this.NoOfDeviceConnectionsFailed == input.NoOfDeviceConnectionsFailed ||
                    this.NoOfDeviceConnectionsFailed.Equals(input.NoOfDeviceConnectionsFailed)
                ) && 
                (
                    this.NoOfDevices == input.NoOfDevices ||
                    this.NoOfDevices.Equals(input.NoOfDevices)
                ) && 
                (
                    this.NoOfDisConnections == input.NoOfDisConnections ||
                    this.NoOfDisConnections.Equals(input.NoOfDisConnections)
                ) && 
                (
                    this.NoOfEventMessages == input.NoOfEventMessages ||
                    this.NoOfEventMessages.Equals(input.NoOfEventMessages)
                ) && 
                (
                    this.NoOfGatewayConnectionsFailed == input.NoOfGatewayConnectionsFailed ||
                    this.NoOfGatewayConnectionsFailed.Equals(input.NoOfGatewayConnectionsFailed)
                ) && 
                (
                    this.NoOfGateways == input.NoOfGateways ||
                    this.NoOfGateways.Equals(input.NoOfGateways)
                ) && 
                (
                    this.NoOfLoopBackMessages == input.NoOfLoopBackMessages ||
                    this.NoOfLoopBackMessages.Equals(input.NoOfLoopBackMessages)
                ) && 
                (
                    this.NoOfMessages == input.NoOfMessages ||
                    this.NoOfMessages.Equals(input.NoOfMessages)
                ) && 
                (
                    this.NoOfPublishErrors == input.NoOfPublishErrors ||
                    this.NoOfPublishErrors.Equals(input.NoOfPublishErrors)
                ) && 
                (
                    this.NoOfRegistries == input.NoOfRegistries ||
                    this.NoOfRegistries.Equals(input.NoOfRegistries)
                ) && 
                (
                    this.NoOfStateMessages == input.NoOfStateMessages ||
                    this.NoOfStateMessages.Equals(input.NoOfStateMessages)
                ) && 
                (
                    this.NoOfSubscribe == input.NoOfSubscribe ||
                    this.NoOfSubscribe.Equals(input.NoOfSubscribe)
                ) && 
                (
                    this.NoOfSuccessfulConnections == input.NoOfSuccessfulConnections ||
                    this.NoOfSuccessfulConnections.Equals(input.NoOfSuccessfulConnections)
                ) && 
                (
                    this.NoOfUnSubscribe == input.NoOfUnSubscribe ||
                    this.NoOfUnSubscribe.Equals(input.NoOfUnSubscribe)
                ) && 
                (
                    this.SubscriptionId == input.SubscriptionId ||
                    (this.SubscriptionId != null &&
                    this.SubscriptionId.Equals(input.SubscriptionId))
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
                if (this.NoOfMessagesFor30Minutes != null)
                {
                    hashCode = (hashCode * 59) + this.NoOfMessagesFor30Minutes.GetHashCode();
                }
                if (this.NoOfMessagesFor48Hours != null)
                {
                    hashCode = (hashCode * 59) + this.NoOfMessagesFor48Hours.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.BillableBytesReceived.GetHashCode();
                hashCode = (hashCode * 59) + this.BillableBytesSent.GetHashCode();
                hashCode = (hashCode * 59) + this.BillableMessageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.BytesReceived.GetHashCode();
                hashCode = (hashCode * 59) + this.BytesSent.GetHashCode();
                hashCode = (hashCode * 59) + this.MessageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfAckMessages.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfCommandMessages.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfConfigMessages.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfDeviceConnectionsFailed.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfDevices.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfDisConnections.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfEventMessages.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfGatewayConnectionsFailed.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfGateways.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfLoopBackMessages.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfMessages.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfPublishErrors.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfRegistries.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfStateMessages.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfSubscribe.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfSuccessfulConnections.GetHashCode();
                hashCode = (hashCode * 59) + this.NoOfUnSubscribe.GetHashCode();
                if (this.SubscriptionId != null)
                {
                    hashCode = (hashCode * 59) + this.SubscriptionId.GetHashCode();
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
