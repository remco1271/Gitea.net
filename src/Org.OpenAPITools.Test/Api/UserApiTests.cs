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

using Org.OpenAPITools.Client;
using Org.OpenAPITools.Api;
// uncomment below to import models
//using Org.OpenAPITools.Model;

namespace Org.OpenAPITools.Test.Api
{
    /// <summary>
    ///  Class for testing UserApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class UserApiTests : IDisposable
    {
        private UserApi instance;

        public UserApiTests()
        {
            instance = new UserApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of UserApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' UserApi
            //Assert.IsType<UserApi>(instance);
        }

        /// <summary>
        /// Test CreateCurrentUserRepo
        /// </summary>
        [Fact]
        public void CreateCurrentUserRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateRepoOption? body = null;
            //var response = instance.CreateCurrentUserRepo(body);
            //Assert.IsType<Repository>(response);
        }

        /// <summary>
        /// Test CreateUserVariable
        /// </summary>
        [Fact]
        public void CreateUserVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string variablename = null;
            //CreateVariableOption? body = null;
            //instance.CreateUserVariable(variablename, body);
        }

        /// <summary>
        /// Test DeleteUserSecret
        /// </summary>
        [Fact]
        public void DeleteUserSecretTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string secretname = null;
            //instance.DeleteUserSecret(secretname);
        }

        /// <summary>
        /// Test DeleteUserVariable
        /// </summary>
        [Fact]
        public void DeleteUserVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string variablename = null;
            //instance.DeleteUserVariable(variablename);
        }

        /// <summary>
        /// Test GetUserSettings
        /// </summary>
        [Fact]
        public void GetUserSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetUserSettings();
            //Assert.IsType<List<UserSettings>>(response);
        }

        /// <summary>
        /// Test GetUserVariable
        /// </summary>
        [Fact]
        public void GetUserVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string variablename = null;
            //var response = instance.GetUserVariable(variablename);
            //Assert.IsType<ActionVariable>(response);
        }

        /// <summary>
        /// Test GetUserVariablesList
        /// </summary>
        [Fact]
        public void GetUserVariablesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetUserVariablesList(page, limit);
            //Assert.IsType<List<ActionVariable>>(response);
        }

        /// <summary>
        /// Test GetVerificationToken
        /// </summary>
        [Fact]
        public void GetVerificationTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.GetVerificationToken();
            //Assert.IsType<string>(response);
        }

        /// <summary>
        /// Test UpdateUserSecret
        /// </summary>
        [Fact]
        public void UpdateUserSecretTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string secretname = null;
            //CreateOrUpdateSecretOption? body = null;
            //instance.UpdateUserSecret(secretname, body);
        }

        /// <summary>
        /// Test UpdateUserSettings
        /// </summary>
        [Fact]
        public void UpdateUserSettingsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UserSettingsOptions? body = null;
            //var response = instance.UpdateUserSettings(body);
            //Assert.IsType<List<UserSettings>>(response);
        }

        /// <summary>
        /// Test UpdateUserVariable
        /// </summary>
        [Fact]
        public void UpdateUserVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string variablename = null;
            //UpdateVariableOption? body = null;
            //instance.UpdateUserVariable(variablename, body);
        }

        /// <summary>
        /// Test UserAddEmail
        /// </summary>
        [Fact]
        public void UserAddEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateEmailOption? body = null;
            //var response = instance.UserAddEmail(body);
            //Assert.IsType<List<Email>>(response);
        }

        /// <summary>
        /// Test UserBlockUser
        /// </summary>
        [Fact]
        public void UserBlockUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string? note = null;
            //instance.UserBlockUser(username, note);
        }

        /// <summary>
        /// Test UserCheckFollowing
        /// </summary>
        [Fact]
        public void UserCheckFollowingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string target = null;
            //instance.UserCheckFollowing(username, target);
        }

        /// <summary>
        /// Test UserCheckUserBlock
        /// </summary>
        [Fact]
        public void UserCheckUserBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //instance.UserCheckUserBlock(username);
        }

        /// <summary>
        /// Test UserCreateHook
        /// </summary>
        [Fact]
        public void UserCreateHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateHookOption body = null;
            //var response = instance.UserCreateHook(body);
            //Assert.IsType<Hook>(response);
        }

        /// <summary>
        /// Test UserCreateOAuth2Application
        /// </summary>
        [Fact]
        public void UserCreateOAuth2ApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateOAuth2ApplicationOptions body = null;
            //var response = instance.UserCreateOAuth2Application(body);
            //Assert.IsType<OAuth2Application>(response);
        }

        /// <summary>
        /// Test UserCreateToken
        /// </summary>
        [Fact]
        public void UserCreateTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //CreateAccessTokenOption? body = null;
            //var response = instance.UserCreateToken(username, body);
            //Assert.IsType<AccessToken>(response);
        }

        /// <summary>
        /// Test UserCurrentCheckFollowing
        /// </summary>
        [Fact]
        public void UserCurrentCheckFollowingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //instance.UserCurrentCheckFollowing(username);
        }

        /// <summary>
        /// Test UserCurrentCheckStarring
        /// </summary>
        [Fact]
        public void UserCurrentCheckStarringTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string repo = null;
            //instance.UserCurrentCheckStarring(owner, repo);
        }

        /// <summary>
        /// Test UserCurrentDeleteFollow
        /// </summary>
        [Fact]
        public void UserCurrentDeleteFollowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //instance.UserCurrentDeleteFollow(username);
        }

        /// <summary>
        /// Test UserCurrentDeleteGPGKey
        /// </summary>
        [Fact]
        public void UserCurrentDeleteGPGKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //instance.UserCurrentDeleteGPGKey(id);
        }

        /// <summary>
        /// Test UserCurrentDeleteKey
        /// </summary>
        [Fact]
        public void UserCurrentDeleteKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //instance.UserCurrentDeleteKey(id);
        }

        /// <summary>
        /// Test UserCurrentDeleteStar
        /// </summary>
        [Fact]
        public void UserCurrentDeleteStarTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string repo = null;
            //instance.UserCurrentDeleteStar(owner, repo);
        }

        /// <summary>
        /// Test UserCurrentGetGPGKey
        /// </summary>
        [Fact]
        public void UserCurrentGetGPGKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.UserCurrentGetGPGKey(id);
            //Assert.IsType<GPGKey>(response);
        }

        /// <summary>
        /// Test UserCurrentGetKey
        /// </summary>
        [Fact]
        public void UserCurrentGetKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.UserCurrentGetKey(id);
            //Assert.IsType<PublicKey>(response);
        }

        /// <summary>
        /// Test UserCurrentListFollowers
        /// </summary>
        [Fact]
        public void UserCurrentListFollowersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserCurrentListFollowers(page, limit);
            //Assert.IsType<List<User>>(response);
        }

        /// <summary>
        /// Test UserCurrentListFollowing
        /// </summary>
        [Fact]
        public void UserCurrentListFollowingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserCurrentListFollowing(page, limit);
            //Assert.IsType<List<User>>(response);
        }

        /// <summary>
        /// Test UserCurrentListGPGKeys
        /// </summary>
        [Fact]
        public void UserCurrentListGPGKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserCurrentListGPGKeys(page, limit);
            //Assert.IsType<List<GPGKey>>(response);
        }

        /// <summary>
        /// Test UserCurrentListKeys
        /// </summary>
        [Fact]
        public void UserCurrentListKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? fingerprint = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserCurrentListKeys(fingerprint, page, limit);
            //Assert.IsType<List<PublicKey>>(response);
        }

        /// <summary>
        /// Test UserCurrentListRepos
        /// </summary>
        [Fact]
        public void UserCurrentListReposTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserCurrentListRepos(page, limit);
            //Assert.IsType<List<Repository>>(response);
        }

        /// <summary>
        /// Test UserCurrentListStarred
        /// </summary>
        [Fact]
        public void UserCurrentListStarredTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserCurrentListStarred(page, limit);
            //Assert.IsType<List<Repository>>(response);
        }

        /// <summary>
        /// Test UserCurrentListSubscriptions
        /// </summary>
        [Fact]
        public void UserCurrentListSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserCurrentListSubscriptions(page, limit);
            //Assert.IsType<List<Repository>>(response);
        }

        /// <summary>
        /// Test UserCurrentPostGPGKey
        /// </summary>
        [Fact]
        public void UserCurrentPostGPGKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateGPGKeyOption? form = null;
            //var response = instance.UserCurrentPostGPGKey(form);
            //Assert.IsType<GPGKey>(response);
        }

        /// <summary>
        /// Test UserCurrentPostKey
        /// </summary>
        [Fact]
        public void UserCurrentPostKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateKeyOption? body = null;
            //var response = instance.UserCurrentPostKey(body);
            //Assert.IsType<PublicKey>(response);
        }

        /// <summary>
        /// Test UserCurrentPutFollow
        /// </summary>
        [Fact]
        public void UserCurrentPutFollowTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //instance.UserCurrentPutFollow(username);
        }

        /// <summary>
        /// Test UserCurrentPutStar
        /// </summary>
        [Fact]
        public void UserCurrentPutStarTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string repo = null;
            //instance.UserCurrentPutStar(owner, repo);
        }

        /// <summary>
        /// Test UserCurrentTrackedTimes
        /// </summary>
        [Fact]
        public void UserCurrentTrackedTimesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //DateTime? since = null;
            //DateTime? before = null;
            //var response = instance.UserCurrentTrackedTimes(page, limit, since, before);
            //Assert.IsType<List<TrackedTime>>(response);
        }

        /// <summary>
        /// Test UserDeleteAccessToken
        /// </summary>
        [Fact]
        public void UserDeleteAccessTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string token = null;
            //instance.UserDeleteAccessToken(username, token);
        }

        /// <summary>
        /// Test UserDeleteAvatar
        /// </summary>
        [Fact]
        public void UserDeleteAvatarTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.UserDeleteAvatar();
        }

        /// <summary>
        /// Test UserDeleteEmail
        /// </summary>
        [Fact]
        public void UserDeleteEmailTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //DeleteEmailOption? body = null;
            //instance.UserDeleteEmail(body);
        }

        /// <summary>
        /// Test UserDeleteHook
        /// </summary>
        [Fact]
        public void UserDeleteHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //instance.UserDeleteHook(id);
        }

        /// <summary>
        /// Test UserDeleteOAuth2Application
        /// </summary>
        [Fact]
        public void UserDeleteOAuth2ApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //instance.UserDeleteOAuth2Application(id);
        }

        /// <summary>
        /// Test UserEditHook
        /// </summary>
        [Fact]
        public void UserEditHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //EditHookOption? body = null;
            //var response = instance.UserEditHook(id, body);
            //Assert.IsType<Hook>(response);
        }

        /// <summary>
        /// Test UserGet
        /// </summary>
        [Fact]
        public void UserGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //var response = instance.UserGet(username);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test UserGetCurrent
        /// </summary>
        [Fact]
        public void UserGetCurrentTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserGetCurrent();
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test UserGetHeatmapData
        /// </summary>
        [Fact]
        public void UserGetHeatmapDataTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //var response = instance.UserGetHeatmapData(username);
            //Assert.IsType<List<UserHeatmapData>>(response);
        }

        /// <summary>
        /// Test UserGetHook
        /// </summary>
        [Fact]
        public void UserGetHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.UserGetHook(id);
            //Assert.IsType<Hook>(response);
        }

        /// <summary>
        /// Test UserGetOAuth2Application
        /// </summary>
        [Fact]
        public void UserGetOAuth2ApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.UserGetOAuth2Application(id);
            //Assert.IsType<OAuth2Application>(response);
        }

        /// <summary>
        /// Test UserGetOauth2Application
        /// </summary>
        [Fact]
        public void UserGetOauth2ApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserGetOauth2Application(page, limit);
            //Assert.IsType<List<OAuth2Application>>(response);
        }

        /// <summary>
        /// Test UserGetRunnerRegistrationToken
        /// </summary>
        [Fact]
        public void UserGetRunnerRegistrationTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.UserGetRunnerRegistrationToken();
        }

        /// <summary>
        /// Test UserGetStopWatches
        /// </summary>
        [Fact]
        public void UserGetStopWatchesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserGetStopWatches(page, limit);
            //Assert.IsType<List<StopWatch>>(response);
        }

        /// <summary>
        /// Test UserGetTokens
        /// </summary>
        [Fact]
        public void UserGetTokensTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserGetTokens(username, page, limit);
            //Assert.IsType<List<AccessToken>>(response);
        }

        /// <summary>
        /// Test UserListActivityFeeds
        /// </summary>
        [Fact]
        public void UserListActivityFeedsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //bool? onlyPerformedBy = null;
            //DateOnly? date = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserListActivityFeeds(username, onlyPerformedBy, date, page, limit);
            //Assert.IsType<List<Activity>>(response);
        }

        /// <summary>
        /// Test UserListBlocks
        /// </summary>
        [Fact]
        public void UserListBlocksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserListBlocks(page, limit);
            //Assert.IsType<List<User>>(response);
        }

        /// <summary>
        /// Test UserListEmails
        /// </summary>
        [Fact]
        public void UserListEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserListEmails();
            //Assert.IsType<List<Email>>(response);
        }

        /// <summary>
        /// Test UserListFollowers
        /// </summary>
        [Fact]
        public void UserListFollowersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserListFollowers(username, page, limit);
            //Assert.IsType<List<User>>(response);
        }

        /// <summary>
        /// Test UserListFollowing
        /// </summary>
        [Fact]
        public void UserListFollowingTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserListFollowing(username, page, limit);
            //Assert.IsType<List<User>>(response);
        }

        /// <summary>
        /// Test UserListGPGKeys
        /// </summary>
        [Fact]
        public void UserListGPGKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserListGPGKeys(username, page, limit);
            //Assert.IsType<List<GPGKey>>(response);
        }

        /// <summary>
        /// Test UserListHooks
        /// </summary>
        [Fact]
        public void UserListHooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserListHooks(page, limit);
            //Assert.IsType<List<Hook>>(response);
        }

        /// <summary>
        /// Test UserListKeys
        /// </summary>
        [Fact]
        public void UserListKeysTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string? fingerprint = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserListKeys(username, fingerprint, page, limit);
            //Assert.IsType<List<PublicKey>>(response);
        }

        /// <summary>
        /// Test UserListRepos
        /// </summary>
        [Fact]
        public void UserListReposTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserListRepos(username, page, limit);
            //Assert.IsType<List<Repository>>(response);
        }

        /// <summary>
        /// Test UserListStarred
        /// </summary>
        [Fact]
        public void UserListStarredTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserListStarred(username, page, limit);
            //Assert.IsType<List<Repository>>(response);
        }

        /// <summary>
        /// Test UserListSubscriptions
        /// </summary>
        [Fact]
        public void UserListSubscriptionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserListSubscriptions(username, page, limit);
            //Assert.IsType<List<Repository>>(response);
        }

        /// <summary>
        /// Test UserListTeams
        /// </summary>
        [Fact]
        public void UserListTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserListTeams(page, limit);
            //Assert.IsType<List<Team>>(response);
        }

        /// <summary>
        /// Test UserSearch
        /// </summary>
        [Fact]
        public void UserSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? q = null;
            //long? uid = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.UserSearch(q, uid, page, limit);
            //Assert.IsType<UserSearch200Response>(response);
        }

        /// <summary>
        /// Test UserUnblockUser
        /// </summary>
        [Fact]
        public void UserUnblockUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //instance.UserUnblockUser(username);
        }

        /// <summary>
        /// Test UserUpdateAvatar
        /// </summary>
        [Fact]
        public void UserUpdateAvatarTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //UpdateUserAvatarOption? body = null;
            //instance.UserUpdateAvatar(body);
        }

        /// <summary>
        /// Test UserUpdateOAuth2Application
        /// </summary>
        [Fact]
        public void UserUpdateOAuth2ApplicationTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //CreateOAuth2ApplicationOptions body = null;
            //var response = instance.UserUpdateOAuth2Application(id, body);
            //Assert.IsType<OAuth2Application>(response);
        }

        /// <summary>
        /// Test UserVerifyGPGKey
        /// </summary>
        [Fact]
        public void UserVerifyGPGKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //var response = instance.UserVerifyGPGKey();
            //Assert.IsType<GPGKey>(response);
        }
    }
}
