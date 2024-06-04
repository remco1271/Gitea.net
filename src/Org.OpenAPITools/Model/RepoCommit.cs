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
    /// RepoCommit
    /// </summary>
    [DataContract(Name = "RepoCommit")]
    public partial class RepoCommit : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepoCommit" /> class.
        /// </summary>
        /// <param name="author">author.</param>
        /// <param name="committer">committer.</param>
        /// <param name="message">message.</param>
        /// <param name="tree">tree.</param>
        /// <param name="url">url.</param>
        /// <param name="verification">verification.</param>
        public RepoCommit(CommitUser author = default(CommitUser), CommitUser committer = default(CommitUser), string message = default(string), CommitMeta tree = default(CommitMeta), string url = default(string), PayloadCommitVerification verification = default(PayloadCommitVerification))
        {
            this.Author = author;
            this.Committer = committer;
            this.Message = message;
            this.Tree = tree;
            this.Url = url;
            this.Verification = verification;
        }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", EmitDefaultValue = false)]
        public CommitUser Author { get; set; }

        /// <summary>
        /// Gets or Sets Committer
        /// </summary>
        [DataMember(Name = "committer", EmitDefaultValue = false)]
        public CommitUser Committer { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Tree
        /// </summary>
        [DataMember(Name = "tree", EmitDefaultValue = false)]
        public CommitMeta Tree { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Verification
        /// </summary>
        [DataMember(Name = "verification", EmitDefaultValue = false)]
        public PayloadCommitVerification Verification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RepoCommit {\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Committer: ").Append(Committer).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Tree: ").Append(Tree).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Verification: ").Append(Verification).Append("\n");
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
