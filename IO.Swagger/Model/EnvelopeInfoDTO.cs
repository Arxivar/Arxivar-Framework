/* 
 * Abletech.Arxivar.Server.WebApi.Services
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// EnvelopeInfoDTO
    /// </summary>
    [DataContract]
    public partial class EnvelopeInfoDTO :  IEquatable<EnvelopeInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EnvelopeInfoDTO" /> class.
        /// </summary>
        /// <param name="SignatureInfoList">SignatureInfoList.</param>
        /// <param name="TimestampInfo">TimestampInfo.</param>
        /// <param name="NestedDepth">NestedDepth.</param>
        /// <param name="EnvelopeSha256Hash">EnvelopeSha256Hash.</param>
        /// <param name="ContentSha256Hash">ContentSha256Hash.</param>
        /// <param name="MimeType">MimeType.</param>
        /// <param name="ValidationMessageList">ValidationMessageList.</param>
        public EnvelopeInfoDTO(List<SignatureInfoDTO> SignatureInfoList = default(List<SignatureInfoDTO>), TimestampInfoDTO TimestampInfo = default(TimestampInfoDTO), int? NestedDepth = default(int?), string EnvelopeSha256Hash = default(string), string ContentSha256Hash = default(string), string MimeType = default(string), List<ValidationMessageDTO> ValidationMessageList = default(List<ValidationMessageDTO>))
        {
            this.SignatureInfoList = SignatureInfoList;
            this.TimestampInfo = TimestampInfo;
            this.NestedDepth = NestedDepth;
            this.EnvelopeSha256Hash = EnvelopeSha256Hash;
            this.ContentSha256Hash = ContentSha256Hash;
            this.MimeType = MimeType;
            this.ValidationMessageList = ValidationMessageList;
        }
        
        /// <summary>
        /// Gets or Sets SignatureInfoList
        /// </summary>
        [DataMember(Name="signatureInfoList", EmitDefaultValue=false)]
        public List<SignatureInfoDTO> SignatureInfoList { get; set; }

        /// <summary>
        /// Gets or Sets TimestampInfo
        /// </summary>
        [DataMember(Name="timestampInfo", EmitDefaultValue=false)]
        public TimestampInfoDTO TimestampInfo { get; set; }

        /// <summary>
        /// Gets or Sets NestedDepth
        /// </summary>
        [DataMember(Name="nestedDepth", EmitDefaultValue=false)]
        public int? NestedDepth { get; set; }

        /// <summary>
        /// Gets or Sets EnvelopeSha256Hash
        /// </summary>
        [DataMember(Name="envelopeSha256Hash", EmitDefaultValue=false)]
        public string EnvelopeSha256Hash { get; set; }

        /// <summary>
        /// Gets or Sets ContentSha256Hash
        /// </summary>
        [DataMember(Name="contentSha256Hash", EmitDefaultValue=false)]
        public string ContentSha256Hash { get; set; }

        /// <summary>
        /// Gets or Sets MimeType
        /// </summary>
        [DataMember(Name="mimeType", EmitDefaultValue=false)]
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or Sets ValidationMessageList
        /// </summary>
        [DataMember(Name="validationMessageList", EmitDefaultValue=false)]
        public List<ValidationMessageDTO> ValidationMessageList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnvelopeInfoDTO {\n");
            sb.Append("  SignatureInfoList: ").Append(SignatureInfoList).Append("\n");
            sb.Append("  TimestampInfo: ").Append(TimestampInfo).Append("\n");
            sb.Append("  NestedDepth: ").Append(NestedDepth).Append("\n");
            sb.Append("  EnvelopeSha256Hash: ").Append(EnvelopeSha256Hash).Append("\n");
            sb.Append("  ContentSha256Hash: ").Append(ContentSha256Hash).Append("\n");
            sb.Append("  MimeType: ").Append(MimeType).Append("\n");
            sb.Append("  ValidationMessageList: ").Append(ValidationMessageList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnvelopeInfoDTO);
        }

        /// <summary>
        /// Returns true if EnvelopeInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EnvelopeInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EnvelopeInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SignatureInfoList == input.SignatureInfoList ||
                    this.SignatureInfoList != null &&
                    this.SignatureInfoList.SequenceEqual(input.SignatureInfoList)
                ) && 
                (
                    this.TimestampInfo == input.TimestampInfo ||
                    (this.TimestampInfo != null &&
                    this.TimestampInfo.Equals(input.TimestampInfo))
                ) && 
                (
                    this.NestedDepth == input.NestedDepth ||
                    (this.NestedDepth != null &&
                    this.NestedDepth.Equals(input.NestedDepth))
                ) && 
                (
                    this.EnvelopeSha256Hash == input.EnvelopeSha256Hash ||
                    (this.EnvelopeSha256Hash != null &&
                    this.EnvelopeSha256Hash.Equals(input.EnvelopeSha256Hash))
                ) && 
                (
                    this.ContentSha256Hash == input.ContentSha256Hash ||
                    (this.ContentSha256Hash != null &&
                    this.ContentSha256Hash.Equals(input.ContentSha256Hash))
                ) && 
                (
                    this.MimeType == input.MimeType ||
                    (this.MimeType != null &&
                    this.MimeType.Equals(input.MimeType))
                ) && 
                (
                    this.ValidationMessageList == input.ValidationMessageList ||
                    this.ValidationMessageList != null &&
                    this.ValidationMessageList.SequenceEqual(input.ValidationMessageList)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.SignatureInfoList != null)
                    hashCode = hashCode * 59 + this.SignatureInfoList.GetHashCode();
                if (this.TimestampInfo != null)
                    hashCode = hashCode * 59 + this.TimestampInfo.GetHashCode();
                if (this.NestedDepth != null)
                    hashCode = hashCode * 59 + this.NestedDepth.GetHashCode();
                if (this.EnvelopeSha256Hash != null)
                    hashCode = hashCode * 59 + this.EnvelopeSha256Hash.GetHashCode();
                if (this.ContentSha256Hash != null)
                    hashCode = hashCode * 59 + this.ContentSha256Hash.GetHashCode();
                if (this.MimeType != null)
                    hashCode = hashCode * 59 + this.MimeType.GetHashCode();
                if (this.ValidationMessageList != null)
                    hashCode = hashCode * 59 + this.ValidationMessageList.GetHashCode();
                return hashCode;
            }
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
