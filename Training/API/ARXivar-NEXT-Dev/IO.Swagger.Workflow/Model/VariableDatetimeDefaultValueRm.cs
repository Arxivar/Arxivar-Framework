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
    /// VariableDatetimeDefaultValueRm
    /// </summary>
    [DataContract]
        public partial class VariableDatetimeDefaultValueRm : VariableDefaultValueRm,  IEquatable<VariableDatetimeDefaultValueRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VariableDatetimeDefaultValueRm" /> class.
        /// </summary>
        /// <param name="utcValue">Variable Value.</param>
        public VariableDatetimeDefaultValueRm(DateTime? utcValue = default(DateTime?), int? variableType = default(int?)) : base(variableType)
        {
            this.UtcValue = utcValue;
        }
        
        /// <summary>
        /// Variable Value
        /// </summary>
        /// <value>Variable Value</value>
        [DataMember(Name="utcValue", EmitDefaultValue=false)]
        public DateTime? UtcValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VariableDatetimeDefaultValueRm {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  UtcValue: ").Append(UtcValue).Append("\n");
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
            return this.Equals(input as VariableDatetimeDefaultValueRm);
        }

        /// <summary>
        /// Returns true if VariableDatetimeDefaultValueRm instances are equal
        /// </summary>
        /// <param name="input">Instance of VariableDatetimeDefaultValueRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VariableDatetimeDefaultValueRm input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.UtcValue == input.UtcValue ||
                    (this.UtcValue != null &&
                    this.UtcValue.Equals(input.UtcValue))
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
                if (this.UtcValue != null)
                    hashCode = hashCode * 59 + this.UtcValue.GetHashCode();
                return hashCode;
            }
        }

    }
}
