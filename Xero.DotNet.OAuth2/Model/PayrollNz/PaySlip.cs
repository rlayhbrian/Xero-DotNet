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
    /// PaySlip
    /// </summary>
    [DataContract]
    public partial class PaySlip :  IEquatable<PaySlip>, IValidatableObject
    {
        /// <summary>
        /// The payment method code
        /// </summary>
        /// <value>The payment method code</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum PaymentMethodEnum
        {
            /// <summary>
            /// Enum Cheque for value: Cheque
            /// </summary>
            [EnumMember(Value = "Cheque")]
            Cheque = 1,

            /// <summary>
            /// Enum Electronically for value: Electronically
            /// </summary>
            [EnumMember(Value = "Electronically")]
            Electronically = 2,

            /// <summary>
            /// Enum Manual for value: Manual
            /// </summary>
            [EnumMember(Value = "Manual")]
            Manual = 3

        }

        /// <summary>
        /// The payment method code
        /// </summary>
        /// <value>The payment method code</value>
        [DataMember(Name="paymentMethod", EmitDefaultValue=false)]
        public PaymentMethodEnum PaymentMethod { get; set; }
        
        /// <summary>
        /// The Xero identifier for a PaySlip
        /// </summary>
        /// <value>The Xero identifier for a PaySlip</value>
        [DataMember(Name="paySlipID", EmitDefaultValue=false)]
        public Guid? PaySlipID { get; set; }

        /// <summary>
        /// The Xero identifier for payroll employee
        /// </summary>
        /// <value>The Xero identifier for payroll employee</value>
        [DataMember(Name="employeeID", EmitDefaultValue=false)]
        public Guid? EmployeeID { get; set; }

        /// <summary>
        /// The Xero identifier for the associated payrun
        /// </summary>
        /// <value>The Xero identifier for the associated payrun</value>
        [DataMember(Name="payRunID", EmitDefaultValue=false)]
        public Guid? PayRunID { get; set; }

        /// <summary>
        /// The date payslip was last updated
        /// </summary>
        /// <value>The date payslip was last updated</value>
        [DataMember(Name="lastEdited", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? LastEdited { get; set; }

        /// <summary>
        /// Employee first name
        /// </summary>
        /// <value>Employee first name</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// Employee last name
        /// </summary>
        /// <value>Employee last name</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// Total earnings before any deductions. Same as gross earnings for NZ.
        /// </summary>
        /// <value>Total earnings before any deductions. Same as gross earnings for NZ.</value>
        [DataMember(Name="totalEarnings", EmitDefaultValue=false)]
        public decimal? TotalEarnings { get; set; }

        /// <summary>
        /// Total earnings before any deductions. Same as total earnings for NZ.
        /// </summary>
        /// <value>Total earnings before any deductions. Same as total earnings for NZ.</value>
        [DataMember(Name="grossEarnings", EmitDefaultValue=false)]
        public decimal? GrossEarnings { get; set; }

        /// <summary>
        /// The employee net pay
        /// </summary>
        /// <value>The employee net pay</value>
        [DataMember(Name="totalPay", EmitDefaultValue=false)]
        public decimal? TotalPay { get; set; }

        /// <summary>
        /// The employer&#39;s tax obligation
        /// </summary>
        /// <value>The employer&#39;s tax obligation</value>
        [DataMember(Name="totalEmployerTaxes", EmitDefaultValue=false)]
        public decimal? TotalEmployerTaxes { get; set; }

        /// <summary>
        /// The part of an employee&#39;s earnings that is deducted for tax purposes
        /// </summary>
        /// <value>The part of an employee&#39;s earnings that is deducted for tax purposes</value>
        [DataMember(Name="totalEmployeeTaxes", EmitDefaultValue=false)]
        public decimal? TotalEmployeeTaxes { get; set; }

        /// <summary>
        /// Total amount subtracted from an employee&#39;s earnings to reach total pay
        /// </summary>
        /// <value>Total amount subtracted from an employee&#39;s earnings to reach total pay</value>
        [DataMember(Name="totalDeductions", EmitDefaultValue=false)]
        public decimal? TotalDeductions { get; set; }

        /// <summary>
        /// Total reimbursements are nontaxable payments to an employee used to repay out-of-pocket expenses when the person incurs those expenses through employment
        /// </summary>
        /// <value>Total reimbursements are nontaxable payments to an employee used to repay out-of-pocket expenses when the person incurs those expenses through employment</value>
        [DataMember(Name="totalReimbursements", EmitDefaultValue=false)]
        public decimal? TotalReimbursements { get; set; }

        /// <summary>
        /// Total amounts required by law to subtract from the employee&#39;s earnings
        /// </summary>
        /// <value>Total amounts required by law to subtract from the employee&#39;s earnings</value>
        [DataMember(Name="totalStatutoryDeductions", EmitDefaultValue=false)]
        public decimal? TotalStatutoryDeductions { get; set; }

        /// <summary>
        /// Benefits (also called fringe benefits, perquisites or perks) are various non-earnings compensations provided to employees in addition to their normal earnings or salaries
        /// </summary>
        /// <value>Benefits (also called fringe benefits, perquisites or perks) are various non-earnings compensations provided to employees in addition to their normal earnings or salaries</value>
        [DataMember(Name="totalSuperannuation", EmitDefaultValue=false)]
        public decimal? TotalSuperannuation { get; set; }

        /// <summary>
        /// BACS Service User Number
        /// </summary>
        /// <value>BACS Service User Number</value>
        [DataMember(Name="bacsHash", EmitDefaultValue=false)]
        public string BacsHash { get; set; }

        /// <summary>
        /// Gets or Sets EarningsLines
        /// </summary>
        [DataMember(Name="earningsLines", EmitDefaultValue=false)]
        public List<EarningsLine> EarningsLines { get; set; }

        /// <summary>
        /// Gets or Sets LeaveEarningsLines
        /// </summary>
        [DataMember(Name="leaveEarningsLines", EmitDefaultValue=false)]
        public List<LeaveEarningsLine> LeaveEarningsLines { get; set; }

        /// <summary>
        /// Gets or Sets TimesheetEarningsLines
        /// </summary>
        [DataMember(Name="timesheetEarningsLines", EmitDefaultValue=false)]
        public List<TimesheetEarningsLine> TimesheetEarningsLines { get; set; }

        /// <summary>
        /// Gets or Sets DeductionLines
        /// </summary>
        [DataMember(Name="deductionLines", EmitDefaultValue=false)]
        public List<DeductionLine> DeductionLines { get; set; }

        /// <summary>
        /// Gets or Sets ReimbursementLines
        /// </summary>
        [DataMember(Name="reimbursementLines", EmitDefaultValue=false)]
        public List<ReimbursementLine> ReimbursementLines { get; set; }

        /// <summary>
        /// Gets or Sets LeaveAccrualLines
        /// </summary>
        [DataMember(Name="leaveAccrualLines", EmitDefaultValue=false)]
        public List<LeaveAccrualLine> LeaveAccrualLines { get; set; }

        /// <summary>
        /// Gets or Sets SuperannuationLines
        /// </summary>
        [DataMember(Name="superannuationLines", EmitDefaultValue=false)]
        public List<SuperannuationLine> SuperannuationLines { get; set; }

        /// <summary>
        /// Gets or Sets PaymentLines
        /// </summary>
        [DataMember(Name="paymentLines", EmitDefaultValue=false)]
        public List<PaymentLine> PaymentLines { get; set; }

        /// <summary>
        /// Gets or Sets EmployeeTaxLines
        /// </summary>
        [DataMember(Name="employeeTaxLines", EmitDefaultValue=false)]
        public List<TaxLine> EmployeeTaxLines { get; set; }

        /// <summary>
        /// Gets or Sets EmployerTaxLines
        /// </summary>
        [DataMember(Name="employerTaxLines", EmitDefaultValue=false)]
        public List<TaxLine> EmployerTaxLines { get; set; }

        /// <summary>
        /// Gets or Sets StatutoryDeductionLines
        /// </summary>
        [DataMember(Name="statutoryDeductionLines", EmitDefaultValue=false)]
        public List<StatutoryDeductionLine> StatutoryDeductionLines { get; set; }

        /// <summary>
        /// Gets or Sets TaxSettings
        /// </summary>
        [DataMember(Name="taxSettings", EmitDefaultValue=false)]
        public TaxSettings TaxSettings { get; set; }

        /// <summary>
        /// Gets or Sets GrossEarningsHistory
        /// </summary>
        [DataMember(Name="grossEarningsHistory", EmitDefaultValue=false)]
        public GrossEarningsHistory GrossEarningsHistory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaySlip {\n");
            sb.Append("  PaySlipID: ").Append(PaySlipID).Append("\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  PayRunID: ").Append(PayRunID).Append("\n");
            sb.Append("  LastEdited: ").Append(LastEdited).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  TotalEarnings: ").Append(TotalEarnings).Append("\n");
            sb.Append("  GrossEarnings: ").Append(GrossEarnings).Append("\n");
            sb.Append("  TotalPay: ").Append(TotalPay).Append("\n");
            sb.Append("  TotalEmployerTaxes: ").Append(TotalEmployerTaxes).Append("\n");
            sb.Append("  TotalEmployeeTaxes: ").Append(TotalEmployeeTaxes).Append("\n");
            sb.Append("  TotalDeductions: ").Append(TotalDeductions).Append("\n");
            sb.Append("  TotalReimbursements: ").Append(TotalReimbursements).Append("\n");
            sb.Append("  TotalStatutoryDeductions: ").Append(TotalStatutoryDeductions).Append("\n");
            sb.Append("  TotalSuperannuation: ").Append(TotalSuperannuation).Append("\n");
            sb.Append("  BacsHash: ").Append(BacsHash).Append("\n");
            sb.Append("  PaymentMethod: ").Append(PaymentMethod).Append("\n");
            sb.Append("  EarningsLines: ").Append(EarningsLines).Append("\n");
            sb.Append("  LeaveEarningsLines: ").Append(LeaveEarningsLines).Append("\n");
            sb.Append("  TimesheetEarningsLines: ").Append(TimesheetEarningsLines).Append("\n");
            sb.Append("  DeductionLines: ").Append(DeductionLines).Append("\n");
            sb.Append("  ReimbursementLines: ").Append(ReimbursementLines).Append("\n");
            sb.Append("  LeaveAccrualLines: ").Append(LeaveAccrualLines).Append("\n");
            sb.Append("  SuperannuationLines: ").Append(SuperannuationLines).Append("\n");
            sb.Append("  PaymentLines: ").Append(PaymentLines).Append("\n");
            sb.Append("  EmployeeTaxLines: ").Append(EmployeeTaxLines).Append("\n");
            sb.Append("  EmployerTaxLines: ").Append(EmployerTaxLines).Append("\n");
            sb.Append("  StatutoryDeductionLines: ").Append(StatutoryDeductionLines).Append("\n");
            sb.Append("  TaxSettings: ").Append(TaxSettings).Append("\n");
            sb.Append("  GrossEarningsHistory: ").Append(GrossEarningsHistory).Append("\n");
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
            return this.Equals(input as PaySlip);
        }

        /// <summary>
        /// Returns true if PaySlip instances are equal
        /// </summary>
        /// <param name="input">Instance of PaySlip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaySlip input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaySlipID == input.PaySlipID ||
                    (this.PaySlipID != null &&
                    this.PaySlipID.Equals(input.PaySlipID))
                ) && 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && 
                (
                    this.PayRunID == input.PayRunID ||
                    (this.PayRunID != null &&
                    this.PayRunID.Equals(input.PayRunID))
                ) && 
                (
                    this.LastEdited == input.LastEdited ||
                    (this.LastEdited != null &&
                    this.LastEdited.Equals(input.LastEdited))
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
                    this.TotalEarnings == input.TotalEarnings ||
                    (this.TotalEarnings != null &&
                    this.TotalEarnings.Equals(input.TotalEarnings))
                ) && 
                (
                    this.GrossEarnings == input.GrossEarnings ||
                    (this.GrossEarnings != null &&
                    this.GrossEarnings.Equals(input.GrossEarnings))
                ) && 
                (
                    this.TotalPay == input.TotalPay ||
                    (this.TotalPay != null &&
                    this.TotalPay.Equals(input.TotalPay))
                ) && 
                (
                    this.TotalEmployerTaxes == input.TotalEmployerTaxes ||
                    (this.TotalEmployerTaxes != null &&
                    this.TotalEmployerTaxes.Equals(input.TotalEmployerTaxes))
                ) && 
                (
                    this.TotalEmployeeTaxes == input.TotalEmployeeTaxes ||
                    (this.TotalEmployeeTaxes != null &&
                    this.TotalEmployeeTaxes.Equals(input.TotalEmployeeTaxes))
                ) && 
                (
                    this.TotalDeductions == input.TotalDeductions ||
                    (this.TotalDeductions != null &&
                    this.TotalDeductions.Equals(input.TotalDeductions))
                ) && 
                (
                    this.TotalReimbursements == input.TotalReimbursements ||
                    (this.TotalReimbursements != null &&
                    this.TotalReimbursements.Equals(input.TotalReimbursements))
                ) && 
                (
                    this.TotalStatutoryDeductions == input.TotalStatutoryDeductions ||
                    (this.TotalStatutoryDeductions != null &&
                    this.TotalStatutoryDeductions.Equals(input.TotalStatutoryDeductions))
                ) && 
                (
                    this.TotalSuperannuation == input.TotalSuperannuation ||
                    (this.TotalSuperannuation != null &&
                    this.TotalSuperannuation.Equals(input.TotalSuperannuation))
                ) && 
                (
                    this.BacsHash == input.BacsHash ||
                    (this.BacsHash != null &&
                    this.BacsHash.Equals(input.BacsHash))
                ) && 
                (
                    this.PaymentMethod == input.PaymentMethod ||
                    this.PaymentMethod.Equals(input.PaymentMethod)
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
                    this.ReimbursementLines == input.ReimbursementLines ||
                    this.ReimbursementLines != null &&
                    input.ReimbursementLines != null &&
                    this.ReimbursementLines.SequenceEqual(input.ReimbursementLines)
                ) && 
                (
                    this.LeaveAccrualLines == input.LeaveAccrualLines ||
                    this.LeaveAccrualLines != null &&
                    input.LeaveAccrualLines != null &&
                    this.LeaveAccrualLines.SequenceEqual(input.LeaveAccrualLines)
                ) && 
                (
                    this.SuperannuationLines == input.SuperannuationLines ||
                    this.SuperannuationLines != null &&
                    input.SuperannuationLines != null &&
                    this.SuperannuationLines.SequenceEqual(input.SuperannuationLines)
                ) && 
                (
                    this.PaymentLines == input.PaymentLines ||
                    this.PaymentLines != null &&
                    input.PaymentLines != null &&
                    this.PaymentLines.SequenceEqual(input.PaymentLines)
                ) && 
                (
                    this.EmployeeTaxLines == input.EmployeeTaxLines ||
                    this.EmployeeTaxLines != null &&
                    input.EmployeeTaxLines != null &&
                    this.EmployeeTaxLines.SequenceEqual(input.EmployeeTaxLines)
                ) && 
                (
                    this.EmployerTaxLines == input.EmployerTaxLines ||
                    this.EmployerTaxLines != null &&
                    input.EmployerTaxLines != null &&
                    this.EmployerTaxLines.SequenceEqual(input.EmployerTaxLines)
                ) && 
                (
                    this.StatutoryDeductionLines == input.StatutoryDeductionLines ||
                    this.StatutoryDeductionLines != null &&
                    input.StatutoryDeductionLines != null &&
                    this.StatutoryDeductionLines.SequenceEqual(input.StatutoryDeductionLines)
                ) && 
                (
                    this.TaxSettings == input.TaxSettings ||
                    (this.TaxSettings != null &&
                    this.TaxSettings.Equals(input.TaxSettings))
                ) && 
                (
                    this.GrossEarningsHistory == input.GrossEarningsHistory ||
                    (this.GrossEarningsHistory != null &&
                    this.GrossEarningsHistory.Equals(input.GrossEarningsHistory))
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
                if (this.PaySlipID != null)
                    hashCode = hashCode * 59 + this.PaySlipID.GetHashCode();
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                if (this.PayRunID != null)
                    hashCode = hashCode * 59 + this.PayRunID.GetHashCode();
                if (this.LastEdited != null)
                    hashCode = hashCode * 59 + this.LastEdited.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.TotalEarnings != null)
                    hashCode = hashCode * 59 + this.TotalEarnings.GetHashCode();
                if (this.GrossEarnings != null)
                    hashCode = hashCode * 59 + this.GrossEarnings.GetHashCode();
                if (this.TotalPay != null)
                    hashCode = hashCode * 59 + this.TotalPay.GetHashCode();
                if (this.TotalEmployerTaxes != null)
                    hashCode = hashCode * 59 + this.TotalEmployerTaxes.GetHashCode();
                if (this.TotalEmployeeTaxes != null)
                    hashCode = hashCode * 59 + this.TotalEmployeeTaxes.GetHashCode();
                if (this.TotalDeductions != null)
                    hashCode = hashCode * 59 + this.TotalDeductions.GetHashCode();
                if (this.TotalReimbursements != null)
                    hashCode = hashCode * 59 + this.TotalReimbursements.GetHashCode();
                if (this.TotalStatutoryDeductions != null)
                    hashCode = hashCode * 59 + this.TotalStatutoryDeductions.GetHashCode();
                if (this.TotalSuperannuation != null)
                    hashCode = hashCode * 59 + this.TotalSuperannuation.GetHashCode();
                if (this.BacsHash != null)
                    hashCode = hashCode * 59 + this.BacsHash.GetHashCode();
                hashCode = hashCode * 59 + this.PaymentMethod.GetHashCode();
                if (this.EarningsLines != null)
                    hashCode = hashCode * 59 + this.EarningsLines.GetHashCode();
                if (this.LeaveEarningsLines != null)
                    hashCode = hashCode * 59 + this.LeaveEarningsLines.GetHashCode();
                if (this.TimesheetEarningsLines != null)
                    hashCode = hashCode * 59 + this.TimesheetEarningsLines.GetHashCode();
                if (this.DeductionLines != null)
                    hashCode = hashCode * 59 + this.DeductionLines.GetHashCode();
                if (this.ReimbursementLines != null)
                    hashCode = hashCode * 59 + this.ReimbursementLines.GetHashCode();
                if (this.LeaveAccrualLines != null)
                    hashCode = hashCode * 59 + this.LeaveAccrualLines.GetHashCode();
                if (this.SuperannuationLines != null)
                    hashCode = hashCode * 59 + this.SuperannuationLines.GetHashCode();
                if (this.PaymentLines != null)
                    hashCode = hashCode * 59 + this.PaymentLines.GetHashCode();
                if (this.EmployeeTaxLines != null)
                    hashCode = hashCode * 59 + this.EmployeeTaxLines.GetHashCode();
                if (this.EmployerTaxLines != null)
                    hashCode = hashCode * 59 + this.EmployerTaxLines.GetHashCode();
                if (this.StatutoryDeductionLines != null)
                    hashCode = hashCode * 59 + this.StatutoryDeductionLines.GetHashCode();
                if (this.TaxSettings != null)
                    hashCode = hashCode * 59 + this.TaxSettings.GetHashCode();
                if (this.GrossEarningsHistory != null)
                    hashCode = hashCode * 59 + this.GrossEarningsHistory.GetHashCode();
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
