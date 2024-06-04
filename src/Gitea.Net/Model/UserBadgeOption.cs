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
    /// UserBadgeOption options for link between users and badges
    /// </summary>
    [DataContract(Name = "UserBadgeOption")]
    public partial class UserBadgeOption : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserBadgeOption" /> class.
        /// </summary>
        /// <param name="badgeSlugs">badgeSlugs.</param>
        public UserBadgeOption(List<string> badgeSlugs = default(List<string>))
        {
            this.BadgeSlugs = badgeSlugs;
        }

        /// <summary>
        /// Gets or Sets BadgeSlugs
        /// </summary>
        /// <example>[badge1, badge2]</example>
        [DataMember(Name = "badge_slugs", EmitDefaultValue = false)]
        public List<string> BadgeSlugs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserBadgeOption {\n");
            sb.Append("  BadgeSlugs: ").Append(BadgeSlugs).Append("\n");
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