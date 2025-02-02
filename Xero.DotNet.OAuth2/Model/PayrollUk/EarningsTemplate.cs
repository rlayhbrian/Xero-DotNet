/* 
 * Xero Payroll UK
 *
 * This is the Xero Payroll API for orgs in the UK region.
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

namespace Xero.DotNet.OAuth2.Model.PayrollUk
{
    /// <summary>
    /// EarningsTemplate
    /// </summary>
    [DataContract]
    public partial class EarningsTemplate :  IEquatable<EarningsTemplate>, IValidatableObject
    {
        
        /// <summary>
        /// The Xero identifier for the earnings template
        /// </summary>
        /// <value>The Xero identifier for the earnings template</value>
        [DataMember(Name="payTemplateEarningID", EmitDefaultValue=false)]
        public Guid? PayTemplateEarningID { get; set; }

        /// <summary>
        /// The rate per unit
        /// </summary>
        /// <value>The rate per unit</value>
        [DataMember(Name="ratePerUnit", EmitDefaultValue=false)]
        public decimal? RatePerUnit { get; set; }

        /// <summary>
        /// The rate per unit
        /// </summary>
        /// <value>The rate per unit</value>
        [DataMember(Name="numberOfUnits", EmitDefaultValue=false)]
        public decimal? NumberOfUnits { get; set; }

        /// <summary>
        /// The fixed amount per period
        /// </summary>
        /// <value>The fixed amount per period</value>
        [DataMember(Name="fixedAmount", EmitDefaultValue=false)]
        public decimal? FixedAmount { get; set; }

        /// <summary>
        /// The corresponding earnings rate identifier
        /// </summary>
        /// <value>The corresponding earnings rate identifier</value>
        [DataMember(Name="earningsRateID", EmitDefaultValue=false)]
        public Guid? EarningsRateID { get; set; }

        /// <summary>
        /// The read-only name of the Earning Template.
        /// </summary>
        /// <value>The read-only name of the Earning Template.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EarningsTemplate {\n");
            sb.Append("  PayTemplateEarningID: ").Append(PayTemplateEarningID).Append("\n");
            sb.Append("  RatePerUnit: ").Append(RatePerUnit).Append("\n");
            sb.Append("  NumberOfUnits: ").Append(NumberOfUnits).Append("\n");
            sb.Append("  FixedAmount: ").Append(FixedAmount).Append("\n");
            sb.Append("  EarningsRateID: ").Append(EarningsRateID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as EarningsTemplate);
        }

        /// <summary>
        /// Returns true if EarningsTemplate instances are equal
        /// </summary>
        /// <param name="input">Instance of EarningsTemplate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarningsTemplate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayTemplateEarningID == input.PayTemplateEarningID ||
                    (this.PayTemplateEarningID != null &&
                    this.PayTemplateEarningID.Equals(input.PayTemplateEarningID))
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
                    this.EarningsRateID == input.EarningsRateID ||
                    (this.EarningsRateID != null &&
                    this.EarningsRateID.Equals(input.EarningsRateID))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.PayTemplateEarningID != null)
                    hashCode = hashCode * 59 + this.PayTemplateEarningID.GetHashCode();
                if (this.RatePerUnit != null)
                    hashCode = hashCode * 59 + this.RatePerUnit.GetHashCode();
                if (this.NumberOfUnits != null)
                    hashCode = hashCode * 59 + this.NumberOfUnits.GetHashCode();
                if (this.FixedAmount != null)
                    hashCode = hashCode * 59 + this.FixedAmount.GetHashCode();
                if (this.EarningsRateID != null)
                    hashCode = hashCode * 59 + this.EarningsRateID.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
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
