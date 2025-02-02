/* 
 * Xero Finance API
 *
 * The Finance API is a collection of endpoints which customers can use in the course of a loan application, which may assist lenders to gain the confidence they need to provide capital.
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

namespace Xero.DotNet.OAuth2.Model.Finance
{
    /// <summary>
    /// ContactTotalDetail
    /// </summary>
    [DataContract]
    public partial class ContactTotalDetail :  IEquatable<ContactTotalDetail>, IValidatableObject
    {
        
        /// <summary>
        /// Total paid invoice and cash value for the contact within the period.
        /// </summary>
        /// <value>Total paid invoice and cash value for the contact within the period.</value>
        [DataMember(Name="totalPaid", EmitDefaultValue=false)]
        public decimal? TotalPaid { get; set; }

        /// <summary>
        /// Total outstanding invoice value for the contact within the period.
        /// </summary>
        /// <value>Total outstanding invoice value for the contact within the period.</value>
        [DataMember(Name="totalOutstanding", EmitDefaultValue=false)]
        public decimal? TotalOutstanding { get; set; }

        /// <summary>
        /// Total unapplied credited value for the contact within the period.
        /// </summary>
        /// <value>Total unapplied credited value for the contact within the period.</value>
        [DataMember(Name="totalCreditedUnApplied", EmitDefaultValue=false)]
        public decimal? TotalCreditedUnApplied { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactTotalDetail {\n");
            sb.Append("  TotalPaid: ").Append(TotalPaid).Append("\n");
            sb.Append("  TotalOutstanding: ").Append(TotalOutstanding).Append("\n");
            sb.Append("  TotalCreditedUnApplied: ").Append(TotalCreditedUnApplied).Append("\n");
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
            return this.Equals(input as ContactTotalDetail);
        }

        /// <summary>
        /// Returns true if ContactTotalDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactTotalDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactTotalDetail input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalPaid == input.TotalPaid ||
                    (this.TotalPaid != null &&
                    this.TotalPaid.Equals(input.TotalPaid))
                ) && 
                (
                    this.TotalOutstanding == input.TotalOutstanding ||
                    (this.TotalOutstanding != null &&
                    this.TotalOutstanding.Equals(input.TotalOutstanding))
                ) && 
                (
                    this.TotalCreditedUnApplied == input.TotalCreditedUnApplied ||
                    (this.TotalCreditedUnApplied != null &&
                    this.TotalCreditedUnApplied.Equals(input.TotalCreditedUnApplied))
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
                if (this.TotalPaid != null)
                    hashCode = hashCode * 59 + this.TotalPaid.GetHashCode();
                if (this.TotalOutstanding != null)
                    hashCode = hashCode * 59 + this.TotalOutstanding.GetHashCode();
                if (this.TotalCreditedUnApplied != null)
                    hashCode = hashCode * 59 + this.TotalCreditedUnApplied.GetHashCode();
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
