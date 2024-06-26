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
    /// NodeInfoUsageUsers contains statistics about the users of this server
    /// </summary>
    [DataContract(Name = "NodeInfoUsageUsers")]
    public partial class NodeInfoUsageUsers : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NodeInfoUsageUsers" /> class.
        /// </summary>
        /// <param name="activeHalfyear">activeHalfyear.</param>
        /// <param name="activeMonth">activeMonth.</param>
        /// <param name="total">total.</param>
        public NodeInfoUsageUsers(long activeHalfyear = default(long), long activeMonth = default(long), long total = default(long))
        {
            this.ActiveHalfyear = activeHalfyear;
            this.ActiveMonth = activeMonth;
            this.Total = total;
        }

        /// <summary>
        /// Gets or Sets ActiveHalfyear
        /// </summary>
        [DataMember(Name = "activeHalfyear", EmitDefaultValue = false)]
        public long ActiveHalfyear { get; set; }

        /// <summary>
        /// Gets or Sets ActiveMonth
        /// </summary>
        [DataMember(Name = "activeMonth", EmitDefaultValue = false)]
        public long ActiveMonth { get; set; }

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
            sb.Append("class NodeInfoUsageUsers {\n");
            sb.Append("  ActiveHalfyear: ").Append(ActiveHalfyear).Append("\n");
            sb.Append("  ActiveMonth: ").Append(ActiveMonth).Append("\n");
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
