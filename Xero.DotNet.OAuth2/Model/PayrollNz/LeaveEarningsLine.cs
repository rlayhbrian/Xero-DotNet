/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
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

namespace Xero.DotNet.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// LeaveEarningsLine
    /// </summary>
    [DataContract]
    public partial class LeaveEarningsLine :  IEquatable<LeaveEarningsLine>, IValidatableObject
    {
        
        /// <summary>
        /// Xero identifier for payroll earnings line
        /// </summary>
        /// <value>Xero identifier for payroll earnings line</value>
        [DataMember(Name="earningsLineID", EmitDefaultValue=false)]
        public Guid? EarningsLineID { get; set; }

        /// <summary>
        /// Xero identifier for payroll leave earnings rate
        /// </summary>
        /// <value>Xero identifier for payroll leave earnings rate</value>
        [DataMember(Name="earningsRateID", EmitDefaultValue=false)]
        public Guid? EarningsRateID { get; set; }

        /// <summary>
        /// name of earnings rate for display in UI
        /// </summary>
        /// <value>name of earnings rate for display in UI</value>
        [DataMember(Name="displayName", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Rate per unit for leave earnings line
        /// </summary>
        /// <value>Rate per unit for leave earnings line</value>
        [DataMember(Name="ratePerUnit", EmitDefaultValue=false)]
        public decimal? RatePerUnit { get; set; }

        /// <summary>
        /// Leave earnings number of units
        /// </summary>
        /// <value>Leave earnings number of units</value>
        [DataMember(Name="numberOfUnits", EmitDefaultValue=false)]
        public decimal? NumberOfUnits { get; set; }

        /// <summary>
        /// Leave earnings fixed amount. Only applicable if the EarningsRate RateType is Fixed
        /// </summary>
        /// <value>Leave earnings fixed amount. Only applicable if the EarningsRate RateType is Fixed</value>
        [DataMember(Name="fixedAmount", EmitDefaultValue=false)]
        public decimal? FixedAmount { get; set; }

        /// <summary>
        /// The amount of the earnings line.
        /// </summary>
        /// <value>The amount of the earnings line.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Identifies if the leave earnings is taken from the timesheet. False for leave earnings line
        /// </summary>
        /// <value>Identifies if the leave earnings is taken from the timesheet. False for leave earnings line</value>
        [DataMember(Name="isLinkedToTimesheet", EmitDefaultValue=false)]
        public bool? IsLinkedToTimesheet { get; set; }

        /// <summary>
        /// Identifies if the earnings is using an average daily pay rate
        /// </summary>
        /// <value>Identifies if the earnings is using an average daily pay rate</value>
        [DataMember(Name="isAverageDailyPayRate", EmitDefaultValue=false)]
        public bool? IsAverageDailyPayRate { get; set; }

        /// <summary>
        /// Flag to identify whether the earnings line is system generated or not.
        /// </summary>
        /// <value>Flag to identify whether the earnings line is system generated or not.</value>
        [DataMember(Name="isSystemGenerated", EmitDefaultValue=false)]
        public bool? IsSystemGenerated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaveEarningsLine {\n");
            sb.Append("  EarningsLineID: ").Append(EarningsLineID).Append("\n");
            sb.Append("  EarningsRateID: ").Append(EarningsRateID).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  RatePerUnit: ").Append(RatePerUnit).Append("\n");
            sb.Append("  NumberOfUnits: ").Append(NumberOfUnits).Append("\n");
            sb.Append("  FixedAmount: ").Append(FixedAmount).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  IsLinkedToTimesheet: ").Append(IsLinkedToTimesheet).Append("\n");
            sb.Append("  IsAverageDailyPayRate: ").Append(IsAverageDailyPayRate).Append("\n");
            sb.Append("  IsSystemGenerated: ").Append(IsSystemGenerated).Append("\n");
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
            return this.Equals(input as LeaveEarningsLine);
        }

        /// <summary>
        /// Returns true if LeaveEarningsLine instances are equal
        /// </summary>
        /// <param name="input">Instance of LeaveEarningsLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaveEarningsLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EarningsLineID == input.EarningsLineID ||
                    (this.EarningsLineID != null &&
                    this.EarningsLineID.Equals(input.EarningsLineID))
                ) && 
                (
                    this.EarningsRateID == input.EarningsRateID ||
                    (this.EarningsRateID != null &&
                    this.EarningsRateID.Equals(input.EarningsRateID))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.RatePerUnit == input.RatePerUnit ||
                    (this.RatePerUnit != null &&
                    this.RatePerUnit.Equals(input.RatePerUnit))
                ) && 
                (
                    this.NumberOfUnits == input.NumberOfUnits ||
                    (this.NumberOfUnits != null &&
                    this.NumberOfUnits.Equals(input.NumberOfUnits))
                ) && 
                (
                    this.FixedAmount == input.FixedAmount ||
                    (this.FixedAmount != null &&
                    this.FixedAmount.Equals(input.FixedAmount))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.IsLinkedToTimesheet == input.IsLinkedToTimesheet ||
                    (this.IsLinkedToTimesheet != null &&
                    this.IsLinkedToTimesheet.Equals(input.IsLinkedToTimesheet))
                ) && 
                (
                    this.IsAverageDailyPayRate == input.IsAverageDailyPayRate ||
                    (this.IsAverageDailyPayRate != null &&
                    this.IsAverageDailyPayRate.Equals(input.IsAverageDailyPayRate))
                ) && 
                (
                    this.IsSystemGenerated == input.IsSystemGenerated ||
                    (this.IsSystemGenerated != null &&
                    this.IsSystemGenerated.Equals(input.IsSystemGenerated))
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
                if (this.EarningsLineID != null)
                    hashCode = hashCode * 59 + this.EarningsLineID.GetHashCode();
                if (this.EarningsRateID != null)
                    hashCode = hashCode * 59 + this.EarningsRateID.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.RatePerUnit != null)
                    hashCode = hashCode * 59 + this.RatePerUnit.GetHashCode();
                if (this.NumberOfUnits != null)
                    hashCode = hashCode * 59 + this.NumberOfUnits.GetHashCode();
                if (this.FixedAmount != null)
                    hashCode = hashCode * 59 + this.FixedAmount.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.IsLinkedToTimesheet != null)
                    hashCode = hashCode * 59 + this.IsLinkedToTimesheet.GetHashCode();
                if (this.IsAverageDailyPayRate != null)
                    hashCode = hashCode * 59 + this.IsAverageDailyPayRate.GetHashCode();
                if (this.IsSystemGenerated != null)
                    hashCode = hashCode * 59 + this.IsSystemGenerated.GetHashCode();
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
