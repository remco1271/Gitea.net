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
    /// GeneralAPISettings contains global api settings exposed by it
    /// </summary>
    [DataContract(Name = "GeneralAPISettings")]
    public partial class GeneralAPISettings : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneralAPISettings" /> class.
        /// </summary>
        /// <param name="defaultGitTreesPerPage">defaultGitTreesPerPage.</param>
        /// <param name="defaultMaxBlobSize">defaultMaxBlobSize.</param>
        /// <param name="defaultPagingNum">defaultPagingNum.</param>
        /// <param name="maxResponseItems">maxResponseItems.</param>
        public GeneralAPISettings(long defaultGitTreesPerPage = default(long), long defaultMaxBlobSize = default(long), long defaultPagingNum = default(long), long maxResponseItems = default(long))
        {
            this.DefaultGitTreesPerPage = defaultGitTreesPerPage;
            this.DefaultMaxBlobSize = defaultMaxBlobSize;
            this.DefaultPagingNum = defaultPagingNum;
            this.MaxResponseItems = maxResponseItems;
        }

        /// <summary>
        /// Gets or Sets DefaultGitTreesPerPage
        /// </summary>
        [DataMember(Name = "default_git_trees_per_page", EmitDefaultValue = false)]
        public long DefaultGitTreesPerPage { get; set; }

        /// <summary>
        /// Gets or Sets DefaultMaxBlobSize
        /// </summary>
        [DataMember(Name = "default_max_blob_size", EmitDefaultValue = false)]
        public long DefaultMaxBlobSize { get; set; }

        /// <summary>
        /// Gets or Sets DefaultPagingNum
        /// </summary>
        [DataMember(Name = "default_paging_num", EmitDefaultValue = false)]
        public long DefaultPagingNum { get; set; }

        /// <summary>
        /// Gets or Sets MaxResponseItems
        /// </summary>
        [DataMember(Name = "max_response_items", EmitDefaultValue = false)]
        public long MaxResponseItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GeneralAPISettings {\n");
            sb.Append("  DefaultGitTreesPerPage: ").Append(DefaultGitTreesPerPage).Append("\n");
            sb.Append("  DefaultMaxBlobSize: ").Append(DefaultMaxBlobSize).Append("\n");
            sb.Append("  DefaultPagingNum: ").Append(DefaultPagingNum).Append("\n");
            sb.Append("  MaxResponseItems: ").Append(MaxResponseItems).Append("\n");
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