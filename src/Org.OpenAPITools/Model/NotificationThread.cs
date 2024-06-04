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
    /// NotificationThread expose Notification on API
    /// </summary>
    [DataContract(Name = "NotificationThread")]
    public partial class NotificationThread : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationThread" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="pinned">pinned.</param>
        /// <param name="repository">repository.</param>
        /// <param name="subject">subject.</param>
        /// <param name="unread">unread.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="url">url.</param>
        public NotificationThread(long id = default(long), bool pinned = default(bool), Repository repository = default(Repository), NotificationSubject subject = default(NotificationSubject), bool unread = default(bool), DateTime updatedAt = default(DateTime), string url = default(string))
        {
            this.Id = id;
            this.Pinned = pinned;
            this.Repository = repository;
            this.Subject = subject;
            this.Unread = unread;
            this.UpdatedAt = updatedAt;
            this.Url = url;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets Pinned
        /// </summary>
        [DataMember(Name = "pinned", EmitDefaultValue = true)]
        public bool Pinned { get; set; }

        /// <summary>
        /// Gets or Sets Repository
        /// </summary>
        [DataMember(Name = "repository", EmitDefaultValue = false)]
        public Repository Repository { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public NotificationSubject Subject { get; set; }

        /// <summary>
        /// Gets or Sets Unread
        /// </summary>
        [DataMember(Name = "unread", EmitDefaultValue = true)]
        public bool Unread { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

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
            sb.Append("class NotificationThread {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
            sb.Append("  Repository: ").Append(Repository).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Unread: ").Append(Unread).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
