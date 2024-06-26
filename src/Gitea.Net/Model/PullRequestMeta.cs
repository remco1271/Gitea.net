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
    /// PullRequestMeta PR info if an issue is a PR
    /// </summary>
    [DataContract(Name = "PullRequestMeta")]
    public partial class PullRequestMeta : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PullRequestMeta" /> class.
        /// </summary>
        /// <param name="draft">draft.</param>
        /// <param name="htmlUrl">htmlUrl.</param>
        /// <param name="merged">merged.</param>
        /// <param name="mergedAt">mergedAt.</param>
        public PullRequestMeta(bool draft = default(bool), string htmlUrl = default(string), bool merged = default(bool), DateTime mergedAt = default(DateTime))
        {
            this.Draft = draft;
            this.HtmlUrl = htmlUrl;
            this.Merged = merged;
            this.MergedAt = mergedAt;
        }

        /// <summary>
        /// Gets or Sets Draft
        /// </summary>
        [DataMember(Name = "draft", EmitDefaultValue = true)]
        public bool Draft { get; set; }

        /// <summary>
        /// Gets or Sets HtmlUrl
        /// </summary>
        [DataMember(Name = "html_url", EmitDefaultValue = false)]
        public string HtmlUrl { get; set; }

        /// <summary>
        /// Gets or Sets Merged
        /// </summary>
        [DataMember(Name = "merged", EmitDefaultValue = true)]
        public bool Merged { get; set; }

        /// <summary>
        /// Gets or Sets MergedAt
        /// </summary>
        [DataMember(Name = "merged_at", EmitDefaultValue = false)]
        public DateTime MergedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PullRequestMeta {\n");
            sb.Append("  Draft: ").Append(Draft).Append("\n");
            sb.Append("  HtmlUrl: ").Append(HtmlUrl).Append("\n");
            sb.Append("  Merged: ").Append(Merged).Append("\n");
            sb.Append("  MergedAt: ").Append(MergedAt).Append("\n");
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
