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
    /// Class of Layout
    /// </summary>
    [DataContract]
    public partial class LayoutDesktopDTO :  IEquatable<LayoutDesktopDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutDesktopDTO" /> class.
        /// </summary>
        /// <param name="Id">Identifier.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Author">Author user.</param>
        /// <param name="AuthorCompleteName">Author name.</param>
        /// <param name="CreationDate">Creation Date.</param>
        /// <param name="Details">Details.</param>
        /// <param name="IsSystem">System Layout.</param>
        public LayoutDesktopDTO(int? Id = default(int?), string Name = default(string), int? Author = default(int?), string AuthorCompleteName = default(string), DateTime? CreationDate = default(DateTime?), List<LayoutDesktopDetailDTO> Details = default(List<LayoutDesktopDetailDTO>), bool? IsSystem = default(bool?))
        {
            this.Id = Id;
            this.Name = Name;
            this.Author = Author;
            this.AuthorCompleteName = AuthorCompleteName;
            this.CreationDate = CreationDate;
            this.Details = Details;
            this.IsSystem = IsSystem;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        /// <value>Name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Author user
        /// </summary>
        /// <value>Author user</value>
        [DataMember(Name="author", EmitDefaultValue=false)]
        public int? Author { get; set; }

        /// <summary>
        /// Author name
        /// </summary>
        /// <value>Author name</value>
        [DataMember(Name="authorCompleteName", EmitDefaultValue=false)]
        public string AuthorCompleteName { get; set; }

        /// <summary>
        /// Creation Date
        /// </summary>
        /// <value>Creation Date</value>
        [DataMember(Name="creationDate", EmitDefaultValue=false)]
        public DateTime? CreationDate { get; set; }

        /// <summary>
        /// Details
        /// </summary>
        /// <value>Details</value>
        [DataMember(Name="details", EmitDefaultValue=false)]
        public List<LayoutDesktopDetailDTO> Details { get; set; }

        /// <summary>
        /// System Layout
        /// </summary>
        /// <value>System Layout</value>
        [DataMember(Name="isSystem", EmitDefaultValue=false)]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LayoutDesktopDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  AuthorCompleteName: ").Append(AuthorCompleteName).Append("\n");
            sb.Append("  CreationDate: ").Append(CreationDate).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
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
            return this.Equals(input as LayoutDesktopDTO);
        }

        /// <summary>
        /// Returns true if LayoutDesktopDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of LayoutDesktopDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LayoutDesktopDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Author == input.Author ||
                    (this.Author != null &&
                    this.Author.Equals(input.Author))
                ) && 
                (
                    this.AuthorCompleteName == input.AuthorCompleteName ||
                    (this.AuthorCompleteName != null &&
                    this.AuthorCompleteName.Equals(input.AuthorCompleteName))
                ) && 
                (
                    this.CreationDate == input.CreationDate ||
                    (this.CreationDate != null &&
                    this.CreationDate.Equals(input.CreationDate))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.IsSystem == input.IsSystem ||
                    (this.IsSystem != null &&
                    this.IsSystem.Equals(input.IsSystem))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Author != null)
                    hashCode = hashCode * 59 + this.Author.GetHashCode();
                if (this.AuthorCompleteName != null)
                    hashCode = hashCode * 59 + this.AuthorCompleteName.GetHashCode();
                if (this.CreationDate != null)
                    hashCode = hashCode * 59 + this.CreationDate.GetHashCode();
                if (this.Details != null)
                    hashCode = hashCode * 59 + this.Details.GetHashCode();
                if (this.IsSystem != null)
                    hashCode = hashCode * 59 + this.IsSystem.GetHashCode();
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
