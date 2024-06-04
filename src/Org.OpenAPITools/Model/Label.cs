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
    /// Label a label to an issue or a pr
    /// </summary>
    [DataContract(Name = "Label")]
    public partial class Label : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Label" /> class.
        /// </summary>
        /// <param name="color">color.</param>
        /// <param name="description">description.</param>
        /// <param name="exclusive">exclusive.</param>
        /// <param name="id">id.</param>
        /// <param name="isArchived">isArchived.</param>
        /// <param name="name">name.</param>
        /// <param name="url">url.</param>
        public Label(string color = default(string), string description = default(string), bool exclusive = default(bool), long id = default(long), bool isArchived = default(bool), string name = default(string), string url = default(string))
        {
            this.Color = color;
            this.Description = description;
            this.Exclusive = exclusive;
            this.Id = id;
            this.IsArchived = isArchived;
            this.Name = name;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        /// <example>00aabb</example>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Exclusive
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "exclusive", EmitDefaultValue = true)]
        public bool Exclusive { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets IsArchived
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "is_archived", EmitDefaultValue = true)]
        public bool IsArchived { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Label {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Exclusive: ").Append(Exclusive).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsArchived: ").Append(IsArchived).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
