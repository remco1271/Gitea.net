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
    /// PayloadCommitVerification represents the GPG verification of a commit
    /// </summary>
    [DataContract(Name = "PayloadCommitVerification")]
    public partial class PayloadCommitVerification : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayloadCommitVerification" /> class.
        /// </summary>
        /// <param name="payload">payload.</param>
        /// <param name="reason">reason.</param>
        /// <param name="signature">signature.</param>
        /// <param name="signer">signer.</param>
        /// <param name="verified">verified.</param>
        public PayloadCommitVerification(string payload = default(string), string reason = default(string), string signature = default(string), PayloadUser signer = default(PayloadUser), bool verified = default(bool))
        {
            this.Payload = payload;
            this.Reason = reason;
            this.Signature = signature;
            this.Signer = signer;
            this.Verified = verified;
        }

        /// <summary>
        /// Gets or Sets Payload
        /// </summary>
        [DataMember(Name = "payload", EmitDefaultValue = false)]
        public string Payload { get; set; }

        /// <summary>
        /// Gets or Sets Reason
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", EmitDefaultValue = false)]
        public string Signature { get; set; }

        /// <summary>
        /// Gets or Sets Signer
        /// </summary>
        [DataMember(Name = "signer", EmitDefaultValue = false)]
        public PayloadUser Signer { get; set; }

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
            sb.Append("class PayloadCommitVerification {\n");
            sb.Append("  Payload: ").Append(Payload).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
            sb.Append("  Signer: ").Append(Signer).Append("\n");
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