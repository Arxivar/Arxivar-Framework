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
    /// ReplacementStorageSearchFilterDto
    /// </summary>
    [DataContract]
    public partial class ReplacementStorageSearchFilterDto :  IEquatable<ReplacementStorageSearchFilterDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplacementStorageSearchFilterDto" /> class.
        /// </summary>
        /// <param name="isAos">isAos.</param>
        /// <param name="period">period.</param>
        /// <param name="dmDevDocDevice">dmDevDocDevice.</param>
        public ReplacementStorageSearchFilterDto(int? isAos = default(int?), string period = default(string), string dmDevDocDevice = default(string))
        {
            this.IsAos = isAos;
            this.Period = period;
            this.DmDevDocDevice = dmDevDocDevice;
        }
        
        /// <summary>
        /// Gets or Sets IsAos
        /// </summary>
        [DataMember(Name="isAos", EmitDefaultValue=false)]
        public int? IsAos { get; set; }

        /// <summary>
        /// Gets or Sets Period
        /// </summary>
        [DataMember(Name="period", EmitDefaultValue=false)]
        public string Period { get; set; }

        /// <summary>
        /// Gets or Sets DmDevDocDevice
        /// </summary>
        [DataMember(Name="dm_DevDoc_Device", EmitDefaultValue=false)]
        public string DmDevDocDevice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplacementStorageSearchFilterDto {\n");
            sb.Append("  IsAos: ").Append(IsAos).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  DmDevDocDevice: ").Append(DmDevDocDevice).Append("\n");
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
            return this.Equals(input as ReplacementStorageSearchFilterDto);
        }

        /// <summary>
        /// Returns true if ReplacementStorageSearchFilterDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplacementStorageSearchFilterDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplacementStorageSearchFilterDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IsAos == input.IsAos ||
                    (this.IsAos != null &&
                    this.IsAos.Equals(input.IsAos))
                ) && 
                (
                    this.Period == input.Period ||
                    (this.Period != null &&
                    this.Period.Equals(input.Period))
                ) && 
                (
                    this.DmDevDocDevice == input.DmDevDocDevice ||
                    (this.DmDevDocDevice != null &&
                    this.DmDevDocDevice.Equals(input.DmDevDocDevice))
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
                if (this.IsAos != null)
                    hashCode = hashCode * 59 + this.IsAos.GetHashCode();
                if (this.Period != null)
                    hashCode = hashCode * 59 + this.Period.GetHashCode();
                if (this.DmDevDocDevice != null)
                    hashCode = hashCode * 59 + this.DmDevDocDevice.GetHashCode();
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
