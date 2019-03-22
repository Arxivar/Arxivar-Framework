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
    /// Class of criteria fields to calculate validation
    /// </summary>
    [DataContract]
    public partial class FieldValidationCalculateArchiveCriteriaDto :  IEquatable<FieldValidationCalculateArchiveCriteriaDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldValidationCalculateArchiveCriteriaDto" /> class.
        /// </summary>
        /// <param name="SearchFilterDto">Filter for profiling.</param>
        /// <param name="FieldName">Field Name.</param>
        public FieldValidationCalculateArchiveCriteriaDto(ProfileDTO SearchFilterDto = default(ProfileDTO), string FieldName = default(string))
        {
            this.SearchFilterDto = SearchFilterDto;
            this.FieldName = FieldName;
        }
        
        /// <summary>
        /// Filter for profiling
        /// </summary>
        /// <value>Filter for profiling</value>
        [DataMember(Name="searchFilterDto", EmitDefaultValue=false)]
        public ProfileDTO SearchFilterDto { get; set; }

        /// <summary>
        /// Field Name
        /// </summary>
        /// <value>Field Name</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldValidationCalculateArchiveCriteriaDto {\n");
            sb.Append("  SearchFilterDto: ").Append(SearchFilterDto).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
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
            return this.Equals(input as FieldValidationCalculateArchiveCriteriaDto);
        }

        /// <summary>
        /// Returns true if FieldValidationCalculateArchiveCriteriaDto instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldValidationCalculateArchiveCriteriaDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldValidationCalculateArchiveCriteriaDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SearchFilterDto == input.SearchFilterDto ||
                    (this.SearchFilterDto != null &&
                    this.SearchFilterDto.Equals(input.SearchFilterDto))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
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
                if (this.SearchFilterDto != null)
                    hashCode = hashCode * 59 + this.SearchFilterDto.GetHashCode();
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
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
