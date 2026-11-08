/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 28.3.0
 *
 * Request-shape tests for SettingsApi. Every call is sent to RecordingApiClient, so no
 * Gitea server is needed. Expected values come from the Gitea swagger spec.
 */

using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

using Gitea.Net.Api;
using Gitea.Net.Model;

namespace Gitea.Net.Test.Api
{
    /// <summary>
    ///  Class for testing SettingsApi
    /// </summary>
    public class SettingsApiTests
    {
        private readonly RecordingApiClient client;
        private readonly SettingsApi instance;

        public SettingsApiTests()
        {
            client = new RecordingApiClient();
            instance = new SettingsApi(client, client, RecordingApiClient.CreateConfiguration());
        }

        // Creates a model without running its constructor, so required-field checks don't fire.
        private static T NewModel<T>() => (T)System.Runtime.CompilerServices.RuntimeHelpers.GetUninitializedObject(typeof(T));

        /// <summary>
        /// Test an instance of SettingsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            Assert.IsType<SettingsApi>(instance);
        }

        /// <summary>
        /// Test GetGeneralAPISettings: GET /settings/api
        /// </summary>
        [Fact]
        public async Task GetGeneralAPISettingsTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/settings/api");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetGeneralAPISettings();
            Verify(client.TakeSingle());

            await instance.GetGeneralAPISettingsAsync();
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetGeneralAttachmentSettings: GET /settings/attachment
        /// </summary>
        [Fact]
        public async Task GetGeneralAttachmentSettingsTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/settings/attachment");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetGeneralAttachmentSettings();
            Verify(client.TakeSingle());

            await instance.GetGeneralAttachmentSettingsAsync();
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetGeneralRepositorySettings: GET /settings/repository
        /// </summary>
        [Fact]
        public async Task GetGeneralRepositorySettingsTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/settings/repository");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetGeneralRepositorySettings();
            Verify(client.TakeSingle());

            await instance.GetGeneralRepositorySettingsAsync();
            Verify(client.TakeSingle());
        }

        /// <summary>
        /// Test GetGeneralUISettings: GET /settings/ui
        /// </summary>
        [Fact]
        public async Task GetGeneralUISettingsTest()
        {
            // no parameters

            void Verify(RecordedRequest r)
            {
                RequestAssert.Matches(r, "GET", "/settings/ui");
                RequestAssert.HasAuthToken(r);
            }

            instance.GetGeneralUISettings();
            Verify(client.TakeSingle());

            await instance.GetGeneralUISettingsAsync();
            Verify(client.TakeSingle());
        }
    }
}
