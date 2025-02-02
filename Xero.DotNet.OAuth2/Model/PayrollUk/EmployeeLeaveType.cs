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
    /// EmployeeLeaveType
    /// </summary>
    [DataContract]
    public partial class EmployeeLeaveType :  IEquatable<EmployeeLeaveType>, IValidatableObject
    {
        /// <summary>
        /// The schedule of accrual
        /// </summary>
        /// <value>The schedule of accrual</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum ScheduleOfAccrualEnum
        {
            /// <summary>
            /// Enum BeginningOfCalendarYear for value: BeginningOfCalendarYear
            /// </summary>
            [EnumMember(Value = "BeginningOfCalendarYear")]
            BeginningOfCalendarYear = 1,

            /// <summary>
            /// Enum OnAnniversaryDate for value: OnAnniversaryDate
            /// </summary>
            [EnumMember(Value = "OnAnniversaryDate")]
            OnAnniversaryDate = 2,

            /// <summary>
            /// Enum EachPayPeriod for value: EachPayPeriod
            /// </summary>
            [EnumMember(Value = "EachPayPeriod")]
            EachPayPeriod = 3,

            /// <summary>
            /// Enum OnHourWorked for value: OnHourWorked
            /// </summary>
            [EnumMember(Value = "OnHourWorked")]
            OnHourWorked = 4

        }

        /// <summary>
        /// The schedule of accrual
        /// </summary>
        /// <value>The schedule of accrual</value>
        [DataMember(Name="scheduleOfAccrual", EmitDefaultValue=false)]
        public ScheduleOfAccrualEnum ScheduleOfAccrual { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeLeaveType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public EmployeeLeaveType() 
        { 
        }
        
        /// <summary>
        /// The Xero identifier for leave type
        /// </summary>
        /// <value>The Xero identifier for leave type</value>
        [DataMember(Name="leaveTypeID", EmitDefaultValue=false)]
        public Guid? LeaveTypeID { get; set; }

        /// <summary>
        /// The number of hours accrued for the leave annually. This is 0 when the scheduleOfAccrual chosen is \&quot;OnHourWorked\&quot;
        /// </summary>
        /// <value>The number of hours accrued for the leave annually. This is 0 when the scheduleOfAccrual chosen is \&quot;OnHourWorked\&quot;</value>
        [DataMember(Name="hoursAccruedAnnually", EmitDefaultValue=false)]
        public double? HoursAccruedAnnually { get; set; }

        /// <summary>
        /// The maximum number of hours that can be accrued for the leave
        /// </summary>
        /// <value>The maximum number of hours that can be accrued for the leave</value>
        [DataMember(Name="maximumToAccrue", EmitDefaultValue=false)]
        public double? MaximumToAccrue { get; set; }

        /// <summary>
        /// The initial number of hours assigned when the leave was added to the employee
        /// </summary>
        /// <value>The initial number of hours assigned when the leave was added to the employee</value>
        [DataMember(Name="openingBalance", EmitDefaultValue=false)]
        public double? OpeningBalance { get; set; }

        /// <summary>
        /// The number of hours added to the leave balance for every hour worked by the employee. This is normally 0, unless the scheduleOfAccrual chosen is \&quot;OnHourWorked\&quot;
        /// </summary>
        /// <value>The number of hours added to the leave balance for every hour worked by the employee. This is normally 0, unless the scheduleOfAccrual chosen is \&quot;OnHourWorked\&quot;</value>
        [DataMember(Name="rateAccruedHourly", EmitDefaultValue=false)]
        public double? RateAccruedHourly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeLeaveType {\n");
            sb.Append("  LeaveTypeID: ").Append(LeaveTypeID).Append("\n");
            sb.Append("  ScheduleOfAccrual: ").Append(ScheduleOfAccrual).Append("\n");
            sb.Append("  HoursAccruedAnnually: ").Append(HoursAccruedAnnually).Append("\n");
            sb.Append("  MaximumToAccrue: ").Append(MaximumToAccrue).Append("\n");
            sb.Append("  OpeningBalance: ").Append(OpeningBalance).Append("\n");
            sb.Append("  RateAccruedHourly: ").Append(RateAccruedHourly).Append("\n");
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
            return this.Equals(input as EmployeeLeaveType);
        }

        /// <summary>
        /// Returns true if EmployeeLeaveType instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeLeaveType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeLeaveType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LeaveTypeID == input.LeaveTypeID ||
                    (this.LeaveTypeID != null &&
                    this.LeaveTypeID.Equals(input.LeaveTypeID))
                ) && 
                (
                    this.ScheduleOfAccrual == input.ScheduleOfAccrual ||
                    this.ScheduleOfAccrual.Equals(input.ScheduleOfAccrual)
                ) && 
                (
                    this.HoursAccruedAnnually == input.HoursAccruedAnnually ||
                    (this.HoursAccruedAnnually != null &&
                    this.HoursAccruedAnnually.Equals(input.HoursAccruedAnnually))
                ) && 
                (
                    this.MaximumToAccrue == input.MaximumToAccrue ||
                    (this.MaximumToAccrue != null &&
                    this.MaximumToAccrue.Equals(input.MaximumToAccrue))
                ) && 
                (
                    this.OpeningBalance == input.OpeningBalance ||
                    (this.OpeningBalance != null &&
                    this.OpeningBalance.Equals(input.OpeningBalance))
                ) && 
                (
                    this.RateAccruedHourly == input.RateAccruedHourly ||
                    (this.RateAccruedHourly != null &&
                    this.RateAccruedHourly.Equals(input.RateAccruedHourly))
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
                if (this.LeaveTypeID != null)
                    hashCode = hashCode * 59 + this.LeaveTypeID.GetHashCode();
                hashCode = hashCode * 59 + this.ScheduleOfAccrual.GetHashCode();
                if (this.HoursAccruedAnnually != null)
                    hashCode = hashCode * 59 + this.HoursAccruedAnnually.GetHashCode();
                if (this.MaximumToAccrue != null)
                    hashCode = hashCode * 59 + this.MaximumToAccrue.GetHashCode();
                if (this.OpeningBalance != null)
                    hashCode = hashCode * 59 + this.OpeningBalance.GetHashCode();
                if (this.RateAccruedHourly != null)
                    hashCode = hashCode * 59 + this.RateAccruedHourly.GetHashCode();
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
