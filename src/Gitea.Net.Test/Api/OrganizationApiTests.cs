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
    ///  Class for testing OrganizationApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class OrganizationApiTests : IDisposable
    {
        private OrganizationApi instance;

        public OrganizationApiTests()
        {
            instance = new OrganizationApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of OrganizationApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' OrganizationApi
            //Assert.IsType<OrganizationApi>(instance);
        }

        /// <summary>
        /// Test CreateOrgRepo
        /// </summary>
        [Fact]
        public void CreateOrgRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //CreateRepoOption? body = null;
            //var response = instance.CreateOrgRepo(org, body);
            //Assert.IsType<Repository>(response);
        }

        /// <summary>
        /// Test CreateOrgRepoDeprecated
        /// </summary>
        [Fact]
        public void CreateOrgRepoDeprecatedTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //CreateRepoOption? body = null;
            //var response = instance.CreateOrgRepoDeprecated(org, body);
            //Assert.IsType<Repository>(response);
        }

        /// <summary>
        /// Test CreateOrgVariable
        /// </summary>
        [Fact]
        public void CreateOrgVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string variablename = null;
            //CreateVariableOption? body = null;
            //instance.CreateOrgVariable(org, variablename, body);
        }

        /// <summary>
        /// Test DeleteOrgSecret
        /// </summary>
        [Fact]
        public void DeleteOrgSecretTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string secretname = null;
            //instance.DeleteOrgSecret(org, secretname);
        }

        /// <summary>
        /// Test DeleteOrgVariable
        /// </summary>
        [Fact]
        public void DeleteOrgVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string variablename = null;
            //var response = instance.DeleteOrgVariable(org, variablename);
            //Assert.IsType<ActionVariable>(response);
        }

        /// <summary>
        /// Test GetOrgVariable
        /// </summary>
        [Fact]
        public void GetOrgVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string variablename = null;
            //var response = instance.GetOrgVariable(org, variablename);
            //Assert.IsType<ActionVariable>(response);
        }

        /// <summary>
        /// Test GetOrgVariablesList
        /// </summary>
        [Fact]
        public void GetOrgVariablesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetOrgVariablesList(org, page, limit);
            //Assert.IsType<List<ActionVariable>>(response);
        }

        /// <summary>
        /// Test OrgAddTeamMember
        /// </summary>
        [Fact]
        public void OrgAddTeamMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string username = null;
            //instance.OrgAddTeamMember(id, username);
        }

        /// <summary>
        /// Test OrgAddTeamRepository
        /// </summary>
        [Fact]
        public void OrgAddTeamRepositoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string org = null;
            //string repo = null;
            //instance.OrgAddTeamRepository(id, org, repo);
        }

        /// <summary>
        /// Test OrgConcealMember
        /// </summary>
        [Fact]
        public void OrgConcealMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string username = null;
            //instance.OrgConcealMember(org, username);
        }

        /// <summary>
        /// Test OrgCreate
        /// </summary>
        [Fact]
        public void OrgCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CreateOrgOption organization = null;
            //var response = instance.OrgCreate(organization);
            //Assert.IsType<Organization>(response);
        }

        /// <summary>
        /// Test OrgCreateHook
        /// </summary>
        [Fact]
        public void OrgCreateHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //CreateHookOption body = null;
            //var response = instance.OrgCreateHook(org, body);
            //Assert.IsType<Hook>(response);
        }

        /// <summary>
        /// Test OrgCreateLabel
        /// </summary>
        [Fact]
        public void OrgCreateLabelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //CreateLabelOption? body = null;
            //var response = instance.OrgCreateLabel(org, body);
            //Assert.IsType<Label>(response);
        }

        /// <summary>
        /// Test OrgCreateTeam
        /// </summary>
        [Fact]
        public void OrgCreateTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //CreateTeamOption? body = null;
            //var response = instance.OrgCreateTeam(org, body);
            //Assert.IsType<Team>(response);
        }

        /// <summary>
        /// Test OrgDelete
        /// </summary>
        [Fact]
        public void OrgDeleteTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //instance.OrgDelete(org);
        }

        /// <summary>
        /// Test OrgDeleteAvatar
        /// </summary>
        [Fact]
        public void OrgDeleteAvatarTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //instance.OrgDeleteAvatar(org);
        }

        /// <summary>
        /// Test OrgDeleteHook
        /// </summary>
        [Fact]
        public void OrgDeleteHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //long id = null;
            //instance.OrgDeleteHook(org, id);
        }

        /// <summary>
        /// Test OrgDeleteLabel
        /// </summary>
        [Fact]
        public void OrgDeleteLabelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //long id = null;
            //instance.OrgDeleteLabel(org, id);
        }

        /// <summary>
        /// Test OrgDeleteMember
        /// </summary>
        [Fact]
        public void OrgDeleteMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string username = null;
            //instance.OrgDeleteMember(org, username);
        }

        /// <summary>
        /// Test OrgDeleteTeam
        /// </summary>
        [Fact]
        public void OrgDeleteTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //instance.OrgDeleteTeam(id);
        }

        /// <summary>
        /// Test OrgEdit
        /// </summary>
        [Fact]
        public void OrgEditTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //EditOrgOption body = null;
            //var response = instance.OrgEdit(org, body);
            //Assert.IsType<Organization>(response);
        }

        /// <summary>
        /// Test OrgEditHook
        /// </summary>
        [Fact]
        public void OrgEditHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //long id = null;
            //EditHookOption? body = null;
            //var response = instance.OrgEditHook(org, id, body);
            //Assert.IsType<Hook>(response);
        }

        /// <summary>
        /// Test OrgEditLabel
        /// </summary>
        [Fact]
        public void OrgEditLabelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //long id = null;
            //EditLabelOption? body = null;
            //var response = instance.OrgEditLabel(org, id, body);
            //Assert.IsType<Label>(response);
        }

        /// <summary>
        /// Test OrgEditTeam
        /// </summary>
        [Fact]
        public void OrgEditTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int id = null;
            //EditTeamOption? body = null;
            //var response = instance.OrgEditTeam(id, body);
            //Assert.IsType<Team>(response);
        }

        /// <summary>
        /// Test OrgGet
        /// </summary>
        [Fact]
        public void OrgGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //var response = instance.OrgGet(org);
            //Assert.IsType<Organization>(response);
        }

        /// <summary>
        /// Test OrgGetAll
        /// </summary>
        [Fact]
        public void OrgGetAllTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgGetAll(page, limit);
            //Assert.IsType<List<Organization>>(response);
        }

        /// <summary>
        /// Test OrgGetHook
        /// </summary>
        [Fact]
        public void OrgGetHookTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //long id = null;
            //var response = instance.OrgGetHook(org, id);
            //Assert.IsType<Hook>(response);
        }

        /// <summary>
        /// Test OrgGetLabel
        /// </summary>
        [Fact]
        public void OrgGetLabelTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //long id = null;
            //var response = instance.OrgGetLabel(org, id);
            //Assert.IsType<Label>(response);
        }

        /// <summary>
        /// Test OrgGetRunnerRegistrationToken
        /// </summary>
        [Fact]
        public void OrgGetRunnerRegistrationTokenTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //instance.OrgGetRunnerRegistrationToken(org);
        }

        /// <summary>
        /// Test OrgGetTeam
        /// </summary>
        [Fact]
        public void OrgGetTeamTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //var response = instance.OrgGetTeam(id);
            //Assert.IsType<Team>(response);
        }

        /// <summary>
        /// Test OrgGetUserPermissions
        /// </summary>
        [Fact]
        public void OrgGetUserPermissionsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //string org = null;
            //var response = instance.OrgGetUserPermissions(username, org);
            //Assert.IsType<OrganizationPermissions>(response);
        }

        /// <summary>
        /// Test OrgIsMember
        /// </summary>
        [Fact]
        public void OrgIsMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string username = null;
            //instance.OrgIsMember(org, username);
        }

        /// <summary>
        /// Test OrgIsPublicMember
        /// </summary>
        [Fact]
        public void OrgIsPublicMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string username = null;
            //instance.OrgIsPublicMember(org, username);
        }

        /// <summary>
        /// Test OrgListActionsSecrets
        /// </summary>
        [Fact]
        public void OrgListActionsSecretsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgListActionsSecrets(org, page, limit);
            //Assert.IsType<List<Secret>>(response);
        }

        /// <summary>
        /// Test OrgListActivityFeeds
        /// </summary>
        [Fact]
        public void OrgListActivityFeedsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //DateTime? date = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgListActivityFeeds(org, date, page, limit);
            //Assert.IsType<List<Activity>>(response);
        }

        /// <summary>
        /// Test OrgListCurrentUserOrgs
        /// </summary>
        [Fact]
        public void OrgListCurrentUserOrgsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgListCurrentUserOrgs(page, limit);
            //Assert.IsType<List<Organization>>(response);
        }

        /// <summary>
        /// Test OrgListHooks
        /// </summary>
        [Fact]
        public void OrgListHooksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgListHooks(org, page, limit);
            //Assert.IsType<List<Hook>>(response);
        }

        /// <summary>
        /// Test OrgListLabels
        /// </summary>
        [Fact]
        public void OrgListLabelsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgListLabels(org, page, limit);
            //Assert.IsType<List<Label>>(response);
        }

        /// <summary>
        /// Test OrgListMembers
        /// </summary>
        [Fact]
        public void OrgListMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgListMembers(org, page, limit);
            //Assert.IsType<List<User>>(response);
        }

        /// <summary>
        /// Test OrgListPublicMembers
        /// </summary>
        [Fact]
        public void OrgListPublicMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgListPublicMembers(org, page, limit);
            //Assert.IsType<List<User>>(response);
        }

        /// <summary>
        /// Test OrgListRepos
        /// </summary>
        [Fact]
        public void OrgListReposTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgListRepos(org, page, limit);
            //Assert.IsType<List<Repository>>(response);
        }

        /// <summary>
        /// Test OrgListTeamActivityFeeds
        /// </summary>
        [Fact]
        public void OrgListTeamActivityFeedsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //DateTime? date = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgListTeamActivityFeeds(id, date, page, limit);
            //Assert.IsType<List<Activity>>(response);
        }

        /// <summary>
        /// Test OrgListTeamMember
        /// </summary>
        [Fact]
        public void OrgListTeamMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string username = null;
            //var response = instance.OrgListTeamMember(id, username);
            //Assert.IsType<User>(response);
        }

        /// <summary>
        /// Test OrgListTeamMembers
        /// </summary>
        [Fact]
        public void OrgListTeamMembersTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgListTeamMembers(id, page, limit);
            //Assert.IsType<List<User>>(response);
        }

        /// <summary>
        /// Test OrgListTeamRepo
        /// </summary>
        [Fact]
        public void OrgListTeamRepoTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string org = null;
            //string repo = null;
            //var response = instance.OrgListTeamRepo(id, org, repo);
            //Assert.IsType<Repository>(response);
        }

        /// <summary>
        /// Test OrgListTeamRepos
        /// </summary>
        [Fact]
        public void OrgListTeamReposTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgListTeamRepos(id, page, limit);
            //Assert.IsType<List<Repository>>(response);
        }

        /// <summary>
        /// Test OrgListTeams
        /// </summary>
        [Fact]
        public void OrgListTeamsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgListTeams(org, page, limit);
            //Assert.IsType<List<Team>>(response);
        }

        /// <summary>
        /// Test OrgListUserOrgs
        /// </summary>
        [Fact]
        public void OrgListUserOrgsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string username = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrgListUserOrgs(username, page, limit);
            //Assert.IsType<List<Organization>>(response);
        }

        /// <summary>
        /// Test OrgPublicizeMember
        /// </summary>
        [Fact]
        public void OrgPublicizeMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string username = null;
            //instance.OrgPublicizeMember(org, username);
        }

        /// <summary>
        /// Test OrgRemoveTeamMember
        /// </summary>
        [Fact]
        public void OrgRemoveTeamMemberTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string username = null;
            //instance.OrgRemoveTeamMember(id, username);
        }

        /// <summary>
        /// Test OrgRemoveTeamRepository
        /// </summary>
        [Fact]
        public void OrgRemoveTeamRepositoryTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //long id = null;
            //string org = null;
            //string repo = null;
            //instance.OrgRemoveTeamRepository(id, org, repo);
        }

        /// <summary>
        /// Test OrgUpdateAvatar
        /// </summary>
        [Fact]
        public void OrgUpdateAvatarTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //UpdateUserAvatarOption? body = null;
            //instance.OrgUpdateAvatar(org, body);
        }

        /// <summary>
        /// Test OrganizationBlockUser
        /// </summary>
        [Fact]
        public void OrganizationBlockUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string username = null;
            //string? note = null;
            //instance.OrganizationBlockUser(org, username, note);
        }

        /// <summary>
        /// Test OrganizationCheckUserBlock
        /// </summary>
        [Fact]
        public void OrganizationCheckUserBlockTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string username = null;
            //instance.OrganizationCheckUserBlock(org, username);
        }

        /// <summary>
        /// Test OrganizationListBlocks
        /// </summary>
        [Fact]
        public void OrganizationListBlocksTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.OrganizationListBlocks(org, page, limit);
            //Assert.IsType<List<User>>(response);
        }

        /// <summary>
        /// Test OrganizationUnblockUser
        /// </summary>
        [Fact]
        public void OrganizationUnblockUserTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string username = null;
            //instance.OrganizationUnblockUser(org, username);
        }

        /// <summary>
        /// Test TeamSearch
        /// </summary>
        [Fact]
        public void TeamSearchTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string? q = null;
            //bool? includeDesc = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.TeamSearch(org, q, includeDesc, page, limit);
            //Assert.IsType<TeamSearch200Response>(response);
        }

        /// <summary>
        /// Test UpdateOrgSecret
        /// </summary>
        [Fact]
        public void UpdateOrgSecretTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string secretname = null;
            //CreateOrUpdateSecretOption? body = null;
            //instance.UpdateOrgSecret(org, secretname, body);
        }

        /// <summary>
        /// Test UpdateOrgVariable
        /// </summary>
        [Fact]
        public void UpdateOrgVariableTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string org = null;
            //string variablename = null;
            //UpdateVariableOption? body = null;
            //instance.UpdateOrgVariable(org, variablename, body);
        }
    }
}
