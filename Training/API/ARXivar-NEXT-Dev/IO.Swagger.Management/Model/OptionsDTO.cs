/* 
 * WebAPI - Area Management
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: management
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
using SwaggerDateConverter = IO.Swagger.Management.Client.SwaggerDateConverter;

namespace IO.Swagger.Management.Model
{
    /// <summary>
    /// Class of arxivar options
    /// </summary>
    [DataContract]
    public partial class OptionsDTO :  IEquatable<OptionsDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OptionsDTO" /> class.
        /// </summary>
        /// <param name="id">Identifier.</param>
        /// <param name="user">User Identifier.</param>
        /// <param name="argument">Argument.</param>
        /// <param name="visible">Visibility.</param>
        /// <param name="sequence">Sequence Number.</param>
        /// <param name="label">Label.</param>
        /// <param name="size">Size.</param>
        /// <param name="order">Possible values:  0: Nessuno  1: Ascendente  2: Descrescente .</param>
        /// <param name="table">Table Name.</param>
        /// <param name="alias">Alias.</param>
        /// <param name="value">Value.</param>
        /// <param name="ldata">Value in datetime format.</param>
        /// <param name="field">Field Name.</param>
        /// <param name="content">Value in stream format.</param>
        public OptionsDTO(int? id = default(int?), int? user = default(int?), string argument = default(string), bool? visible = default(bool?), int? sequence = default(int?), string label = default(string), int? size = default(int?), int? order = default(int?), string table = default(string), string alias = default(string), string value = default(string), DateTime? ldata = default(DateTime?), string field = default(string), byte[] content = default(byte[]))
        {
            this.Id = id;
            this.User = user;
            this.Argument = argument;
            this.Visible = visible;
            this.Sequence = sequence;
            this.Label = label;
            this.Size = size;
            this.Order = order;
            this.Table = table;
            this.Alias = alias;
            this.Value = value;
            this.Ldata = ldata;
            this.Field = field;
            this.Content = content;
        }
        
        /// <summary>
        /// Identifier
        /// </summary>
        /// <value>Identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// User Identifier
        /// </summary>
        /// <value>User Identifier</value>
        [DataMember(Name="user", EmitDefaultValue=false)]
        public int? User { get; set; }

        /// <summary>
        /// Argument
        /// </summary>
        /// <value>Argument</value>
        [DataMember(Name="argument", EmitDefaultValue=false)]
        public string Argument { get; set; }

        /// <summary>
        /// Visibility
        /// </summary>
        /// <value>Visibility</value>
        [DataMember(Name="visible", EmitDefaultValue=false)]
        public bool? Visible { get; set; }

        /// <summary>
        /// Sequence Number
        /// </summary>
        /// <value>Sequence Number</value>
        [DataMember(Name="sequence", EmitDefaultValue=false)]
        public int? Sequence { get; set; }

        /// <summary>
        /// Label
        /// </summary>
        /// <value>Label</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Size
        /// </summary>
        /// <value>Size</value>
        [DataMember(Name="size", EmitDefaultValue=false)]
        public int? Size { get; set; }

        /// <summary>
        /// Possible values:  0: Nessuno  1: Ascendente  2: Descrescente 
        /// </summary>
        /// <value>Possible values:  0: Nessuno  1: Ascendente  2: Descrescente </value>
        [DataMember(Name="order", EmitDefaultValue=false)]
        public int? Order { get; set; }

        /// <summary>
        /// Table Name
        /// </summary>
        /// <value>Table Name</value>
        [DataMember(Name="table", EmitDefaultValue=false)]
        public string Table { get; set; }

        /// <summary>
        /// Alias
        /// </summary>
        /// <value>Alias</value>
        [DataMember(Name="alias", EmitDefaultValue=false)]
        public string Alias { get; set; }

        /// <summary>
        /// Value
        /// </summary>
        /// <value>Value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Value in datetime format
        /// </summary>
        /// <value>Value in datetime format</value>
        [DataMember(Name="ldata", EmitDefaultValue=false)]
        public DateTime? Ldata { get; set; }

        /// <summary>
        /// Field Name
        /// </summary>
        /// <value>Field Name</value>
        [DataMember(Name="field", EmitDefaultValue=false)]
        public string Field { get; set; }

        /// <summary>
        /// Value in stream format
        /// </summary>
        /// <value>Value in stream format</value>
        [DataMember(Name="content", EmitDefaultValue=false)]
        public byte[] Content { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OptionsDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Argument: ").Append(Argument).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  Table: ").Append(Table).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Ldata: ").Append(Ldata).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
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
            return this.Equals(input as OptionsDTO);
        }

        /// <summary>
        /// Returns true if OptionsDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of OptionsDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OptionsDTO input)
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
                    this.User == input.User ||
                    (this.User != null &&
                    this.User.Equals(input.User))
                ) && 
                (
                    this.Argument == input.Argument ||
                    (this.Argument != null &&
                    this.Argument.Equals(input.Argument))
                ) && 
                (
                    this.Visible == input.Visible ||
                    (this.Visible != null &&
                    this.Visible.Equals(input.Visible))
                ) && 
                (
                    this.Sequence == input.Sequence ||
                    (this.Sequence != null &&
                    this.Sequence.Equals(input.Sequence))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Order == input.Order ||
                    (this.Order != null &&
                    this.Order.Equals(input.Order))
                ) && 
                (
                    this.Table == input.Table ||
                    (this.Table != null &&
                    this.Table.Equals(input.Table))
                ) && 
                (
                    this.Alias == input.Alias ||
                    (this.Alias != null &&
                    this.Alias.Equals(input.Alias))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Ldata == input.Ldata ||
                    (this.Ldata != null &&
                    this.Ldata.Equals(input.Ldata))
                ) && 
                (
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
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
                if (this.User != null)
                    hashCode = hashCode * 59 + this.User.GetHashCode();
                if (this.Argument != null)
                    hashCode = hashCode * 59 + this.Argument.GetHashCode();
                if (this.Visible != null)
                    hashCode = hashCode * 59 + this.Visible.GetHashCode();
                if (this.Sequence != null)
                    hashCode = hashCode * 59 + this.Sequence.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Order != null)
                    hashCode = hashCode * 59 + this.Order.GetHashCode();
                if (this.Table != null)
                    hashCode = hashCode * 59 + this.Table.GetHashCode();
                if (this.Alias != null)
                    hashCode = hashCode * 59 + this.Alias.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Ldata != null)
                    hashCode = hashCode * 59 + this.Ldata.GetHashCode();
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.Content != null)
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
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