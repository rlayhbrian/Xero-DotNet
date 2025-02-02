/* 
 * Xero Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = Xero.DotNet.OAuth2.Client.OpenAPIDateConverter;

namespace Xero.DotNet.OAuth2.Model.Accounting
{
    /// <summary>
    /// ReportWithRow
    /// </summary>
    [DataContract]
    public partial class ReportWithRow :  IEquatable<ReportWithRow>, IValidatableObject
    {
        
        /// <summary>
        /// ID of the Report
        /// </summary>
        /// <value>ID of the Report</value>
        [DataMember(Name="ReportID", EmitDefaultValue=false)]
        public string ReportID { get; set; }

        /// <summary>
        /// Name of the report
        /// </summary>
        /// <value>Name of the report</value>
        [DataMember(Name="ReportName", EmitDefaultValue=false)]
        public string ReportName { get; set; }

        /// <summary>
        /// Title of the report
        /// </summary>
        /// <value>Title of the report</value>
        [DataMember(Name="ReportTitle", EmitDefaultValue=false)]
        public string ReportTitle { get; set; }

        /// <summary>
        /// The type of report (BalanceSheet,ProfitLoss, etc)
        /// </summary>
        /// <value>The type of report (BalanceSheet,ProfitLoss, etc)</value>
        [DataMember(Name="ReportType", EmitDefaultValue=false)]
        public string ReportType { get; set; }

        /// <summary>
        /// Report titles array (3 to 4 strings with the report name, orgnisation name and time frame of report)
        /// </summary>
        /// <value>Report titles array (3 to 4 strings with the report name, orgnisation name and time frame of report)</value>
        [DataMember(Name="ReportTitles", EmitDefaultValue=false)]
        public List<string> ReportTitles { get; set; }

        /// <summary>
        /// Date of report
        /// </summary>
        /// <value>Date of report</value>
        [DataMember(Name="ReportDate", EmitDefaultValue=false)]
        public string ReportDate { get; set; }

        /// <summary>
        /// Gets or Sets Rows
        /// </summary>
        [DataMember(Name="Rows", EmitDefaultValue=false)]
        public List<ReportRows> Rows { get; set; }

        /// <summary>
        /// Updated Date
        /// </summary>
        /// <value>Updated Date</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Gets or Sets Fields
        /// </summary>
        [DataMember(Name="Fields", EmitDefaultValue=false)]
        public List<ReportFields> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReportWithRow {\n");
            sb.Append("  ReportID: ").Append(ReportID).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  ReportTitle: ").Append(ReportTitle).Append("\n");
            sb.Append("  ReportType: ").Append(ReportType).Append("\n");
            sb.Append("  ReportTitles: ").Append(ReportTitles).Append("\n");
            sb.Append("  ReportDate: ").Append(ReportDate).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as ReportWithRow);
        }

        /// <summary>
        /// Returns true if ReportWithRow instances are equal
        /// </summary>
        /// <param name="input">Instance of ReportWithRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReportWithRow input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReportID == input.ReportID ||
                    (this.ReportID != null &&
                    this.ReportID.Equals(input.ReportID))
                ) && 
                (
                    this.ReportName == input.ReportName ||
                    (this.ReportName != null &&
                    this.ReportName.Equals(input.ReportName))
                ) && 
                (
                    this.ReportTitle == input.ReportTitle ||
                    (this.ReportTitle != null &&
                    this.ReportTitle.Equals(input.ReportTitle))
                ) && 
                (
                    this.ReportType == input.ReportType ||
                    (this.ReportType != null &&
                    this.ReportType.Equals(input.ReportType))
                ) && 
                (
                    this.ReportTitles == input.ReportTitles ||
                    this.ReportTitles != null &&
                    input.ReportTitles != null &&
                    this.ReportTitles.SequenceEqual(input.ReportTitles)
                ) && 
                (
                    this.ReportDate == input.ReportDate ||
                    (this.ReportDate != null &&
                    this.ReportDate.Equals(input.ReportDate))
                ) && 
                (
                    this.Rows == input.Rows ||
                    this.Rows != null &&
                    input.Rows != null &&
                    this.Rows.SequenceEqual(input.Rows)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.ReportID != null)
                    hashCode = hashCode * 59 + this.ReportID.GetHashCode();
                if (this.ReportName != null)
                    hashCode = hashCode * 59 + this.ReportName.GetHashCode();
                if (this.ReportTitle != null)
                    hashCode = hashCode * 59 + this.ReportTitle.GetHashCode();
                if (this.ReportType != null)
                    hashCode = hashCode * 59 + this.ReportType.GetHashCode();
                if (this.ReportTitles != null)
                    hashCode = hashCode * 59 + this.ReportTitles.GetHashCode();
                if (this.ReportDate != null)
                    hashCode = hashCode * 59 + this.ReportDate.GetHashCode();
                if (this.Rows != null)
                    hashCode = hashCode * 59 + this.Rows.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
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
