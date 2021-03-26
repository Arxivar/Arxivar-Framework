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
    /// Class of binder type
    /// </summary>
    [DataContract]
    public partial class BinderTypeDTO :  IEquatable<BinderTypeDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BinderTypeDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="binderType">Type Identifier.</param>
        /// <param name="folderId">Folder Identifier.</param>
        /// <param name="dynamicFolder">Dynamic Folder.</param>
        /// <param name="progressive">Progressive number.</param>
        /// <param name="dynamicNumber">Dynamic Progressive number.</param>
        /// <param name="externalId">External Identifier.</param>
        /// <param name="fields">Custom Fields.</param>
        /// <param name="_default">As default.</param>
        public BinderTypeDTO(int? id = default(int?), string binderType = default(string), int? folderId = default(int?), string dynamicFolder = default(string), int? progressive = default(int?), string dynamicNumber = default(string), string externalId = default(string), List<FieldBaseDTO> fields = default(List<FieldBaseDTO>), bool? _default = default(bool?))
        {
            this.Id = id;
            this.BinderType = binderType;
            this.FolderId = folderId;
            this.DynamicFolder = dynamicFolder;
            this.Progressive = progressive;
            this.DynamicNumber = dynamicNumber;
            this.ExternalId = externalId;
            this.Fields = fields;
            this.Default = _default;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Type Identifier
        /// </summary>
        /// <value>Type Identifier</value>
        [DataMember(Name="binderType", EmitDefaultValue=false)]
        public string BinderType { get; set; }

        /// <summary>
        /// Folder Identifier
        /// </summary>
        /// <value>Folder Identifier</value>
        [DataMember(Name="folderId", EmitDefaultValue=false)]
        public int? FolderId { get; set; }

        /// <summary>
        /// Dynamic Folder
        /// </summary>
        /// <value>Dynamic Folder</value>
        [DataMember(Name="dynamicFolder", EmitDefaultValue=false)]
        public string DynamicFolder { get; set; }

        /// <summary>
        /// Progressive number
        /// </summary>
        /// <value>Progressive number</value>
        [DataMember(Name="progressive", EmitDefaultValue=false)]
        public int? Progressive { get; set; }

        /// <summary>
        /// Dynamic Progressive number
        /// </summary>
        /// <value>Dynamic Progressive number</value>
        [DataMember(Name="dynamicNumber", EmitDefaultValue=false)]
        public string DynamicNumber { get; set; }

        /// <summary>
        /// External Identifier
        /// </summary>
        /// <value>External Identifier</value>
        [DataMember(Name="externalId", EmitDefaultValue=false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Custom Fields
        /// </summary>
        /// <value>Custom Fields</value>
        [DataMember(Name="fields", EmitDefaultValue=false)]
        public List<FieldBaseDTO> Fields { get; set; }

        /// <summary>
        /// As default
        /// </summary>
        /// <value>As default</value>
        [DataMember(Name="default", EmitDefaultValue=false)]
        public bool? Default { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BinderTypeDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  BinderType: ").Append(BinderType).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  DynamicFolder: ").Append(DynamicFolder).Append("\n");
            sb.Append("  Progressive: ").Append(Progressive).Append("\n");
            sb.Append("  DynamicNumber: ").Append(DynamicNumber).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  Default: ").Append(Default).Append("\n");
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
            return this.Equals(input as BinderTypeDTO);
        }

        /// <summary>
        /// Returns true if BinderTypeDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of BinderTypeDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BinderTypeDTO input)
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
                    this.BinderType == input.BinderType ||
                    (this.BinderType != null &&
                    this.BinderType.Equals(input.BinderType))
                ) && 
                (
                    this.FolderId == input.FolderId ||
                    (this.FolderId != null &&
                    this.FolderId.Equals(input.FolderId))
                ) && 
                (
                    this.DynamicFolder == input.DynamicFolder ||
                    (this.DynamicFolder != null &&
                    this.DynamicFolder.Equals(input.DynamicFolder))
                ) && 
                (
                    this.Progressive == input.Progressive ||
                    (this.Progressive != null &&
                    this.Progressive.Equals(input.Progressive))
                ) && 
                (
                    this.DynamicNumber == input.DynamicNumber ||
                    (this.DynamicNumber != null &&
                    this.DynamicNumber.Equals(input.DynamicNumber))
                ) && 
                (
                    this.ExternalId == input.ExternalId ||
                    (this.ExternalId != null &&
                    this.ExternalId.Equals(input.ExternalId))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.Default == input.Default ||
                    (this.Default != null &&
                    this.Default.Equals(input.Default))
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
                if (this.BinderType != null)
                    hashCode = hashCode * 59 + this.BinderType.GetHashCode();
                if (this.FolderId != null)
                    hashCode = hashCode * 59 + this.FolderId.GetHashCode();
                if (this.DynamicFolder != null)
                    hashCode = hashCode * 59 + this.DynamicFolder.GetHashCode();
                if (this.Progressive != null)
                    hashCode = hashCode * 59 + this.Progressive.GetHashCode();
                if (this.DynamicNumber != null)
                    hashCode = hashCode * 59 + this.DynamicNumber.GetHashCode();
                if (this.ExternalId != null)
                    hashCode = hashCode * 59 + this.ExternalId.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.Default != null)
                    hashCode = hashCode * 59 + this.Default.GetHashCode();
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