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
    /// CreateOrUpdateSecretOption options when creating or updating secret
    /// </summary>
    [DataContract(Name = "CreateOrUpdateSecretOption")]
    public partial class CreateOrUpdateSecretOption : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateSecretOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOrUpdateSecretOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrUpdateSecretOption" /> class.
        /// </summary>
        /// <param name="data">Data of the secret to update (required).</param>
        public CreateOrUpdateSecretOption(string data = default(string))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for CreateOrUpdateSecretOption and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// Data of the secret to update
        /// </summary>
        /// <value>Data of the secret to update</value>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public string Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateOrUpdateSecretOption {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
