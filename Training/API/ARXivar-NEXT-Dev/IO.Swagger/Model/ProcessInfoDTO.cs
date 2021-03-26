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
    /// ProcessInfoDTO
    /// </summary>
    [DataContract]
    public partial class ProcessInfoDTO :  IEquatable<ProcessInfoDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessInfoDTO" /> class.
        /// </summary>
        /// <param name="taskInfoList">taskInfoList.</param>
        /// <param name="documentInfoList">documentInfoList.</param>
        /// <param name="noteInfoList">noteInfoList.</param>
        /// <param name="attachmentInfoList">attachmentInfoList.</param>
        /// <param name="professionalRoleInfoList">professionalRoleInfoList.</param>
        /// <param name="chronoInfoList">chronoInfoList.</param>
        /// <param name="variableInfo">variableInfo.</param>
        public ProcessInfoDTO(List<TaskInfoDTO> taskInfoList = default(List<TaskInfoDTO>), List<DocumentWorkInfoDTO> documentInfoList = default(List<DocumentWorkInfoDTO>), List<NoteWorkInfoDTO> noteInfoList = default(List<NoteWorkInfoDTO>), List<AttachmentWorkInfoDTO> attachmentInfoList = default(List<AttachmentWorkInfoDTO>), List<ProfessionalRoleInfoDTO> professionalRoleInfoList = default(List<ProfessionalRoleInfoDTO>), List<ChronoInfoDTO> chronoInfoList = default(List<ChronoInfoDTO>), ProcessInfoVariableDTO variableInfo = default(ProcessInfoVariableDTO))
        {
            this.TaskInfoList = taskInfoList;
            this.DocumentInfoList = documentInfoList;
            this.NoteInfoList = noteInfoList;
            this.AttachmentInfoList = attachmentInfoList;
            this.ProfessionalRoleInfoList = professionalRoleInfoList;
            this.ChronoInfoList = chronoInfoList;
            this.VariableInfo = variableInfo;
        }
        
        /// <summary>
        /// Gets or Sets TaskInfoList
        /// </summary>
        [DataMember(Name="taskInfoList", EmitDefaultValue=false)]
        public List<TaskInfoDTO> TaskInfoList { get; set; }

        /// <summary>
        /// Gets or Sets DocumentInfoList
        /// </summary>
        [DataMember(Name="documentInfoList", EmitDefaultValue=false)]
        public List<DocumentWorkInfoDTO> DocumentInfoList { get; set; }

        /// <summary>
        /// Gets or Sets NoteInfoList
        /// </summary>
        [DataMember(Name="noteInfoList", EmitDefaultValue=false)]
        public List<NoteWorkInfoDTO> NoteInfoList { get; set; }

        /// <summary>
        /// Gets or Sets AttachmentInfoList
        /// </summary>
        [DataMember(Name="attachmentInfoList", EmitDefaultValue=false)]
        public List<AttachmentWorkInfoDTO> AttachmentInfoList { get; set; }

        /// <summary>
        /// Gets or Sets ProfessionalRoleInfoList
        /// </summary>
        [DataMember(Name="professionalRoleInfoList", EmitDefaultValue=false)]
        public List<ProfessionalRoleInfoDTO> ProfessionalRoleInfoList { get; set; }

        /// <summary>
        /// Gets or Sets ChronoInfoList
        /// </summary>
        [DataMember(Name="chronoInfoList", EmitDefaultValue=false)]
        public List<ChronoInfoDTO> ChronoInfoList { get; set; }

        /// <summary>
        /// Gets or Sets VariableInfo
        /// </summary>
        [DataMember(Name="variableInfo", EmitDefaultValue=false)]
        public ProcessInfoVariableDTO VariableInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessInfoDTO {\n");
            sb.Append("  TaskInfoList: ").Append(TaskInfoList).Append("\n");
            sb.Append("  DocumentInfoList: ").Append(DocumentInfoList).Append("\n");
            sb.Append("  NoteInfoList: ").Append(NoteInfoList).Append("\n");
            sb.Append("  AttachmentInfoList: ").Append(AttachmentInfoList).Append("\n");
            sb.Append("  ProfessionalRoleInfoList: ").Append(ProfessionalRoleInfoList).Append("\n");
            sb.Append("  ChronoInfoList: ").Append(ChronoInfoList).Append("\n");
            sb.Append("  VariableInfo: ").Append(VariableInfo).Append("\n");
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
            return this.Equals(input as ProcessInfoDTO);
        }

        /// <summary>
        /// Returns true if ProcessInfoDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessInfoDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessInfoDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskInfoList == input.TaskInfoList ||
                    this.TaskInfoList != null &&
                    this.TaskInfoList.SequenceEqual(input.TaskInfoList)
                ) && 
                (
                    this.DocumentInfoList == input.DocumentInfoList ||
                    this.DocumentInfoList != null &&
                    this.DocumentInfoList.SequenceEqual(input.DocumentInfoList)
                ) && 
                (
                    this.NoteInfoList == input.NoteInfoList ||
                    this.NoteInfoList != null &&
                    this.NoteInfoList.SequenceEqual(input.NoteInfoList)
                ) && 
                (
                    this.AttachmentInfoList == input.AttachmentInfoList ||
                    this.AttachmentInfoList != null &&
                    this.AttachmentInfoList.SequenceEqual(input.AttachmentInfoList)
                ) && 
                (
                    this.ProfessionalRoleInfoList == input.ProfessionalRoleInfoList ||
                    this.ProfessionalRoleInfoList != null &&
                    this.ProfessionalRoleInfoList.SequenceEqual(input.ProfessionalRoleInfoList)
                ) && 
                (
                    this.ChronoInfoList == input.ChronoInfoList ||
                    this.ChronoInfoList != null &&
                    this.ChronoInfoList.SequenceEqual(input.ChronoInfoList)
                ) && 
                (
                    this.VariableInfo == input.VariableInfo ||
                    (this.VariableInfo != null &&
                    this.VariableInfo.Equals(input.VariableInfo))
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
                if (this.TaskInfoList != null)
                    hashCode = hashCode * 59 + this.TaskInfoList.GetHashCode();
                if (this.DocumentInfoList != null)
                    hashCode = hashCode * 59 + this.DocumentInfoList.GetHashCode();
                if (this.NoteInfoList != null)
                    hashCode = hashCode * 59 + this.NoteInfoList.GetHashCode();
                if (this.AttachmentInfoList != null)
                    hashCode = hashCode * 59 + this.AttachmentInfoList.GetHashCode();
                if (this.ProfessionalRoleInfoList != null)
                    hashCode = hashCode * 59 + this.ProfessionalRoleInfoList.GetHashCode();
                if (this.ChronoInfoList != null)
                    hashCode = hashCode * 59 + this.ChronoInfoList.GetHashCode();
                if (this.VariableInfo != null)
                    hashCode = hashCode * 59 + this.VariableInfo.GetHashCode();
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
