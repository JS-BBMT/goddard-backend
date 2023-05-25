/*
 * Goddard iPaaS Schools API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
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

using FranchiseePortal.SchoolsWebApiClient.Client;
using FranchiseePortal.SchoolsWebApiClient.Api;
// uncomment below to import models
//using FranchiseePortal.SchoolsWebApiClient.Model;

namespace FranchiseePortal.SchoolsWebApiClient.Test.Api
{
    /// <summary>
    ///  Class for testing GeocoordinatesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class GeocoordinatesApiTests : IDisposable
    {
        private GeocoordinatesApi instance;

        public GeocoordinatesApiTests()
        {
            instance = new GeocoordinatesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of GeocoordinatesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' GeocoordinatesApi
            //Assert.IsType<GeocoordinatesApi>(instance);
        }

        /// <summary>
        /// Test ApiV1GeocoordinatesGet
        /// </summary>
        [Fact]
        public void ApiV1GeocoordinatesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //bool? showOnPublicWebsite = null;
            //var response = instance.ApiV1GeocoordinatesGet(showOnPublicWebsite);
            //Assert.IsType<List<SchoolGeocoordinate>>(response);
        }
    }
}