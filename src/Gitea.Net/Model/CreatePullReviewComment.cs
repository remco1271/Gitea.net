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
    /// CreatePullReviewComment represent a review comment for creation api
    /// </summary>
    [DataContract(Name = "CreatePullReviewComment")]
    public partial class CreatePullReviewComment : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreatePullReviewComment" /> class.
        /// </summary>
        /// <param name="body">body.</param>
        /// <param name="newPosition">if comment to new file line or 0.</param>
        /// <param name="oldPosition">if comment to old file line or 0.</param>
        /// <param name="path">the tree path.</param>
        public CreatePullReviewComment(string body = default(string), long newPosition = default(long), long oldPosition = default(long), string path = default(string))
        {
            this.Body = body;
            this.NewPosition = newPosition;
            this.OldPosition = oldPosition;
            this.Path = path;
        }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// if comment to new file line or 0
        /// </summary>
        /// <value>if comment to new file line or 0</value>
        [DataMember(Name = "new_position", EmitDefaultValue = false)]
        public long NewPosition { get; set; }

        /// <summary>
        /// if comment to old file line or 0
        /// </summary>
        /// <value>if comment to old file line or 0</value>
        [DataMember(Name = "old_position", EmitDefaultValue = false)]
        public long OldPosition { get; set; }

        /// <summary>
        /// the tree path
        /// </summary>
        /// <value>the tree path</value>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public string Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreatePullReviewComment {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  NewPosition: ").Append(NewPosition).Append("\n");
            sb.Append("  OldPosition: ").Append(OldPosition).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
