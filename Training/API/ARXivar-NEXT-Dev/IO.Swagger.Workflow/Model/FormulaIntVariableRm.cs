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
    /// FormulaIntVariableRm
    /// </summary>
    [DataContract]
        public partial class FormulaIntVariableRm : FormulaVariableRm,  IEquatable<FormulaIntVariableRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormulaIntVariableRm" /> class.
        /// </summary>
        /// <param name="value">Formula value.</param>
        public FormulaIntVariableRm(int? value = default(int?), Guid? id = default(Guid?), string name = default(string), int? variableType = default(int?)) : base(id, name, variableType)
        {
            this.Value = value;
        }
        
        /// <summary>
        /// Formula value
        /// </summary>
        /// <value>Formula value</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public int? Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormulaIntVariableRm {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as FormulaIntVariableRm);
        }

        /// <summary>
        /// Returns true if FormulaIntVariableRm instances are equal
        /// </summary>
        /// <param name="input">Instance of FormulaIntVariableRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FormulaIntVariableRm input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                int hashCode = base.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }
}
