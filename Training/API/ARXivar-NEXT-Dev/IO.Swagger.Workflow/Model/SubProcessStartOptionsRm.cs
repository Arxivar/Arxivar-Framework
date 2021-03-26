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
    /// Sub process start options
    /// </summary>
    [DataContract]
        public partial class SubProcessStartOptionsRm :  IEquatable<SubProcessStartOptionsRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubProcessStartOptionsRm" /> class.
        /// </summary>
        /// <param name="addPrimary">Add primary document.</param>
        /// <param name="addSecondary">Add secondary documents.</param>
        /// <param name="addAttachment">Add attachments.</param>
        /// <param name="addNotes">Add notes.</param>
        /// <param name="modeVariableCopyMode">Sub process variable copy mode [0&#x3D;None, 1&#x3D;Auto, 2&#x3D;Manual].</param>
        /// <param name="variableMappingList">Variable mapping list.</param>
        public SubProcessStartOptionsRm(bool? addPrimary = default(bool?), bool? addSecondary = default(bool?), bool? addAttachment = default(bool?), bool? addNotes = default(bool?), int? modeVariableCopyMode = default(int?), List<MappingProcessVariableRm> variableMappingList = default(List<MappingProcessVariableRm>))
        {
            this.AddPrimary = addPrimary;
            this.AddSecondary = addSecondary;
            this.AddAttachment = addAttachment;
            this.AddNotes = addNotes;
            this.ModeVariableCopyMode = modeVariableCopyMode;
            this.VariableMappingList = variableMappingList;
        }
        
        /// <summary>
        /// Add primary document
        /// </summary>
        /// <value>Add primary document</value>
        [DataMember(Name="addPrimary", EmitDefaultValue=false)]
        public bool? AddPrimary { get; set; }

        /// <summary>
        /// Add secondary documents
        /// </summary>
        /// <value>Add secondary documents</value>
        [DataMember(Name="addSecondary", EmitDefaultValue=false)]
        public bool? AddSecondary { get; set; }

        /// <summary>
        /// Add attachments
        /// </summary>
        /// <value>Add attachments</value>
        [DataMember(Name="addAttachment", EmitDefaultValue=false)]
        public bool? AddAttachment { get; set; }

        /// <summary>
        /// Add notes
        /// </summary>
        /// <value>Add notes</value>
        [DataMember(Name="addNotes", EmitDefaultValue=false)]
        public bool? AddNotes { get; set; }

        /// <summary>
        /// Sub process variable copy mode [0&#x3D;None, 1&#x3D;Auto, 2&#x3D;Manual]
        /// </summary>
        /// <value>Sub process variable copy mode [0&#x3D;None, 1&#x3D;Auto, 2&#x3D;Manual]</value>
        [DataMember(Name="modeVariableCopyMode", EmitDefaultValue=false)]
        public int? ModeVariableCopyMode { get; set; }

        /// <summary>
        /// Variable mapping list
        /// </summary>
        /// <value>Variable mapping list</value>
        [DataMember(Name="variableMappingList", EmitDefaultValue=false)]
        public List<MappingProcessVariableRm> VariableMappingList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubProcessStartOptionsRm {\n");
            sb.Append("  AddPrimary: ").Append(AddPrimary).Append("\n");
            sb.Append("  AddSecondary: ").Append(AddSecondary).Append("\n");
            sb.Append("  AddAttachment: ").Append(AddAttachment).Append("\n");
            sb.Append("  AddNotes: ").Append(AddNotes).Append("\n");
            sb.Append("  ModeVariableCopyMode: ").Append(ModeVariableCopyMode).Append("\n");
            sb.Append("  VariableMappingList: ").Append(VariableMappingList).Append("\n");
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
            return this.Equals(input as SubProcessStartOptionsRm);
        }

        /// <summary>
        /// Returns true if SubProcessStartOptionsRm instances are equal
        /// </summary>
        /// <param name="input">Instance of SubProcessStartOptionsRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubProcessStartOptionsRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddPrimary == input.AddPrimary ||
                    (this.AddPrimary != null &&
                    this.AddPrimary.Equals(input.AddPrimary))
                ) && 
                (
                    this.AddSecondary == input.AddSecondary ||
                    (this.AddSecondary != null &&
                    this.AddSecondary.Equals(input.AddSecondary))
                ) && 
                (
                    this.AddAttachment == input.AddAttachment ||
                    (this.AddAttachment != null &&
                    this.AddAttachment.Equals(input.AddAttachment))
                ) && 
                (
                    this.AddNotes == input.AddNotes ||
                    (this.AddNotes != null &&
                    this.AddNotes.Equals(input.AddNotes))
                ) && 
                (
                    this.ModeVariableCopyMode == input.ModeVariableCopyMode ||
                    (this.ModeVariableCopyMode != null &&
                    this.ModeVariableCopyMode.Equals(input.ModeVariableCopyMode))
                ) && 
                (
                    this.VariableMappingList == input.VariableMappingList ||
                    this.VariableMappingList != null &&
                    input.VariableMappingList != null &&
                    this.VariableMappingList.SequenceEqual(input.VariableMappingList)
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
                if (this.AddPrimary != null)
                    hashCode = hashCode * 59 + this.AddPrimary.GetHashCode();
                if (this.AddSecondary != null)
                    hashCode = hashCode * 59 + this.AddSecondary.GetHashCode();
                if (this.AddAttachment != null)
                    hashCode = hashCode * 59 + this.AddAttachment.GetHashCode();
                if (this.AddNotes != null)
                    hashCode = hashCode * 59 + this.AddNotes.GetHashCode();
                if (this.ModeVariableCopyMode != null)
                    hashCode = hashCode * 59 + this.ModeVariableCopyMode.GetHashCode();
                if (this.VariableMappingList != null)
                    hashCode = hashCode * 59 + this.VariableMappingList.GetHashCode();
                return hashCode;
            }
        }

    }
}