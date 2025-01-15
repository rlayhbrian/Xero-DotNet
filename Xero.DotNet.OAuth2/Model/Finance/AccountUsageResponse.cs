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
    /// AccountUsageResponse
    /// </summary>
    [DataContract]
    public partial class AccountUsageResponse :  IEquatable<AccountUsageResponse>, IValidatableObject
    {
        
        /// <summary>
        /// The requested Organisation to which the data pertains
        /// </summary>
        /// <value>The requested Organisation to which the data pertains</value>
        [DataMember(Name="organisationId", EmitDefaultValue=false)]
        public Guid? OrganisationId { get; set; }

        /// <summary>
        /// The start month of the report
        /// </summary>
        /// <value>The start month of the report</value>
        [DataMember(Name="startMonth", EmitDefaultValue=false)]
        public string StartMonth { get; set; }

        /// <summary>
        /// The end month of the report
        /// </summary>
        /// <value>The end month of the report</value>
        [DataMember(Name="endMonth", EmitDefaultValue=false)]
        public string EndMonth { get; set; }

        /// <summary>
        /// Gets or Sets AccountUsage
        /// </summary>
        [DataMember(Name="accountUsage", EmitDefaultValue=false)]
        public List<AccountUsage> AccountUsage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountUsageResponse {\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
            sb.Append("  StartMonth: ").Append(StartMonth).Append("\n");
            sb.Append("  EndMonth: ").Append(EndMonth).Append("\n");
            sb.Append("  AccountUsage: ").Append(AccountUsage).Append("\n");
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
            return this.Equals(input as AccountUsageResponse);
        }

        /// <summary>
        /// Returns true if AccountUsageResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountUsageResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountUsageResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.OrganisationId == input.OrganisationId ||
                    (this.OrganisationId != null &&
                    this.OrganisationId.Equals(input.OrganisationId))
                ) && 
                (
                    this.StartMonth == input.StartMonth ||
                    (this.StartMonth != null &&
                    this.StartMonth.Equals(input.StartMonth))
                ) && 
                (
                    this.EndMonth == input.EndMonth ||
                    (this.EndMonth != null &&
                    this.EndMonth.Equals(input.EndMonth))
                ) && 
                (
                    this.AccountUsage == input.AccountUsage ||
                    this.AccountUsage != null &&
                    input.AccountUsage != null &&
                    this.AccountUsage.SequenceEqual(input.AccountUsage)
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
                if (this.OrganisationId != null)
                    hashCode = hashCode * 59 + this.OrganisationId.GetHashCode();
                if (this.StartMonth != null)
                    hashCode = hashCode * 59 + this.StartMonth.GetHashCode();
                if (this.EndMonth != null)
                    hashCode = hashCode * 59 + this.EndMonth.GetHashCode();
                if (this.AccountUsage != null)
                    hashCode = hashCode * 59 + this.AccountUsage.GetHashCode();
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
