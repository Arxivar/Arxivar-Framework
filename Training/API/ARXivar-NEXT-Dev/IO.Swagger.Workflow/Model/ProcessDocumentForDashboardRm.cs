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
    /// Process documento information for dashboard
    /// </summary>
    [DataContract]
        public partial class ProcessDocumentForDashboardRm :  IEquatable<ProcessDocumentForDashboardRm>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessDocumentForDashboardRm" /> class.
        /// </summary>
        /// <param name="id">Process document identifier.</param>
        /// <param name="documentKind">Process document kind [0&#x3D;Primary, 1&#x3D;Secondary, 2&#x3D;Attachment].</param>
        /// <param name="filename">File name.</param>
        /// <param name="toSend">Defines if the process document can be sent.</param>
        /// <param name="isLocal">Defines if the process document is in the edit buffer.</param>
        /// <param name="info">info.</param>
        /// <param name="arxDocInfo">arxDocInfo.</param>
        public ProcessDocumentForDashboardRm(Guid? id = default(Guid?), int? documentKind = default(int?), string filename = default(string), bool? toSend = default(bool?), bool? isLocal = default(bool?), RecordInfoRm info = default(RecordInfoRm), ARXivarDocumentInfoRm arxDocInfo = default(ARXivarDocumentInfoRm))
        {
            this.Id = id;
            this.DocumentKind = documentKind;
            this.Filename = filename;
            this.ToSend = toSend;
            this.IsLocal = isLocal;
            this.Info = info;
            this.ArxDocInfo = arxDocInfo;
        }
        
        /// <summary>
        /// Process document identifier
        /// </summary>
        /// <value>Process document identifier</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public Guid? Id { get; set; }

        /// <summary>
        /// Process document kind [0&#x3D;Primary, 1&#x3D;Secondary, 2&#x3D;Attachment]
        /// </summary>
        /// <value>Process document kind [0&#x3D;Primary, 1&#x3D;Secondary, 2&#x3D;Attachment]</value>
        [DataMember(Name="documentKind", EmitDefaultValue=false)]
        public int? DocumentKind { get; set; }

        /// <summary>
        /// File name
        /// </summary>
        /// <value>File name</value>
        [DataMember(Name="filename", EmitDefaultValue=false)]
        public string Filename { get; set; }

        /// <summary>
        /// Defines if the process document can be sent
        /// </summary>
        /// <value>Defines if the process document can be sent</value>
        [DataMember(Name="toSend", EmitDefaultValue=false)]
        public bool? ToSend { get; set; }

        /// <summary>
        /// Defines if the process document is in the edit buffer
        /// </summary>
        /// <value>Defines if the process document is in the edit buffer</value>
        [DataMember(Name="isLocal", EmitDefaultValue=false)]
        public bool? IsLocal { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name="info", EmitDefaultValue=false)]
        public RecordInfoRm Info { get; set; }

        /// <summary>
        /// Gets or Sets ArxDocInfo
        /// </summary>
        [DataMember(Name="arxDocInfo", EmitDefaultValue=false)]
        public ARXivarDocumentInfoRm ArxDocInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessDocumentForDashboardRm {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DocumentKind: ").Append(DocumentKind).Append("\n");
            sb.Append("  Filename: ").Append(Filename).Append("\n");
            sb.Append("  ToSend: ").Append(ToSend).Append("\n");
            sb.Append("  IsLocal: ").Append(IsLocal).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  ArxDocInfo: ").Append(ArxDocInfo).Append("\n");
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
            return this.Equals(input as ProcessDocumentForDashboardRm);
        }

        /// <summary>
        /// Returns true if ProcessDocumentForDashboardRm instances are equal
        /// </summary>
        /// <param name="input">Instance of ProcessDocumentForDashboardRm to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessDocumentForDashboardRm input)
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
                    this.DocumentKind == input.DocumentKind ||
                    (this.DocumentKind != null &&
                    this.DocumentKind.Equals(input.DocumentKind))
                ) && 
                (
                    this.Filename == input.Filename ||
                    (this.Filename != null &&
                    this.Filename.Equals(input.Filename))
                ) && 
                (
                    this.ToSend == input.ToSend ||
                    (this.ToSend != null &&
                    this.ToSend.Equals(input.ToSend))
                ) && 
                (
                    this.IsLocal == input.IsLocal ||
                    (this.IsLocal != null &&
                    this.IsLocal.Equals(input.IsLocal))
                ) && 
                (
                    this.Info == input.Info ||
                    (this.Info != null &&
                    this.Info.Equals(input.Info))
                ) && 
                (
                    this.ArxDocInfo == input.ArxDocInfo ||
                    (this.ArxDocInfo != null &&
                    this.ArxDocInfo.Equals(input.ArxDocInfo))
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
                if (this.DocumentKind != null)
                    hashCode = hashCode * 59 + this.DocumentKind.GetHashCode();
                if (this.Filename != null)
                    hashCode = hashCode * 59 + this.Filename.GetHashCode();
                if (this.ToSend != null)
                    hashCode = hashCode * 59 + this.ToSend.GetHashCode();
                if (this.IsLocal != null)
                    hashCode = hashCode * 59 + this.IsLocal.GetHashCode();
                if (this.Info != null)
                    hashCode = hashCode * 59 + this.Info.GetHashCode();
                if (this.ArxDocInfo != null)
                    hashCode = hashCode * 59 + this.ArxDocInfo.GetHashCode();
                return hashCode;
            }
        }

    }
}
