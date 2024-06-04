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
    /// PullReviewRequestOptions are options to add or remove pull review requests
    /// </summary>
    [DataContract(Name = "PullReviewRequestOptions")]
    public partial class PullReviewRequestOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PullReviewRequestOptions" /> class.
        /// </summary>
        /// <param name="reviewers">reviewers.</param>
        /// <param name="teamReviewers">teamReviewers.</param>
        public PullReviewRequestOptions(List<string> reviewers = default(List<string>), List<string> teamReviewers = default(List<string>))
        {
            this.Reviewers = reviewers;
            this.TeamReviewers = teamReviewers;
        }

        /// <summary>
        /// Gets or Sets Reviewers
        /// </summary>
        [DataMember(Name = "reviewers", EmitDefaultValue = false)]
        public List<string> Reviewers { get; set; }

        /// <summary>
        /// Gets or Sets TeamReviewers
        /// </summary>
        [DataMember(Name = "team_reviewers", EmitDefaultValue = false)]
        public List<string> TeamReviewers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PullReviewRequestOptions {\n");
            sb.Append("  Reviewers: ").Append(Reviewers).Append("\n");
            sb.Append("  TeamReviewers: ").Append(TeamReviewers).Append("\n");
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
