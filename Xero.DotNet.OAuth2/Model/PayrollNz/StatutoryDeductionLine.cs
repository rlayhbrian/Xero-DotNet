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
    /// StatutoryDeductionLine
    /// </summary>
    [DataContract]
    public partial class StatutoryDeductionLine :  IEquatable<StatutoryDeductionLine>, IValidatableObject
    {
        
        /// <summary>
        /// Xero identifier for payroll statutory deduction type
        /// </summary>
        /// <value>Xero identifier for payroll statutory deduction type</value>
        [DataMember(Name="statutoryDeductionTypeID", EmitDefaultValue=false)]
        public Guid? StatutoryDeductionTypeID { get; set; }

        /// <summary>
        /// The amount of the statutory deduction line
        /// </summary>
        /// <value>The amount of the statutory deduction line</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Fixed Amount
        /// </summary>
        /// <value>Fixed Amount</value>
        [DataMember(Name="fixedAmount", EmitDefaultValue=false)]
        public decimal? FixedAmount { get; set; }

        /// <summary>
        /// Identifies if the tax line is a manual adjustment
        /// </summary>
        /// <value>Identifies if the tax line is a manual adjustment</value>
        [DataMember(Name="manualAdjustment", EmitDefaultValue=false)]
        public bool? ManualAdjustment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatutoryDeductionLine {\n");
            sb.Append("  StatutoryDeductionTypeID: ").Append(StatutoryDeductionTypeID).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  FixedAmount: ").Append(FixedAmount).Append("\n");
            sb.Append("  ManualAdjustment: ").Append(ManualAdjustment).Append("\n");
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
            return this.Equals(input as StatutoryDeductionLine);
        }

        /// <summary>
        /// Returns true if StatutoryDeductionLine instances are equal
        /// </summary>
        /// <param name="input">Instance of StatutoryDeductionLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatutoryDeductionLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatutoryDeductionTypeID == input.StatutoryDeductionTypeID ||
                    (this.StatutoryDeductionTypeID != null &&
                    this.StatutoryDeductionTypeID.Equals(input.StatutoryDeductionTypeID))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.FixedAmount == input.FixedAmount ||
                    (this.FixedAmount != null &&
                    this.FixedAmount.Equals(input.FixedAmount))
                ) && 
                (
                    this.ManualAdjustment == input.ManualAdjustment ||
                    (this.ManualAdjustment != null &&
                    this.ManualAdjustment.Equals(input.ManualAdjustment))
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
                if (this.StatutoryDeductionTypeID != null)
                    hashCode = hashCode * 59 + this.StatutoryDeductionTypeID.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.FixedAmount != null)
                    hashCode = hashCode * 59 + this.FixedAmount.GetHashCode();
                if (this.ManualAdjustment != null)
                    hashCode = hashCode * 59 + this.ManualAdjustment.GetHashCode();
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
