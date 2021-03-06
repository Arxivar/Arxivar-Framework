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
    /// Describes a profile formula field
    /// </summary>
    [DataContract]
        public partial class ProfileFormulaFieldRm :  IEquatable<ProfileFormulaFieldRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProfileFormulaFieldRm" /> class.
        /// </summary>
        /// <param name="value">The value of the profile field.</param>
        /// <param name="label">The label of the profile field.</param>
        /// <param name="fieldType">Describes the profile field type [0&#x3D;Int, 1&#x3D;String, 2&#x3D;Datetime, 3&#x3D;Decimal, 4&#x3D;Boolean, 5&#x3D;Multivalue].</param>
        /// <param name="groupType">Describes the profile group type [0&#x3D;Standard, 1&#x3D;Additional, 2&#x3D;System, 3&#x3D;AuthorityData].</param>
        public ProfileFormulaFieldRm(string value = default(string), string label = default(string), int? fieldType = default(int?), int? groupType = default(int?))
        {
            this.Value = value;
            this.Label = label;
            this.FieldType = fieldType;
            this.GroupType = groupType;
        }
        
        /// <summary>
        /// The value of the profile field
        /// </summary>
        /// <value>The value of the profile field</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// The label of the profile field
        /// </summary>
        /// <value>The label of the profile field</value>
        [DataMember(Name="label", EmitDefaultValue=false)]
        public string Label { get; set; }

        /// <summary>
        /// Describes the profile field type [0&#x3D;Int, 1&#x3D;String, 2&#x3D;Datetime, 3&#x3D;Decimal, 4&#x3D;Boolean, 5&#x3D;Multivalue]
        /// </summary>
        /// <value>Describes the profile field type [0&#x3D;Int, 1&#x3D;String, 2&#x3D;Datetime, 3&#x3D;Decimal, 4&#x3D;Boolean, 5&#x3D;Multivalue]</value>
        [DataMember(Name="fieldType", EmitDefaultValue=false)]
        public int? FieldType { get; set; }

        /// <summary>
        /// Describes the profile group type [0&#x3D;Standard, 1&#x3D;Additional, 2&#x3D;System, 3&#x3D;AuthorityData]
        /// </summary>
        /// <value>Describes the profile group type [0&#x3D;Standard, 1&#x3D;Additional, 2&#x3D;System, 3&#x3D;AuthorityData]</value>
        [DataMember(Name="groupType", EmitDefaultValue=false)]
        public int? GroupType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProfileFormulaFieldRm {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  FieldType: ").Append(FieldType).Append("\n");
            sb.Append("  GroupType: ").Append(GroupType).Append("\n");
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
            return this.Equals(input as ProfileFormulaFieldRm);
        }

        /// <summary>
        /// Returns true if ProfileFormulaFieldRm instances are equal
        /// </summary>
        /// <param name="input">Instance of ProfileFormulaFieldRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProfileFormulaFieldRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Label == input.Label ||
                    (this.Label != null &&
                    this.Label.Equals(input.Label))
                ) && 
                (
                    this.FieldType == input.FieldType ||
                    (this.FieldType != null &&
                    this.FieldType.Equals(input.FieldType))
                ) && 
                (
                    this.GroupType == input.GroupType ||
                    (this.GroupType != null &&
                    this.GroupType.Equals(input.GroupType))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Label != null)
                    hashCode = hashCode * 59 + this.Label.GetHashCode();
                if (this.FieldType != null)
                    hashCode = hashCode * 59 + this.FieldType.GetHashCode();
                if (this.GroupType != null)
                    hashCode = hashCode * 59 + this.GroupType.GetHashCode();
                return hashCode;
            }
        }

    }
}
