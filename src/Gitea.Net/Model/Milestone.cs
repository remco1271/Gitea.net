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
    /// Milestone milestone is a collection of issues on one repository
    /// </summary>
    [DataContract(Name = "Milestone")]
    public partial class Milestone : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Milestone" /> class.
        /// </summary>
        /// <param name="closedAt">closedAt.</param>
        /// <param name="closedIssues">closedIssues.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="description">description.</param>
        /// <param name="dueOn">dueOn.</param>
        /// <param name="id">id.</param>
        /// <param name="openIssues">openIssues.</param>
        /// <param name="state">StateType issue state type.</param>
        /// <param name="title">title.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public Milestone(DateTime closedAt = default(DateTime), long closedIssues = default(long), DateTime createdAt = default(DateTime), string description = default(string), DateTime dueOn = default(DateTime), long id = default(long), long openIssues = default(long), string state = default(string), string title = default(string), DateTime updatedAt = default(DateTime))
        {
            this.ClosedAt = closedAt;
            this.ClosedIssues = closedIssues;
            this.CreatedAt = createdAt;
            this.Description = description;
            this.DueOn = dueOn;
            this.Id = id;
            this.OpenIssues = openIssues;
            this.State = state;
            this.Title = title;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets ClosedAt
        /// </summary>
        [DataMember(Name = "closed_at", EmitDefaultValue = false)]
        public DateTime ClosedAt { get; set; }

        /// <summary>
        /// Gets or Sets ClosedIssues
        /// </summary>
        [DataMember(Name = "closed_issues", EmitDefaultValue = false)]
        public long ClosedIssues { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets DueOn
        /// </summary>
        [DataMember(Name = "due_on", EmitDefaultValue = false)]
        public DateTime DueOn { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets OpenIssues
        /// </summary>
        [DataMember(Name = "open_issues", EmitDefaultValue = false)]
        public long OpenIssues { get; set; }

        /// <summary>
        /// StateType issue state type
        /// </summary>
        /// <value>StateType issue state type</value>
        [DataMember(Name = "state", EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Milestone {\n");
            sb.Append("  ClosedAt: ").Append(ClosedAt).Append("\n");
            sb.Append("  ClosedIssues: ").Append(ClosedIssues).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  DueOn: ").Append(DueOn).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OpenIssues: ").Append(OpenIssues).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
