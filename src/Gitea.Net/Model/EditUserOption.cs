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
    /// EditUserOption edit user options
    /// </summary>
    [DataContract(Name = "EditUserOption")]
    public partial class EditUserOption : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditUserOption" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EditUserOption() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EditUserOption" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="admin">admin.</param>
        /// <param name="allowCreateOrganization">allowCreateOrganization.</param>
        /// <param name="allowGitHook">allowGitHook.</param>
        /// <param name="allowImportLocal">allowImportLocal.</param>
        /// <param name="description">description.</param>
        /// <param name="email">email.</param>
        /// <param name="fullName">fullName.</param>
        /// <param name="location">location.</param>
        /// <param name="loginName">loginName (required).</param>
        /// <param name="maxRepoCreation">maxRepoCreation.</param>
        /// <param name="mustChangePassword">mustChangePassword.</param>
        /// <param name="password">password.</param>
        /// <param name="prohibitLogin">prohibitLogin.</param>
        /// <param name="restricted">restricted.</param>
        /// <param name="sourceId">sourceId (required).</param>
        /// <param name="visibility">visibility.</param>
        /// <param name="website">website.</param>
        public EditUserOption(bool active = default(bool), bool admin = default(bool), bool allowCreateOrganization = default(bool), bool allowGitHook = default(bool), bool allowImportLocal = default(bool), string description = default(string), string email = default(string), string fullName = default(string), string location = default(string), string loginName = default(string), long maxRepoCreation = default(long), bool mustChangePassword = default(bool), string password = default(string), bool prohibitLogin = default(bool), bool restricted = default(bool), long sourceId = default(long), string visibility = default(string), string website = default(string))
        {
            // to ensure "loginName" is required (not null)
            if (loginName == null)
            {
                throw new ArgumentNullException("loginName is a required property for EditUserOption and cannot be null");
            }
            this.LoginName = loginName;
            this.SourceId = sourceId;
            this.Active = active;
            this.Admin = admin;
            this.AllowCreateOrganization = allowCreateOrganization;
            this.AllowGitHook = allowGitHook;
            this.AllowImportLocal = allowImportLocal;
            this.Description = description;
            this.Email = email;
            this.FullName = fullName;
            this.Location = location;
            this.MaxRepoCreation = maxRepoCreation;
            this.MustChangePassword = mustChangePassword;
            this.Password = password;
            this.ProhibitLogin = prohibitLogin;
            this.Restricted = restricted;
            this.Visibility = visibility;
            this.Website = website;
        }

        /// <summary>
        /// Gets or Sets Active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or Sets Admin
        /// </summary>
        [DataMember(Name = "admin", EmitDefaultValue = true)]
        public bool Admin { get; set; }

        /// <summary>
        /// Gets or Sets AllowCreateOrganization
        /// </summary>
        [DataMember(Name = "allow_create_organization", EmitDefaultValue = true)]
        public bool AllowCreateOrganization { get; set; }

        /// <summary>
        /// Gets or Sets AllowGitHook
        /// </summary>
        [DataMember(Name = "allow_git_hook", EmitDefaultValue = true)]
        public bool AllowGitHook { get; set; }

        /// <summary>
        /// Gets or Sets AllowImportLocal
        /// </summary>
        [DataMember(Name = "allow_import_local", EmitDefaultValue = true)]
        public bool AllowImportLocal { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets FullName
        /// </summary>
        [DataMember(Name = "full_name", EmitDefaultValue = false)]
        public string FullName { get; set; }

        /// <summary>
        /// Gets or Sets Location
        /// </summary>
        [DataMember(Name = "location", EmitDefaultValue = false)]
        public string Location { get; set; }

        /// <summary>
        /// Gets or Sets LoginName
        /// </summary>
        [DataMember(Name = "login_name", IsRequired = true, EmitDefaultValue = true)]
        public string LoginName { get; set; }

        /// <summary>
        /// Gets or Sets MaxRepoCreation
        /// </summary>
        [DataMember(Name = "max_repo_creation", EmitDefaultValue = false)]
        public long MaxRepoCreation { get; set; }

        /// <summary>
        /// Gets or Sets MustChangePassword
        /// </summary>
        [DataMember(Name = "must_change_password", EmitDefaultValue = true)]
        public bool MustChangePassword { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets ProhibitLogin
        /// </summary>
        [DataMember(Name = "prohibit_login", EmitDefaultValue = true)]
        public bool ProhibitLogin { get; set; }

        /// <summary>
        /// Gets or Sets Restricted
        /// </summary>
        [DataMember(Name = "restricted", EmitDefaultValue = true)]
        public bool Restricted { get; set; }

        /// <summary>
        /// Gets or Sets SourceId
        /// </summary>
        [DataMember(Name = "source_id", IsRequired = true, EmitDefaultValue = true)]
        public long SourceId { get; set; }

        /// <summary>
        /// Gets or Sets Visibility
        /// </summary>
        [DataMember(Name = "visibility", EmitDefaultValue = false)]
        public string Visibility { get; set; }

        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name = "website", EmitDefaultValue = false)]
        public string Website { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EditUserOption {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  Admin: ").Append(Admin).Append("\n");
            sb.Append("  AllowCreateOrganization: ").Append(AllowCreateOrganization).Append("\n");
            sb.Append("  AllowGitHook: ").Append(AllowGitHook).Append("\n");
            sb.Append("  AllowImportLocal: ").Append(AllowImportLocal).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  LoginName: ").Append(LoginName).Append("\n");
            sb.Append("  MaxRepoCreation: ").Append(MaxRepoCreation).Append("\n");
            sb.Append("  MustChangePassword: ").Append(MustChangePassword).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ProhibitLogin: ").Append(ProhibitLogin).Append("\n");
            sb.Append("  Restricted: ").Append(Restricted).Append("\n");
            sb.Append("  SourceId: ").Append(SourceId).Append("\n");
            sb.Append("  Visibility: ").Append(Visibility).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
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
