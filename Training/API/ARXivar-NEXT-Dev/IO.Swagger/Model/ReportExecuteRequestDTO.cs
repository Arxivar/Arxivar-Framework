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
    /// ReportExecuteRequestDTO
    /// </summary>
    [DataContract]
    public partial class ReportExecuteRequestDTO :  IEquatable<ReportExecuteRequestDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReportExecuteRequestDTO" /> class.
        /// </summary>
        /// <param name="identifier">Report Id.</param>
        /// <param name="format">Possible values:  1: Pdf  2: Xps  3: HtmlTable  4: HtmlSpan  5: HtmlDiv  6: Rtf  7: RtfTable  8: RtfFrame  9: RtfWinWord  10: RtfTabbedText  11: Text  12: Excel  13: ExcelXml  14: Excel2007  15: Word2007  16: Xml  17: Csv  18: Dif  19: Sylk  20: ImageGif  21: ImageBmp  22: ImagePng  23: ImageTiff  24: ImageJpeg  25: ImagePcx  26: ImageEmf  27: Mht  28: Dbf  29: Html  30: Ods  31: Odt  32: Ppt2007  33: ImageSvg  34: ImageSvgz .</param>
        /// <param name="parameters">Parameters to input for the execution.</param>
        public ReportExecuteRequestDTO(ReportIdentifier identifier = default(ReportIdentifier), int? format = default(int?), List<ReportParamDTO> parameters = default(List<ReportParamDTO>))
        {
            this.Identifier = identifier;
            this.Format = format;
            this.Parameters = parameters;
        }
        
        /// <summary>
        /// Report Id
        /// </summary>
        /// <value>Report Id</value>
        [DataMember(Name="identifier", EmitDefaultValue=false)]
        public ReportIdentifier Identifier { get; set; }

        /// <summary>
        /// Possible values:  1: Pdf  2: Xps  3: HtmlTable  4: HtmlSpan  5: HtmlDiv  6: Rtf  7: RtfTable  8: RtfFrame  9: RtfWinWord  10: RtfTabbedText  11: Text  12: Excel  13: ExcelXml  14: Excel2007  15: Word2007  16: Xml  17: Csv  18: Dif  19: Sylk  20: ImageGif  21: ImageBmp  22: ImagePng  23: ImageTiff  24: ImageJpeg  25: ImagePcx  26: ImageEmf  27: Mht  28: Dbf  29: Html  30: Ods  31: Odt  32: Ppt2007  33: ImageSvg  34: ImageSvgz 
        /// </summary>
        /// <value>Possible values:  1: Pdf  2: Xps  3: HtmlTable  4: HtmlSpan  5: HtmlDiv  6: Rtf  7: RtfTable  8: RtfFrame  9: RtfWinWord  10: RtfTabbedText  11: Text  12: Excel  13: ExcelXml  14: Excel2007  15: Word2007  16: Xml  17: Csv  18: Dif  19: Sylk  20: ImageGif  21: ImageBmp  22: ImagePng  23: ImageTiff  24: ImageJpeg  25: ImagePcx  26: ImageEmf  27: Mht  28: Dbf  29: Html  30: Ods  31: Odt  32: Ppt2007  33: ImageSvg  34: ImageSvgz </value>
        [DataMember(Name="format", EmitDefaultValue=false)]
        public int? Format { get; set; }

        /// <summary>
        /// Parameters to input for the execution
        /// </summary>
        /// <value>Parameters to input for the execution</value>
        [DataMember(Name="parameters", EmitDefaultValue=false)]
        public List<ReportParamDTO> Parameters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportExecuteRequestDTO {\n");
            sb.Append("  Identifier: ").Append(Identifier).Append("\n");
            sb.Append("  Format: ").Append(Format).Append("\n");
            sb.Append("  Parameters: ").Append(Parameters).Append("\n");
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
            return this.Equals(input as ReportExecuteRequestDTO);
        }

        /// <summary>
        /// Returns true if ReportExecuteRequestDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportExecuteRequestDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportExecuteRequestDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Identifier == input.Identifier ||
                    (this.Identifier != null &&
                    this.Identifier.Equals(input.Identifier))
                ) && 
                (
                    this.Format == input.Format ||
                    (this.Format != null &&
                    this.Format.Equals(input.Format))
                ) && 
                (
                    this.Parameters == input.Parameters ||
                    this.Parameters != null &&
                    this.Parameters.SequenceEqual(input.Parameters)
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
                if (this.Identifier != null)
                    hashCode = hashCode * 59 + this.Identifier.GetHashCode();
                if (this.Format != null)
                    hashCode = hashCode * 59 + this.Format.GetHashCode();
                if (this.Parameters != null)
                    hashCode = hashCode * 59 + this.Parameters.GetHashCode();
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
