/* 
 * Xero Payroll AU API
 *
 * This is the Xero Payroll API for orgs in Australia region.
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

namespace Xero.DotNet.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// Payslip
    /// </summary>
    [DataContract]
    public partial class Payslip :  IEquatable<Payslip>, IValidatableObject
    {
        
        /// <summary>
        /// The Xero identifier for an employee
        /// </summary>
        /// <value>The Xero identifier for an employee</value>
        [DataMember(Name="EmployeeID", EmitDefaultValue=false)]
        public Guid? EmployeeID { get; set; }

        /// <summary>
        /// Xero identifier for the payslip
        /// </summary>
        /// <value>Xero identifier for the payslip</value>
        [DataMember(Name="PayslipID", EmitDefaultValue=false)]
        public Guid? PayslipID { get; set; }

        /// <summary>
        /// First name of employee
        /// </summary>
        /// <value>First name of employee</value>
        [DataMember(Name="FirstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of employee
        /// </summary>
        /// <value>Last name of employee</value>
        [DataMember(Name="LastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// The Wages for the Payslip
        /// </summary>
        /// <value>The Wages for the Payslip</value>
        [DataMember(Name="Wages", EmitDefaultValue=false)]
        public decimal? Wages { get; set; }

        /// <summary>
        /// The Deductions for the Payslip
        /// </summary>
        /// <value>The Deductions for the Payslip</value>
        [DataMember(Name="Deductions", EmitDefaultValue=false)]
        public decimal? Deductions { get; set; }

        /// <summary>
        /// The Tax for the Payslip
        /// </summary>
        /// <value>The Tax for the Payslip</value>
        [DataMember(Name="Tax", EmitDefaultValue=false)]
        public decimal? Tax { get; set; }

        /// <summary>
        /// The Super for the Payslip
        /// </summary>
        /// <value>The Super for the Payslip</value>
        [DataMember(Name="Super", EmitDefaultValue=false)]
        public decimal? Super { get; set; }

        /// <summary>
        /// The Reimbursements for the Payslip
        /// </summary>
        /// <value>The Reimbursements for the Payslip</value>
        [DataMember(Name="Reimbursements", EmitDefaultValue=false)]
        public decimal? Reimbursements { get; set; }

        /// <summary>
        /// The NetPay for the Payslip
        /// </summary>
        /// <value>The NetPay for the Payslip</value>
        [DataMember(Name="NetPay", EmitDefaultValue=false)]
        public decimal? NetPay { get; set; }

        /// <summary>
        /// Gets or Sets EarningsLines
        /// </summary>
        [DataMember(Name="EarningsLines", EmitDefaultValue=false)]
        public List<EarningsLine> EarningsLines { get; set; }

        /// <summary>
        /// Gets or Sets LeaveEarningsLines
        /// </summary>
        [DataMember(Name="LeaveEarningsLines", EmitDefaultValue=false)]
        public List<LeaveEarningsLine> LeaveEarningsLines { get; set; }

        /// <summary>
        /// Gets or Sets TimesheetEarningsLines
        /// </summary>
        [DataMember(Name="TimesheetEarningsLines", EmitDefaultValue=false)]
        public List<EarningsLine> TimesheetEarningsLines { get; set; }

        /// <summary>
        /// Gets or Sets DeductionLines
        /// </summary>
        [DataMember(Name="DeductionLines", EmitDefaultValue=false)]
        public List<DeductionLine> DeductionLines { get; set; }

        /// <summary>
        /// Gets or Sets LeaveAccrualLines
        /// </summary>
        [DataMember(Name="LeaveAccrualLines", EmitDefaultValue=false)]
        public List<LeaveAccrualLine> LeaveAccrualLines { get; set; }

        /// <summary>
        /// Gets or Sets ReimbursementLines
        /// </summary>
        [DataMember(Name="ReimbursementLines", EmitDefaultValue=false)]
        public List<ReimbursementLine> ReimbursementLines { get; set; }

        /// <summary>
        /// Gets or Sets SuperannuationLines
        /// </summary>
        [DataMember(Name="SuperannuationLines", EmitDefaultValue=false)]
        public List<SuperannuationLine> SuperannuationLines { get; set; }

        /// <summary>
        /// Gets or Sets TaxLines
        /// </summary>
        [DataMember(Name="TaxLines", EmitDefaultValue=false)]
        public List<TaxLine> TaxLines { get; set; }

        /// <summary>
        /// Last modified timestamp
        /// </summary>
        /// <value>Last modified timestamp</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Payslip {\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  PayslipID: ").Append(PayslipID).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Wages: ").Append(Wages).Append("\n");
            sb.Append("  Deductions: ").Append(Deductions).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Super: ").Append(Super).Append("\n");
            sb.Append("  Reimbursements: ").Append(Reimbursements).Append("\n");
            sb.Append("  NetPay: ").Append(NetPay).Append("\n");
            sb.Append("  EarningsLines: ").Append(EarningsLines).Append("\n");
            sb.Append("  LeaveEarningsLines: ").Append(LeaveEarningsLines).Append("\n");
            sb.Append("  TimesheetEarningsLines: ").Append(TimesheetEarningsLines).Append("\n");
            sb.Append("  DeductionLines: ").Append(DeductionLines).Append("\n");
            sb.Append("  LeaveAccrualLines: ").Append(LeaveAccrualLines).Append("\n");
            sb.Append("  ReimbursementLines: ").Append(ReimbursementLines).Append("\n");
            sb.Append("  SuperannuationLines: ").Append(SuperannuationLines).Append("\n");
            sb.Append("  TaxLines: ").Append(TaxLines).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
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
            return this.Equals(input as Payslip);
        }

        /// <summary>
        /// Returns true if Payslip instances are equal
        /// </summary>
        /// <param name="input">Instance of Payslip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Payslip input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && 
                (
                    this.PayslipID == input.PayslipID ||
                    (this.PayslipID != null &&
                    this.PayslipID.Equals(input.PayslipID))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Wages == input.Wages ||
                    (this.Wages != null &&
                    this.Wages.Equals(input.Wages))
                ) && 
                (
                    this.Deductions == input.Deductions ||
                    (this.Deductions != null &&
                    this.Deductions.Equals(input.Deductions))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.Super == input.Super ||
                    (this.Super != null &&
                    this.Super.Equals(input.Super))
                ) && 
                (
                    this.Reimbursements == input.Reimbursements ||
                    (this.Reimbursements != null &&
                    this.Reimbursements.Equals(input.Reimbursements))
                ) && 
                (
                    this.NetPay == input.NetPay ||
                    (this.NetPay != null &&
                    this.NetPay.Equals(input.NetPay))
                ) && 
                (
                    this.EarningsLines == input.EarningsLines ||
                    this.EarningsLines != null &&
                    input.EarningsLines != null &&
                    this.EarningsLines.SequenceEqual(input.EarningsLines)
                ) && 
                (
                    this.LeaveEarningsLines == input.LeaveEarningsLines ||
                    this.LeaveEarningsLines != null &&
                    input.LeaveEarningsLines != null &&
                    this.LeaveEarningsLines.SequenceEqual(input.LeaveEarningsLines)
                ) && 
                (
                    this.TimesheetEarningsLines == input.TimesheetEarningsLines ||
                    this.TimesheetEarningsLines != null &&
                    input.TimesheetEarningsLines != null &&
                    this.TimesheetEarningsLines.SequenceEqual(input.TimesheetEarningsLines)
                ) && 
                (
                    this.DeductionLines == input.DeductionLines ||
                    this.DeductionLines != null &&
                    input.DeductionLines != null &&
                    this.DeductionLines.SequenceEqual(input.DeductionLines)
                ) && 
                (
                    this.LeaveAccrualLines == input.LeaveAccrualLines ||
                    this.LeaveAccrualLines != null &&
                    input.LeaveAccrualLines != null &&
                    this.LeaveAccrualLines.SequenceEqual(input.LeaveAccrualLines)
                ) && 
                (
                    this.ReimbursementLines == input.ReimbursementLines ||
                    this.ReimbursementLines != null &&
                    input.ReimbursementLines != null &&
                    this.ReimbursementLines.SequenceEqual(input.ReimbursementLines)
                ) && 
                (
                    this.SuperannuationLines == input.SuperannuationLines ||
                    this.SuperannuationLines != null &&
                    input.SuperannuationLines != null &&
                    this.SuperannuationLines.SequenceEqual(input.SuperannuationLines)
                ) && 
                (
                    this.TaxLines == input.TaxLines ||
                    this.TaxLines != null &&
                    input.TaxLines != null &&
                    this.TaxLines.SequenceEqual(input.TaxLines)
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
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
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                if (this.PayslipID != null)
                    hashCode = hashCode * 59 + this.PayslipID.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.Wages != null)
                    hashCode = hashCode * 59 + this.Wages.GetHashCode();
                if (this.Deductions != null)
                    hashCode = hashCode * 59 + this.Deductions.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.Super != null)
                    hashCode = hashCode * 59 + this.Super.GetHashCode();
                if (this.Reimbursements != null)
                    hashCode = hashCode * 59 + this.Reimbursements.GetHashCode();
                if (this.NetPay != null)
                    hashCode = hashCode * 59 + this.NetPay.GetHashCode();
                if (this.EarningsLines != null)
                    hashCode = hashCode * 59 + this.EarningsLines.GetHashCode();
                if (this.LeaveEarningsLines != null)
                    hashCode = hashCode * 59 + this.LeaveEarningsLines.GetHashCode();
                if (this.TimesheetEarningsLines != null)
                    hashCode = hashCode * 59 + this.TimesheetEarningsLines.GetHashCode();
                if (this.DeductionLines != null)
                    hashCode = hashCode * 59 + this.DeductionLines.GetHashCode();
                if (this.LeaveAccrualLines != null)
                    hashCode = hashCode * 59 + this.LeaveAccrualLines.GetHashCode();
                if (this.ReimbursementLines != null)
                    hashCode = hashCode * 59 + this.ReimbursementLines.GetHashCode();
                if (this.SuperannuationLines != null)
                    hashCode = hashCode * 59 + this.SuperannuationLines.GetHashCode();
                if (this.TaxLines != null)
                    hashCode = hashCode * 59 + this.TaxLines.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
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
