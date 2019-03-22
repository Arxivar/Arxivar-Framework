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
    /// Version
    /// </summary>
    [DataContract]
    public partial class Version :  IEquatable<Version>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Version" /> class.
        /// </summary>
        /// <param name="Major">Major.</param>
        /// <param name="Minor">Minor.</param>
        /// <param name="Build">Build.</param>
        /// <param name="Revision">Revision.</param>
        public Version(int? Major = default(int?), int? Minor = default(int?), int? Build = default(int?), int? Revision = default(int?))
        {
            this.Major = Major;
            this.Minor = Minor;
            this.Build = Build;
            this.Revision = Revision;
        }
        
        /// <summary>
        /// Gets or Sets Major
        /// </summary>
        [DataMember(Name="_Major", EmitDefaultValue=false)]
        public int? Major { get; set; }

        /// <summary>
        /// Gets or Sets Minor
        /// </summary>
        [DataMember(Name="_Minor", EmitDefaultValue=false)]
        public int? Minor { get; set; }

        /// <summary>
        /// Gets or Sets Build
        /// </summary>
        [DataMember(Name="_Build", EmitDefaultValue=false)]
        public int? Build { get; set; }

        /// <summary>
        /// Gets or Sets Revision
        /// </summary>
        [DataMember(Name="_Revision", EmitDefaultValue=false)]
        public int? Revision { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Version {\n");
            sb.Append("  Major: ").Append(Major).Append("\n");
            sb.Append("  Minor: ").Append(Minor).Append("\n");
            sb.Append("  Build: ").Append(Build).Append("\n");
            sb.Append("  Revision: ").Append(Revision).Append("\n");
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
            return this.Equals(input as Version);
        }

        /// <summary>
        /// Returns true if Version instances are equal
        /// </summary>
        /// <param name="input">Instance of Version to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Version input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Major == input.Major ||
                    (this.Major != null &&
                    this.Major.Equals(input.Major))
                ) && 
                (
                    this.Minor == input.Minor ||
                    (this.Minor != null &&
                    this.Minor.Equals(input.Minor))
                ) && 
                (
                    this.Build == input.Build ||
                    (this.Build != null &&
                    this.Build.Equals(input.Build))
                ) && 
                (
                    this.Revision == input.Revision ||
                    (this.Revision != null &&
                    this.Revision.Equals(input.Revision))
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
                if (this.Major != null)
                    hashCode = hashCode * 59 + this.Major.GetHashCode();
                if (this.Minor != null)
                    hashCode = hashCode * 59 + this.Minor.GetHashCode();
                if (this.Build != null)
                    hashCode = hashCode * 59 + this.Build.GetHashCode();
                if (this.Revision != null)
                    hashCode = hashCode * 59 + this.Revision.GetHashCode();
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
