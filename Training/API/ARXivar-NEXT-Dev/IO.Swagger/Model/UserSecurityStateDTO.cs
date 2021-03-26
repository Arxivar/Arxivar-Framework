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
    /// UserSecurityStateDTO
    /// </summary>
    [DataContract]
    public partial class UserSecurityStateDTO :  IEquatable<UserSecurityStateDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserSecurityStateDTO" /> class.
        /// </summary>
        /// <param name="id">Identificativo..</param>
        /// <param name="state">Nome dello stato..</param>
        /// <param name="userId">Identificativo utente..</param>
        /// <param name="opt1">Possibilità di modifica del file associato al profilo documentale..</param>
        /// <param name="opt2">Possibilità di modifica del profilo documentale..</param>
        public UserSecurityStateDTO(int? id = default(int?), string state = default(string), int? userId = default(int?), bool? opt1 = default(bool?), bool? opt2 = default(bool?))
        {
            this.Id = id;
            this.State = state;
            this.UserId = userId;
            this.Opt1 = opt1;
            this.Opt2 = opt2;
        }
        
        /// <summary>
        /// Identificativo.
        /// </summary>
        /// <value>Identificativo.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Nome dello stato.
        /// </summary>
        /// <value>Nome dello stato.</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public string State { get; set; }

        /// <summary>
        /// Identificativo utente.
        /// </summary>
        /// <value>Identificativo utente.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public int? UserId { get; set; }

        /// <summary>
        /// Possibilità di modifica del file associato al profilo documentale.
        /// </summary>
        /// <value>Possibilità di modifica del file associato al profilo documentale.</value>
        [DataMember(Name="opt1", EmitDefaultValue=false)]
        public bool? Opt1 { get; set; }

        /// <summary>
        /// Possibilità di modifica del profilo documentale.
        /// </summary>
        /// <value>Possibilità di modifica del profilo documentale.</value>
        [DataMember(Name="opt2", EmitDefaultValue=false)]
        public bool? Opt2 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserSecurityStateDTO {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Opt1: ").Append(Opt1).Append("\n");
            sb.Append("  Opt2: ").Append(Opt2).Append("\n");
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
            return this.Equals(input as UserSecurityStateDTO);
        }

        /// <summary>
        /// Returns true if UserSecurityStateDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of UserSecurityStateDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserSecurityStateDTO input)
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
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Opt1 == input.Opt1 ||
                    (this.Opt1 != null &&
                    this.Opt1.Equals(input.Opt1))
                ) && 
                (
                    this.Opt2 == input.Opt2 ||
                    (this.Opt2 != null &&
                    this.Opt2.Equals(input.Opt2))
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
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Opt1 != null)
                    hashCode = hashCode * 59 + this.Opt1.GetHashCode();
                if (this.Opt2 != null)
                    hashCode = hashCode * 59 + this.Opt2.GetHashCode();
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
