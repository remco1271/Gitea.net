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
    /// InternalTracker represents settings for internal tracker
    /// </summary>
    [DataContract(Name = "InternalTracker")]
    public partial class InternalTracker : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternalTracker" /> class.
        /// </summary>
        /// <param name="allowOnlyContributorsToTrackTime">Let only contributors track time (Built-in issue tracker).</param>
        /// <param name="enableIssueDependencies">Enable dependencies for issues and pull requests (Built-in issue tracker).</param>
        /// <param name="enableTimeTracker">Enable time tracking (Built-in issue tracker).</param>
        public InternalTracker(bool allowOnlyContributorsToTrackTime = default(bool), bool enableIssueDependencies = default(bool), bool enableTimeTracker = default(bool))
        {
            this.AllowOnlyContributorsToTrackTime = allowOnlyContributorsToTrackTime;
            this.EnableIssueDependencies = enableIssueDependencies;
            this.EnableTimeTracker = enableTimeTracker;
        }

        /// <summary>
        /// Let only contributors track time (Built-in issue tracker)
        /// </summary>
        /// <value>Let only contributors track time (Built-in issue tracker)</value>
        [DataMember(Name = "allow_only_contributors_to_track_time", EmitDefaultValue = true)]
        public bool AllowOnlyContributorsToTrackTime { get; set; }

        /// <summary>
        /// Enable dependencies for issues and pull requests (Built-in issue tracker)
        /// </summary>
        /// <value>Enable dependencies for issues and pull requests (Built-in issue tracker)</value>
        [DataMember(Name = "enable_issue_dependencies", EmitDefaultValue = true)]
        public bool EnableIssueDependencies { get; set; }

        /// <summary>
        /// Enable time tracking (Built-in issue tracker)
        /// </summary>
        /// <value>Enable time tracking (Built-in issue tracker)</value>
        [DataMember(Name = "enable_time_tracker", EmitDefaultValue = true)]
        public bool EnableTimeTracker { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InternalTracker {\n");
            sb.Append("  AllowOnlyContributorsToTrackTime: ").Append(AllowOnlyContributorsToTrackTime).Append("\n");
            sb.Append("  EnableIssueDependencies: ").Append(EnableIssueDependencies).Append("\n");
            sb.Append("  EnableTimeTracker: ").Append(EnableTimeTracker).Append("\n");
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
