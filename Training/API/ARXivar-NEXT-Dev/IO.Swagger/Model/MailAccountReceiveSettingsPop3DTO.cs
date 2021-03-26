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
    /// POP3 Settings
    /// </summary>
    [DataContract]
    public partial class MailAccountReceiveSettingsPop3DTO :  IEquatable<MailAccountReceiveSettingsPop3DTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MailAccountReceiveSettingsPop3DTO" /> class.
        /// </summary>
        /// <param name="server">Server address.</param>
        /// <param name="username">Username.</param>
        /// <param name="password">Password.</param>
        /// <param name="port">Port.</param>
        /// <param name="ssl">SSL.</param>
        /// <param name="passwordProtection">Boolean indicating whether to use the password protection (SPA).</param>
        /// <param name="deleteEmailMode">Possible values:  0: None  1: Immediately  2: AfterNumDays .</param>
        /// <param name="numDayDelete">Number of days before deleting the message if DeleteEmailMode is set to AfterNumDays.</param>
        /// <param name="pecSubject">Possible values:  0: Unread  1: Overwrite  2: DoNotOverwrite .</param>
        /// <param name="pecSender">Possible values:  0: Unread  1: Overwrite  2: DoNotOverwrite .</param>
        /// <param name="mapping">Fields mapping.</param>
        public MailAccountReceiveSettingsPop3DTO(string server = default(string), string username = default(string), string password = default(string), int? port = default(int?), bool? ssl = default(bool?), bool? passwordProtection = default(bool?), int? deleteEmailMode = default(int?), int? numDayDelete = default(int?), int? pecSubject = default(int?), int? pecSender = default(int?), MailAccountStoreSettingsDTO mapping = default(MailAccountStoreSettingsDTO))
        {
            this.Server = server;
            this.Username = username;
            this.Password = password;
            this.Port = port;
            this.Ssl = ssl;
            this.PasswordProtection = passwordProtection;
            this.DeleteEmailMode = deleteEmailMode;
            this.NumDayDelete = numDayDelete;
            this.PecSubject = pecSubject;
            this.PecSender = pecSender;
            this.Mapping = mapping;
        }
        
        /// <summary>
        /// Server address
        /// </summary>
        /// <value>Server address</value>
        [DataMember(Name="server", EmitDefaultValue=false)]
        public string Server { get; set; }

        /// <summary>
        /// Username
        /// </summary>
        /// <value>Username</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Password
        /// </summary>
        /// <value>Password</value>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Port
        /// </summary>
        /// <value>Port</value>
        [DataMember(Name="port", EmitDefaultValue=false)]
        public int? Port { get; set; }

        /// <summary>
        /// SSL
        /// </summary>
        /// <value>SSL</value>
        [DataMember(Name="ssl", EmitDefaultValue=false)]
        public bool? Ssl { get; set; }

        /// <summary>
        /// Boolean indicating whether to use the password protection (SPA)
        /// </summary>
        /// <value>Boolean indicating whether to use the password protection (SPA)</value>
        [DataMember(Name="passwordProtection", EmitDefaultValue=false)]
        public bool? PasswordProtection { get; set; }

        /// <summary>
        /// Possible values:  0: None  1: Immediately  2: AfterNumDays 
        /// </summary>
        /// <value>Possible values:  0: None  1: Immediately  2: AfterNumDays </value>
        [DataMember(Name="deleteEmailMode", EmitDefaultValue=false)]
        public int? DeleteEmailMode { get; set; }

        /// <summary>
        /// Number of days before deleting the message if DeleteEmailMode is set to AfterNumDays
        /// </summary>
        /// <value>Number of days before deleting the message if DeleteEmailMode is set to AfterNumDays</value>
        [DataMember(Name="numDayDelete", EmitDefaultValue=false)]
        public int? NumDayDelete { get; set; }

        /// <summary>
        /// Possible values:  0: Unread  1: Overwrite  2: DoNotOverwrite 
        /// </summary>
        /// <value>Possible values:  0: Unread  1: Overwrite  2: DoNotOverwrite </value>
        [DataMember(Name="pecSubject", EmitDefaultValue=false)]
        public int? PecSubject { get; set; }

        /// <summary>
        /// Possible values:  0: Unread  1: Overwrite  2: DoNotOverwrite 
        /// </summary>
        /// <value>Possible values:  0: Unread  1: Overwrite  2: DoNotOverwrite </value>
        [DataMember(Name="pecSender", EmitDefaultValue=false)]
        public int? PecSender { get; set; }

        /// <summary>
        /// Fields mapping
        /// </summary>
        /// <value>Fields mapping</value>
        [DataMember(Name="mapping", EmitDefaultValue=false)]
        public MailAccountStoreSettingsDTO Mapping { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailAccountReceiveSettingsPop3DTO {\n");
            sb.Append("  Server: ").Append(Server).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Port: ").Append(Port).Append("\n");
            sb.Append("  Ssl: ").Append(Ssl).Append("\n");
            sb.Append("  PasswordProtection: ").Append(PasswordProtection).Append("\n");
            sb.Append("  DeleteEmailMode: ").Append(DeleteEmailMode).Append("\n");
            sb.Append("  NumDayDelete: ").Append(NumDayDelete).Append("\n");
            sb.Append("  PecSubject: ").Append(PecSubject).Append("\n");
            sb.Append("  PecSender: ").Append(PecSender).Append("\n");
            sb.Append("  Mapping: ").Append(Mapping).Append("\n");
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
            return this.Equals(input as MailAccountReceiveSettingsPop3DTO);
        }

        /// <summary>
        /// Returns true if MailAccountReceiveSettingsPop3DTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MailAccountReceiveSettingsPop3DTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MailAccountReceiveSettingsPop3DTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Server == input.Server ||
                    (this.Server != null &&
                    this.Server.Equals(input.Server))
                ) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && 
                (
                    this.Port == input.Port ||
                    (this.Port != null &&
                    this.Port.Equals(input.Port))
                ) && 
                (
                    this.Ssl == input.Ssl ||
                    (this.Ssl != null &&
                    this.Ssl.Equals(input.Ssl))
                ) && 
                (
                    this.PasswordProtection == input.PasswordProtection ||
                    (this.PasswordProtection != null &&
                    this.PasswordProtection.Equals(input.PasswordProtection))
                ) && 
                (
                    this.DeleteEmailMode == input.DeleteEmailMode ||
                    (this.DeleteEmailMode != null &&
                    this.DeleteEmailMode.Equals(input.DeleteEmailMode))
                ) && 
                (
                    this.NumDayDelete == input.NumDayDelete ||
                    (this.NumDayDelete != null &&
                    this.NumDayDelete.Equals(input.NumDayDelete))
                ) && 
                (
                    this.PecSubject == input.PecSubject ||
                    (this.PecSubject != null &&
                    this.PecSubject.Equals(input.PecSubject))
                ) && 
                (
                    this.PecSender == input.PecSender ||
                    (this.PecSender != null &&
                    this.PecSender.Equals(input.PecSender))
                ) && 
                (
                    this.Mapping == input.Mapping ||
                    (this.Mapping != null &&
                    this.Mapping.Equals(input.Mapping))
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
                if (this.Server != null)
                    hashCode = hashCode * 59 + this.Server.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Port != null)
                    hashCode = hashCode * 59 + this.Port.GetHashCode();
                if (this.Ssl != null)
                    hashCode = hashCode * 59 + this.Ssl.GetHashCode();
                if (this.PasswordProtection != null)
                    hashCode = hashCode * 59 + this.PasswordProtection.GetHashCode();
                if (this.DeleteEmailMode != null)
                    hashCode = hashCode * 59 + this.DeleteEmailMode.GetHashCode();
                if (this.NumDayDelete != null)
                    hashCode = hashCode * 59 + this.NumDayDelete.GetHashCode();
                if (this.PecSubject != null)
                    hashCode = hashCode * 59 + this.PecSubject.GetHashCode();
                if (this.PecSender != null)
                    hashCode = hashCode * 59 + this.PecSender.GetHashCode();
                if (this.Mapping != null)
                    hashCode = hashCode * 59 + this.Mapping.GetHashCode();
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