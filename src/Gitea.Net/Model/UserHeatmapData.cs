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
    /// UserHeatmapData represents the data needed to create a heatmap
    /// </summary>
    [DataContract(Name = "UserHeatmapData")]
    public partial class UserHeatmapData : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserHeatmapData" /> class.
        /// </summary>
        /// <param name="contributions">contributions.</param>
        /// <param name="timestamp">TimeStamp defines a timestamp.</param>
        public UserHeatmapData(long contributions = default(long), long timestamp = default(long))
        {
            this.Contributions = contributions;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Gets or Sets Contributions
        /// </summary>
        [DataMember(Name = "contributions", EmitDefaultValue = false)]
        public long Contributions { get; set; }

        /// <summary>
        /// TimeStamp defines a timestamp
        /// </summary>
        /// <value>TimeStamp defines a timestamp</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public long Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserHeatmapData {\n");
            sb.Append("  Contributions: ").Append(Contributions).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
