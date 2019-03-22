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
    /// Class of criteria for search values of process variables
    /// </summary>
    [DataContract]
    public partial class VariablesValuesCriteriaDTO :  IEquatable<VariablesValuesCriteriaDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariablesValuesCriteriaDTO" /> class.
        /// </summary>
        /// <param name="ProcessVariablesFields">Fields.</param>
        /// <param name="VariableFilters">Filters.</param>
        public VariablesValuesCriteriaDTO(ProcessVariablesFieldsDTO ProcessVariablesFields = default(ProcessVariablesFieldsDTO), VariableFiltersDTO VariableFilters = default(VariableFiltersDTO))
        {
            this.ProcessVariablesFields = ProcessVariablesFields;
            this.VariableFilters = VariableFilters;
        }
        
        /// <summary>
        /// Fields
        /// </summary>
        /// <value>Fields</value>
        [DataMember(Name="processVariablesFields", EmitDefaultValue=false)]
        public ProcessVariablesFieldsDTO ProcessVariablesFields { get; set; }

        /// <summary>
        /// Filters
        /// </summary>
        /// <value>Filters</value>
        [DataMember(Name="variableFilters", EmitDefaultValue=false)]
        public VariableFiltersDTO VariableFilters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariablesValuesCriteriaDTO {\n");
            sb.Append("  ProcessVariablesFields: ").Append(ProcessVariablesFields).Append("\n");
            sb.Append("  VariableFilters: ").Append(VariableFilters).Append("\n");
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
            return this.Equals(input as VariablesValuesCriteriaDTO);
        }

        /// <summary>
        /// Returns true if VariablesValuesCriteriaDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of VariablesValuesCriteriaDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariablesValuesCriteriaDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProcessVariablesFields == input.ProcessVariablesFields ||
                    (this.ProcessVariablesFields != null &&
                    this.ProcessVariablesFields.Equals(input.ProcessVariablesFields))
                ) && 
                (
                    this.VariableFilters == input.VariableFilters ||
                    (this.VariableFilters != null &&
                    this.VariableFilters.Equals(input.VariableFilters))
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
                if (this.ProcessVariablesFields != null)
                    hashCode = hashCode * 59 + this.ProcessVariablesFields.GetHashCode();
                if (this.VariableFilters != null)
                    hashCode = hashCode * 59 + this.VariableFilters.GetHashCode();
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
