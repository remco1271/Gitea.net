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
    /// GeneralRepoSettings contains global repository settings exposed by API
    /// </summary>
    [DataContract(Name = "GeneralRepoSettings")]
    public partial class GeneralRepoSettings : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralRepoSettings" /> class.
        /// </summary>
        /// <param name="httpGitDisabled">httpGitDisabled.</param>
        /// <param name="lfsDisabled">lfsDisabled.</param>
        /// <param name="migrationsDisabled">migrationsDisabled.</param>
        /// <param name="mirrorsDisabled">mirrorsDisabled.</param>
        /// <param name="starsDisabled">starsDisabled.</param>
        /// <param name="timeTrackingDisabled">timeTrackingDisabled.</param>
        public GeneralRepoSettings(bool httpGitDisabled = default(bool), bool lfsDisabled = default(bool), bool migrationsDisabled = default(bool), bool mirrorsDisabled = default(bool), bool starsDisabled = default(bool), bool timeTrackingDisabled = default(bool))
        {
            this.HttpGitDisabled = httpGitDisabled;
            this.LfsDisabled = lfsDisabled;
            this.MigrationsDisabled = migrationsDisabled;
            this.MirrorsDisabled = mirrorsDisabled;
            this.StarsDisabled = starsDisabled;
            this.TimeTrackingDisabled = timeTrackingDisabled;
        }

        /// <summary>
        /// Gets or Sets HttpGitDisabled
        /// </summary>
        [DataMember(Name = "http_git_disabled", EmitDefaultValue = true)]
        public bool HttpGitDisabled { get; set; }

        /// <summary>
        /// Gets or Sets LfsDisabled
        /// </summary>
        [DataMember(Name = "lfs_disabled", EmitDefaultValue = true)]
        public bool LfsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets MigrationsDisabled
        /// </summary>
        [DataMember(Name = "migrations_disabled", EmitDefaultValue = true)]
        public bool MigrationsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets MirrorsDisabled
        /// </summary>
        [DataMember(Name = "mirrors_disabled", EmitDefaultValue = true)]
        public bool MirrorsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets StarsDisabled
        /// </summary>
        [DataMember(Name = "stars_disabled", EmitDefaultValue = true)]
        public bool StarsDisabled { get; set; }

        /// <summary>
        /// Gets or Sets TimeTrackingDisabled
        /// </summary>
        [DataMember(Name = "time_tracking_disabled", EmitDefaultValue = true)]
        public bool TimeTrackingDisabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GeneralRepoSettings {\n");
            sb.Append("  HttpGitDisabled: ").Append(HttpGitDisabled).Append("\n");
            sb.Append("  LfsDisabled: ").Append(LfsDisabled).Append("\n");
            sb.Append("  MigrationsDisabled: ").Append(MigrationsDisabled).Append("\n");
            sb.Append("  MirrorsDisabled: ").Append(MirrorsDisabled).Append("\n");
            sb.Append("  StarsDisabled: ").Append(StarsDisabled).Append("\n");
            sb.Append("  TimeTrackingDisabled: ").Append(TimeTrackingDisabled).Append("\n");
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
