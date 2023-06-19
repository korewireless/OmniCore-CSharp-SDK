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
    ///  Class for testing MetricsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MetricsApiTests : IDisposable
    {
        private MetricsApi instance;

        public MetricsApiTests()
        {
            instance = new MetricsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MetricsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MetricsApi
            //Assert.IsType<MetricsApi>(instance);
        }

        /// <summary>
        /// Test GetMetrics
        /// </summary>
        [Fact]
        public void GetMetricsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //var response = instance.GetMetrics(subscriptionId);
            //Assert.IsType<Metrics>(response);
        }
    }
}
