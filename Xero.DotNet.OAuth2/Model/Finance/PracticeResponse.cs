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
    /// PracticeResponse
    /// </summary>
    [DataContract]
    public partial class PracticeResponse :  IEquatable<PracticeResponse>, IValidatableObject
    {
        
        /// <summary>
        /// Year of becoming a partner.
        /// </summary>
        /// <value>Year of becoming a partner.</value>
        [DataMember(Name="xeroPartnerSince", EmitDefaultValue=false)]
        public int? XeroPartnerSince { get; set; }

        /// <summary>
        /// Customer tier e.g. Silver
        /// </summary>
        /// <value>Customer tier e.g. Silver</value>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public string Tier { get; set; }

        /// <summary>
        /// Country of location.
        /// </summary>
        /// <value>Country of location.</value>
        [DataMember(Name="location", EmitDefaultValue=false)]
        public string Location { get; set; }

        /// <summary>
        /// Organisation count.
        /// </summary>
        /// <value>Organisation count.</value>
        [DataMember(Name="organisationCount", EmitDefaultValue=false)]
        public int? OrganisationCount { get; set; }

        /// <summary>
        /// Staff certified (true/false).
        /// </summary>
        /// <value>Staff certified (true/false).</value>
        [DataMember(Name="staffCertified", EmitDefaultValue=false)]
        public bool? StaffCertified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PracticeResponse {\n");
            sb.Append("  XeroPartnerSince: ").Append(XeroPartnerSince).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  Location: ").Append(Location).Append("\n");
            sb.Append("  OrganisationCount: ").Append(OrganisationCount).Append("\n");
            sb.Append("  StaffCertified: ").Append(StaffCertified).Append("\n");
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
            return this.Equals(input as PracticeResponse);
        }

        /// <summary>
        /// Returns true if PracticeResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PracticeResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PracticeResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.XeroPartnerSince == input.XeroPartnerSince ||
                    (this.XeroPartnerSince != null &&
                    this.XeroPartnerSince.Equals(input.XeroPartnerSince))
                ) && 
                (
                    this.Tier == input.Tier ||
                    (this.Tier != null &&
                    this.Tier.Equals(input.Tier))
                ) && 
                (
                    this.Location == input.Location ||
                    (this.Location != null &&
                    this.Location.Equals(input.Location))
                ) && 
                (
                    this.OrganisationCount == input.OrganisationCount ||
                    (this.OrganisationCount != null &&
                    this.OrganisationCount.Equals(input.OrganisationCount))
                ) && 
                (
                    this.StaffCertified == input.StaffCertified ||
                    (this.StaffCertified != null &&
                    this.StaffCertified.Equals(input.StaffCertified))
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
                if (this.XeroPartnerSince != null)
                    hashCode = hashCode * 59 + this.XeroPartnerSince.GetHashCode();
                if (this.Tier != null)
                    hashCode = hashCode * 59 + this.Tier.GetHashCode();
                if (this.Location != null)
                    hashCode = hashCode * 59 + this.Location.GetHashCode();
                if (this.OrganisationCount != null)
                    hashCode = hashCode * 59 + this.OrganisationCount.GetHashCode();
                if (this.StaffCertified != null)
                    hashCode = hashCode * 59 + this.StaffCertified.GetHashCode();
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
