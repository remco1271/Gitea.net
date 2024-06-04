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
    /// RenameUserOption options when renaming a user
    /// </summary>
    [DataContract(Name = "RenameUserOption")]
    public partial class RenameUserOption : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RenameUserOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RenameUserOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RenameUserOption" /> class.
        /// </summary>
        /// <param name="newUsername">New username for this user. This name cannot be in use yet by any other user. (required).</param>
        public RenameUserOption(string newUsername = default(string))
        {
            // to ensure "newUsername" is required (not null)
            if (newUsername == null)
            {
                throw new ArgumentNullException("newUsername is a required property for RenameUserOption and cannot be null");
            }
            this.NewUsername = newUsername;
        }

        /// <summary>
        /// New username for this user. This name cannot be in use yet by any other user.
        /// </summary>
        /// <value>New username for this user. This name cannot be in use yet by any other user.</value>
        [DataMember(Name = "new_username", IsRequired = true, EmitDefaultValue = true)]
        public string NewUsername { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RenameUserOption {\n");
            sb.Append("  NewUsername: ").Append(NewUsername).Append("\n");
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