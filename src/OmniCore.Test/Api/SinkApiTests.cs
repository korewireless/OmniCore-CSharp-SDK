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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using OmniCore.Client;
using OmniCore.Api;
// uncomment below to import models
//using OmniCore.Model;

namespace OmniCore.Test.Api
{
    /// <summary>
    ///  Class for testing SinkApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class SinkApiTests : IDisposable
    {
        private SinkApi instance;

        public SinkApiTests()
        {
            instance = new SinkApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of SinkApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' SinkApi
            //Assert.IsType<SinkApi>(instance);
        }

        /// <summary>
        /// Test CreateSink
        /// </summary>
        [Fact]
        public void CreateSinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //Sink sink = null;
            //var response = instance.CreateSink(subscriptionId, sink);
            //Assert.IsType<Sink>(response);
        }

        /// <summary>
        /// Test DeleteSink
        /// </summary>
        [Fact]
        public void DeleteSinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string sinkId = null;
            //var response = instance.DeleteSink(subscriptionId, sinkId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetASink
        /// </summary>
        [Fact]
        public void GetASinkTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string sinkId = null;
            //var response = instance.GetASink(subscriptionId, sinkId);
            //Assert.IsType<Sink>(response);
        }

        /// <summary>
        /// Test GetSinks
        /// </summary>
        [Fact]
        public void GetSinksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //var response = instance.GetSinks(subscriptionId);
            //Assert.IsType<ListSinks>(response);
        }
    }
}
