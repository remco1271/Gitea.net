/*
 * Gitea API
 *
 * This documentation describes the Gitea API.
 *
 * The version of the OpenAPI document: 1.22.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Gitea.Net.Client.OpenAPIDateConverter;

namespace Gitea.Net.Model
{
    /// <summary>
    /// EditBranchProtectionOption options for editing a branch protection
    /// </summary>
    [DataContract(Name = "EditBranchProtectionOption")]
    public partial class EditBranchProtectionOption : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditBranchProtectionOption" /> class.
        /// </summary>
        /// <param name="approvalsWhitelistTeams">approvalsWhitelistTeams.</param>
        /// <param name="approvalsWhitelistUsername">approvalsWhitelistUsername.</param>
        /// <param name="blockOnOfficialReviewRequests">blockOnOfficialReviewRequests.</param>
        /// <param name="blockOnOutdatedBranch">blockOnOutdatedBranch.</param>
        /// <param name="blockOnRejectedReviews">blockOnRejectedReviews.</param>
        /// <param name="dismissStaleApprovals">dismissStaleApprovals.</param>
        /// <param name="enableApprovalsWhitelist">enableApprovalsWhitelist.</param>
        /// <param name="enableMergeWhitelist">enableMergeWhitelist.</param>
        /// <param name="enablePush">enablePush.</param>
        /// <param name="enablePushWhitelist">enablePushWhitelist.</param>
        /// <param name="enableStatusCheck">enableStatusCheck.</param>
        /// <param name="ignoreStaleApprovals">ignoreStaleApprovals.</param>
        /// <param name="mergeWhitelistTeams">mergeWhitelistTeams.</param>
        /// <param name="mergeWhitelistUsernames">mergeWhitelistUsernames.</param>
        /// <param name="protectedFilePatterns">protectedFilePatterns.</param>
        /// <param name="pushWhitelistDeployKeys">pushWhitelistDeployKeys.</param>
        /// <param name="pushWhitelistTeams">pushWhitelistTeams.</param>
        /// <param name="pushWhitelistUsernames">pushWhitelistUsernames.</param>
        /// <param name="requireSignedCommits">requireSignedCommits.</param>
        /// <param name="requiredApprovals">requiredApprovals.</param>
        /// <param name="statusCheckContexts">statusCheckContexts.</param>
        /// <param name="unprotectedFilePatterns">unprotectedFilePatterns.</param>
        public EditBranchProtectionOption(List<string> approvalsWhitelistTeams = default(List<string>), List<string> approvalsWhitelistUsername = default(List<string>), bool blockOnOfficialReviewRequests = default(bool), bool blockOnOutdatedBranch = default(bool), bool blockOnRejectedReviews = default(bool), bool dismissStaleApprovals = default(bool), bool enableApprovalsWhitelist = default(bool), bool enableMergeWhitelist = default(bool), bool enablePush = default(bool), bool enablePushWhitelist = default(bool), bool enableStatusCheck = default(bool), bool ignoreStaleApprovals = default(bool), List<string> mergeWhitelistTeams = default(List<string>), List<string> mergeWhitelistUsernames = default(List<string>), string protectedFilePatterns = default(string), bool pushWhitelistDeployKeys = default(bool), List<string> pushWhitelistTeams = default(List<string>), List<string> pushWhitelistUsernames = default(List<string>), bool requireSignedCommits = default(bool), long requiredApprovals = default(long), List<string> statusCheckContexts = default(List<string>), string unprotectedFilePatterns = default(string))
        {
            this.ApprovalsWhitelistTeams = approvalsWhitelistTeams;
            this.ApprovalsWhitelistUsername = approvalsWhitelistUsername;
            this.BlockOnOfficialReviewRequests = blockOnOfficialReviewRequests;
            this.BlockOnOutdatedBranch = blockOnOutdatedBranch;
            this.BlockOnRejectedReviews = blockOnRejectedReviews;
            this.DismissStaleApprovals = dismissStaleApprovals;
            this.EnableApprovalsWhitelist = enableApprovalsWhitelist;
            this.EnableMergeWhitelist = enableMergeWhitelist;
            this.EnablePush = enablePush;
            this.EnablePushWhitelist = enablePushWhitelist;
            this.EnableStatusCheck = enableStatusCheck;
            this.IgnoreStaleApprovals = ignoreStaleApprovals;
            this.MergeWhitelistTeams = mergeWhitelistTeams;
            this.MergeWhitelistUsernames = mergeWhitelistUsernames;
            this.ProtectedFilePatterns = protectedFilePatterns;
            this.PushWhitelistDeployKeys = pushWhitelistDeployKeys;
            this.PushWhitelistTeams = pushWhitelistTeams;
            this.PushWhitelistUsernames = pushWhitelistUsernames;
            this.RequireSignedCommits = requireSignedCommits;
            this.RequiredApprovals = requiredApprovals;
            this.StatusCheckContexts = statusCheckContexts;
            this.UnprotectedFilePatterns = unprotectedFilePatterns;
        }

        /// <summary>
        /// Gets or Sets ApprovalsWhitelistTeams
        /// </summary>
        [DataMember(Name = "approvals_whitelist_teams", EmitDefaultValue = false)]
        public List<string> ApprovalsWhitelistTeams { get; set; }

        /// <summary>
        /// Gets or Sets ApprovalsWhitelistUsername
        /// </summary>
        [DataMember(Name = "approvals_whitelist_username", EmitDefaultValue = false)]
        public List<string> ApprovalsWhitelistUsername { get; set; }

        /// <summary>
        /// Gets or Sets BlockOnOfficialReviewRequests
        /// </summary>
        [DataMember(Name = "block_on_official_review_requests", EmitDefaultValue = true)]
        public bool BlockOnOfficialReviewRequests { get; set; }

        /// <summary>
        /// Gets or Sets BlockOnOutdatedBranch
        /// </summary>
        [DataMember(Name = "block_on_outdated_branch", EmitDefaultValue = true)]
        public bool BlockOnOutdatedBranch { get; set; }

        /// <summary>
        /// Gets or Sets BlockOnRejectedReviews
        /// </summary>
        [DataMember(Name = "block_on_rejected_reviews", EmitDefaultValue = true)]
        public bool BlockOnRejectedReviews { get; set; }

        /// <summary>
        /// Gets or Sets DismissStaleApprovals
        /// </summary>
        [DataMember(Name = "dismiss_stale_approvals", EmitDefaultValue = true)]
        public bool DismissStaleApprovals { get; set; }

        /// <summary>
        /// Gets or Sets EnableApprovalsWhitelist
        /// </summary>
        [DataMember(Name = "enable_approvals_whitelist", EmitDefaultValue = true)]
        public bool EnableApprovalsWhitelist { get; set; }

        /// <summary>
        /// Gets or Sets EnableMergeWhitelist
        /// </summary>
        [DataMember(Name = "enable_merge_whitelist", EmitDefaultValue = true)]
        public bool EnableMergeWhitelist { get; set; }

        /// <summary>
        /// Gets or Sets EnablePush
        /// </summary>
        [DataMember(Name = "enable_push", EmitDefaultValue = true)]
        public bool EnablePush { get; set; }

        /// <summary>
        /// Gets or Sets EnablePushWhitelist
        /// </summary>
        [DataMember(Name = "enable_push_whitelist", EmitDefaultValue = true)]
        public bool EnablePushWhitelist { get; set; }

        /// <summary>
        /// Gets or Sets EnableStatusCheck
        /// </summary>
        [DataMember(Name = "enable_status_check", EmitDefaultValue = true)]
        public bool EnableStatusCheck { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreStaleApprovals
        /// </summary>
        [DataMember(Name = "ignore_stale_approvals", EmitDefaultValue = true)]
        public bool IgnoreStaleApprovals { get; set; }

        /// <summary>
        /// Gets or Sets MergeWhitelistTeams
        /// </summary>
        [DataMember(Name = "merge_whitelist_teams", EmitDefaultValue = false)]
        public List<string> MergeWhitelistTeams { get; set; }

        /// <summary>
        /// Gets or Sets MergeWhitelistUsernames
        /// </summary>
        [DataMember(Name = "merge_whitelist_usernames", EmitDefaultValue = false)]
        public List<string> MergeWhitelistUsernames { get; set; }

        /// <summary>
        /// Gets or Sets ProtectedFilePatterns
        /// </summary>
        [DataMember(Name = "protected_file_patterns", EmitDefaultValue = false)]
        public string ProtectedFilePatterns { get; set; }

        /// <summary>
        /// Gets or Sets PushWhitelistDeployKeys
        /// </summary>
        [DataMember(Name = "push_whitelist_deploy_keys", EmitDefaultValue = true)]
        public bool PushWhitelistDeployKeys { get; set; }

        /// <summary>
        /// Gets or Sets PushWhitelistTeams
        /// </summary>
        [DataMember(Name = "push_whitelist_teams", EmitDefaultValue = false)]
        public List<string> PushWhitelistTeams { get; set; }

        /// <summary>
        /// Gets or Sets PushWhitelistUsernames
        /// </summary>
        [DataMember(Name = "push_whitelist_usernames", EmitDefaultValue = false)]
        public List<string> PushWhitelistUsernames { get; set; }

        /// <summary>
        /// Gets or Sets RequireSignedCommits
        /// </summary>
        [DataMember(Name = "require_signed_commits", EmitDefaultValue = true)]
        public bool RequireSignedCommits { get; set; }

        /// <summary>
        /// Gets or Sets RequiredApprovals
        /// </summary>
        [DataMember(Name = "required_approvals", EmitDefaultValue = false)]
        public long RequiredApprovals { get; set; }

        /// <summary>
        /// Gets or Sets StatusCheckContexts
        /// </summary>
        [DataMember(Name = "status_check_contexts", EmitDefaultValue = false)]
        public List<string> StatusCheckContexts { get; set; }

        /// <summary>
        /// Gets or Sets UnprotectedFilePatterns
        /// </summary>
        [DataMember(Name = "unprotected_file_patterns", EmitDefaultValue = false)]
        public string UnprotectedFilePatterns { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EditBranchProtectionOption {\n");
            sb.Append("  ApprovalsWhitelistTeams: ").Append(ApprovalsWhitelistTeams).Append("\n");
            sb.Append("  ApprovalsWhitelistUsername: ").Append(ApprovalsWhitelistUsername).Append("\n");
            sb.Append("  BlockOnOfficialReviewRequests: ").Append(BlockOnOfficialReviewRequests).Append("\n");
            sb.Append("  BlockOnOutdatedBranch: ").Append(BlockOnOutdatedBranch).Append("\n");
            sb.Append("  BlockOnRejectedReviews: ").Append(BlockOnRejectedReviews).Append("\n");
            sb.Append("  DismissStaleApprovals: ").Append(DismissStaleApprovals).Append("\n");
            sb.Append("  EnableApprovalsWhitelist: ").Append(EnableApprovalsWhitelist).Append("\n");
            sb.Append("  EnableMergeWhitelist: ").Append(EnableMergeWhitelist).Append("\n");
            sb.Append("  EnablePush: ").Append(EnablePush).Append("\n");
            sb.Append("  EnablePushWhitelist: ").Append(EnablePushWhitelist).Append("\n");
            sb.Append("  EnableStatusCheck: ").Append(EnableStatusCheck).Append("\n");
            sb.Append("  IgnoreStaleApprovals: ").Append(IgnoreStaleApprovals).Append("\n");
            sb.Append("  MergeWhitelistTeams: ").Append(MergeWhitelistTeams).Append("\n");
            sb.Append("  MergeWhitelistUsernames: ").Append(MergeWhitelistUsernames).Append("\n");
            sb.Append("  ProtectedFilePatterns: ").Append(ProtectedFilePatterns).Append("\n");
            sb.Append("  PushWhitelistDeployKeys: ").Append(PushWhitelistDeployKeys).Append("\n");
            sb.Append("  PushWhitelistTeams: ").Append(PushWhitelistTeams).Append("\n");
            sb.Append("  PushWhitelistUsernames: ").Append(PushWhitelistUsernames).Append("\n");
            sb.Append("  RequireSignedCommits: ").Append(RequireSignedCommits).Append("\n");
            sb.Append("  RequiredApprovals: ").Append(RequiredApprovals).Append("\n");
            sb.Append("  StatusCheckContexts: ").Append(StatusCheckContexts).Append("\n");
            sb.Append("  UnprotectedFilePatterns: ").Append(UnprotectedFilePatterns).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
