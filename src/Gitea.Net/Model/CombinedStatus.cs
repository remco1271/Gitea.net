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
    /// CombinedStatus holds the combined state of several statuses for a single commit
    /// </summary>
    [DataContract(Name = "CombinedStatus")]
    public partial class CombinedStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CombinedStatus" /> class.
        /// </summary>
        /// <param name="commitUrl">commitUrl.</param>
        /// <param name="repository">repository.</param>
        /// <param name="sha">sha.</param>
        /// <param name="state">CommitStatusState holds the state of a CommitStatus It can be \&quot;pending\&quot;, \&quot;success\&quot;, \&quot;error\&quot; and \&quot;failure\&quot;.</param>
        /// <param name="statuses">statuses.</param>
        /// <param name="totalCount">totalCount.</param>
        /// <param name="url">url.</param>
        public CombinedStatus(string commitUrl = default(string), Repository repository = default(Repository), string sha = default(string), string state = default(string), List<CommitStatus> statuses = default(List<CommitStatus>), long totalCount = default(long), string url = default(string))
        {
            this.CommitUrl = commitUrl;
            this.Repository = repository;
            this.Sha = sha;
            this.State = state;
            this.Statuses = statuses;
            this.TotalCount = totalCount;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets CommitUrl
        /// </summary>
        [DataMember(Name = "commit_url", EmitDefaultValue = false)]
        public string CommitUrl { get; set; }

        /// <summary>
        /// Gets or Sets Repository
        /// </summary>
        [DataMember(Name = "repository", EmitDefaultValue = false)]
        public Repository Repository { get; set; }

        /// <summary>
        /// Gets or Sets Sha
        /// </summary>
        [DataMember(Name = "sha", EmitDefaultValue = false)]
        public string Sha { get; set; }

        /// <summary>
        /// CommitStatusState holds the state of a CommitStatus It can be \&quot;pending\&quot;, \&quot;success\&quot;, \&quot;error\&quot; and \&quot;failure\&quot;
        /// </summary>
        /// <value>CommitStatusState holds the state of a CommitStatus It can be \&quot;pending\&quot;, \&quot;success\&quot;, \&quot;error\&quot; and \&quot;failure\&quot;</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Statuses
        /// </summary>
        [DataMember(Name = "statuses", EmitDefaultValue = false)]
        public List<CommitStatus> Statuses { get; set; }

        /// <summary>
        /// Gets or Sets TotalCount
        /// </summary>
        [DataMember(Name = "total_count", EmitDefaultValue = false)]
        public long TotalCount { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CombinedStatus {\n");
            sb.Append("  CommitUrl: ").Append(CommitUrl).Append("\n");
            sb.Append("  Repository: ").Append(Repository).Append("\n");
            sb.Append("  Sha: ").Append(Sha).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Statuses: ").Append(Statuses).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
