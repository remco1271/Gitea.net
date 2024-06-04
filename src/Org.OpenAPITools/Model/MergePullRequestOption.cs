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
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// MergePullRequestForm form for merging Pull Request
    /// </summary>
    [DataContract(Name = "MergePullRequestOption")]
    public partial class MergePullRequestOption : IValidatableObject
    {
        /// <summary>
        /// Defines Do
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DoEnum
        {
            /// <summary>
            /// Enum Merge for value: merge
            /// </summary>
            [EnumMember(Value = "merge")]
            Merge = 1,

            /// <summary>
            /// Enum Rebase for value: rebase
            /// </summary>
            [EnumMember(Value = "rebase")]
            Rebase = 2,

            /// <summary>
            /// Enum RebaseMerge for value: rebase-merge
            /// </summary>
            [EnumMember(Value = "rebase-merge")]
            RebaseMerge = 3,

            /// <summary>
            /// Enum Squash for value: squash
            /// </summary>
            [EnumMember(Value = "squash")]
            Squash = 4,

            /// <summary>
            /// Enum FastForwardOnly for value: fast-forward-only
            /// </summary>
            [EnumMember(Value = "fast-forward-only")]
            FastForwardOnly = 5,

            /// <summary>
            /// Enum ManuallyMerged for value: manually-merged
            /// </summary>
            [EnumMember(Value = "manually-merged")]
            ManuallyMerged = 6
        }


        /// <summary>
        /// Gets or Sets Do
        /// </summary>
        [DataMember(Name = "Do", IsRequired = true, EmitDefaultValue = true)]
        public DoEnum Do { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MergePullRequestOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MergePullRequestOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MergePullRequestOption" /> class.
        /// </summary>
        /// <param name="varDo">varDo (required).</param>
        /// <param name="mergeCommitID">mergeCommitID.</param>
        /// <param name="mergeMessageField">mergeMessageField.</param>
        /// <param name="mergeTitleField">mergeTitleField.</param>
        /// <param name="deleteBranchAfterMerge">deleteBranchAfterMerge.</param>
        /// <param name="forceMerge">forceMerge.</param>
        /// <param name="headCommitId">headCommitId.</param>
        /// <param name="mergeWhenChecksSucceed">mergeWhenChecksSucceed.</param>
        public MergePullRequestOption(DoEnum varDo = default(DoEnum), string mergeCommitID = default(string), string mergeMessageField = default(string), string mergeTitleField = default(string), bool deleteBranchAfterMerge = default(bool), bool forceMerge = default(bool), string headCommitId = default(string), bool mergeWhenChecksSucceed = default(bool))
        {
            this.Do = varDo;
            this.MergeCommitID = mergeCommitID;
            this.MergeMessageField = mergeMessageField;
            this.MergeTitleField = mergeTitleField;
            this.DeleteBranchAfterMerge = deleteBranchAfterMerge;
            this.ForceMerge = forceMerge;
            this.HeadCommitId = headCommitId;
            this.MergeWhenChecksSucceed = mergeWhenChecksSucceed;
        }

        /// <summary>
        /// Gets or Sets MergeCommitID
        /// </summary>
        [DataMember(Name = "MergeCommitID", EmitDefaultValue = false)]
        public string MergeCommitID { get; set; }

        /// <summary>
        /// Gets or Sets MergeMessageField
        /// </summary>
        [DataMember(Name = "MergeMessageField", EmitDefaultValue = false)]
        public string MergeMessageField { get; set; }

        /// <summary>
        /// Gets or Sets MergeTitleField
        /// </summary>
        [DataMember(Name = "MergeTitleField", EmitDefaultValue = false)]
        public string MergeTitleField { get; set; }

        /// <summary>
        /// Gets or Sets DeleteBranchAfterMerge
        /// </summary>
        [DataMember(Name = "delete_branch_after_merge", EmitDefaultValue = true)]
        public bool DeleteBranchAfterMerge { get; set; }

        /// <summary>
        /// Gets or Sets ForceMerge
        /// </summary>
        [DataMember(Name = "force_merge", EmitDefaultValue = true)]
        public bool ForceMerge { get; set; }

        /// <summary>
        /// Gets or Sets HeadCommitId
        /// </summary>
        [DataMember(Name = "head_commit_id", EmitDefaultValue = false)]
        public string HeadCommitId { get; set; }

        /// <summary>
        /// Gets or Sets MergeWhenChecksSucceed
        /// </summary>
        [DataMember(Name = "merge_when_checks_succeed", EmitDefaultValue = true)]
        public bool MergeWhenChecksSucceed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MergePullRequestOption {\n");
            sb.Append("  Do: ").Append(Do).Append("\n");
            sb.Append("  MergeCommitID: ").Append(MergeCommitID).Append("\n");
            sb.Append("  MergeMessageField: ").Append(MergeMessageField).Append("\n");
            sb.Append("  MergeTitleField: ").Append(MergeTitleField).Append("\n");
            sb.Append("  DeleteBranchAfterMerge: ").Append(DeleteBranchAfterMerge).Append("\n");
            sb.Append("  ForceMerge: ").Append(ForceMerge).Append("\n");
            sb.Append("  HeadCommitId: ").Append(HeadCommitId).Append("\n");
            sb.Append("  MergeWhenChecksSucceed: ").Append(MergeWhenChecksSucceed).Append("\n");
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
