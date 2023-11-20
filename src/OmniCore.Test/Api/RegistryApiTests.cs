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
    ///  Class for testing RegistryApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class RegistryApiTests : IDisposable
    {
        private RegistryApi instance;

        public RegistryApiTests()
        {
            instance = new RegistryApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of RegistryApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' RegistryApi
            //Assert.IsType<RegistryApi>(instance);
        }

        /// <summary>
        /// Test CreateRegistry
        /// </summary>
        [Fact]
        public void CreateRegistryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //DeviceRegistry registry = null;
            //var response = instance.CreateRegistry(subscriptionId, registry);
            //Assert.IsType<DeviceRegistry>(response);
        }

        /// <summary>
        /// Test DeleteRegistry
        /// </summary>
        [Fact]
        public void DeleteRegistryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string registryId = null;
            //var response = instance.DeleteRegistry(subscriptionId, registryId);
            //Assert.IsType<Info>(response);
        }

        /// <summary>
        /// Test GetRegistries
        /// </summary>
        [Fact]
        public void GetRegistriesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //List<string> registryIds = null;
            //var response = instance.GetRegistries(subscriptionId, pageNumber, pageSize, registryIds);
            //Assert.IsType<ListDeviceRegistries>(response);
        }

        /// <summary>
        /// Test GetRegistry
        /// </summary>
        [Fact]
        public void GetRegistryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string registryId = null;
            //var response = instance.GetRegistry(subscriptionId, registryId);
            //Assert.IsType<DeviceRegistry>(response);
        }

        /// <summary>
        /// Test SendBroadcastToDevices
        /// </summary>
        [Fact]
        public void SendBroadcastToDevicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionid = null;
            //string registryId = null;
            //DeviceCommand broadcast = null;
            //var response = instance.SendBroadcastToDevices(subscriptionid, registryId, broadcast);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UpdateRegistry
        /// </summary>
        [Fact]
        public void UpdateRegistryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string registryId = null;
            //string updateMask = null;
            //DeviceRegistry registry = null;
            //var response = instance.UpdateRegistry(subscriptionId, registryId, updateMask, registry);
            //Assert.IsType<DeviceRegistry>(response);
        }
    }
}
