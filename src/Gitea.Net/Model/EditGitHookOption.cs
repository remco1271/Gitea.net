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
    /// EditGitHookOption options when modifying one Git hook
    /// </summary>
    [DataContract(Name = "EditGitHookOption")]
    public partial class EditGitHookOption : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditGitHookOption" /> class.
        /// </summary>
        /// <param name="content">content.</param>
        public EditGitHookOption(string content = default(string))
        {
            this.Content = content;
        }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EditGitHookOption {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
