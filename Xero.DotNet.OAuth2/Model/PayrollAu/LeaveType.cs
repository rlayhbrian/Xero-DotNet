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
    /// LeaveType
    /// </summary>
    [DataContract]
    public partial class LeaveType :  IEquatable<LeaveType>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets LeaveCategoryCode
        /// </summary>
        [DataMember(Name="LeaveCategoryCode", EmitDefaultValue=false)]
        public LeaveCategoryCode LeaveCategoryCode { get; set; }
        
        /// <summary>
        /// Name of the earnings rate (max length &#x3D; 100)
        /// </summary>
        /// <value>Name of the earnings rate (max length &#x3D; 100)</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The type of units by which leave entitlements are normally tracked. These are typically the same as the type of units used for the employee’s ordinary earnings rate
        /// </summary>
        /// <value>The type of units by which leave entitlements are normally tracked. These are typically the same as the type of units used for the employee’s ordinary earnings rate</value>
        [DataMember(Name="TypeOfUnits", EmitDefaultValue=false)]
        public string TypeOfUnits { get; set; }

        /// <summary>
        /// Xero identifier
        /// </summary>
        /// <value>Xero identifier</value>
        [DataMember(Name="LeaveTypeID", EmitDefaultValue=false)]
        public Guid? LeaveTypeID { get; set; }

        /// <summary>
        /// The number of units the employee is entitled to each year
        /// </summary>
        /// <value>The number of units the employee is entitled to each year</value>
        [DataMember(Name="NormalEntitlement", EmitDefaultValue=false)]
        public double? NormalEntitlement { get; set; }

        /// <summary>
        /// Enter an amount here if your organisation pays an additional percentage on top of ordinary earnings when your employees take leave (typically 17.5%)
        /// </summary>
        /// <value>Enter an amount here if your organisation pays an additional percentage on top of ordinary earnings when your employees take leave (typically 17.5%)</value>
        [DataMember(Name="LeaveLoadingRate", EmitDefaultValue=false)]
        public double? LeaveLoadingRate { get; set; }

        /// <summary>
        /// Last modified timestamp
        /// </summary>
        /// <value>Last modified timestamp</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Set this to indicate that an employee will be paid when taking this type of leave
        /// </summary>
        /// <value>Set this to indicate that an employee will be paid when taking this type of leave</value>
        [DataMember(Name="IsPaidLeave", EmitDefaultValue=false)]
        public bool? IsPaidLeave { get; set; }

        /// <summary>
        /// Set this if you want a balance for this leave type to be shown on your employee’s payslips
        /// </summary>
        /// <value>Set this if you want a balance for this leave type to be shown on your employee’s payslips</value>
        [DataMember(Name="ShowOnPayslip", EmitDefaultValue=false)]
        public bool? ShowOnPayslip { get; set; }

        /// <summary>
        /// Is the current record
        /// </summary>
        /// <value>Is the current record</value>
        [DataMember(Name="CurrentRecord", EmitDefaultValue=false)]
        public bool? CurrentRecord { get; set; }

        /// <summary>
        /// Set this to indicate that the leave type is exempt from superannuation guarantee contribution
        /// </summary>
        /// <value>Set this to indicate that the leave type is exempt from superannuation guarantee contribution</value>
        [DataMember(Name="SGCExempt", EmitDefaultValue=false)]
        public bool? SGCExempt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LeaveType {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TypeOfUnits: ").Append(TypeOfUnits).Append("\n");
            sb.Append("  LeaveTypeID: ").Append(LeaveTypeID).Append("\n");
            sb.Append("  NormalEntitlement: ").Append(NormalEntitlement).Append("\n");
            sb.Append("  LeaveLoadingRate: ").Append(LeaveLoadingRate).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  IsPaidLeave: ").Append(IsPaidLeave).Append("\n");
            sb.Append("  ShowOnPayslip: ").Append(ShowOnPayslip).Append("\n");
            sb.Append("  CurrentRecord: ").Append(CurrentRecord).Append("\n");
            sb.Append("  LeaveCategoryCode: ").Append(LeaveCategoryCode).Append("\n");
            sb.Append("  SGCExempt: ").Append(SGCExempt).Append("\n");
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
            return this.Equals(input as LeaveType);
        }

        /// <summary>
        /// Returns true if LeaveType instances are equal
        /// </summary>
        /// <param name="input">Instance of LeaveType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LeaveType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TypeOfUnits == input.TypeOfUnits ||
                    (this.TypeOfUnits != null &&
                    this.TypeOfUnits.Equals(input.TypeOfUnits))
                ) && 
                (
                    this.LeaveTypeID == input.LeaveTypeID ||
                    (this.LeaveTypeID != null &&
                    this.LeaveTypeID.Equals(input.LeaveTypeID))
                ) && 
                (
                    this.NormalEntitlement == input.NormalEntitlement ||
                    (this.NormalEntitlement != null &&
                    this.NormalEntitlement.Equals(input.NormalEntitlement))
                ) && 
                (
                    this.LeaveLoadingRate == input.LeaveLoadingRate ||
                    (this.LeaveLoadingRate != null &&
                    this.LeaveLoadingRate.Equals(input.LeaveLoadingRate))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.IsPaidLeave == input.IsPaidLeave ||
                    (this.IsPaidLeave != null &&
                    this.IsPaidLeave.Equals(input.IsPaidLeave))
                ) && 
                (
                    this.ShowOnPayslip == input.ShowOnPayslip ||
                    (this.ShowOnPayslip != null &&
                    this.ShowOnPayslip.Equals(input.ShowOnPayslip))
                ) && 
                (
                    this.CurrentRecord == input.CurrentRecord ||
                    (this.CurrentRecord != null &&
                    this.CurrentRecord.Equals(input.CurrentRecord))
                ) && 
                (
                    this.LeaveCategoryCode == input.LeaveCategoryCode ||
                    this.LeaveCategoryCode.Equals(input.LeaveCategoryCode)
                ) && 
                (
                    this.SGCExempt == input.SGCExempt ||
                    (this.SGCExempt != null &&
                    this.SGCExempt.Equals(input.SGCExempt))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.TypeOfUnits != null)
                    hashCode = hashCode * 59 + this.TypeOfUnits.GetHashCode();
                if (this.LeaveTypeID != null)
                    hashCode = hashCode * 59 + this.LeaveTypeID.GetHashCode();
                if (this.NormalEntitlement != null)
                    hashCode = hashCode * 59 + this.NormalEntitlement.GetHashCode();
                if (this.LeaveLoadingRate != null)
                    hashCode = hashCode * 59 + this.LeaveLoadingRate.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.IsPaidLeave != null)
                    hashCode = hashCode * 59 + this.IsPaidLeave.GetHashCode();
                if (this.ShowOnPayslip != null)
                    hashCode = hashCode * 59 + this.ShowOnPayslip.GetHashCode();
                if (this.CurrentRecord != null)
                    hashCode = hashCode * 59 + this.CurrentRecord.GetHashCode();
                hashCode = hashCode * 59 + this.LeaveCategoryCode.GetHashCode();
                if (this.SGCExempt != null)
                    hashCode = hashCode * 59 + this.SGCExempt.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 100.", new [] { "Name" });
            }

            yield break;
        }
    }

}
