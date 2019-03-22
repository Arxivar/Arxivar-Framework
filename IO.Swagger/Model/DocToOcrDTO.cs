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
    /// Class of optical character recognition (OCR) on a document profile.
    /// </summary>
    [DataContract]
    public partial class DocToOcrDTO :  IEquatable<DocToOcrDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocToOcrDTO" /> class.
        /// </summary>
        /// <param name="Docnumber">Document Identifier.</param>
        /// <param name="Status">Possible values:  1: Pending  2: Failed  3: Scheduled  4: Pending_Rev  5: Failed_Rev  6: Scheduled_Rev .</param>
        /// <param name="Revision">Revision of document.</param>
        /// <param name="OcrDate">Schedule Date.</param>
        /// <param name="User">User Identifier.</param>
        /// <param name="Guid">Identifier.</param>
        /// <param name="NumAttemps">Number of Attempts.</param>
        /// <param name="ErrorMessage">Error Message.</param>
        public DocToOcrDTO(int? Docnumber = default(int?), int? Status = default(int?), int? Revision = default(int?), DateTime? OcrDate = default(DateTime?), int? User = default(int?), string Guid = default(string), int? NumAttemps = default(int?), string ErrorMessage = default(string))
        {
            this.Docnumber = Docnumber;
            this.Status = Status;
            this.Revision = Revision;
            this.OcrDate = OcrDate;
            this.User = User;
            this.Guid = Guid;
            this.NumAttemps = NumAttemps;
            this.ErrorMessage = ErrorMessage;
        }
        
        /// <summary>
        /// Document Identifier
        /// </summary>
        /// <value>Document Identifier</value>
        [DataMember(Name="docnumber", EmitDefaultValue=false)]
        public int? Docnumber { get; set; }

        /// <summary>
        /// Possible values:  1: Pending  2: Failed  3: Scheduled  4: Pending_Rev  5: Failed_Rev  6: Scheduled_Rev 
        /// </summary>
        /// <value>Possible values:  1: Pending  2: Failed  3: Scheduled  4: Pending_Rev  5: Failed_Rev  6: Scheduled_Rev </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public int? Status { get; set; }

        /// <summary>
        /// Revision of document
        /// </summary>
        /// <value>Revision of document</value>
        [DataMember(Name="revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// Schedule Date
        /// </summary>
        /// <value>Schedule Date</value>
        [DataMember(Name="ocrDate", EmitDefaultValue=false)]
        public DateTime? OcrDate { get; set; }

        /// <summary>
        /// User Identifier
        /// </summary>
        /// <value>User Identifier</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="guid", EmitDefaultValue=false)]
        public string Guid { get; set; }

        /// <summary>
        /// Number of Attempts
        /// </summary>
        /// <value>Number of Attempts</value>
        [DataMember(Name="numAttemps", EmitDefaultValue=false)]
        public int? NumAttemps { get; set; }

        /// <summary>
        /// Error Message
        /// </summary>
        /// <value>Error Message</value>
        [DataMember(Name="errorMessage", EmitDefaultValue=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocToOcrDTO {\n");
            sb.Append("  Docnumber: ").Append(Docnumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
            sb.Append("  OcrDate: ").Append(OcrDate).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Guid: ").Append(Guid).Append("\n");
            sb.Append("  NumAttemps: ").Append(NumAttemps).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
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
            return this.Equals(input as DocToOcrDTO);
        }

        /// <summary>
        /// Returns true if DocToOcrDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DocToOcrDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocToOcrDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Docnumber == input.Docnumber ||
                    (this.Docnumber != null &&
                    this.Docnumber.Equals(input.Docnumber))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
                ) && 
                (
                    this.OcrDate == input.OcrDate ||
                    (this.OcrDate != null &&
                    this.OcrDate.Equals(input.OcrDate))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Guid == input.Guid ||
                    (this.Guid != null &&
                    this.Guid.Equals(input.Guid))
                ) && 
                (
                    this.NumAttemps == input.NumAttemps ||
                    (this.NumAttemps != null &&
                    this.NumAttemps.Equals(input.NumAttemps))
                ) && 
                (
                    this.ErrorMessage == input.ErrorMessage ||
                    (this.ErrorMessage != null &&
                    this.ErrorMessage.Equals(input.ErrorMessage))
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
                if (this.Docnumber != null)
                    hashCode = hashCode * 59 + this.Docnumber.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
                if (this.OcrDate != null)
                    hashCode = hashCode * 59 + this.OcrDate.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Guid != null)
                    hashCode = hashCode * 59 + this.Guid.GetHashCode();
                if (this.NumAttemps != null)
                    hashCode = hashCode * 59 + this.NumAttemps.GetHashCode();
                if (this.ErrorMessage != null)
                    hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
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
