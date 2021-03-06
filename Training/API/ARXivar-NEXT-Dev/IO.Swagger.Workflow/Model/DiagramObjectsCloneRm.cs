/* 
 * ARXivar Workflow API
 *
 * ARXivar Workflow API
 *
 * OpenAPI spec version: v1
 * Contact: info@abletech.it
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
using SwaggerDateConverter = IO.Swagger.Workflow.Client.SwaggerDateConverter;

namespace IO.Swagger.Workflow.Model
{
    /// <summary>
    /// Object list clone model
    /// </summary>
    [DataContract]
        public partial class DiagramObjectsCloneRm :  IEquatable<DiagramObjectsCloneRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiagramObjectsCloneRm" /> class.
        /// </summary>
        /// <param name="diagramId">Diagram identifier.</param>
        /// <param name="objects">List of objects to clone.</param>
        public DiagramObjectsCloneRm(Guid? diagramId = default(Guid?), List<DiagramObjectCloneRm> objects = default(List<DiagramObjectCloneRm>))
        {
            this.DiagramId = diagramId;
            this.Objects = objects;
        }
        
        /// <summary>
        /// Diagram identifier
        /// </summary>
        /// <value>Diagram identifier</value>
        [DataMember(Name="diagramId", EmitDefaultValue=false)]
        public Guid? DiagramId { get; set; }

        /// <summary>
        /// List of objects to clone
        /// </summary>
        /// <value>List of objects to clone</value>
        [DataMember(Name="objects", EmitDefaultValue=false)]
        public List<DiagramObjectCloneRm> Objects { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiagramObjectsCloneRm {\n");
            sb.Append("  DiagramId: ").Append(DiagramId).Append("\n");
            sb.Append("  Objects: ").Append(Objects).Append("\n");
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
            return this.Equals(input as DiagramObjectsCloneRm);
        }

        /// <summary>
        /// Returns true if DiagramObjectsCloneRm instances are equal
        /// </summary>
        /// <param name="input">Instance of DiagramObjectsCloneRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiagramObjectsCloneRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DiagramId == input.DiagramId ||
                    (this.DiagramId != null &&
                    this.DiagramId.Equals(input.DiagramId))
                ) && 
                (
                    this.Objects == input.Objects ||
                    this.Objects != null &&
                    input.Objects != null &&
                    this.Objects.SequenceEqual(input.Objects)
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
                if (this.DiagramId != null)
                    hashCode = hashCode * 59 + this.DiagramId.GetHashCode();
                if (this.Objects != null)
                    hashCode = hashCode * 59 + this.Objects.GetHashCode();
                return hashCode;
            }
        }

    }
}
