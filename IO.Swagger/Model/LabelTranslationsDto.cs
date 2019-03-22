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
    /// Class of traslated label
    /// </summary>
    [DataContract]
    public partial class LabelTranslationsDto :  IEquatable<LabelTranslationsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelTranslationsDto" /> class.
        /// </summary>
        /// <param name="LangCode">Code.</param>
        /// <param name="LabelTranslation">Traslated Label.</param>
        public LabelTranslationsDto(string LangCode = default(string), string LabelTranslation = default(string))
        {
            this.LangCode = LangCode;
            this.LabelTranslation = LabelTranslation;
        }
        
        /// <summary>
        /// Code
        /// </summary>
        /// <value>Code</value>
        [DataMember(Name="langCode", EmitDefaultValue=false)]
        public string LangCode { get; set; }

        /// <summary>
        /// Traslated Label
        /// </summary>
        /// <value>Traslated Label</value>
        [DataMember(Name="labelTranslation", EmitDefaultValue=false)]
        public string LabelTranslation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LabelTranslationsDto {\n");
            sb.Append("  LangCode: ").Append(LangCode).Append("\n");
            sb.Append("  LabelTranslation: ").Append(LabelTranslation).Append("\n");
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
            return this.Equals(input as LabelTranslationsDto);
        }

        /// <summary>
        /// Returns true if LabelTranslationsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of LabelTranslationsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LabelTranslationsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LangCode == input.LangCode ||
                    (this.LangCode != null &&
                    this.LangCode.Equals(input.LangCode))
                ) && 
                (
                    this.LabelTranslation == input.LabelTranslation ||
                    (this.LabelTranslation != null &&
                    this.LabelTranslation.Equals(input.LabelTranslation))
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
                if (this.LangCode != null)
                    hashCode = hashCode * 59 + this.LangCode.GetHashCode();
                if (this.LabelTranslation != null)
                    hashCode = hashCode * 59 + this.LabelTranslation.GetHashCode();
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
