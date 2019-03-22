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
    /// ReportExecuteMultipleRequestDTO
    /// </summary>
    [DataContract]
    public partial class ReportExecuteMultipleRequestDTO :  IEquatable<ReportExecuteMultipleRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportExecuteMultipleRequestDTO" /> class.
        /// </summary>
        /// <param name="Identifier">Report Id.</param>
        /// <param name="Formats">Report output formats.</param>
        /// <param name="Parameters">Parameters to input for the execution.</param>
        public ReportExecuteMultipleRequestDTO(ReportIdentifier Identifier = default(ReportIdentifier), List<int?> Formats = default(List<int?>), List<ReportParamDTO> Parameters = default(List<ReportParamDTO>))
        {
            this.Identifier = Identifier;
            this.Formats = Formats;
            this.Parameters = Parameters;
        }
        
        /// <summary>
        /// Report Id
        /// </summary>
        /// <value>Report Id</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public ReportIdentifier Identifier { get; set; }

        /// <summary>
        /// Report output formats
        /// </summary>
        /// <value>Report output formats</value>
        [DataMember(Name="formats", EmitDefaultValue=false)]
        public List<int?> Formats { get; set; }

        /// <summary>
        /// Parameters to input for the execution
        /// </summary>
        /// <value>Parameters to input for the execution</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<ReportParamDTO> Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportExecuteMultipleRequestDTO {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Formats: ").Append(Formats).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(input as ReportExecuteMultipleRequestDTO);
        }

        /// <summary>
        /// Returns true if ReportExecuteMultipleRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportExecuteMultipleRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportExecuteMultipleRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Formats == input.Formats ||
                    this.Formats != null &&
                    this.Formats.SequenceEqual(input.Formats)
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Formats != null)
                    hashCode = hashCode * 59 + this.Formats.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
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
