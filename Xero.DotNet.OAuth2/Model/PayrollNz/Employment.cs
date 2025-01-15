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
    /// Employment
    /// </summary>
    [DataContract]
    public partial class Employment :  IEquatable<Employment>, IValidatableObject
    {
        
        /// <summary>
        /// Xero unique identifier for the payroll calendar of the employee
        /// </summary>
        /// <value>Xero unique identifier for the payroll calendar of the employee</value>
        [DataMember(Name="payrollCalendarID", EmitDefaultValue=false)]
        public Guid? PayrollCalendarID { get; set; }

        /// <summary>
        /// Xero unique identifier for the payrun calendar for the employee (Deprecated in version 1.1.6)
        /// </summary>
        /// <value>Xero unique identifier for the payrun calendar for the employee (Deprecated in version 1.1.6)</value>
        [DataMember(Name="payRunCalendarID", EmitDefaultValue=false)]
        public Guid? PayRunCalendarID { get; set; }

        /// <summary>
        /// Start date of the employment (YYYY-MM-DD)
        /// </summary>
        /// <value>Start date of the employment (YYYY-MM-DD)</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Engagement type of the employee
        /// </summary>
        /// <value>Engagement type of the employee</value>
        [DataMember(Name="engagementType", EmitDefaultValue=false)]
        public string EngagementType { get; set; }

        /// <summary>
        /// End date for an employee with a fixed-term engagement type
        /// </summary>
        /// <value>End date for an employee with a fixed-term engagement type</value>
        [DataMember(Name="fixedTermEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? FixedTermEndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Employment {\n");
            sb.Append("  PayrollCalendarID: ").Append(PayrollCalendarID).Append("\n");
            sb.Append("  PayRunCalendarID: ").Append(PayRunCalendarID).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EngagementType: ").Append(EngagementType).Append("\n");
            sb.Append("  FixedTermEndDate: ").Append(FixedTermEndDate).Append("\n");
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
            return this.Equals(input as Employment);
        }

        /// <summary>
        /// Returns true if Employment instances are equal
        /// </summary>
        /// <param name="input">Instance of Employment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Employment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PayrollCalendarID == input.PayrollCalendarID ||
                    (this.PayrollCalendarID != null &&
                    this.PayrollCalendarID.Equals(input.PayrollCalendarID))
                ) && 
                (
                    this.PayRunCalendarID == input.PayRunCalendarID ||
                    (this.PayRunCalendarID != null &&
                    this.PayRunCalendarID.Equals(input.PayRunCalendarID))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EngagementType == input.EngagementType ||
                    (this.EngagementType != null &&
                    this.EngagementType.Equals(input.EngagementType))
                ) && 
                (
                    this.FixedTermEndDate == input.FixedTermEndDate ||
                    (this.FixedTermEndDate != null &&
                    this.FixedTermEndDate.Equals(input.FixedTermEndDate))
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
                if (this.PayrollCalendarID != null)
                    hashCode = hashCode * 59 + this.PayrollCalendarID.GetHashCode();
                if (this.PayRunCalendarID != null)
                    hashCode = hashCode * 59 + this.PayRunCalendarID.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EngagementType != null)
                    hashCode = hashCode * 59 + this.EngagementType.GetHashCode();
                if (this.FixedTermEndDate != null)
                    hashCode = hashCode * 59 + this.FixedTermEndDate.GetHashCode();
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
