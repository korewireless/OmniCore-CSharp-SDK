/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.8.5
 * Contact: omnicoresupport@korewireless.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using OmniCore.Api;
using OmniCore.Model;
using OmniCore.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace OmniCore.Test.Model
{
    /// <summary>
    ///  Class for testing MetricsDetails
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MetricsDetailsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MetricsDetails
        //private MetricsDetails instance;

        public MetricsDetailsTests()
        {
            // TODO uncomment below to create an instance of MetricsDetails
            //instance = new MetricsDetails();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MetricsDetails
        /// </summary>
        [Fact]
        public void MetricsDetailsInstanceTest()
        {
            // TODO uncomment below to test "IsType" MetricsDetails
            //Assert.IsType<MetricsDetails>(instance);
        }


        /// <summary>
        /// Test the property 'NoOfMessagesFor30Minutes'
        /// </summary>
        [Fact]
        public void NoOfMessagesFor30MinutesTest()
        {
            // TODO unit test for the property 'NoOfMessagesFor30Minutes'
        }
        /// <summary>
        /// Test the property 'NoOfMessagesFor48Hours'
        /// </summary>
        [Fact]
        public void NoOfMessagesFor48HoursTest()
        {
            // TODO unit test for the property 'NoOfMessagesFor48Hours'
        }
        /// <summary>
        /// Test the property 'BillableBytesReceived'
        /// </summary>
        [Fact]
        public void BillableBytesReceivedTest()
        {
            // TODO unit test for the property 'BillableBytesReceived'
        }
        /// <summary>
        /// Test the property 'BillableBytesSent'
        /// </summary>
        [Fact]
        public void BillableBytesSentTest()
        {
            // TODO unit test for the property 'BillableBytesSent'
        }
        /// <summary>
        /// Test the property 'BillableMessageSize'
        /// </summary>
        [Fact]
        public void BillableMessageSizeTest()
        {
            // TODO unit test for the property 'BillableMessageSize'
        }
        /// <summary>
        /// Test the property 'BytesReceived'
        /// </summary>
        [Fact]
        public void BytesReceivedTest()
        {
            // TODO unit test for the property 'BytesReceived'
        }
        /// <summary>
        /// Test the property 'BytesSent'
        /// </summary>
        [Fact]
        public void BytesSentTest()
        {
            // TODO unit test for the property 'BytesSent'
        }
        /// <summary>
        /// Test the property 'MessageSize'
        /// </summary>
        [Fact]
        public void MessageSizeTest()
        {
            // TODO unit test for the property 'MessageSize'
        }
        /// <summary>
        /// Test the property 'NoOfAckMessages'
        /// </summary>
        [Fact]
        public void NoOfAckMessagesTest()
        {
            // TODO unit test for the property 'NoOfAckMessages'
        }
        /// <summary>
        /// Test the property 'NoOfCommandMessages'
        /// </summary>
        [Fact]
        public void NoOfCommandMessagesTest()
        {
            // TODO unit test for the property 'NoOfCommandMessages'
        }
        /// <summary>
        /// Test the property 'NoOfConfigMessages'
        /// </summary>
        [Fact]
        public void NoOfConfigMessagesTest()
        {
            // TODO unit test for the property 'NoOfConfigMessages'
        }
        /// <summary>
        /// Test the property 'NoOfDeviceConnectionsFailed'
        /// </summary>
        [Fact]
        public void NoOfDeviceConnectionsFailedTest()
        {
            // TODO unit test for the property 'NoOfDeviceConnectionsFailed'
        }
        /// <summary>
        /// Test the property 'NoOfDevices'
        /// </summary>
        [Fact]
        public void NoOfDevicesTest()
        {
            // TODO unit test for the property 'NoOfDevices'
        }
        /// <summary>
        /// Test the property 'NoOfDisConnections'
        /// </summary>
        [Fact]
        public void NoOfDisConnectionsTest()
        {
            // TODO unit test for the property 'NoOfDisConnections'
        }
        /// <summary>
        /// Test the property 'NoOfEventMessages'
        /// </summary>
        [Fact]
        public void NoOfEventMessagesTest()
        {
            // TODO unit test for the property 'NoOfEventMessages'
        }
        /// <summary>
        /// Test the property 'NoOfGatewayConnectionsFailed'
        /// </summary>
        [Fact]
        public void NoOfGatewayConnectionsFailedTest()
        {
            // TODO unit test for the property 'NoOfGatewayConnectionsFailed'
        }
        /// <summary>
        /// Test the property 'NoOfGateways'
        /// </summary>
        [Fact]
        public void NoOfGatewaysTest()
        {
            // TODO unit test for the property 'NoOfGateways'
        }
        /// <summary>
        /// Test the property 'NoOfLoopBackMessages'
        /// </summary>
        [Fact]
        public void NoOfLoopBackMessagesTest()
        {
            // TODO unit test for the property 'NoOfLoopBackMessages'
        }
        /// <summary>
        /// Test the property 'NoOfMessages'
        /// </summary>
        [Fact]
        public void NoOfMessagesTest()
        {
            // TODO unit test for the property 'NoOfMessages'
        }
        /// <summary>
        /// Test the property 'NoOfPublishErrors'
        /// </summary>
        [Fact]
        public void NoOfPublishErrorsTest()
        {
            // TODO unit test for the property 'NoOfPublishErrors'
        }
        /// <summary>
        /// Test the property 'NoOfRegistries'
        /// </summary>
        [Fact]
        public void NoOfRegistriesTest()
        {
            // TODO unit test for the property 'NoOfRegistries'
        }
        /// <summary>
        /// Test the property 'NoOfStateMessages'
        /// </summary>
        [Fact]
        public void NoOfStateMessagesTest()
        {
            // TODO unit test for the property 'NoOfStateMessages'
        }
        /// <summary>
        /// Test the property 'NoOfSubscribe'
        /// </summary>
        [Fact]
        public void NoOfSubscribeTest()
        {
            // TODO unit test for the property 'NoOfSubscribe'
        }
        /// <summary>
        /// Test the property 'NoOfSuccessfulConnections'
        /// </summary>
        [Fact]
        public void NoOfSuccessfulConnectionsTest()
        {
            // TODO unit test for the property 'NoOfSuccessfulConnections'
        }
        /// <summary>
        /// Test the property 'NoOfUnSubscribe'
        /// </summary>
        [Fact]
        public void NoOfUnSubscribeTest()
        {
            // TODO unit test for the property 'NoOfUnSubscribe'
        }
        /// <summary>
        /// Test the property 'SubscriptionId'
        /// </summary>
        [Fact]
        public void SubscriptionIdTest()
        {
            // TODO unit test for the property 'SubscriptionId'
        }

    }

}
