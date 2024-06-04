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
    /// CreateWikiPageOptions form for creating wiki
    /// </summary>
    [DataContract(Name = "CreateWikiPageOptions")]
    public partial class CreateWikiPageOptions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWikiPageOptions" /> class.
        /// </summary>
        /// <param name="contentBase64">content must be base64 encoded.</param>
        /// <param name="message">optional commit message summarizing the change.</param>
        /// <param name="title">page title. leave empty to keep unchanged.</param>
        public CreateWikiPageOptions(string contentBase64 = default(string), string message = default(string), string title = default(string))
        {
            this.ContentBase64 = contentBase64;
            this.Message = message;
            this.Title = title;
        }

        /// <summary>
        /// content must be base64 encoded
        /// </summary>
        /// <value>content must be base64 encoded</value>
        [DataMember(Name = "content_base64", EmitDefaultValue = false)]
        public string ContentBase64 { get; set; }

        /// <summary>
        /// optional commit message summarizing the change
        /// </summary>
        /// <value>optional commit message summarizing the change</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// page title. leave empty to keep unchanged
        /// </summary>
        /// <value>page title. leave empty to keep unchanged</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateWikiPageOptions {\n");
            sb.Append("  ContentBase64: ").Append(ContentBase64).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
