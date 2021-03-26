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
    /// Class of options for copy security by business unit
    /// </summary>
    [DataContract]
    public partial class SecurityBusinessUnitCopyOptionsDTO :  IEquatable<SecurityBusinessUnitCopyOptionsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityBusinessUnitCopyOptionsDTO" /> class.
        /// </summary>
        /// <param name="sourceBusinessUnitCode">Business unit identifier to copy from.</param>
        /// <param name="destinationBusinessUnitCodes">Business unit identifiers to paste into.</param>
        public SecurityBusinessUnitCopyOptionsDTO(string sourceBusinessUnitCode = default(string), List<string> destinationBusinessUnitCodes = default(List<string>))
        {
            this.SourceBusinessUnitCode = sourceBusinessUnitCode;
            this.DestinationBusinessUnitCodes = destinationBusinessUnitCodes;
        }
        
        /// <summary>
        /// Business unit identifier to copy from
        /// </summary>
        /// <value>Business unit identifier to copy from</value>
        [DataMember(Name="sourceBusinessUnitCode", EmitDefaultValue=false)]
        public string SourceBusinessUnitCode { get; set; }

        /// <summary>
        /// Business unit identifiers to paste into
        /// </summary>
        /// <value>Business unit identifiers to paste into</value>
        [DataMember(Name="destinationBusinessUnitCodes", EmitDefaultValue=false)]
        public List<string> DestinationBusinessUnitCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecurityBusinessUnitCopyOptionsDTO {\n");
            sb.Append("  SourceBusinessUnitCode: ").Append(SourceBusinessUnitCode).Append("\n");
            sb.Append("  DestinationBusinessUnitCodes: ").Append(DestinationBusinessUnitCodes).Append("\n");
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
            return this.Equals(input as SecurityBusinessUnitCopyOptionsDTO);
        }

        /// <summary>
        /// Returns true if SecurityBusinessUnitCopyOptionsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of SecurityBusinessUnitCopyOptionsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecurityBusinessUnitCopyOptionsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourceBusinessUnitCode == input.SourceBusinessUnitCode ||
                    (this.SourceBusinessUnitCode != null &&
                    this.SourceBusinessUnitCode.Equals(input.SourceBusinessUnitCode))
                ) && 
                (
                    this.DestinationBusinessUnitCodes == input.DestinationBusinessUnitCodes ||
                    this.DestinationBusinessUnitCodes != null &&
                    this.DestinationBusinessUnitCodes.SequenceEqual(input.DestinationBusinessUnitCodes)
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
                if (this.SourceBusinessUnitCode != null)
                    hashCode = hashCode * 59 + this.SourceBusinessUnitCode.GetHashCode();
                if (this.DestinationBusinessUnitCodes != null)
                    hashCode = hashCode * 59 + this.DestinationBusinessUnitCodes.GetHashCode();
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
