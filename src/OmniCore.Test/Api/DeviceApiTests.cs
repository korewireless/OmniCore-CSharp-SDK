/*
 * OmniCore Model and State Management API
 *
 * This is an OmniCore Model and State Management server.
 *
 * The version of the OpenAPI document: 1.8.4
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
    ///  Class for testing DeviceApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class DeviceApiTests : IDisposable
    {
        private DeviceApi instance;

        public DeviceApiTests()
        {
            instance = new DeviceApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of DeviceApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' DeviceApi
            //Assert.IsType<DeviceApi>(instance);
        }

        /// <summary>
        /// Test BindDevice
        /// </summary>
        [Fact]
        public void BindDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string registryId = null;
            //BindRequest bind = null;
            //var response = instance.BindDevice(subscriptionId, registryId, bind);
            //Assert.IsType<Info>(response);
        }

        /// <summary>
        /// Test BindDevices
        /// </summary>
        [Fact]
        public void BindDevicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string registryId = null;
            //BindRequestIdsGateway bind = null;
            //var response = instance.BindDevices(subscriptionId, registryId, bind);
            //Assert.IsType<Info>(response);
        }

        /// <summary>
        /// Test BlockDeviceCommuncation
        /// </summary>
        [Fact]
        public void BlockDeviceCommuncationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionid = null;
            //string registryId = null;
            //string deviceId = null;
            //BlockCommunicationBody block = null;
            //var response = instance.BlockDeviceCommuncation(subscriptionid, registryId, deviceId, block);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test CreateDevice
        /// </summary>
        [Fact]
        public void CreateDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string registryId = null;
            //Device device = null;
            //var response = instance.CreateDevice(subscriptionId, registryId, device);
            //Assert.IsType<Device>(response);
        }

        /// <summary>
        /// Test DeleteDevice
        /// </summary>
        [Fact]
        public void DeleteDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string registryId = null;
            //string deviceId = null;
            //var response = instance.DeleteDevice(subscriptionId, registryId, deviceId);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test GetConfig
        /// </summary>
        [Fact]
        public void GetConfigTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionid = null;
            //string registryId = null;
            //string deviceId = null;
            //int? numVersions = null;
            //var response = instance.GetConfig(subscriptionid, registryId, deviceId, numVersions);
            //Assert.IsType<ListDeviceConfigVersionsResponse>(response);
        }

        /// <summary>
        /// Test GetDevice
        /// </summary>
        [Fact]
        public void GetDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string registryId = null;
            //string deviceId = null;
            //var response = instance.GetDevice(subscriptionId, registryId, deviceId);
            //Assert.IsType<Device>(response);
        }

        /// <summary>
        /// Test GetDevices
        /// </summary>
        [Fact]
        public void GetDevicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string registryId = null;
            //int? pageNumber = null;
            //int? pageSize = null;
            //string fieldMask = null;
            //List<string> deviceIds = null;
            //List<string> deviceNumIds = null;
            //string gatewayListOptionsAssociationsDeviceId = null;
            //string gatewayListOptionsAssociationsGatewayId = null;
            //string gatewayListOptionsGatewayType = null;
            //var response = instance.GetDevices(subscriptionId, registryId, pageNumber, pageSize, fieldMask, deviceIds, deviceNumIds, gatewayListOptionsAssociationsDeviceId, gatewayListOptionsAssociationsGatewayId, gatewayListOptionsGatewayType);
            //Assert.IsType<ListDevicesResponse>(response);
        }

        /// <summary>
        /// Test GetStates
        /// </summary>
        [Fact]
        public void GetStatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionid = null;
            //string registryId = null;
            //string deviceId = null;
            //int? numStates = null;
            //var response = instance.GetStates(subscriptionid, registryId, deviceId, numStates);
            //Assert.IsType<ListDeviceStatesResponse>(response);
        }

        /// <summary>
        /// Test SendCommandToDevice
        /// </summary>
        [Fact]
        public void SendCommandToDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionid = null;
            //string registryId = null;
            //string deviceId = null;
            //DeviceCommand command = null;
            //var response = instance.SendCommandToDevice(subscriptionid, registryId, deviceId, command);
            //Assert.IsType<Object>(response);
        }

        /// <summary>
        /// Test UnBindDevice
        /// </summary>
        [Fact]
        public void UnBindDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string registryId = null;
            //BindRequest unbind = null;
            //var response = instance.UnBindDevice(subscriptionId, registryId, unbind);
            //Assert.IsType<Info>(response);
        }

        /// <summary>
        /// Test UnBindDevices
        /// </summary>
        [Fact]
        public void UnBindDevicesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string registryId = null;
            //BindRequestIdsGateway unbind = null;
            //var response = instance.UnBindDevices(subscriptionId, registryId, unbind);
            //Assert.IsType<Info>(response);
        }

        /// <summary>
        /// Test UpdateConfigurationToDevice
        /// </summary>
        [Fact]
        public void UpdateConfigurationToDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionid = null;
            //string registryId = null;
            //string deviceId = null;
            //DeviceConfiguration configuration = null;
            //var response = instance.UpdateConfigurationToDevice(subscriptionid, registryId, deviceId, configuration);
            //Assert.IsType<DeviceConfig>(response);
        }

        /// <summary>
        /// Test UpdateCustomOnboardRequest
        /// </summary>
        [Fact]
        public void UpdateCustomOnboardRequestTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionid = null;
            //string registryId = null;
            //string deviceId = null;
            //CustomOnboard customOnboard = null;
            //var response = instance.UpdateCustomOnboardRequest(subscriptionid, registryId, deviceId, customOnboard);
            //Assert.IsType<Info>(response);
        }

        /// <summary>
        /// Test UpdateDevice
        /// </summary>
        [Fact]
        public void UpdateDeviceTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string subscriptionId = null;
            //string registryId = null;
            //string deviceId = null;
            //string updateMask = null;
            //Device device = null;
            //var response = instance.UpdateDevice(subscriptionId, registryId, deviceId, updateMask, device);
            //Assert.IsType<Device>(response);
        }
    }
}
