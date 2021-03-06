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
    /// Class of barcode settings
    /// </summary>
    [DataContract]
    public partial class BarcodeUserSettingsDto :  IEquatable<BarcodeUserSettingsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarcodeUserSettingsDto" /> class.
        /// </summary>
        /// <param name="ActivateUserSettings">Activate User.</param>
        /// <param name="BarcodePrintMode">Possible values:  0: Client  1: Server  2: ClientFile  3: TerminalServer .</param>
        /// <param name="BarcodePrintSettings">Print Settings.</param>
        /// <param name="BarcodeAttachmentPrintOffsetX">X Offset.</param>
        /// <param name="BarcodeAttachmentPrintOffsetY">Y Offset.</param>
        /// <param name="PrinterMode">Possible values:  0: EPL2  1: POS  2: OTHER .</param>
        public BarcodeUserSettingsDto(bool? ActivateUserSettings = default(bool?), int? BarcodePrintMode = default(int?), string BarcodePrintSettings = default(string), int? BarcodeAttachmentPrintOffsetX = default(int?), int? BarcodeAttachmentPrintOffsetY = default(int?), int? PrinterMode = default(int?))
        {
            this.ActivateUserSettings = ActivateUserSettings;
            this.BarcodePrintMode = BarcodePrintMode;
            this.BarcodePrintSettings = BarcodePrintSettings;
            this.BarcodeAttachmentPrintOffsetX = BarcodeAttachmentPrintOffsetX;
            this.BarcodeAttachmentPrintOffsetY = BarcodeAttachmentPrintOffsetY;
            this.PrinterMode = PrinterMode;
        }
        
        /// <summary>
        /// Activate User
        /// </summary>
        /// <value>Activate User</value>
        [DataMember(Name="activateUserSettings", EmitDefaultValue=false)]
        public bool? ActivateUserSettings { get; set; }

        /// <summary>
        /// Possible values:  0: Client  1: Server  2: ClientFile  3: TerminalServer 
        /// </summary>
        /// <value>Possible values:  0: Client  1: Server  2: ClientFile  3: TerminalServer </value>
        [DataMember(Name="barcodePrintMode", EmitDefaultValue=false)]
        public int? BarcodePrintMode { get; set; }

        /// <summary>
        /// Print Settings
        /// </summary>
        /// <value>Print Settings</value>
        [DataMember(Name="barcodePrintSettings", EmitDefaultValue=false)]
        public string BarcodePrintSettings { get; set; }

        /// <summary>
        /// X Offset
        /// </summary>
        /// <value>X Offset</value>
        [DataMember(Name="barcodeAttachmentPrintOffsetX", EmitDefaultValue=false)]
        public int? BarcodeAttachmentPrintOffsetX { get; set; }

        /// <summary>
        /// Y Offset
        /// </summary>
        /// <value>Y Offset</value>
        [DataMember(Name="barcodeAttachmentPrintOffsetY", EmitDefaultValue=false)]
        public int? BarcodeAttachmentPrintOffsetY { get; set; }

        /// <summary>
        /// Possible values:  0: EPL2  1: POS  2: OTHER 
        /// </summary>
        /// <value>Possible values:  0: EPL2  1: POS  2: OTHER </value>
        [DataMember(Name="printerMode", EmitDefaultValue=false)]
        public int? PrinterMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BarcodeUserSettingsDto {\n");
            sb.Append("  ActivateUserSettings: ").Append(ActivateUserSettings).Append("\n");
            sb.Append("  BarcodePrintMode: ").Append(BarcodePrintMode).Append("\n");
            sb.Append("  BarcodePrintSettings: ").Append(BarcodePrintSettings).Append("\n");
            sb.Append("  BarcodeAttachmentPrintOffsetX: ").Append(BarcodeAttachmentPrintOffsetX).Append("\n");
            sb.Append("  BarcodeAttachmentPrintOffsetY: ").Append(BarcodeAttachmentPrintOffsetY).Append("\n");
            sb.Append("  PrinterMode: ").Append(PrinterMode).Append("\n");
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
            return this.Equals(input as BarcodeUserSettingsDto);
        }

        /// <summary>
        /// Returns true if BarcodeUserSettingsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BarcodeUserSettingsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BarcodeUserSettingsDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActivateUserSettings == input.ActivateUserSettings ||
                    (this.ActivateUserSettings != null &&
                    this.ActivateUserSettings.Equals(input.ActivateUserSettings))
                ) && 
                (
                    this.BarcodePrintMode == input.BarcodePrintMode ||
                    (this.BarcodePrintMode != null &&
                    this.BarcodePrintMode.Equals(input.BarcodePrintMode))
                ) && 
                (
                    this.BarcodePrintSettings == input.BarcodePrintSettings ||
                    (this.BarcodePrintSettings != null &&
                    this.BarcodePrintSettings.Equals(input.BarcodePrintSettings))
                ) && 
                (
                    this.BarcodeAttachmentPrintOffsetX == input.BarcodeAttachmentPrintOffsetX ||
                    (this.BarcodeAttachmentPrintOffsetX != null &&
                    this.BarcodeAttachmentPrintOffsetX.Equals(input.BarcodeAttachmentPrintOffsetX))
                ) && 
                (
                    this.BarcodeAttachmentPrintOffsetY == input.BarcodeAttachmentPrintOffsetY ||
                    (this.BarcodeAttachmentPrintOffsetY != null &&
                    this.BarcodeAttachmentPrintOffsetY.Equals(input.BarcodeAttachmentPrintOffsetY))
                ) && 
                (
                    this.PrinterMode == input.PrinterMode ||
                    (this.PrinterMode != null &&
                    this.PrinterMode.Equals(input.PrinterMode))
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
                if (this.ActivateUserSettings != null)
                    hashCode = hashCode * 59 + this.ActivateUserSettings.GetHashCode();
                if (this.BarcodePrintMode != null)
                    hashCode = hashCode * 59 + this.BarcodePrintMode.GetHashCode();
                if (this.BarcodePrintSettings != null)
                    hashCode = hashCode * 59 + this.BarcodePrintSettings.GetHashCode();
                if (this.BarcodeAttachmentPrintOffsetX != null)
                    hashCode = hashCode * 59 + this.BarcodeAttachmentPrintOffsetX.GetHashCode();
                if (this.BarcodeAttachmentPrintOffsetY != null)
                    hashCode = hashCode * 59 + this.BarcodeAttachmentPrintOffsetY.GetHashCode();
                if (this.PrinterMode != null)
                    hashCode = hashCode * 59 + this.PrinterMode.GetHashCode();
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
