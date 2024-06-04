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
    /// Permission represents a set of permissions
    /// </summary>
    [DataContract(Name = "Permission")]
    public partial class Permission : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        /// <param name="admin">admin.</param>
        /// <param name="pull">pull.</param>
        /// <param name="push">push.</param>
        public Permission(bool admin = default(bool), bool pull = default(bool), bool push = default(bool))
        {
            this.Admin = admin;
            this.Pull = pull;
            this.Push = push;
        }

        /// <summary>
        /// Gets or Sets Admin
        /// </summary>
        [DataMember(Name = "admin", EmitDefaultValue = true)]
        public bool Admin { get; set; }

        /// <summary>
        /// Gets or Sets Pull
        /// </summary>
        [DataMember(Name = "pull", EmitDefaultValue = true)]
        public bool Pull { get; set; }

        /// <summary>
        /// Gets or Sets Push
        /// </summary>
        [DataMember(Name = "push", EmitDefaultValue = true)]
        public bool Push { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Permission {\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  Pull: ").Append(Pull).Append("\n");
            sb.Append("  Push: ").Append(Push).Append("\n");
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
