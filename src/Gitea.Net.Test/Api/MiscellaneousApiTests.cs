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
    ///  Class for testing MiscellaneousApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class MiscellaneousApiTests : IDisposable
    {
        private MiscellaneousApi instance;

        public MiscellaneousApiTests()
        {
            instance = new MiscellaneousApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MiscellaneousApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' MiscellaneousApi
            //Assert.IsType<MiscellaneousApi>(instance);
        }

        /// <summary>
        /// Test GetGitignoreTemplateInfo
        /// </summary>
        [Fact]
        public void GetGitignoreTemplateInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.GetGitignoreTemplateInfo(name);
            //Assert.IsType<GitignoreTemplateInfo>(response);
        }

        /// <summary>
        /// Test GetLabelTemplateInfo
        /// </summary>
        [Fact]
        public void GetLabelTemplateInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.GetLabelTemplateInfo(name);
            //Assert.IsType<List<LabelTemplate>>(response);
        }

        /// <summary>
        /// Test GetLicenseTemplateInfo
        /// </summary>
        [Fact]
        public void GetLicenseTemplateInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string name = null;
            //var response = instance.GetLicenseTemplateInfo(name);
            //Assert.IsType<LicenseTemplateInfo>(response);
        }

        /// <summary>
        /// Test GetNodeInfo
        /// </summary>
        [Fact]
        public void GetNodeInfoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetNodeInfo();
            //Assert.IsType<NodeInfo>(response);
        }

        /// <summary>
        /// Test GetSigningKey
        /// </summary>
        [Fact]
        public void GetSigningKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetSigningKey();
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test GetVersion
        /// </summary>
        [Fact]
        public void GetVersionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetVersion();
            //Assert.IsType<ServerVersion>(response);
        }

        /// <summary>
        /// Test ListGitignoresTemplates
        /// </summary>
        [Fact]
        public void ListGitignoresTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListGitignoresTemplates();
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test ListLabelTemplates
        /// </summary>
        [Fact]
        public void ListLabelTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListLabelTemplates();
            //Assert.IsType<List<string>>(response);
        }

        /// <summary>
        /// Test ListLicenseTemplates
        /// </summary>
        [Fact]
        public void ListLicenseTemplatesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.ListLicenseTemplates();
            //Assert.IsType<List<LicensesTemplateListEntry>>(response);
        }

        /// <summary>
        /// Test RenderMarkdown
        /// </summary>
        [Fact]
        public void RenderMarkdownTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MarkdownOption? body = null;
            //var response = instance.RenderMarkdown(body);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test RenderMarkdownRaw
        /// </summary>
        [Fact]
        public void RenderMarkdownRawTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string body = null;
            //var response = instance.RenderMarkdownRaw(body);
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test RenderMarkup
        /// </summary>
        [Fact]
        public void RenderMarkupTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MarkupOption? body = null;
            //var response = instance.RenderMarkup(body);
            //Assert.IsType<string>(response);
        }
    }
}
