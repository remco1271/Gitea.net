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
    /// Branch represents a repository branch
    /// </summary>
    [DataContract(Name = "Branch")]
    public partial class Branch : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Branch" /> class.
        /// </summary>
        /// <param name="commit">commit.</param>
        /// <param name="effectiveBranchProtectionName">effectiveBranchProtectionName.</param>
        /// <param name="enableStatusCheck">enableStatusCheck.</param>
        /// <param name="name">name.</param>
        /// <param name="varProtected">varProtected.</param>
        /// <param name="requiredApprovals">requiredApprovals.</param>
        /// <param name="statusCheckContexts">statusCheckContexts.</param>
        /// <param name="userCanMerge">userCanMerge.</param>
        /// <param name="userCanPush">userCanPush.</param>
        public Branch(PayloadCommit commit = default(PayloadCommit), string effectiveBranchProtectionName = default(string), bool enableStatusCheck = default(bool), string name = default(string), bool varProtected = default(bool), long requiredApprovals = default(long), List<string> statusCheckContexts = default(List<string>), bool userCanMerge = default(bool), bool userCanPush = default(bool))
        {
            this.Commit = commit;
            this.EffectiveBranchProtectionName = effectiveBranchProtectionName;
            this.EnableStatusCheck = enableStatusCheck;
            this.Name = name;
            this.Protected = varProtected;
            this.RequiredApprovals = requiredApprovals;
            this.StatusCheckContexts = statusCheckContexts;
            this.UserCanMerge = userCanMerge;
            this.UserCanPush = userCanPush;
        }

        /// <summary>
        /// Gets or Sets Commit
        /// </summary>
        [DataMember(Name = "commit", EmitDefaultValue = false)]
        public PayloadCommit Commit { get; set; }

        /// <summary>
        /// Gets or Sets EffectiveBranchProtectionName
        /// </summary>
        [DataMember(Name = "effective_branch_protection_name", EmitDefaultValue = false)]
        public string EffectiveBranchProtectionName { get; set; }

        /// <summary>
        /// Gets or Sets EnableStatusCheck
        /// </summary>
        [DataMember(Name = "enable_status_check", EmitDefaultValue = true)]
        public bool EnableStatusCheck { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Protected
        /// </summary>
        [DataMember(Name = "protected", EmitDefaultValue = true)]
        public bool Protected { get; set; }

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
        /// Gets or Sets UserCanMerge
        /// </summary>
        [DataMember(Name = "user_can_merge", EmitDefaultValue = true)]
        public bool UserCanMerge { get; set; }

        /// <summary>
        /// Gets or Sets UserCanPush
        /// </summary>
        [DataMember(Name = "user_can_push", EmitDefaultValue = true)]
        public bool UserCanPush { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Branch {\n");
            sb.Append("  Commit: ").Append(Commit).Append("\n");
            sb.Append("  EffectiveBranchProtectionName: ").Append(EffectiveBranchProtectionName).Append("\n");
            sb.Append("  EnableStatusCheck: ").Append(EnableStatusCheck).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Protected: ").Append(Protected).Append("\n");
            sb.Append("  RequiredApprovals: ").Append(RequiredApprovals).Append("\n");
            sb.Append("  StatusCheckContexts: ").Append(StatusCheckContexts).Append("\n");
            sb.Append("  UserCanMerge: ").Append(UserCanMerge).Append("\n");
            sb.Append("  UserCanPush: ").Append(UserCanPush).Append("\n");
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