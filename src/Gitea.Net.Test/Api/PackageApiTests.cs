/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 1.22.0
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

using Gitea.Net.Client;
using Gitea.Net.Api;
// uncomment below to import models
//using Gitea.Net.Model;

namespace Gitea.Net.Test.Api
{
    /// <summary>
    ///  Class for testing PackageApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PackageApiTests : IDisposable
    {
        private PackageApi instance;

        public PackageApiTests()
        {
            instance = new PackageApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PackageApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PackageApi
            //Assert.IsType<PackageApi>(instance);
        }

        /// <summary>
        /// Test DeletePackage
        /// </summary>
        [Fact]
        public void DeletePackageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string type = null;
            //string name = null;
            //string version = null;
            //instance.DeletePackage(owner, type, name, version);
        }

        /// <summary>
        /// Test GetPackage
        /// </summary>
        [Fact]
        public void GetPackageTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string type = null;
            //string name = null;
            //string version = null;
            //var response = instance.GetPackage(owner, type, name, version);
            //Assert.IsType<Package>(response);
        }

        /// <summary>
        /// Test ListPackageFiles
        /// </summary>
        [Fact]
        public void ListPackageFilesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string type = null;
            //string name = null;
            //string version = null;
            //var response = instance.ListPackageFiles(owner, type, name, version);
            //Assert.IsType<List<PackageFile>>(response);
        }

        /// <summary>
        /// Test ListPackages
        /// </summary>
        [Fact]
        public void ListPackagesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //int? page = null;
            //int? limit = null;
            //string? type = null;
            //string? q = null;
            //var response = instance.ListPackages(owner, page, limit, type, q);
            //Assert.IsType<List<Package>>(response);
        }
    }
}
