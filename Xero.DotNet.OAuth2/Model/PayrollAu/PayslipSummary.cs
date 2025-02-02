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
    /// PayslipSummary
    /// </summary>
    [DataContract]
    public partial class PayslipSummary :  IEquatable<PayslipSummary>, IValidatableObject
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
        /// Employee group name
        /// </summary>
        /// <value>Employee group name</value>
        [DataMember(Name="EmployeeGroup", EmitDefaultValue=false)]
        public string EmployeeGroup { get; set; }

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
            sb.Append("class PayslipSummary {\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  PayslipID: ").Append(PayslipID).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  EmployeeGroup: ").Append(EmployeeGroup).Append("\n");
            sb.Append("  Wages: ").Append(Wages).Append("\n");
            sb.Append("  Deductions: ").Append(Deductions).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  Super: ").Append(Super).Append("\n");
            sb.Append("  Reimbursements: ").Append(Reimbursements).Append("\n");
            sb.Append("  NetPay: ").Append(NetPay).Append("\n");
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
            return this.Equals(input as PayslipSummary);
        }

        /// <summary>
        /// Returns true if PayslipSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of PayslipSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayslipSummary input)
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
                    this.EmployeeGroup == input.EmployeeGroup ||
                    (this.EmployeeGroup != null &&
                    this.EmployeeGroup.Equals(input.EmployeeGroup))
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
                if (this.EmployeeGroup != null)
                    hashCode = hashCode * 59 + this.EmployeeGroup.GetHashCode();
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
