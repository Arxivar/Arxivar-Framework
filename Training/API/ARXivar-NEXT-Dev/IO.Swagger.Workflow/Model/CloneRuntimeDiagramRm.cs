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
    /// Clone runtime diagram model
    /// </summary>
    [DataContract]
        public partial class CloneRuntimeDiagramRm :  IEquatable<CloneRuntimeDiagramRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CloneRuntimeDiagramRm" /> class.
        /// </summary>
        /// <param name="runtimeProcessId">Runtime process indentifier.</param>
        /// <param name="id">Entity identifier.</param>
        public CloneRuntimeDiagramRm(Guid? runtimeProcessId = default(Guid?), Guid? id = default(Guid?))
        {
            this.RuntimeProcessId = runtimeProcessId;
            this.Id = id;
        }
        
        /// <summary>
        /// Runtime process indentifier
        /// </summary>
        /// <value>Runtime process indentifier</value>
        [DataMember(Name="runtimeProcessId", EmitDefaultValue=false)]
        public Guid? RuntimeProcessId { get; set; }

        /// <summary>
        /// Entity identifier
        /// </summary>
        /// <value>Entity identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CloneRuntimeDiagramRm {\n");
            sb.Append("  RuntimeProcessId: ").Append(RuntimeProcessId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as CloneRuntimeDiagramRm);
        }

        /// <summary>
        /// Returns true if CloneRuntimeDiagramRm instances are equal
        /// </summary>
        /// <param name="input">Instance of CloneRuntimeDiagramRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CloneRuntimeDiagramRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RuntimeProcessId == input.RuntimeProcessId ||
                    (this.RuntimeProcessId != null &&
                    this.RuntimeProcessId.Equals(input.RuntimeProcessId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.RuntimeProcessId != null)
                    hashCode = hashCode * 59 + this.RuntimeProcessId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                return hashCode;
            }
        }

    }
}
