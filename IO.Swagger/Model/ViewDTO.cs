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
    /// Class of View
    /// </summary>
    [DataContract]
    public partial class ViewDTO :  IEquatable<ViewDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewDTO" /> class.
        /// </summary>
        /// <param name="MaxItems">Max items for result.</param>
        /// <param name="DocumentTypeDescription">Description of Document Type.</param>
        /// <param name="Id">Identifier.</param>
        /// <param name="Description">Description.</param>
        /// <param name="User">Author Identifier.</param>
        /// <param name="UserCompleteName">Author Complete Name.</param>
        /// <param name="DocumentType">Document Type of first level.</param>
        /// <param name="Type2">Document Type of second level.</param>
        /// <param name="Type3">Document Type of third level.</param>
        /// <param name="SelectFields">Select Fields.</param>
        /// <param name="EditFields">Edit Fields.</param>
        /// <param name="LockFields">Uneditable Fields.</param>
        /// <param name="OrderFields">Order Fields.</param>
        /// <param name="ShowFields">Show Fields.</param>
        /// <param name="FormOpen">Opening the search form after running the Arxivar client view..</param>
        /// <param name="AllowEmptyFilterMode">Possible values:  0: Yes  1: No  2: OnDemand .</param>
        /// <param name="ShowGroupsMode">Possible values:  0: No  1: Yes .</param>
        /// <param name="CanExecute">Execute.</param>
        /// <param name="CanUpdate">Edit.</param>
        /// <param name="CanDelete">Delete.</param>
        /// <param name="SearchFilterDto">SearchFilterDto.</param>
        /// <param name="SelectFilterDto">SelectFilterDto.</param>
        public ViewDTO(int? MaxItems = default(int?), string DocumentTypeDescription = default(string), string Id = default(string), string Description = default(string), int? User = default(int?), string UserCompleteName = default(string), int? DocumentType = default(int?), int? Type2 = default(int?), int? Type3 = default(int?), string SelectFields = default(string), string EditFields = default(string), SearchDTO LockFields = default(SearchDTO), string OrderFields = default(string), bool? ShowFields = default(bool?), bool? FormOpen = default(bool?), int? AllowEmptyFilterMode = default(int?), int? ShowGroupsMode = default(int?), bool? CanExecute = default(bool?), bool? CanUpdate = default(bool?), bool? CanDelete = default(bool?), SearchDTO SearchFilterDto = default(SearchDTO), SelectDTO SelectFilterDto = default(SelectDTO))
        {
            this.MaxItems = MaxItems;
            this.DocumentTypeDescription = DocumentTypeDescription;
            this.Id = Id;
            this.Description = Description;
            this.User = User;
            this.UserCompleteName = UserCompleteName;
            this.DocumentType = DocumentType;
            this.Type2 = Type2;
            this.Type3 = Type3;
            this.SelectFields = SelectFields;
            this.EditFields = EditFields;
            this.LockFields = LockFields;
            this.OrderFields = OrderFields;
            this.ShowFields = ShowFields;
            this.FormOpen = FormOpen;
            this.AllowEmptyFilterMode = AllowEmptyFilterMode;
            this.ShowGroupsMode = ShowGroupsMode;
            this.CanExecute = CanExecute;
            this.CanUpdate = CanUpdate;
            this.CanDelete = CanDelete;
            this.SearchFilterDto = SearchFilterDto;
            this.SelectFilterDto = SelectFilterDto;
        }
        
        /// <summary>
        /// Max items for result
        /// </summary>
        /// <value>Max items for result</value>
        [DataMember(Name="maxItems", EmitDefaultValue=false)]
        public int? MaxItems { get; set; }

        /// <summary>
        /// Description of Document Type
        /// </summary>
        /// <value>Description of Document Type</value>
        [DataMember(Name="documentTypeDescription", EmitDefaultValue=false)]
        public string DocumentTypeDescription { get; set; }

        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        /// <value>Description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Author Identifier
        /// </summary>
        /// <value>Author Identifier</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// Author Complete Name
        /// </summary>
        /// <value>Author Complete Name</value>
        [DataMember(Name="userCompleteName", EmitDefaultValue=false)]
        public string UserCompleteName { get; set; }

        /// <summary>
        /// Document Type of first level
        /// </summary>
        /// <value>Document Type of first level</value>
        [DataMember(Name="documentType", EmitDefaultValue=false)]
        public int? DocumentType { get; set; }

        /// <summary>
        /// Document Type of second level
        /// </summary>
        /// <value>Document Type of second level</value>
        [DataMember(Name="type2", EmitDefaultValue=false)]
        public int? Type2 { get; set; }

        /// <summary>
        /// Document Type of third level
        /// </summary>
        /// <value>Document Type of third level</value>
        [DataMember(Name="type3", EmitDefaultValue=false)]
        public int? Type3 { get; set; }

        /// <summary>
        /// Select Fields
        /// </summary>
        /// <value>Select Fields</value>
        [DataMember(Name="selectFields", EmitDefaultValue=false)]
        public string SelectFields { get; set; }

        /// <summary>
        /// Edit Fields
        /// </summary>
        /// <value>Edit Fields</value>
        [DataMember(Name="editFields", EmitDefaultValue=false)]
        public string EditFields { get; set; }

        /// <summary>
        /// Uneditable Fields
        /// </summary>
        /// <value>Uneditable Fields</value>
        [DataMember(Name="lockFields", EmitDefaultValue=false)]
        public SearchDTO LockFields { get; set; }

        /// <summary>
        /// Order Fields
        /// </summary>
        /// <value>Order Fields</value>
        [DataMember(Name="orderFields", EmitDefaultValue=false)]
        public string OrderFields { get; set; }

        /// <summary>
        /// Show Fields
        /// </summary>
        /// <value>Show Fields</value>
        [DataMember(Name="showFields", EmitDefaultValue=false)]
        public bool? ShowFields { get; set; }

        /// <summary>
        /// Opening the search form after running the Arxivar client view.
        /// </summary>
        /// <value>Opening the search form after running the Arxivar client view.</value>
        [DataMember(Name="formOpen", EmitDefaultValue=false)]
        public bool? FormOpen { get; set; }

        /// <summary>
        /// Possible values:  0: Yes  1: No  2: OnDemand 
        /// </summary>
        /// <value>Possible values:  0: Yes  1: No  2: OnDemand </value>
        [DataMember(Name="allowEmptyFilterMode", EmitDefaultValue=false)]
        public int? AllowEmptyFilterMode { get; set; }

        /// <summary>
        /// Possible values:  0: No  1: Yes 
        /// </summary>
        /// <value>Possible values:  0: No  1: Yes </value>
        [DataMember(Name="showGroupsMode", EmitDefaultValue=false)]
        public int? ShowGroupsMode { get; set; }

        /// <summary>
        /// Execute
        /// </summary>
        /// <value>Execute</value>
        [DataMember(Name="canExecute", EmitDefaultValue=false)]
        public bool? CanExecute { get; set; }

        /// <summary>
        /// Edit
        /// </summary>
        /// <value>Edit</value>
        [DataMember(Name="canUpdate", EmitDefaultValue=false)]
        public bool? CanUpdate { get; set; }

        /// <summary>
        /// Delete
        /// </summary>
        /// <value>Delete</value>
        [DataMember(Name="canDelete", EmitDefaultValue=false)]
        public bool? CanDelete { get; set; }

        /// <summary>
        /// Gets or Sets SearchFilterDto
        /// </summary>
        [DataMember(Name="searchFilterDto", EmitDefaultValue=false)]
        public SearchDTO SearchFilterDto { get; set; }

        /// <summary>
        /// Gets or Sets SelectFilterDto
        /// </summary>
        [DataMember(Name="selectFilterDto", EmitDefaultValue=false)]
        public SelectDTO SelectFilterDto { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ViewDTO {\n");
            sb.Append("  MaxItems: ").Append(MaxItems).Append("\n");
            sb.Append("  DocumentTypeDescription: ").Append(DocumentTypeDescription).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  UserCompleteName: ").Append(UserCompleteName).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  Type2: ").Append(Type2).Append("\n");
            sb.Append("  Type3: ").Append(Type3).Append("\n");
            sb.Append("  SelectFields: ").Append(SelectFields).Append("\n");
            sb.Append("  EditFields: ").Append(EditFields).Append("\n");
            sb.Append("  LockFields: ").Append(LockFields).Append("\n");
            sb.Append("  OrderFields: ").Append(OrderFields).Append("\n");
            sb.Append("  ShowFields: ").Append(ShowFields).Append("\n");
            sb.Append("  FormOpen: ").Append(FormOpen).Append("\n");
            sb.Append("  AllowEmptyFilterMode: ").Append(AllowEmptyFilterMode).Append("\n");
            sb.Append("  ShowGroupsMode: ").Append(ShowGroupsMode).Append("\n");
            sb.Append("  CanExecute: ").Append(CanExecute).Append("\n");
            sb.Append("  CanUpdate: ").Append(CanUpdate).Append("\n");
            sb.Append("  CanDelete: ").Append(CanDelete).Append("\n");
            sb.Append("  SearchFilterDto: ").Append(SearchFilterDto).Append("\n");
            sb.Append("  SelectFilterDto: ").Append(SelectFilterDto).Append("\n");
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
            return this.Equals(input as ViewDTO);
        }

        /// <summary>
        /// Returns true if ViewDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ViewDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViewDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxItems == input.MaxItems ||
                    (this.MaxItems != null &&
                    this.MaxItems.Equals(input.MaxItems))
                ) && 
                (
                    this.DocumentTypeDescription == input.DocumentTypeDescription ||
                    (this.DocumentTypeDescription != null &&
                    this.DocumentTypeDescription.Equals(input.DocumentTypeDescription))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.UserCompleteName == input.UserCompleteName ||
                    (this.UserCompleteName != null &&
                    this.UserCompleteName.Equals(input.UserCompleteName))
                ) && 
                (
                    this.DocumentType == input.DocumentType ||
                    (this.DocumentType != null &&
                    this.DocumentType.Equals(input.DocumentType))
                ) && 
                (
                    this.Type2 == input.Type2 ||
                    (this.Type2 != null &&
                    this.Type2.Equals(input.Type2))
                ) && 
                (
                    this.Type3 == input.Type3 ||
                    (this.Type3 != null &&
                    this.Type3.Equals(input.Type3))
                ) && 
                (
                    this.SelectFields == input.SelectFields ||
                    (this.SelectFields != null &&
                    this.SelectFields.Equals(input.SelectFields))
                ) && 
                (
                    this.EditFields == input.EditFields ||
                    (this.EditFields != null &&
                    this.EditFields.Equals(input.EditFields))
                ) && 
                (
                    this.LockFields == input.LockFields ||
                    (this.LockFields != null &&
                    this.LockFields.Equals(input.LockFields))
                ) && 
                (
                    this.OrderFields == input.OrderFields ||
                    (this.OrderFields != null &&
                    this.OrderFields.Equals(input.OrderFields))
                ) && 
                (
                    this.ShowFields == input.ShowFields ||
                    (this.ShowFields != null &&
                    this.ShowFields.Equals(input.ShowFields))
                ) && 
                (
                    this.FormOpen == input.FormOpen ||
                    (this.FormOpen != null &&
                    this.FormOpen.Equals(input.FormOpen))
                ) && 
                (
                    this.AllowEmptyFilterMode == input.AllowEmptyFilterMode ||
                    (this.AllowEmptyFilterMode != null &&
                    this.AllowEmptyFilterMode.Equals(input.AllowEmptyFilterMode))
                ) && 
                (
                    this.ShowGroupsMode == input.ShowGroupsMode ||
                    (this.ShowGroupsMode != null &&
                    this.ShowGroupsMode.Equals(input.ShowGroupsMode))
                ) && 
                (
                    this.CanExecute == input.CanExecute ||
                    (this.CanExecute != null &&
                    this.CanExecute.Equals(input.CanExecute))
                ) && 
                (
                    this.CanUpdate == input.CanUpdate ||
                    (this.CanUpdate != null &&
                    this.CanUpdate.Equals(input.CanUpdate))
                ) && 
                (
                    this.CanDelete == input.CanDelete ||
                    (this.CanDelete != null &&
                    this.CanDelete.Equals(input.CanDelete))
                ) && 
                (
                    this.SearchFilterDto == input.SearchFilterDto ||
                    (this.SearchFilterDto != null &&
                    this.SearchFilterDto.Equals(input.SearchFilterDto))
                ) && 
                (
                    this.SelectFilterDto == input.SelectFilterDto ||
                    (this.SelectFilterDto != null &&
                    this.SelectFilterDto.Equals(input.SelectFilterDto))
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
                if (this.MaxItems != null)
                    hashCode = hashCode * 59 + this.MaxItems.GetHashCode();
                if (this.DocumentTypeDescription != null)
                    hashCode = hashCode * 59 + this.DocumentTypeDescription.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.UserCompleteName != null)
                    hashCode = hashCode * 59 + this.UserCompleteName.GetHashCode();
                if (this.DocumentType != null)
                    hashCode = hashCode * 59 + this.DocumentType.GetHashCode();
                if (this.Type2 != null)
                    hashCode = hashCode * 59 + this.Type2.GetHashCode();
                if (this.Type3 != null)
                    hashCode = hashCode * 59 + this.Type3.GetHashCode();
                if (this.SelectFields != null)
                    hashCode = hashCode * 59 + this.SelectFields.GetHashCode();
                if (this.EditFields != null)
                    hashCode = hashCode * 59 + this.EditFields.GetHashCode();
                if (this.LockFields != null)
                    hashCode = hashCode * 59 + this.LockFields.GetHashCode();
                if (this.OrderFields != null)
                    hashCode = hashCode * 59 + this.OrderFields.GetHashCode();
                if (this.ShowFields != null)
                    hashCode = hashCode * 59 + this.ShowFields.GetHashCode();
                if (this.FormOpen != null)
                    hashCode = hashCode * 59 + this.FormOpen.GetHashCode();
                if (this.AllowEmptyFilterMode != null)
                    hashCode = hashCode * 59 + this.AllowEmptyFilterMode.GetHashCode();
                if (this.ShowGroupsMode != null)
                    hashCode = hashCode * 59 + this.ShowGroupsMode.GetHashCode();
                if (this.CanExecute != null)
                    hashCode = hashCode * 59 + this.CanExecute.GetHashCode();
                if (this.CanUpdate != null)
                    hashCode = hashCode * 59 + this.CanUpdate.GetHashCode();
                if (this.CanDelete != null)
                    hashCode = hashCode * 59 + this.CanDelete.GetHashCode();
                if (this.SearchFilterDto != null)
                    hashCode = hashCode * 59 + this.SearchFilterDto.GetHashCode();
                if (this.SelectFilterDto != null)
                    hashCode = hashCode * 59 + this.SelectFilterDto.GetHashCode();
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
