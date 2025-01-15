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
    /// TimeEntryCreateOrUpdate
    /// </summary>
    [DataContract]
    public partial class TimeEntryCreateOrUpdate :  IEquatable<TimeEntryCreateOrUpdate>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimeEntryCreateOrUpdate" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TimeEntryCreateOrUpdate() 
        { 
        }
        
        /// <summary>
        /// The xero user identifier of the person logging the time.
        /// </summary>
        /// <value>The xero user identifier of the person logging the time.</value>
        [DataMember(Name="userId", EmitDefaultValue=false)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Identifier of the task that time entry is logged against.
        /// </summary>
        /// <value>Identifier of the task that time entry is logged against.</value>
        [DataMember(Name="taskId", EmitDefaultValue=false)]
        public Guid? TaskId { get; set; }

        /// <summary>
        /// Date time entry is logged on. UTC Date Time in ISO-8601 format.
        /// </summary>
        /// <value>Date time entry is logged on. UTC Date Time in ISO-8601 format.</value>
        [DataMember(Name="dateUtc", EmitDefaultValue=false)]
        public DateTime? DateUtc { get; set; }

        /// <summary>
        /// Number of minutes to be logged. Duration is between 1 and 59940 inclusively.
        /// </summary>
        /// <value>Number of minutes to be logged. Duration is between 1 and 59940 inclusively.</value>
        [DataMember(Name="duration", EmitDefaultValue=false)]
        public int? Duration { get; set; }

        /// <summary>
        /// An optional description of the time entry, will be set to null if not provided during update.
        /// </summary>
        /// <value>An optional description of the time entry, will be set to null if not provided during update.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimeEntryCreateOrUpdate {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  DateUtc: ").Append(DateUtc).Append("\n");
            sb.Append("  Duration: ").Append(Duration).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as TimeEntryCreateOrUpdate);
        }

        /// <summary>
        /// Returns true if TimeEntryCreateOrUpdate instances are equal
        /// </summary>
        /// <param name="input">Instance of TimeEntryCreateOrUpdate to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimeEntryCreateOrUpdate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.DateUtc != null)
                    hashCode = hashCode * 59 + this.DateUtc.GetHashCode();
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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
