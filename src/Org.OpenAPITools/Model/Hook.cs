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
    /// Hook a hook is a web hook when one repository changed
    /// </summary>
    [DataContract(Name = "Hook")]
    public partial class Hook : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Hook" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="authorizationHeader">authorizationHeader.</param>
        /// <param name="branchFilter">branchFilter.</param>
        /// <param name="config">config.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="events">events.</param>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public Hook(bool active = default(bool), string authorizationHeader = default(string), string branchFilter = default(string), Dictionary<string, string> config = default(Dictionary<string, string>), DateTime createdAt = default(DateTime), List<string> events = default(List<string>), long id = default(long), string type = default(string), DateTime updatedAt = default(DateTime))
        {
            this.Active = active;
            this.AuthorizationHeader = authorizationHeader;
            this.BranchFilter = branchFilter;
            this.Config = config;
            this.CreatedAt = createdAt;
            this.Events = events;
            this.Id = id;
            this.Type = type;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets AuthorizationHeader
        /// </summary>
        [DataMember(Name = "authorization_header", EmitDefaultValue = false)]
        public string AuthorizationHeader { get; set; }

        /// <summary>
        /// Gets or Sets BranchFilter
        /// </summary>
        [DataMember(Name = "branch_filter", EmitDefaultValue = false)]
        public string BranchFilter { get; set; }

        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name = "config", EmitDefaultValue = false)]
        public Dictionary<string, string> Config { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

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
            sb.Append("class Hook {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AuthorizationHeader: ").Append(AuthorizationHeader).Append("\n");
            sb.Append("  BranchFilter: ").Append(BranchFilter).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
