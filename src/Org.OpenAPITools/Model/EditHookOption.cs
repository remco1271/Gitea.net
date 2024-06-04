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
    /// EditHookOption options when modify one hook
    /// </summary>
    [DataContract(Name = "EditHookOption")]
    public partial class EditHookOption : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHookOption" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="authorizationHeader">authorizationHeader.</param>
        /// <param name="branchFilter">branchFilter.</param>
        /// <param name="config">config.</param>
        /// <param name="events">events.</param>
        public EditHookOption(bool active = default(bool), string authorizationHeader = default(string), string branchFilter = default(string), Dictionary<string, string> config = default(Dictionary<string, string>), List<string> events = default(List<string>))
        {
            this.Active = active;
            this.AuthorizationHeader = authorizationHeader;
            this.BranchFilter = branchFilter;
            this.Config = config;
            this.Events = events;
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
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name = "events", EmitDefaultValue = false)]
        public List<string> Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EditHookOption {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  AuthorizationHeader: ").Append(AuthorizationHeader).Append("\n");
            sb.Append("  BranchFilter: ").Append(BranchFilter).Append("\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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
