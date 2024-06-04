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
    ///  Class for testing CommitStats
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CommitStatsTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CommitStats
        //private CommitStats instance;

        public CommitStatsTests()
        {
            // TODO uncomment below to create an instance of CommitStats
            //instance = new CommitStats();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CommitStats
        /// </summary>
        [Fact]
        public void CommitStatsInstanceTest()
        {
            // TODO uncomment below to test "IsType" CommitStats
            //Assert.IsType<CommitStats>(instance);
        }

        /// <summary>
        /// Test the property 'Additions'
        /// </summary>
        [Fact]
        public void AdditionsTest()
        {
            // TODO unit test for the property 'Additions'
        }

        /// <summary>
        /// Test the property 'Deletions'
        /// </summary>
        [Fact]
        public void DeletionsTest()
        {
            // TODO unit test for the property 'Deletions'
        }

        /// <summary>
        /// Test the property 'Total'
        /// </summary>
        [Fact]
        public void TotalTest()
        {
            // TODO unit test for the property 'Total'
        }
    }
}