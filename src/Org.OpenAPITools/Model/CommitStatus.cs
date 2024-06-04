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
    /// CommitStatus holds a single status of a single Commit
    /// </summary>
    [DataContract(Name = "CommitStatus")]
    public partial class CommitStatus : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommitStatus" /> class.
        /// </summary>
        /// <param name="context">context.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="creator">creator.</param>
        /// <param name="description">description.</param>
        /// <param name="id">id.</param>
        /// <param name="status">CommitStatusState holds the state of a CommitStatus It can be \&quot;pending\&quot;, \&quot;success\&quot;, \&quot;error\&quot; and \&quot;failure\&quot;.</param>
        /// <param name="targetUrl">targetUrl.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="url">url.</param>
        public CommitStatus(string context = default(string), DateTime createdAt = default(DateTime), User creator = default(User), string description = default(string), long id = default(long), string status = default(string), string targetUrl = default(string), DateTime updatedAt = default(DateTime), string url = default(string))
        {
            this.Context = context;
            this.CreatedAt = createdAt;
            this.Creator = creator;
            this.Description = description;
            this.Id = id;
            this.Status = status;
            this.TargetUrl = targetUrl;
            this.UpdatedAt = updatedAt;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets Context
        /// </summary>
        [DataMember(Name = "context", EmitDefaultValue = false)]
        public string Context { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Creator
        /// </summary>
        [DataMember(Name = "creator", EmitDefaultValue = false)]
        public User Creator { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// CommitStatusState holds the state of a CommitStatus It can be \&quot;pending\&quot;, \&quot;success\&quot;, \&quot;error\&quot; and \&quot;failure\&quot;
        /// </summary>
        /// <value>CommitStatusState holds the state of a CommitStatus It can be \&quot;pending\&quot;, \&quot;success\&quot;, \&quot;error\&quot; and \&quot;failure\&quot;</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets TargetUrl
        /// </summary>
        [DataMember(Name = "target_url", EmitDefaultValue = false)]
        public string TargetUrl { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

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
            sb.Append("class CommitStatus {\n");
            sb.Append("  Context: ").Append(Context).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Creator: ").Append(Creator).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TargetUrl: ").Append(TargetUrl).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
