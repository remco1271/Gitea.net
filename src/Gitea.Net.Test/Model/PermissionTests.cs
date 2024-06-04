/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 1.22.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Gitea.Net.Model;
using Gitea.Net.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Gitea.Net.Test.Model
{
    /// <summary>
    ///  Class for testing Permission
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PermissionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Permission
        //private Permission instance;

        public PermissionTests()
        {
            // TODO uncomment below to create an instance of Permission
            //instance = new Permission();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Permission
        /// </summary>
        [Fact]
        public void PermissionInstanceTest()
        {
            // TODO uncomment below to test "IsType" Permission
            //Assert.IsType<Permission>(instance);
        }

        /// <summary>
        /// Test the property 'Admin'
        /// </summary>
        [Fact]
        public void AdminTest()
        {
            // TODO unit test for the property 'Admin'
        }

        /// <summary>
        /// Test the property 'Pull'
        /// </summary>
        [Fact]
        public void PullTest()
        {
            // TODO unit test for the property 'Pull'
        }

        /// <summary>
        /// Test the property 'Push'
        /// </summary>
        [Fact]
        public void PushTest()
        {
            // TODO unit test for the property 'Push'
        }
    }
}