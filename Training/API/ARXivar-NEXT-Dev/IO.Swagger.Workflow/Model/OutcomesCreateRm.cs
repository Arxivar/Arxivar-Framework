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
    /// Oucome create model
    /// </summary>
    [DataContract]
        public partial class OutcomesCreateRm :  IEquatable<OutcomesCreateRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OutcomesCreateRm" /> class.
        /// </summary>
        /// <param name="name">Outcome name (required).</param>
        /// <param name="iconCssClass">Outcome icon (required).</param>
        /// <param name="outcomeGroupId">Outcome group identifier.</param>
        /// <param name="descriptions">List of translation of the outcome descriptions.</param>
        public OutcomesCreateRm(string name = default(string), string iconCssClass = default(string), Guid? outcomeGroupId = default(Guid?), List<MultiLanguageValueRm> descriptions = default(List<MultiLanguageValueRm>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for OutcomesCreateRm and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "iconCssClass" is required (not null)
            if (iconCssClass == null)
            {
                throw new InvalidDataException("iconCssClass is a required property for OutcomesCreateRm and cannot be null");
            }
            else
            {
                this.IconCssClass = iconCssClass;
            }
            this.OutcomeGroupId = outcomeGroupId;
            this.Descriptions = descriptions;
        }
        
        /// <summary>
        /// Outcome name
        /// </summary>
        /// <value>Outcome name</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Outcome icon
        /// </summary>
        /// <value>Outcome icon</value>
        [DataMember(Name="iconCssClass", EmitDefaultValue=false)]
        public string IconCssClass { get; set; }

        /// <summary>
        /// Outcome group identifier
        /// </summary>
        /// <value>Outcome group identifier</value>
        [DataMember(Name="outcomeGroupId", EmitDefaultValue=false)]
        public Guid? OutcomeGroupId { get; set; }

        /// <summary>
        /// List of translation of the outcome descriptions
        /// </summary>
        /// <value>List of translation of the outcome descriptions</value>
        [DataMember(Name="descriptions", EmitDefaultValue=false)]
        public List<MultiLanguageValueRm> Descriptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OutcomesCreateRm {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IconCssClass: ").Append(IconCssClass).Append("\n");
            sb.Append("  OutcomeGroupId: ").Append(OutcomeGroupId).Append("\n");
            sb.Append("  Descriptions: ").Append(Descriptions).Append("\n");
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
            return this.Equals(input as OutcomesCreateRm);
        }

        /// <summary>
        /// Returns true if OutcomesCreateRm instances are equal
        /// </summary>
        /// <param name="input">Instance of OutcomesCreateRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OutcomesCreateRm input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IconCssClass == input.IconCssClass ||
                    (this.IconCssClass != null &&
                    this.IconCssClass.Equals(input.IconCssClass))
                ) && 
                (
                    this.OutcomeGroupId == input.OutcomeGroupId ||
                    (this.OutcomeGroupId != null &&
                    this.OutcomeGroupId.Equals(input.OutcomeGroupId))
                ) && 
                (
                    this.Descriptions == input.Descriptions ||
                    this.Descriptions != null &&
                    input.Descriptions != null &&
                    this.Descriptions.SequenceEqual(input.Descriptions)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IconCssClass != null)
                    hashCode = hashCode * 59 + this.IconCssClass.GetHashCode();
                if (this.OutcomeGroupId != null)
                    hashCode = hashCode * 59 + this.OutcomeGroupId.GetHashCode();
                if (this.Descriptions != null)
                    hashCode = hashCode * 59 + this.Descriptions.GetHashCode();
                return hashCode;
            }
        }

    }
}
