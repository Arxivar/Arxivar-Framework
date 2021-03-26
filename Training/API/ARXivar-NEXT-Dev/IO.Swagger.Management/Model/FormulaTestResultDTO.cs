/* 
 * WebAPI - Area Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: management
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
using SwaggerDateConverter = IO.Swagger.Management.Client.SwaggerDateConverter;

namespace IO.Swagger.Management.Model
{
    /// <summary>
    /// Class for Formula test result
    /// </summary>
    [DataContract]
    public partial class FormulaTestResultDTO :  IEquatable<FormulaTestResultDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormulaTestResultDTO" /> class.
        /// </summary>
        /// <param name="formula">Formula string.</param>
        /// <param name="isValid">Boolean that is true if the formula is formally valid.</param>
        /// <param name="output">Formula result.</param>
        public FormulaTestResultDTO(FormulaTestDTO formula = default(FormulaTestDTO), bool? isValid = default(bool?), string output = default(string))
        {
            this.Formula = formula;
            this.IsValid = isValid;
            this.Output = output;
        }
        
        /// <summary>
        /// Formula string
        /// </summary>
        /// <value>Formula string</value>
        [DataMember(Name="formula", EmitDefaultValue=false)]
        public FormulaTestDTO Formula { get; set; }

        /// <summary>
        /// Boolean that is true if the formula is formally valid
        /// </summary>
        /// <value>Boolean that is true if the formula is formally valid</value>
        [DataMember(Name="isValid", EmitDefaultValue=false)]
        public bool? IsValid { get; set; }

        /// <summary>
        /// Formula result
        /// </summary>
        /// <value>Formula result</value>
        [DataMember(Name="output", EmitDefaultValue=false)]
        public string Output { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormulaTestResultDTO {\n");
            sb.Append("  Formula: ").Append(Formula).Append("\n");
            sb.Append("  IsValid: ").Append(IsValid).Append("\n");
            sb.Append("  Output: ").Append(Output).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
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
            return this.Equals(input as FormulaTestResultDTO);
        }

        /// <summary>
        /// Returns true if FormulaTestResultDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of FormulaTestResultDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormulaTestResultDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Formula == input.Formula ||
                    (this.Formula != null &&
                    this.Formula.Equals(input.Formula))
                ) && 
                (
                    this.IsValid == input.IsValid ||
                    (this.IsValid != null &&
                    this.IsValid.Equals(input.IsValid))
                ) && 
                (
                    this.Output == input.Output ||
                    (this.Output != null &&
                    this.Output.Equals(input.Output))
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
                if (this.Formula != null)
                    hashCode = hashCode * 59 + this.Formula.GetHashCode();
                if (this.IsValid != null)
                    hashCode = hashCode * 59 + this.IsValid.GetHashCode();
                if (this.Output != null)
                    hashCode = hashCode * 59 + this.Output.GetHashCode();
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
