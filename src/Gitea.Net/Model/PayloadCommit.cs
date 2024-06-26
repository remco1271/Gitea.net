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
    /// PayloadCommit represents a commit
    /// </summary>
    [DataContract(Name = "PayloadCommit")]
    public partial class PayloadCommit : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadCommit" /> class.
        /// </summary>
        /// <param name="added">added.</param>
        /// <param name="author">author.</param>
        /// <param name="committer">committer.</param>
        /// <param name="id">sha1 hash of the commit.</param>
        /// <param name="message">message.</param>
        /// <param name="modified">modified.</param>
        /// <param name="removed">removed.</param>
        /// <param name="timestamp">timestamp.</param>
        /// <param name="url">url.</param>
        /// <param name="verification">verification.</param>
        public PayloadCommit(List<string> added = default(List<string>), PayloadUser author = default(PayloadUser), PayloadUser committer = default(PayloadUser), string id = default(string), string message = default(string), List<string> modified = default(List<string>), List<string> removed = default(List<string>), DateTime timestamp = default(DateTime), string url = default(string), PayloadCommitVerification verification = default(PayloadCommitVerification))
        {
            this.Added = added;
            this.Author = author;
            this.Committer = committer;
            this.Id = id;
            this.Message = message;
            this.Modified = modified;
            this.Removed = removed;
            this.Timestamp = timestamp;
            this.Url = url;
            this.Verification = verification;
        }

        /// <summary>
        /// Gets or Sets Added
        /// </summary>
        [DataMember(Name = "added", EmitDefaultValue = false)]
        public List<string> Added { get; set; }

        /// <summary>
        /// Gets or Sets Author
        /// </summary>
        [DataMember(Name = "author", EmitDefaultValue = false)]
        public PayloadUser Author { get; set; }

        /// <summary>
        /// Gets or Sets Committer
        /// </summary>
        [DataMember(Name = "committer", EmitDefaultValue = false)]
        public PayloadUser Committer { get; set; }

        /// <summary>
        /// sha1 hash of the commit
        /// </summary>
        /// <value>sha1 hash of the commit</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Gets or Sets Modified
        /// </summary>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public List<string> Modified { get; set; }

        /// <summary>
        /// Gets or Sets Removed
        /// </summary>
        [DataMember(Name = "removed", EmitDefaultValue = false)]
        public List<string> Removed { get; set; }

        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

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
            sb.Append("class PayloadCommit {\n");
            sb.Append("  Added: ").Append(Added).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  Committer: ").Append(Committer).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Removed: ").Append(Removed).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
