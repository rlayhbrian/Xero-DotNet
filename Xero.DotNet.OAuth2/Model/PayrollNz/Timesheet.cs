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
    /// Timesheet
    /// </summary>
    [DataContract]
    public partial class Timesheet :  IEquatable<Timesheet>, IValidatableObject
    {
        /// <summary>
        /// Status of the timesheet
        /// </summary>
        /// <value>Status of the timesheet</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Draft for value: Draft
            /// </summary>
            [EnumMember(Value = "Draft")]
            Draft = 1,

            /// <summary>
            /// Enum Approved for value: Approved
            /// </summary>
            [EnumMember(Value = "Approved")]
            Approved = 2,

            /// <summary>
            /// Enum Completed for value: Completed
            /// </summary>
            [EnumMember(Value = "Completed")]
            Completed = 3,

            /// <summary>
            /// Enum Requested for value: Requested
            /// </summary>
            [EnumMember(Value = "Requested")]
            Requested = 4

        }

        /// <summary>
        /// Status of the timesheet
        /// </summary>
        /// <value>Status of the timesheet</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Timesheet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Timesheet() 
        {  
          TimesheetLines = new List<TimesheetLine>(); 
        }
        
        /// <summary>
        /// The Xero identifier for a Timesheet
        /// </summary>
        /// <value>The Xero identifier for a Timesheet</value>
        [DataMember(Name="timesheetID", EmitDefaultValue=false)]
        public Guid? TimesheetID { get; set; }

        /// <summary>
        /// The Xero identifier for the Payroll Calendar that the Timesheet applies to
        /// </summary>
        /// <value>The Xero identifier for the Payroll Calendar that the Timesheet applies to</value>
        [DataMember(Name="payrollCalendarID", EmitDefaultValue=false)]
        public Guid? PayrollCalendarID { get; set; }

        /// <summary>
        /// The Xero identifier for the Employee that the Timesheet is for
        /// </summary>
        /// <value>The Xero identifier for the Employee that the Timesheet is for</value>
        [DataMember(Name="employeeID", EmitDefaultValue=false)]
        public Guid? EmployeeID { get; set; }

        /// <summary>
        /// The Start Date of the Timesheet period (YYYY-MM-DD)
        /// </summary>
        /// <value>The Start Date of the Timesheet period (YYYY-MM-DD)</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The End Date of the Timesheet period (YYYY-MM-DD)
        /// </summary>
        /// <value>The End Date of the Timesheet period (YYYY-MM-DD)</value>
        [DataMember(Name="endDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// The Total Hours of the Timesheet
        /// </summary>
        /// <value>The Total Hours of the Timesheet</value>
        [DataMember(Name="totalHours", EmitDefaultValue=false)]
        public decimal? TotalHours { get; set; }

        /// <summary>
        /// The UTC date time that the Timesheet was last updated
        /// </summary>
        /// <value>The UTC date time that the Timesheet was last updated</value>
        [DataMember(Name="updatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; set; }

        /// <summary>
        /// Gets or Sets TimesheetLines
        /// </summary>
        [DataMember(Name="timesheetLines", EmitDefaultValue=false)]
        public List<TimesheetLine> TimesheetLines { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Timesheet {\n");
            sb.Append("  TimesheetID: ").Append(TimesheetID).Append("\n");
            sb.Append("  PayrollCalendarID: ").Append(PayrollCalendarID).Append("\n");
            sb.Append("  EmployeeID: ").Append(EmployeeID).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TotalHours: ").Append(TotalHours).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  TimesheetLines: ").Append(TimesheetLines).Append("\n");
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
            return this.Equals(input as Timesheet);
        }

        /// <summary>
        /// Returns true if Timesheet instances are equal
        /// </summary>
        /// <param name="input">Instance of Timesheet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Timesheet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimesheetID == input.TimesheetID ||
                    (this.TimesheetID != null &&
                    this.TimesheetID.Equals(input.TimesheetID))
                ) && 
                (
                    this.PayrollCalendarID == input.PayrollCalendarID ||
                    (this.PayrollCalendarID != null &&
                    this.PayrollCalendarID.Equals(input.PayrollCalendarID))
                ) && 
                (
                    this.EmployeeID == input.EmployeeID ||
                    (this.EmployeeID != null &&
                    this.EmployeeID.Equals(input.EmployeeID))
                ) && 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.EndDate == input.EndDate ||
                    (this.EndDate != null &&
                    this.EndDate.Equals(input.EndDate))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TotalHours == input.TotalHours ||
                    (this.TotalHours != null &&
                    this.TotalHours.Equals(input.TotalHours))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.TimesheetLines == input.TimesheetLines ||
                    this.TimesheetLines != null &&
                    input.TimesheetLines != null &&
                    this.TimesheetLines.SequenceEqual(input.TimesheetLines)
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
                if (this.TimesheetID != null)
                    hashCode = hashCode * 59 + this.TimesheetID.GetHashCode();
                if (this.PayrollCalendarID != null)
                    hashCode = hashCode * 59 + this.PayrollCalendarID.GetHashCode();
                if (this.EmployeeID != null)
                    hashCode = hashCode * 59 + this.EmployeeID.GetHashCode();
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null)
                    hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TotalHours != null)
                    hashCode = hashCode * 59 + this.TotalHours.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.TimesheetLines != null)
                    hashCode = hashCode * 59 + this.TimesheetLines.GetHashCode();
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
