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
    /// LockHistoryResponse
    /// </summary>
    [DataContract]
    public partial class LockHistoryResponse :  IEquatable<LockHistoryResponse>, IValidatableObject
    {
        
        /// <summary>
        /// The requested Organisation to which the data pertains
        /// </summary>
        /// <value>The requested Organisation to which the data pertains</value>
        [DataMember(Name="organisationId", EmitDefaultValue=false)]
        public Guid? OrganisationId { get; set; }

        /// <summary>
        /// The end date of the report
        /// </summary>
        /// <value>The end date of the report</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Gets or Sets LockDates
        /// </summary>
        [DataMember(Name="lockDates", EmitDefaultValue=false)]
        public List<LockHistoryModel> LockDates { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LockHistoryResponse {\n");
            sb.Append("  OrganisationId: ").Append(OrganisationId).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  LockDates: ").Append(LockDates).Append("\n");
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
            return this.Equals(input as LockHistoryResponse);
        }

        /// <summary>
        /// Returns true if LockHistoryResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of LockHistoryResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LockHistoryResponse input)
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
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.LockDates == input.LockDates ||
                    this.LockDates != null &&
                    input.LockDates != null &&
                    this.LockDates.SequenceEqual(input.LockDates)
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
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.LockDates != null)
                    hashCode = hashCode * 59 + this.LockDates.GetHashCode();
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
