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
    /// Class of options for editing profile
    /// </summary>
    [DataContract]
    public partial class EditProfileOptionsDTO :  IEquatable<EditProfileOptionsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditProfileOptionsDTO" /> class.
        /// </summary>
        /// <param name="CanLoadPredefinedProfile">Load Predefined Profile.</param>
        /// <param name="CanUnlockProfile">Unlock Profile.</param>
        /// <param name="CanUnlockProfileMessage">Unlock Profile Message.</param>
        /// <param name="CanSwitch">Enabled Switch.</param>
        /// <param name="AllowEditPaFields">Editing fields of Public Amministration (PA) information.</param>
        /// <param name="WorkflowSubjected">Workflow in progress.</param>
        public EditProfileOptionsDTO(bool? CanLoadPredefinedProfile = default(bool?), bool? CanUnlockProfile = default(bool?), string CanUnlockProfileMessage = default(string), bool? CanSwitch = default(bool?), bool? AllowEditPaFields = default(bool?), bool? WorkflowSubjected = default(bool?))
        {
            this.CanLoadPredefinedProfile = CanLoadPredefinedProfile;
            this.CanUnlockProfile = CanUnlockProfile;
            this.CanUnlockProfileMessage = CanUnlockProfileMessage;
            this.CanSwitch = CanSwitch;
            this.AllowEditPaFields = AllowEditPaFields;
            this.WorkflowSubjected = WorkflowSubjected;
        }
        
        /// <summary>
        /// Load Predefined Profile
        /// </summary>
        /// <value>Load Predefined Profile</value>
        [DataMember(Name="canLoadPredefinedProfile", EmitDefaultValue=false)]
        public bool? CanLoadPredefinedProfile { get; set; }

        /// <summary>
        /// Unlock Profile
        /// </summary>
        /// <value>Unlock Profile</value>
        [DataMember(Name="canUnlockProfile", EmitDefaultValue=false)]
        public bool? CanUnlockProfile { get; set; }

        /// <summary>
        /// Unlock Profile Message
        /// </summary>
        /// <value>Unlock Profile Message</value>
        [DataMember(Name="canUnlockProfileMessage", EmitDefaultValue=false)]
        public string CanUnlockProfileMessage { get; set; }

        /// <summary>
        /// Enabled Switch
        /// </summary>
        /// <value>Enabled Switch</value>
        [DataMember(Name="canSwitch", EmitDefaultValue=false)]
        public bool? CanSwitch { get; set; }

        /// <summary>
        /// Editing fields of Public Amministration (PA) information
        /// </summary>
        /// <value>Editing fields of Public Amministration (PA) information</value>
        [DataMember(Name="allowEditPaFields", EmitDefaultValue=false)]
        public bool? AllowEditPaFields { get; set; }

        /// <summary>
        /// Workflow in progress
        /// </summary>
        /// <value>Workflow in progress</value>
        [DataMember(Name="workflowSubjected", EmitDefaultValue=false)]
        public bool? WorkflowSubjected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditProfileOptionsDTO {\n");
            sb.Append("  CanLoadPredefinedProfile: ").Append(CanLoadPredefinedProfile).Append("\n");
            sb.Append("  CanUnlockProfile: ").Append(CanUnlockProfile).Append("\n");
            sb.Append("  CanUnlockProfileMessage: ").Append(CanUnlockProfileMessage).Append("\n");
            sb.Append("  CanSwitch: ").Append(CanSwitch).Append("\n");
            sb.Append("  AllowEditPaFields: ").Append(AllowEditPaFields).Append("\n");
            sb.Append("  WorkflowSubjected: ").Append(WorkflowSubjected).Append("\n");
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
            return this.Equals(input as EditProfileOptionsDTO);
        }

        /// <summary>
        /// Returns true if EditProfileOptionsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of EditProfileOptionsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EditProfileOptionsDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CanLoadPredefinedProfile == input.CanLoadPredefinedProfile ||
                    (this.CanLoadPredefinedProfile != null &&
                    this.CanLoadPredefinedProfile.Equals(input.CanLoadPredefinedProfile))
                ) && 
                (
                    this.CanUnlockProfile == input.CanUnlockProfile ||
                    (this.CanUnlockProfile != null &&
                    this.CanUnlockProfile.Equals(input.CanUnlockProfile))
                ) && 
                (
                    this.CanUnlockProfileMessage == input.CanUnlockProfileMessage ||
                    (this.CanUnlockProfileMessage != null &&
                    this.CanUnlockProfileMessage.Equals(input.CanUnlockProfileMessage))
                ) && 
                (
                    this.CanSwitch == input.CanSwitch ||
                    (this.CanSwitch != null &&
                    this.CanSwitch.Equals(input.CanSwitch))
                ) && 
                (
                    this.AllowEditPaFields == input.AllowEditPaFields ||
                    (this.AllowEditPaFields != null &&
                    this.AllowEditPaFields.Equals(input.AllowEditPaFields))
                ) && 
                (
                    this.WorkflowSubjected == input.WorkflowSubjected ||
                    (this.WorkflowSubjected != null &&
                    this.WorkflowSubjected.Equals(input.WorkflowSubjected))
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
                if (this.CanLoadPredefinedProfile != null)
                    hashCode = hashCode * 59 + this.CanLoadPredefinedProfile.GetHashCode();
                if (this.CanUnlockProfile != null)
                    hashCode = hashCode * 59 + this.CanUnlockProfile.GetHashCode();
                if (this.CanUnlockProfileMessage != null)
                    hashCode = hashCode * 59 + this.CanUnlockProfileMessage.GetHashCode();
                if (this.CanSwitch != null)
                    hashCode = hashCode * 59 + this.CanSwitch.GetHashCode();
                if (this.AllowEditPaFields != null)
                    hashCode = hashCode * 59 + this.AllowEditPaFields.GetHashCode();
                if (this.WorkflowSubjected != null)
                    hashCode = hashCode * 59 + this.WorkflowSubjected.GetHashCode();
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
