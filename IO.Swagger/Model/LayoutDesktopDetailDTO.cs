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
    /// Class of layout detail in desktop
    /// </summary>
    [DataContract]
    public partial class LayoutDesktopDetailDTO :  IEquatable<LayoutDesktopDetailDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LayoutDesktopDetailDTO" /> class.
        /// </summary>
        /// <param name="Id">Identifier.</param>
        /// <param name="ElementId">Item Identifier.</param>
        /// <param name="X">X Coordinates.</param>
        /// <param name="Y">Y Coordinates.</param>
        /// <param name="W">Width.</param>
        /// <param name="H">Heigth.</param>
        /// <param name="InstanceId">Instance Identifier.</param>
        /// <param name="LayoutId">Layout Identifier.</param>
        public LayoutDesktopDetailDTO(int? Id = default(int?), string ElementId = default(string), int? X = default(int?), int? Y = default(int?), int? W = default(int?), int? H = default(int?), string InstanceId = default(string), int? LayoutId = default(int?))
        {
            this.Id = Id;
            this.ElementId = ElementId;
            this.X = X;
            this.Y = Y;
            this.W = W;
            this.H = H;
            this.InstanceId = InstanceId;
            this.LayoutId = LayoutId;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Item Identifier
        /// </summary>
        /// <value>Item Identifier</value>
        [DataMember(Name="elementId", EmitDefaultValue=false)]
        public string ElementId { get; set; }

        /// <summary>
        /// X Coordinates
        /// </summary>
        /// <value>X Coordinates</value>
        [DataMember(Name="x", EmitDefaultValue=false)]
        public int? X { get; set; }

        /// <summary>
        /// Y Coordinates
        /// </summary>
        /// <value>Y Coordinates</value>
        [DataMember(Name="y", EmitDefaultValue=false)]
        public int? Y { get; set; }

        /// <summary>
        /// Width
        /// </summary>
        /// <value>Width</value>
        [DataMember(Name="w", EmitDefaultValue=false)]
        public int? W { get; set; }

        /// <summary>
        /// Heigth
        /// </summary>
        /// <value>Heigth</value>
        [DataMember(Name="h", EmitDefaultValue=false)]
        public int? H { get; set; }

        /// <summary>
        /// Instance Identifier
        /// </summary>
        /// <value>Instance Identifier</value>
        [DataMember(Name="instanceId", EmitDefaultValue=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Layout Identifier
        /// </summary>
        /// <value>Layout Identifier</value>
        [DataMember(Name="layoutId", EmitDefaultValue=false)]
        public int? LayoutId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LayoutDesktopDetailDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ElementId: ").Append(ElementId).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  W: ").Append(W).Append("\n");
            sb.Append("  H: ").Append(H).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  LayoutId: ").Append(LayoutId).Append("\n");
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
            return this.Equals(input as LayoutDesktopDetailDTO);
        }

        /// <summary>
        /// Returns true if LayoutDesktopDetailDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of LayoutDesktopDetailDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LayoutDesktopDetailDTO input)
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
                    this.ElementId == input.ElementId ||
                    (this.ElementId != null &&
                    this.ElementId.Equals(input.ElementId))
                ) && 
                (
                    this.X == input.X ||
                    (this.X != null &&
                    this.X.Equals(input.X))
                ) && 
                (
                    this.Y == input.Y ||
                    (this.Y != null &&
                    this.Y.Equals(input.Y))
                ) && 
                (
                    this.W == input.W ||
                    (this.W != null &&
                    this.W.Equals(input.W))
                ) && 
                (
                    this.H == input.H ||
                    (this.H != null &&
                    this.H.Equals(input.H))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.LayoutId == input.LayoutId ||
                    (this.LayoutId != null &&
                    this.LayoutId.Equals(input.LayoutId))
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
                if (this.ElementId != null)
                    hashCode = hashCode * 59 + this.ElementId.GetHashCode();
                if (this.X != null)
                    hashCode = hashCode * 59 + this.X.GetHashCode();
                if (this.Y != null)
                    hashCode = hashCode * 59 + this.Y.GetHashCode();
                if (this.W != null)
                    hashCode = hashCode * 59 + this.W.GetHashCode();
                if (this.H != null)
                    hashCode = hashCode * 59 + this.H.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.LayoutId != null)
                    hashCode = hashCode * 59 + this.LayoutId.GetHashCode();
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
