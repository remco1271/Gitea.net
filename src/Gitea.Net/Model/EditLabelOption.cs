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
    /// EditLabelOption options for editing a label
    /// </summary>
    [DataContract(Name = "EditLabelOption")]
    public partial class EditLabelOption : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditLabelOption" /> class.
        /// </summary>
        /// <param name="color">color.</param>
        /// <param name="description">description.</param>
        /// <param name="exclusive">exclusive.</param>
        /// <param name="isArchived">isArchived.</param>
        /// <param name="name">name.</param>
        public EditLabelOption(string color = default(string), string description = default(string), bool exclusive = default(bool), bool isArchived = default(bool), string name = default(string))
        {
            this.Color = color;
            this.Description = description;
            this.Exclusive = exclusive;
            this.IsArchived = isArchived;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Color
        /// </summary>
        /// <example>#00aabb</example>
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EditLabelOption {\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Exclusive: ").Append(Exclusive).Append("\n");
            sb.Append("  IsArchived: ").Append(IsArchived).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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