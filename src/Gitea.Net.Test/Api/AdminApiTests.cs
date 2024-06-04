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
    ///  Class for testing AdminApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AdminApiTests : IDisposable
    {
        private AdminApi instance;

        public AdminApiTests()
        {
            instance = new AdminApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AdminApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AdminApi
            //Assert.IsType<AdminApi>(instance);
        }

        /// <summary>
        /// Test AdminAddUserBadges
        /// </summary>
        [Fact]
        public void AdminAddUserBadgesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //UserBadgeOption? body = null;
            //instance.AdminAddUserBadges(username, body);
        }

        /// <summary>
        /// Test AdminAdoptRepository
        /// </summary>
        [Fact]
        public void AdminAdoptRepositoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string repo = null;
            //instance.AdminAdoptRepository(owner, repo);
        }

        /// <summary>
        /// Test AdminCreateHook
        /// </summary>
        [Fact]
        public void AdminCreateHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateHookOption body = null;
            //var response = instance.AdminCreateHook(body);
            //Assert.IsType<Hook>(response);
        }

        /// <summary>
        /// Test AdminCreateOrg
        /// </summary>
        [Fact]
        public void AdminCreateOrgTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //CreateOrgOption organization = null;
            //var response = instance.AdminCreateOrg(username, organization);
            //Assert.IsType<Organization>(response);
        }

        /// <summary>
        /// Test AdminCreatePublicKey
        /// </summary>
        [Fact]
        public void AdminCreatePublicKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //CreateKeyOption? key = null;
            //var response = instance.AdminCreatePublicKey(username, key);
            //Assert.IsType<PublicKey>(response);
        }

        /// <summary>
        /// Test AdminCreateRepo
        /// </summary>
        [Fact]
        public void AdminCreateRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //CreateRepoOption repository = null;
            //var response = instance.AdminCreateRepo(username, repository);
            //Assert.IsType<Repository>(response);
        }

        /// <summary>
        /// Test AdminCreateUser
        /// </summary>
        [Fact]
        public void AdminCreateUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateUserOption? body = null;
            //var response = instance.AdminCreateUser(body);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test AdminCronList
        /// </summary>
        [Fact]
        public void AdminCronListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.AdminCronList(page, limit);
            //Assert.IsType<List<Cron>>(response);
        }

        /// <summary>
        /// Test AdminCronRun
        /// </summary>
        [Fact]
        public void AdminCronRunTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string task = null;
            //instance.AdminCronRun(task);
        }

        /// <summary>
        /// Test AdminDeleteHook
        /// </summary>
        [Fact]
        public void AdminDeleteHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //instance.AdminDeleteHook(id);
        }

        /// <summary>
        /// Test AdminDeleteUnadoptedRepository
        /// </summary>
        [Fact]
        public void AdminDeleteUnadoptedRepositoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string owner = null;
            //string repo = null;
            //instance.AdminDeleteUnadoptedRepository(owner, repo);
        }

        /// <summary>
        /// Test AdminDeleteUser
        /// </summary>
        [Fact]
        public void AdminDeleteUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //bool? purge = null;
            //instance.AdminDeleteUser(username, purge);
        }

        /// <summary>
        /// Test AdminDeleteUserBadges
        /// </summary>
        [Fact]
        public void AdminDeleteUserBadgesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //UserBadgeOption? body = null;
            //instance.AdminDeleteUserBadges(username, body);
        }

        /// <summary>
        /// Test AdminDeleteUserPublicKey
        /// </summary>
        [Fact]
        public void AdminDeleteUserPublicKeyTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //long id = null;
            //instance.AdminDeleteUserPublicKey(username, id);
        }

        /// <summary>
        /// Test AdminEditHook
        /// </summary>
        [Fact]
        public void AdminEditHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //EditHookOption? body = null;
            //var response = instance.AdminEditHook(id, body);
            //Assert.IsType<Hook>(response);
        }

        /// <summary>
        /// Test AdminEditUser
        /// </summary>
        [Fact]
        public void AdminEditUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //EditUserOption? body = null;
            //var response = instance.AdminEditUser(username, body);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test AdminGetAllEmails
        /// </summary>
        [Fact]
        public void AdminGetAllEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.AdminGetAllEmails(page, limit);
            //Assert.IsType<List<Email>>(response);
        }

        /// <summary>
        /// Test AdminGetAllOrgs
        /// </summary>
        [Fact]
        public void AdminGetAllOrgsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.AdminGetAllOrgs(page, limit);
            //Assert.IsType<List<Organization>>(response);
        }

        /// <summary>
        /// Test AdminGetHook
        /// </summary>
        [Fact]
        public void AdminGetHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.AdminGetHook(id);
            //Assert.IsType<Hook>(response);
        }

        /// <summary>
        /// Test AdminGetRunnerRegistrationToken
        /// </summary>
        [Fact]
        public void AdminGetRunnerRegistrationTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //instance.AdminGetRunnerRegistrationToken();
        }

        /// <summary>
        /// Test AdminListHooks
        /// </summary>
        [Fact]
        public void AdminListHooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.AdminListHooks(page, limit);
            //Assert.IsType<List<Hook>>(response);
        }

        /// <summary>
        /// Test AdminListUserBadges
        /// </summary>
        [Fact]
        public void AdminListUserBadgesTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //var response = instance.AdminListUserBadges(username);
            //Assert.IsType<List<Badge>>(response);
        }

        /// <summary>
        /// Test AdminRenameUser
        /// </summary>
        [Fact]
        public void AdminRenameUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //RenameUserOption body = null;
            //instance.AdminRenameUser(username, body);
        }

        /// <summary>
        /// Test AdminSearchEmails
        /// </summary>
        [Fact]
        public void AdminSearchEmailsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string? q = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.AdminSearchEmails(q, page, limit);
            //Assert.IsType<List<Email>>(response);
        }

        /// <summary>
        /// Test AdminSearchUsers
        /// </summary>
        [Fact]
        public void AdminSearchUsersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long? sourceId = null;
            //string? loginName = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.AdminSearchUsers(sourceId, loginName, page, limit);
            //Assert.IsType<List<User>>(response);
        }

        /// <summary>
        /// Test AdminUnadoptedList
        /// </summary>
        [Fact]
        public void AdminUnadoptedListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //string? pattern = null;
            //var response = instance.AdminUnadoptedList(page, limit, pattern);
            //Assert.IsType<List<string>>(response);
        }
    }
}