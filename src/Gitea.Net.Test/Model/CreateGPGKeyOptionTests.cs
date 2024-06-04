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
    ///  Class for testing CreateGPGKeyOption
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class CreateGPGKeyOptionTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for CreateGPGKeyOption
        //private CreateGPGKeyOption instance;

        public CreateGPGKeyOptionTests()
        {
            // TODO uncomment below to create an instance of CreateGPGKeyOption
            //instance = new CreateGPGKeyOption();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreateGPGKeyOption
        /// </summary>
        [Fact]
        public void CreateGPGKeyOptionInstanceTest()
        {
            // TODO uncomment below to test "IsType" CreateGPGKeyOption
            //Assert.IsType<CreateGPGKeyOption>(instance);
        }

        /// <summary>
        /// Test the property 'ArmoredPublicKey'
        /// </summary>
        [Fact]
        public void ArmoredPublicKeyTest()
        {
            // TODO unit test for the property 'ArmoredPublicKey'
        }

        /// <summary>
        /// Test the property 'ArmoredSignature'
        /// </summary>
        [Fact]
        public void ArmoredSignatureTest()
        {
            // TODO unit test for the property 'ArmoredSignature'
        }
    }
}