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
    /// RepoCreateReleaseAttachmentRequest
    /// </summary>
    [DataContract(Name = "repoCreateReleaseAttachment_request")]
    public partial class RepoCreateReleaseAttachmentRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RepoCreateReleaseAttachmentRequest" /> class.
        /// </summary>
        /// <param name="attachment">attachment to upload.</param>
        public RepoCreateReleaseAttachmentRequest(System.IO.Stream attachment = default(System.IO.Stream))
        {
            this.Attachment = attachment;
        }

        /// <summary>
        /// attachment to upload
        /// </summary>
        /// <value>attachment to upload</value>
        [DataMember(Name = "attachment", EmitDefaultValue = false)]
        public System.IO.Stream Attachment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RepoCreateReleaseAttachmentRequest {\n");
            sb.Append("  Attachment: ").Append(Attachment).Append("\n");
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
