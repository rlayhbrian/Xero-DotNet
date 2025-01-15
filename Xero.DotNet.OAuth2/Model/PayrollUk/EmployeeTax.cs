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
    /// EmployeeTax
    /// </summary>
    [DataContract]
    public partial class EmployeeTax :  IEquatable<EmployeeTax>, IValidatableObject
    {
        
        /// <summary>
        /// The Starter type.
        /// </summary>
        /// <value>The Starter type.</value>
        [DataMember(Name="starterType", EmitDefaultValue=false)]
        public string StarterType { get; set; }

        /// <summary>
        /// Starter declaration.
        /// </summary>
        /// <value>Starter declaration.</value>
        [DataMember(Name="starterDeclaration", EmitDefaultValue=false)]
        public string StarterDeclaration { get; set; }

        /// <summary>
        /// The Tax code.
        /// </summary>
        /// <value>The Tax code.</value>
        [DataMember(Name="taxCode", EmitDefaultValue=false)]
        public string TaxCode { get; set; }

        /// <summary>
        /// Describes whether the tax settings is W1M1
        /// </summary>
        /// <value>Describes whether the tax settings is W1M1</value>
        [DataMember(Name="w1M1", EmitDefaultValue=false)]
        public bool? W1M1 { get; set; }

        /// <summary>
        /// The previous taxable pay
        /// </summary>
        /// <value>The previous taxable pay</value>
        [DataMember(Name="previousTaxablePay", EmitDefaultValue=false)]
        public decimal? PreviousTaxablePay { get; set; }

        /// <summary>
        /// The tax amount previously paid
        /// </summary>
        /// <value>The tax amount previously paid</value>
        [DataMember(Name="previousTaxPaid", EmitDefaultValue=false)]
        public decimal? PreviousTaxPaid { get; set; }

        /// <summary>
        /// The employee&#39;s student loan deduction type
        /// </summary>
        /// <value>The employee&#39;s student loan deduction type</value>
        [DataMember(Name="studentLoanDeduction", EmitDefaultValue=false)]
        public string StudentLoanDeduction { get; set; }

        /// <summary>
        /// Describes whether the employee has post graduate loans
        /// </summary>
        /// <value>Describes whether the employee has post graduate loans</value>
        [DataMember(Name="hasPostGraduateLoans", EmitDefaultValue=false)]
        public bool? HasPostGraduateLoans { get; set; }

        /// <summary>
        /// Describes whether the employee is director
        /// </summary>
        /// <value>Describes whether the employee is director</value>
        [DataMember(Name="isDirector", EmitDefaultValue=false)]
        public bool? IsDirector { get; set; }

        /// <summary>
        /// The directorship start date
        /// </summary>
        /// <value>The directorship start date</value>
        [DataMember(Name="directorshipStartDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? DirectorshipStartDate { get; set; }

        /// <summary>
        /// NICs calculation method
        /// </summary>
        /// <value>NICs calculation method</value>
        [DataMember(Name="nicCalculationMethod", EmitDefaultValue=false)]
        public string NicCalculationMethod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeTax {\n");
            sb.Append("  StarterType: ").Append(StarterType).Append("\n");
            sb.Append("  StarterDeclaration: ").Append(StarterDeclaration).Append("\n");
            sb.Append("  TaxCode: ").Append(TaxCode).Append("\n");
            sb.Append("  W1M1: ").Append(W1M1).Append("\n");
            sb.Append("  PreviousTaxablePay: ").Append(PreviousTaxablePay).Append("\n");
            sb.Append("  PreviousTaxPaid: ").Append(PreviousTaxPaid).Append("\n");
            sb.Append("  StudentLoanDeduction: ").Append(StudentLoanDeduction).Append("\n");
            sb.Append("  HasPostGraduateLoans: ").Append(HasPostGraduateLoans).Append("\n");
            sb.Append("  IsDirector: ").Append(IsDirector).Append("\n");
            sb.Append("  DirectorshipStartDate: ").Append(DirectorshipStartDate).Append("\n");
            sb.Append("  NicCalculationMethod: ").Append(NicCalculationMethod).Append("\n");
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
            return this.Equals(input as EmployeeTax);
        }

        /// <summary>
        /// Returns true if EmployeeTax instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeTax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeTax input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StarterType == input.StarterType ||
                    (this.StarterType != null &&
                    this.StarterType.Equals(input.StarterType))
                ) && 
                (
                    this.StarterDeclaration == input.StarterDeclaration ||
                    (this.StarterDeclaration != null &&
                    this.StarterDeclaration.Equals(input.StarterDeclaration))
                ) && 
                (
                    this.TaxCode == input.TaxCode ||
                    (this.TaxCode != null &&
                    this.TaxCode.Equals(input.TaxCode))
                ) && 
                (
                    this.W1M1 == input.W1M1 ||
                    (this.W1M1 != null &&
                    this.W1M1.Equals(input.W1M1))
                ) && 
                (
                    this.PreviousTaxablePay == input.PreviousTaxablePay ||
                    (this.PreviousTaxablePay != null &&
                    this.PreviousTaxablePay.Equals(input.PreviousTaxablePay))
                ) && 
                (
                    this.PreviousTaxPaid == input.PreviousTaxPaid ||
                    (this.PreviousTaxPaid != null &&
                    this.PreviousTaxPaid.Equals(input.PreviousTaxPaid))
                ) && 
                (
                    this.StudentLoanDeduction == input.StudentLoanDeduction ||
                    (this.StudentLoanDeduction != null &&
                    this.StudentLoanDeduction.Equals(input.StudentLoanDeduction))
                ) && 
                (
                    this.HasPostGraduateLoans == input.HasPostGraduateLoans ||
                    (this.HasPostGraduateLoans != null &&
                    this.HasPostGraduateLoans.Equals(input.HasPostGraduateLoans))
                ) && 
                (
                    this.IsDirector == input.IsDirector ||
                    (this.IsDirector != null &&
                    this.IsDirector.Equals(input.IsDirector))
                ) && 
                (
                    this.DirectorshipStartDate == input.DirectorshipStartDate ||
                    (this.DirectorshipStartDate != null &&
                    this.DirectorshipStartDate.Equals(input.DirectorshipStartDate))
                ) && 
                (
                    this.NicCalculationMethod == input.NicCalculationMethod ||
                    (this.NicCalculationMethod != null &&
                    this.NicCalculationMethod.Equals(input.NicCalculationMethod))
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
                if (this.StarterType != null)
                    hashCode = hashCode * 59 + this.StarterType.GetHashCode();
                if (this.StarterDeclaration != null)
                    hashCode = hashCode * 59 + this.StarterDeclaration.GetHashCode();
                if (this.TaxCode != null)
                    hashCode = hashCode * 59 + this.TaxCode.GetHashCode();
                if (this.W1M1 != null)
                    hashCode = hashCode * 59 + this.W1M1.GetHashCode();
                if (this.PreviousTaxablePay != null)
                    hashCode = hashCode * 59 + this.PreviousTaxablePay.GetHashCode();
                if (this.PreviousTaxPaid != null)
                    hashCode = hashCode * 59 + this.PreviousTaxPaid.GetHashCode();
                if (this.StudentLoanDeduction != null)
                    hashCode = hashCode * 59 + this.StudentLoanDeduction.GetHashCode();
                if (this.HasPostGraduateLoans != null)
                    hashCode = hashCode * 59 + this.HasPostGraduateLoans.GetHashCode();
                if (this.IsDirector != null)
                    hashCode = hashCode * 59 + this.IsDirector.GetHashCode();
                if (this.DirectorshipStartDate != null)
                    hashCode = hashCode * 59 + this.DirectorshipStartDate.GetHashCode();
                if (this.NicCalculationMethod != null)
                    hashCode = hashCode * 59 + this.NicCalculationMethod.GetHashCode();
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
