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
    /// EarningsLine
    /// </summary>
    [DataContract]
    public partial class EarningsLine :  IEquatable<EarningsLine>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CalculationType
        /// </summary>
        [DataMember(Name="CalculationType", EmitDefaultValue=false)]
        public EarningsRateCalculationType CalculationType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EarningsLine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public EarningsLine() 
        { 
        }
        
        /// <summary>
        /// Xero unique id for earnings rate
        /// </summary>
        /// <value>Xero unique id for earnings rate</value>
        [DataMember(Name="EarningsRateID", EmitDefaultValue=false)]
        public Guid? EarningsRateID { get; set; }

        /// <summary>
        /// Annual salary for earnings line
        /// </summary>
        /// <value>Annual salary for earnings line</value>
        [DataMember(Name="AnnualSalary", EmitDefaultValue=false)]
        public decimal? AnnualSalary { get; set; }

        /// <summary>
        /// number of units for earning line
        /// </summary>
        /// <value>number of units for earning line</value>
        [DataMember(Name="NumberOfUnitsPerWeek", EmitDefaultValue=false)]
        public decimal? NumberOfUnitsPerWeek { get; set; }

        /// <summary>
        /// Rate per unit of the EarningsLine.
        /// </summary>
        /// <value>Rate per unit of the EarningsLine.</value>
        [DataMember(Name="RatePerUnit", EmitDefaultValue=false)]
        public decimal? RatePerUnit { get; set; }

        /// <summary>
        /// Normal number of units for EarningsLine. Applicable when RateType is \&quot;MULTIPLE\&quot;
        /// </summary>
        /// <value>Normal number of units for EarningsLine. Applicable when RateType is \&quot;MULTIPLE\&quot;</value>
        [DataMember(Name="NormalNumberOfUnits", EmitDefaultValue=false)]
        public decimal? NormalNumberOfUnits { get; set; }

        /// <summary>
        /// Earnings rate amount
        /// </summary>
        /// <value>Earnings rate amount</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Earnings rate number of units.
        /// </summary>
        /// <value>Earnings rate number of units.</value>
        [DataMember(Name="NumberOfUnits", EmitDefaultValue=false)]
        public decimal? NumberOfUnits { get; set; }

        /// <summary>
        /// Earnings rate amount. Only applicable if the EarningsRate RateType is Fixed
        /// </summary>
        /// <value>Earnings rate amount. Only applicable if the EarningsRate RateType is Fixed</value>
        [DataMember(Name="FixedAmount", EmitDefaultValue=false)]
        public decimal? FixedAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EarningsLine {\n");
            sb.Append("  EarningsRateID: ").Append(EarningsRateID).Append("\n");
            sb.Append("  CalculationType: ").Append(CalculationType).Append("\n");
            sb.Append("  AnnualSalary: ").Append(AnnualSalary).Append("\n");
            sb.Append("  NumberOfUnitsPerWeek: ").Append(NumberOfUnitsPerWeek).Append("\n");
            sb.Append("  RatePerUnit: ").Append(RatePerUnit).Append("\n");
            sb.Append("  NormalNumberOfUnits: ").Append(NormalNumberOfUnits).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  NumberOfUnits: ").Append(NumberOfUnits).Append("\n");
            sb.Append("  FixedAmount: ").Append(FixedAmount).Append("\n");
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
            return this.Equals(input as EarningsLine);
        }

        /// <summary>
        /// Returns true if EarningsLine instances are equal
        /// </summary>
        /// <param name="input">Instance of EarningsLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarningsLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EarningsRateID == input.EarningsRateID ||
                    (this.EarningsRateID != null &&
                    this.EarningsRateID.Equals(input.EarningsRateID))
                ) && 
                (
                    this.CalculationType == input.CalculationType ||
                    this.CalculationType.Equals(input.CalculationType)
                ) && 
                (
                    this.AnnualSalary == input.AnnualSalary ||
                    (this.AnnualSalary != null &&
                    this.AnnualSalary.Equals(input.AnnualSalary))
                ) && 
                (
                    this.NumberOfUnitsPerWeek == input.NumberOfUnitsPerWeek ||
                    (this.NumberOfUnitsPerWeek != null &&
                    this.NumberOfUnitsPerWeek.Equals(input.NumberOfUnitsPerWeek))
                ) && 
                (
                    this.RatePerUnit == input.RatePerUnit ||
                    (this.RatePerUnit != null &&
                    this.RatePerUnit.Equals(input.RatePerUnit))
                ) && 
                (
                    this.NormalNumberOfUnits == input.NormalNumberOfUnits ||
                    (this.NormalNumberOfUnits != null &&
                    this.NormalNumberOfUnits.Equals(input.NormalNumberOfUnits))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.EarningsRateID != null)
                    hashCode = hashCode * 59 + this.EarningsRateID.GetHashCode();
                hashCode = hashCode * 59 + this.CalculationType.GetHashCode();
                if (this.AnnualSalary != null)
                    hashCode = hashCode * 59 + this.AnnualSalary.GetHashCode();
                if (this.NumberOfUnitsPerWeek != null)
                    hashCode = hashCode * 59 + this.NumberOfUnitsPerWeek.GetHashCode();
                if (this.RatePerUnit != null)
                    hashCode = hashCode * 59 + this.RatePerUnit.GetHashCode();
                if (this.NormalNumberOfUnits != null)
                    hashCode = hashCode * 59 + this.NormalNumberOfUnits.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.NumberOfUnits != null)
                    hashCode = hashCode * 59 + this.NumberOfUnits.GetHashCode();
                if (this.FixedAmount != null)
                    hashCode = hashCode * 59 + this.FixedAmount.GetHashCode();
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
