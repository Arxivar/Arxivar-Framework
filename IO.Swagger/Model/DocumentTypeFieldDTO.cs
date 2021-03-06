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
    /// Document type class
    /// </summary>
    [DataContract]
    public partial class DocumentTypeFieldDTO : FieldBaseDTO,  IEquatable<DocumentTypeFieldDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTypeFieldDTO" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentTypeFieldDTO() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentTypeFieldDTO" /> class.
        /// </summary>
        /// <param name="Value">Document type id.</param>
        /// <param name="DisplayValue">Document type display value.</param>
        public DocumentTypeFieldDTO(int? Value = default(int?), string DisplayValue = default(string), string Name = default(string), string ExternalId = default(string), string Description = default(string), int? Order = default(int?), string DataSource = default(string), bool? Required = default(bool?), string Formula = default(string), string ClassName = "DocumentTypeFieldDTO", bool? Locked = default(bool?), string ComboGruppiId = default(string), List<DependencyFieldItem> DependencyFields = default(List<DependencyFieldItem>), List<AssocitationFieldItem> Associations = default(List<AssocitationFieldItem>), bool? IsAdditional = default(bool?), bool? Visible = default(bool?), string PredefinedProfileFormula = default(string)) : base(Name, ExternalId, Description, Order, DataSource, Required, Formula, ClassName, Locked, ComboGruppiId, DependencyFields, Associations, IsAdditional, Visible, PredefinedProfileFormula)
        {
            this.Value = Value;
            this.DisplayValue = DisplayValue;
        }
        
        /// <summary>
        /// Document type id
        /// </summary>
        /// <value>Document type id</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }

        /// <summary>
        /// Document type display value
        /// </summary>
        /// <value>Document type display value</value>
        [DataMember(Name="displayValue", EmitDefaultValue=false)]
        public string DisplayValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentTypeFieldDTO {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  DisplayValue: ").Append(DisplayValue).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as DocumentTypeFieldDTO);
        }

        /// <summary>
        /// Returns true if DocumentTypeFieldDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of DocumentTypeFieldDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DocumentTypeFieldDTO input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && base.Equals(input) && 
                (
                    this.DisplayValue == input.DisplayValue ||
                    (this.DisplayValue != null &&
                    this.DisplayValue.Equals(input.DisplayValue))
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
                int hashCode = base.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.DisplayValue != null)
                    hashCode = hashCode * 59 + this.DisplayValue.GetHashCode();
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
            foreach(var x in BaseValidate(validationContext)) yield return x;
            yield break;
        }
    }

}
