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
    /// RepoTransfer represents a pending repo transfer
    /// </summary>
    [DataContract(Name = "RepoTransfer")]
    public partial class RepoTransfer : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepoTransfer" /> class.
        /// </summary>
        /// <param name="doer">doer.</param>
        /// <param name="recipient">recipient.</param>
        /// <param name="teams">teams.</param>
        public RepoTransfer(User doer = default(User), User recipient = default(User), List<Team> teams = default(List<Team>))
        {
            this.Doer = doer;
            this.Recipient = recipient;
            this.Teams = teams;
        }

        /// <summary>
        /// Gets or Sets Doer
        /// </summary>
        [DataMember(Name = "doer", EmitDefaultValue = false)]
        public User Doer { get; set; }

        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name = "recipient", EmitDefaultValue = false)]
        public User Recipient { get; set; }

        /// <summary>
        /// Gets or Sets Teams
        /// </summary>
        [DataMember(Name = "teams", EmitDefaultValue = false)]
        public List<Team> Teams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RepoTransfer {\n");
            sb.Append("  Doer: ").Append(Doer).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Teams: ").Append(Teams).Append("\n");
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
