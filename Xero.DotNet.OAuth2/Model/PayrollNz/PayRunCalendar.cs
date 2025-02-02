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
    /// PayRunCalendar
    /// </summary>
    [DataContract]
    public partial class PayRunCalendar :  IEquatable<PayRunCalendar>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CalendarType
        /// </summary>
        [DataMember(Name="calendarType", EmitDefaultValue=false)]
        public CalendarType CalendarType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayRunCalendar" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public PayRunCalendar() 
        { 
        }
        
        /// <summary>
        /// Xero unique identifier for the payroll calendar
        /// </summary>
        /// <value>Xero unique identifier for the payroll calendar</value>
        [DataMember(Name="payrollCalendarID", EmitDefaultValue=false)]
        public Guid? PayrollCalendarID { get; set; }

        /// <summary>
        /// Name of the calendar
        /// </summary>
        /// <value>Name of the calendar</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Period start date of the calendar
        /// </summary>
        /// <value>Period start date of the calendar</value>
        [DataMember(Name="periodStartDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PeriodStartDate { get; set; }

        /// <summary>
        /// Period end date of the calendar
        /// </summary>
        /// <value>Period end date of the calendar</value>
        [DataMember(Name="periodEndDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PeriodEndDate { get; set; }

        /// <summary>
        /// Payment date of the calendar
        /// </summary>
        /// <value>Payment date of the calendar</value>
        [DataMember(Name="paymentDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PaymentDate { get; set; }

        /// <summary>
        /// UTC timestamp of the last update to the pay run calendar
        /// </summary>
        /// <value>UTC timestamp of the last update to the pay run calendar</value>
        [DataMember(Name="updatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayRunCalendar {\n");
            sb.Append("  PayrollCalendarID: ").Append(PayrollCalendarID).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CalendarType: ").Append(CalendarType).Append("\n");
            sb.Append("  PeriodStartDate: ").Append(PeriodStartDate).Append("\n");
            sb.Append("  PeriodEndDate: ").Append(PeriodEndDate).Append("\n");
            sb.Append("  PaymentDate: ").Append(PaymentDate).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
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
            return this.Equals(input as PayRunCalendar);
        }

        /// <summary>
        /// Returns true if PayRunCalendar instances are equal
        /// </summary>
        /// <param name="input">Instance of PayRunCalendar to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayRunCalendar input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CalendarType == input.CalendarType ||
                    this.CalendarType.Equals(input.CalendarType)
                ) && 
                (
                    this.PeriodStartDate == input.PeriodStartDate ||
                    (this.PeriodStartDate != null &&
                    this.PeriodStartDate.Equals(input.PeriodStartDate))
                ) && 
                (
                    this.PeriodEndDate == input.PeriodEndDate ||
                    (this.PeriodEndDate != null &&
                    this.PeriodEndDate.Equals(input.PeriodEndDate))
                ) && 
                (
                    this.PaymentDate == input.PaymentDate ||
                    (this.PaymentDate != null &&
                    this.PaymentDate.Equals(input.PaymentDate))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.CalendarType.GetHashCode();
                if (this.PeriodStartDate != null)
                    hashCode = hashCode * 59 + this.PeriodStartDate.GetHashCode();
                if (this.PeriodEndDate != null)
                    hashCode = hashCode * 59 + this.PeriodEndDate.GetHashCode();
                if (this.PaymentDate != null)
                    hashCode = hashCode * 59 + this.PaymentDate.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
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
