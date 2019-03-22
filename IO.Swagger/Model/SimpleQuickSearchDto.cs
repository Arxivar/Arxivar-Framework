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
    /// Class of quick search that doesn&#39;t support OR search list
    /// </summary>
    [DataContract]
    public partial class SimpleQuickSearchDto :  IEquatable<SimpleQuickSearchDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleQuickSearchDto" /> class.
        /// </summary>
        /// <param name="Find">Find information.</param>
        /// <param name="SearchFilterDto">SearchFilterDto.</param>
        /// <param name="SelectFilterDto">SelectFilterDto.</param>
        public SimpleQuickSearchDto(FindDTO Find = default(FindDTO), SearchDTO SearchFilterDto = default(SearchDTO), SelectDTO SelectFilterDto = default(SelectDTO))
        {
            this.Find = Find;
            this.SearchFilterDto = SearchFilterDto;
            this.SelectFilterDto = SelectFilterDto;
        }
        
        /// <summary>
        /// Find information
        /// </summary>
        /// <value>Find information</value>
        [DataMember(Name="find", EmitDefaultValue=false)]
        public FindDTO Find { get; set; }

        /// <summary>
        /// Gets or Sets SearchFilterDto
        /// </summary>
        [DataMember(Name="searchFilterDto", EmitDefaultValue=false)]
        public SearchDTO SearchFilterDto { get; set; }

        /// <summary>
        /// Gets or Sets SelectFilterDto
        /// </summary>
        [DataMember(Name="selectFilterDto", EmitDefaultValue=false)]
        public SelectDTO SelectFilterDto { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleQuickSearchDto {\n");
            sb.Append("  Find: ").Append(Find).Append("\n");
            sb.Append("  SearchFilterDto: ").Append(SearchFilterDto).Append("\n");
            sb.Append("  SelectFilterDto: ").Append(SelectFilterDto).Append("\n");
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
            return this.Equals(input as SimpleQuickSearchDto);
        }

        /// <summary>
        /// Returns true if SimpleQuickSearchDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleQuickSearchDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleQuickSearchDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Find == input.Find ||
                    (this.Find != null &&
                    this.Find.Equals(input.Find))
                ) && 
                (
                    this.SearchFilterDto == input.SearchFilterDto ||
                    (this.SearchFilterDto != null &&
                    this.SearchFilterDto.Equals(input.SearchFilterDto))
                ) && 
                (
                    this.SelectFilterDto == input.SelectFilterDto ||
                    (this.SelectFilterDto != null &&
                    this.SelectFilterDto.Equals(input.SelectFilterDto))
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
                if (this.Find != null)
                    hashCode = hashCode * 59 + this.Find.GetHashCode();
                if (this.SearchFilterDto != null)
                    hashCode = hashCode * 59 + this.SearchFilterDto.GetHashCode();
                if (this.SelectFilterDto != null)
                    hashCode = hashCode * 59 + this.SelectFilterDto.GetHashCode();
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