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
    /// GPGKey a user GPG key to sign commit and tag in repository
    /// </summary>
    [DataContract(Name = "GPGKey")]
    public partial class GPGKey : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GPGKey" /> class.
        /// </summary>
        /// <param name="canCertify">canCertify.</param>
        /// <param name="canEncryptComms">canEncryptComms.</param>
        /// <param name="canEncryptStorage">canEncryptStorage.</param>
        /// <param name="canSign">canSign.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="emails">emails.</param>
        /// <param name="expiresAt">expiresAt.</param>
        /// <param name="id">id.</param>
        /// <param name="keyId">keyId.</param>
        /// <param name="primaryKeyId">primaryKeyId.</param>
        /// <param name="publicKey">publicKey.</param>
        /// <param name="subkeys">subkeys.</param>
        /// <param name="verified">verified.</param>
        public GPGKey(bool canCertify = default(bool), bool canEncryptComms = default(bool), bool canEncryptStorage = default(bool), bool canSign = default(bool), DateTime createdAt = default(DateTime), List<GPGKeyEmail> emails = default(List<GPGKeyEmail>), DateTime expiresAt = default(DateTime), long id = default(long), string keyId = default(string), string primaryKeyId = default(string), string publicKey = default(string), List<GPGKey> subkeys = default(List<GPGKey>), bool verified = default(bool))
        {
            this.CanCertify = canCertify;
            this.CanEncryptComms = canEncryptComms;
            this.CanEncryptStorage = canEncryptStorage;
            this.CanSign = canSign;
            this.CreatedAt = createdAt;
            this.Emails = emails;
            this.ExpiresAt = expiresAt;
            this.Id = id;
            this.KeyId = keyId;
            this.PrimaryKeyId = primaryKeyId;
            this.PublicKey = publicKey;
            this.Subkeys = subkeys;
            this.Verified = verified;
        }

        /// <summary>
        /// Gets or Sets CanCertify
        /// </summary>
        [DataMember(Name = "can_certify", EmitDefaultValue = true)]
        public bool CanCertify { get; set; }

        /// <summary>
        /// Gets or Sets CanEncryptComms
        /// </summary>
        [DataMember(Name = "can_encrypt_comms", EmitDefaultValue = true)]
        public bool CanEncryptComms { get; set; }

        /// <summary>
        /// Gets or Sets CanEncryptStorage
        /// </summary>
        [DataMember(Name = "can_encrypt_storage", EmitDefaultValue = true)]
        public bool CanEncryptStorage { get; set; }

        /// <summary>
        /// Gets or Sets CanSign
        /// </summary>
        [DataMember(Name = "can_sign", EmitDefaultValue = true)]
        public bool CanSign { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Emails
        /// </summary>
        [DataMember(Name = "emails", EmitDefaultValue = false)]
        public List<GPGKeyEmail> Emails { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresAt
        /// </summary>
        [DataMember(Name = "expires_at", EmitDefaultValue = false)]
        public DateTime ExpiresAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// Gets or Sets KeyId
        /// </summary>
        [DataMember(Name = "key_id", EmitDefaultValue = false)]
        public string KeyId { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryKeyId
        /// </summary>
        [DataMember(Name = "primary_key_id", EmitDefaultValue = false)]
        public string PrimaryKeyId { get; set; }

        /// <summary>
        /// Gets or Sets PublicKey
        /// </summary>
        [DataMember(Name = "public_key", EmitDefaultValue = false)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Gets or Sets Subkeys
        /// </summary>
        [DataMember(Name = "subkeys", EmitDefaultValue = false)]
        public List<GPGKey> Subkeys { get; set; }

        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name = "verified", EmitDefaultValue = true)]
        public bool Verified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GPGKey {\n");
            sb.Append("  CanCertify: ").Append(CanCertify).Append("\n");
            sb.Append("  CanEncryptComms: ").Append(CanEncryptComms).Append("\n");
            sb.Append("  CanEncryptStorage: ").Append(CanEncryptStorage).Append("\n");
            sb.Append("  CanSign: ").Append(CanSign).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Emails: ").Append(Emails).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  KeyId: ").Append(KeyId).Append("\n");
            sb.Append("  PrimaryKeyId: ").Append(PrimaryKeyId).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  Subkeys: ").Append(Subkeys).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
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
