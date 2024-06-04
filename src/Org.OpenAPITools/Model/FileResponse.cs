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
    /// FileResponse contains information about a repo&#39;s file
    /// </summary>
    [DataContract(Name = "FileResponse")]
    public partial class FileResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileResponse" /> class.
        /// </summary>
        /// <param name="commit">commit.</param>
        /// <param name="content">content.</param>
        /// <param name="verification">verification.</param>
        public FileResponse(FileCommitResponse commit = default(FileCommitResponse), ContentsResponse content = default(ContentsResponse), PayloadCommitVerification verification = default(PayloadCommitVerification))
        {
            this.Commit = commit;
            this.Content = content;
            this.Verification = verification;
        }

        /// <summary>
        /// Gets or Sets Commit
        /// </summary>
        [DataMember(Name = "commit", EmitDefaultValue = false)]
        public FileCommitResponse Commit { get; set; }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public ContentsResponse Content { get; set; }

        /// <summary>
        /// Gets or Sets Verification
        /// </summary>
        [DataMember(Name = "verification", EmitDefaultValue = false)]
        public PayloadCommitVerification Verification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileResponse {\n");
            sb.Append("  Commit: ").Append(Commit).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Verification: ").Append(Verification).Append("\n");
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
