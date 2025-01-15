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
    /// Task
    /// </summary>
    [DataContract]
    public partial class Task :  IEquatable<Task>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets ChargeType
        /// </summary>
        [DataMember(Name="chargeType", EmitDefaultValue=false)]
        public ChargeType ChargeType { get; set; }
        /// <summary>
        /// Status of the task. When a task of ChargeType is &#x60;FIXED&#x60; and the rate amount is invoiced the status will be set to &#x60;INVOICED&#x60; and can&#39;t be modified. A task with ChargeType of &#x60;TIME&#x60; or &#x60;NON_CHARGEABLE&#x60; cannot have a status of &#x60;INVOICED&#x60;. A &#x60;LOCKED&#x60; state indicates that the task is currently changing state (for example being invoiced) and can&#39;t be modified.
        /// </summary>
        /// <value>Status of the task. When a task of ChargeType is &#x60;FIXED&#x60; and the rate amount is invoiced the status will be set to &#x60;INVOICED&#x60; and can&#39;t be modified. A task with ChargeType of &#x60;TIME&#x60; or &#x60;NON_CHARGEABLE&#x60; cannot have a status of &#x60;INVOICED&#x60;. A &#x60;LOCKED&#x60; state indicates that the task is currently changing state (for example being invoiced) and can&#39;t be modified.</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,

            /// <summary>
            /// Enum INVOICED for value: INVOICED
            /// </summary>
            [EnumMember(Value = "INVOICED")]
            INVOICED = 2,

            /// <summary>
            /// Enum LOCKED for value: LOCKED
            /// </summary>
            [EnumMember(Value = "LOCKED")]
            LOCKED = 3

        }

        /// <summary>
        /// Status of the task. When a task of ChargeType is &#x60;FIXED&#x60; and the rate amount is invoiced the status will be set to &#x60;INVOICED&#x60; and can&#39;t be modified. A task with ChargeType of &#x60;TIME&#x60; or &#x60;NON_CHARGEABLE&#x60; cannot have a status of &#x60;INVOICED&#x60;. A &#x60;LOCKED&#x60; state indicates that the task is currently changing state (for example being invoiced) and can&#39;t be modified.
        /// </summary>
        /// <value>Status of the task. When a task of ChargeType is &#x60;FIXED&#x60; and the rate amount is invoiced the status will be set to &#x60;INVOICED&#x60; and can&#39;t be modified. A task with ChargeType of &#x60;TIME&#x60; or &#x60;NON_CHARGEABLE&#x60; cannot have a status of &#x60;INVOICED&#x60;. A &#x60;LOCKED&#x60; state indicates that the task is currently changing state (for example being invoiced) and can&#39;t be modified.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        
        /// <summary>
        /// Identifier of the task.
        /// </summary>
        /// <value>Identifier of the task.</value>
        [DataMember(Name="taskId", EmitDefaultValue=false)]
        public Guid? TaskId { get; set; }

        /// <summary>
        /// Name of the task.
        /// </summary>
        /// <value>Name of the task.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name="rate", EmitDefaultValue=false)]
        public Amount Rate { get; set; }

        /// <summary>
        /// An estimated time to perform the task
        /// </summary>
        /// <value>An estimated time to perform the task</value>
        [DataMember(Name="estimateMinutes", EmitDefaultValue=false)]
        public int? EstimateMinutes { get; set; }

        /// <summary>
        /// Identifier of the project task belongs to.
        /// </summary>
        /// <value>Identifier of the project task belongs to.</value>
        [DataMember(Name="projectId", EmitDefaultValue=false)]
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// Total minutes which have been logged against the task. Logged by assigning a time entry to a task
        /// </summary>
        /// <value>Total minutes which have been logged against the task. Logged by assigning a time entry to a task</value>
        [DataMember(Name="totalMinutes", EmitDefaultValue=false)]
        public int? TotalMinutes { get; set; }

        /// <summary>
        /// Gets or Sets TotalAmount
        /// </summary>
        [DataMember(Name="totalAmount", EmitDefaultValue=false)]
        public Amount TotalAmount { get; set; }

        /// <summary>
        /// Minutes on this task which have been invoiced.
        /// </summary>
        /// <value>Minutes on this task which have been invoiced.</value>
        [DataMember(Name="minutesInvoiced", EmitDefaultValue=false)]
        public int? MinutesInvoiced { get; set; }

        /// <summary>
        /// Minutes on this task which have not been invoiced.
        /// </summary>
        /// <value>Minutes on this task which have not been invoiced.</value>
        [DataMember(Name="minutesToBeInvoiced", EmitDefaultValue=false)]
        public int? MinutesToBeInvoiced { get; set; }

        /// <summary>
        /// Minutes logged against this task if its charge type is &#x60;FIXED&#x60;.
        /// </summary>
        /// <value>Minutes logged against this task if its charge type is &#x60;FIXED&#x60;.</value>
        [DataMember(Name="fixedMinutes", EmitDefaultValue=false)]
        public int? FixedMinutes { get; set; }

        /// <summary>
        /// Minutes logged against this task if its charge type is &#x60;NON_CHARGEABLE&#x60;.
        /// </summary>
        /// <value>Minutes logged against this task if its charge type is &#x60;NON_CHARGEABLE&#x60;.</value>
        [DataMember(Name="nonChargeableMinutes", EmitDefaultValue=false)]
        public int? NonChargeableMinutes { get; set; }

        /// <summary>
        /// Gets or Sets AmountToBeInvoiced
        /// </summary>
        [DataMember(Name="amountToBeInvoiced", EmitDefaultValue=false)]
        public Amount AmountToBeInvoiced { get; set; }

        /// <summary>
        /// Gets or Sets AmountInvoiced
        /// </summary>
        [DataMember(Name="amountInvoiced", EmitDefaultValue=false)]
        public Amount AmountInvoiced { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  TaskId: ").Append(TaskId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  EstimateMinutes: ").Append(EstimateMinutes).Append("\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  TotalMinutes: ").Append(TotalMinutes).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  MinutesInvoiced: ").Append(MinutesInvoiced).Append("\n");
            sb.Append("  MinutesToBeInvoiced: ").Append(MinutesToBeInvoiced).Append("\n");
            sb.Append("  FixedMinutes: ").Append(FixedMinutes).Append("\n");
            sb.Append("  NonChargeableMinutes: ").Append(NonChargeableMinutes).Append("\n");
            sb.Append("  AmountToBeInvoiced: ").Append(AmountToBeInvoiced).Append("\n");
            sb.Append("  AmountInvoiced: ").Append(AmountInvoiced).Append("\n");
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
            return this.Equals(input as Task);
        }

        /// <summary>
        /// Returns true if Task instances are equal
        /// </summary>
        /// <param name="input">Instance of Task to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Task input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TaskId == input.TaskId ||
                    (this.TaskId != null &&
                    this.TaskId.Equals(input.TaskId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Rate == input.Rate ||
                    (this.Rate != null &&
                    this.Rate.Equals(input.Rate))
                ) && 
                (
                    this.ChargeType == input.ChargeType ||
                    this.ChargeType.Equals(input.ChargeType)
                ) && 
                (
                    this.EstimateMinutes == input.EstimateMinutes ||
                    (this.EstimateMinutes != null &&
                    this.EstimateMinutes.Equals(input.EstimateMinutes))
                ) && 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.TotalMinutes == input.TotalMinutes ||
                    (this.TotalMinutes != null &&
                    this.TotalMinutes.Equals(input.TotalMinutes))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.MinutesInvoiced == input.MinutesInvoiced ||
                    (this.MinutesInvoiced != null &&
                    this.MinutesInvoiced.Equals(input.MinutesInvoiced))
                ) && 
                (
                    this.MinutesToBeInvoiced == input.MinutesToBeInvoiced ||
                    (this.MinutesToBeInvoiced != null &&
                    this.MinutesToBeInvoiced.Equals(input.MinutesToBeInvoiced))
                ) && 
                (
                    this.FixedMinutes == input.FixedMinutes ||
                    (this.FixedMinutes != null &&
                    this.FixedMinutes.Equals(input.FixedMinutes))
                ) && 
                (
                    this.NonChargeableMinutes == input.NonChargeableMinutes ||
                    (this.NonChargeableMinutes != null &&
                    this.NonChargeableMinutes.Equals(input.NonChargeableMinutes))
                ) && 
                (
                    this.AmountToBeInvoiced == input.AmountToBeInvoiced ||
                    (this.AmountToBeInvoiced != null &&
                    this.AmountToBeInvoiced.Equals(input.AmountToBeInvoiced))
                ) && 
                (
                    this.AmountInvoiced == input.AmountInvoiced ||
                    (this.AmountInvoiced != null &&
                    this.AmountInvoiced.Equals(input.AmountInvoiced))
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
                if (this.TaskId != null)
                    hashCode = hashCode * 59 + this.TaskId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Rate != null)
                    hashCode = hashCode * 59 + this.Rate.GetHashCode();
                hashCode = hashCode * 59 + this.ChargeType.GetHashCode();
                if (this.EstimateMinutes != null)
                    hashCode = hashCode * 59 + this.EstimateMinutes.GetHashCode();
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.TotalMinutes != null)
                    hashCode = hashCode * 59 + this.TotalMinutes.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                if (this.MinutesInvoiced != null)
                    hashCode = hashCode * 59 + this.MinutesInvoiced.GetHashCode();
                if (this.MinutesToBeInvoiced != null)
                    hashCode = hashCode * 59 + this.MinutesToBeInvoiced.GetHashCode();
                if (this.FixedMinutes != null)
                    hashCode = hashCode * 59 + this.FixedMinutes.GetHashCode();
                if (this.NonChargeableMinutes != null)
                    hashCode = hashCode * 59 + this.NonChargeableMinutes.GetHashCode();
                if (this.AmountToBeInvoiced != null)
                    hashCode = hashCode * 59 + this.AmountToBeInvoiced.GetHashCode();
                if (this.AmountInvoiced != null)
                    hashCode = hashCode * 59 + this.AmountInvoiced.GetHashCode();
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
