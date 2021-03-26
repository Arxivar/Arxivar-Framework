/* 
 * WebAPI
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: data
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
    /// ExportMassiveForProcessDocRequestDTO
    /// </summary>
    [DataContract]
    public partial class ExportMassiveForProcessDocRequestDTO :  IEquatable<ExportMassiveForProcessDocRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportMassiveForProcessDocRequestDTO" /> class.
        /// </summary>
        /// <param name="items">items.</param>
        /// <param name="forView">forView.</param>
        public ExportMassiveForProcessDocRequestDTO(List<ExportMassiveForProcessDocItemRequestDTO> items = default(List<ExportMassiveForProcessDocItemRequestDTO>), bool? forView = default(bool?))
        {
            this.Items = items;
            this.ForView = forView;
        }
        
        /// <summary>
        /// Gets or Sets Items
        /// </summary>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<ExportMassiveForProcessDocItemRequestDTO> Items { get; set; }

        /// <summary>
        /// Gets or Sets ForView
        /// </summary>
        [DataMember(Name="forView", EmitDefaultValue=false)]
        public bool? ForView { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportMassiveForProcessDocRequestDTO {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  ForView: ").Append(ForView).Append("\n");
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
            return this.Equals(input as ExportMassiveForProcessDocRequestDTO);
        }

        /// <summary>
        /// Returns true if ExportMassiveForProcessDocRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ExportMassiveForProcessDocRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExportMassiveForProcessDocRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.ForView == input.ForView ||
                    (this.ForView != null &&
                    this.ForView.Equals(input.ForView))
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.ForView != null)
                    hashCode = hashCode * 59 + this.ForView.GetHashCode();
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
