/* 
 * Xero Projects API
 *
 * This is the Xero Projects API
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

namespace Xero.DotNet.OAuth2.Model.Project
{
    /// <summary>
    /// TimeEntry
    /// </summary>
    [DataContract]
    public partial class TimeEntry :  IEquatable<TimeEntry>, IValidatableObject
    {
        /// <summary>
        /// Status of the time entry. By default a time entry is created with status of &#x60;ACTIVE&#x60;. A &#x60;LOCKED&#x60; state indicates that the time entry is currently changing state (for example being invoiced). Updates are not allowed when in this state. It will have a status of INVOICED once it is invoiced.
        /// </summary>
        /// <value>Status of the time entry. By default a time entry is created with status of &#x60;ACTIVE&#x60;. A &#x60;LOCKED&#x60; state indicates that the time entry is currently changing state (for example being invoiced). Updates are not allowed when in this state. It will have a status of INVOICED once it is invoiced.</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,

            /// <summary>
            /// Enum LOCKED for value: LOCKED
            /// </summary>
            [EnumMember(Value = "LOCKED")]
            LOCKED = 2,

            /// <summary>
            /// Enum INVOICED for value: INVOICED
            /// </summary>
            [EnumMember(Value = "INVOICED")]
            INVOICED = 3

        }

        /// <summary>
        /// Status of the time entry. By default a time entry is created with status of &#x60;ACTIVE&#x60;. A &#x60;LOCKED&#x60; state indicates that the time entry is currently changing state (for example being invoiced). Updates are not allowed when in this state. It will have a status of INVOICED once it is invoiced.
        /// </summary>
        /// <value>Status of the time entry. By default a time entry is created with status of &#x60;ACTIVE&#x60;. A &#x60;LOCKED&#x60; state indicates that the time entry is currently changing state (for example being invoiced). Updates are not allowed when in this state. It will have a status of INVOICED once it is invoiced.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        
        /// <summary>
        /// Identifier of the time entry.
        /// </summary>
        /// <value>Identifier of the time entry.</value>
        [DataMember(Name="timeEntryId", EmitDefaultValue=false)]
        public Guid? TimeEntryId { get; set; }

        /// <summary>
        /// The xero user identifier of the person who logged time.
        /// </summary>
        /// <value>The xero user identifier of the person who logged time.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Identifier of the project, that the task (which the time entry is logged against) belongs to.
        /// </summary>
        /// <value>Identifier of the project, that the task (which the time entry is logged against) belongs to.</value>
        [DataMember(Name="projectId", EmitDefaultValue=false)]
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// Identifier of the task that time entry is logged against.
        /// </summary>
        /// <value>Identifier of the task that time entry is logged against.</value>
        [DataMember(Name="taskId", EmitDefaultValue=false)]
        public Guid? TaskId { get; set; }

        /// <summary>
        /// The date time that time entry is logged on. UTC Date Time in ISO-8601 format.
        /// </summary>
        /// <value>The date time that time entry is logged on. UTC Date Time in ISO-8601 format.</value>
        [DataMember(Name="dateUtc", EmitDefaultValue=false)]
        public DateTime? DateUtc { get; set; }

        /// <summary>
        /// The date time that time entry is created. UTC Date Time in ISO-8601 format. By default it is set to server time.
        /// </summary>
        /// <value>The date time that time entry is created. UTC Date Time in ISO-8601 format. By default it is set to server time.</value>
        [DataMember(Name="dateEnteredUtc", EmitDefaultValue=false)]
        public DateTime? DateEnteredUtc { get; set; }

        /// <summary>
        /// The duration of logged minutes.
        /// </summary>
        /// <value>The duration of logged minutes.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// A description of the time entry.
        /// </summary>
        /// <value>A description of the time entry.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeEntry {\n");
            sb.Append("  TimeEntryId: ").Append(TimeEntryId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  DateUtc: ").Append(DateUtc).Append("\n");
            sb.Append("  DateEnteredUtc: ").Append(DateEnteredUtc).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as TimeEntry);
        }

        /// <summary>
        /// Returns true if TimeEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeEntryId == input.TimeEntryId ||
                    (this.TimeEntryId != null &&
                    this.TimeEntryId.Equals(input.TimeEntryId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.DateUtc == input.DateUtc ||
                    (this.DateUtc != null &&
                    this.DateUtc.Equals(input.DateUtc))
                ) && 
                (
                    this.DateEnteredUtc == input.DateEnteredUtc ||
                    (this.DateEnteredUtc != null &&
                    this.DateEnteredUtc.Equals(input.DateEnteredUtc))
                ) && 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
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
                if (this.TimeEntryId != null)
                    hashCode = hashCode * 59 + this.TimeEntryId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.DateUtc != null)
                    hashCode = hashCode * 59 + this.DateUtc.GetHashCode();
                if (this.DateEnteredUtc != null)
                    hashCode = hashCode * 59 + this.DateEnteredUtc.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
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
