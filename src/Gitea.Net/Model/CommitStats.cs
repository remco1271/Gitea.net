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
    /// CommitStats is statistics for a RepoCommit
    /// </summary>
    [DataContract(Name = "CommitStats")]
    public partial class CommitStats : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommitStats" /> class.
        /// </summary>
        /// <param name="additions">additions.</param>
        /// <param name="deletions">deletions.</param>
        /// <param name="total">total.</param>
        public CommitStats(long additions = default(long), long deletions = default(long), long total = default(long))
        {
            this.Additions = additions;
            this.Deletions = deletions;
            this.Total = total;
        }

        /// <summary>
        /// Gets or Sets Additions
        /// </summary>
        [DataMember(Name = "additions", EmitDefaultValue = false)]
        public long Additions { get; set; }

        /// <summary>
        /// Gets or Sets Deletions
        /// </summary>
        [DataMember(Name = "deletions", EmitDefaultValue = false)]
        public long Deletions { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public long Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommitStats {\n");
            sb.Append("  Additions: ").Append(Additions).Append("\n");
            sb.Append("  Deletions: ").Append(Deletions).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
