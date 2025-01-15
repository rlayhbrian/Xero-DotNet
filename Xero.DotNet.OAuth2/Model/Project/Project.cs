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
    /// Project
    /// </summary>
    [DataContract]
    public partial class Project :  IEquatable<Project>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="currencyCode", EmitDefaultValue=false)]
        public CurrencyCode CurrencyCode { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public ProjectStatus Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Project() 
        { 
        }
        
        /// <summary>
        /// Identifier of the project.
        /// </summary>
        /// <value>Identifier of the project.</value>
        [DataMember(Name="projectId", EmitDefaultValue=false)]
        public Guid? ProjectId { get; set; }

        /// <summary>
        /// Identifier of the contact this project was created for.
        /// </summary>
        /// <value>Identifier of the contact this project was created for.</value>
        [DataMember(Name="contactId", EmitDefaultValue=false)]
        public Guid? ContactId { get; set; }

        /// <summary>
        /// Name of the project.
        /// </summary>
        /// <value>Name of the project.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A total of minutes logged against all tasks on the Project.
        /// </summary>
        /// <value>A total of minutes logged against all tasks on the Project.</value>
        [DataMember(Name="minutesLogged", EmitDefaultValue=false)]
        public int? MinutesLogged { get; set; }

        /// <summary>
        /// Gets or Sets TotalTaskAmount
        /// </summary>
        [DataMember(Name="totalTaskAmount", EmitDefaultValue=false)]
        public Amount TotalTaskAmount { get; set; }

        /// <summary>
        /// Gets or Sets TotalExpenseAmount
        /// </summary>
        [DataMember(Name="totalExpenseAmount", EmitDefaultValue=false)]
        public Amount TotalExpenseAmount { get; set; }

        /// <summary>
        /// Gets or Sets EstimateAmount
        /// </summary>
        [DataMember(Name="estimateAmount", EmitDefaultValue=false)]
        public Amount EstimateAmount { get; set; }

        /// <summary>
        /// Minutes which have not been invoiced across all chargeable tasks in the project.
        /// </summary>
        /// <value>Minutes which have not been invoiced across all chargeable tasks in the project.</value>
        [DataMember(Name="minutesToBeInvoiced", EmitDefaultValue=false)]
        public int? MinutesToBeInvoiced { get; set; }

        /// <summary>
        /// Gets or Sets TaskAmountToBeInvoiced
        /// </summary>
        [DataMember(Name="taskAmountToBeInvoiced", EmitDefaultValue=false)]
        public Amount TaskAmountToBeInvoiced { get; set; }

        /// <summary>
        /// Gets or Sets TaskAmountInvoiced
        /// </summary>
        [DataMember(Name="taskAmountInvoiced", EmitDefaultValue=false)]
        public Amount TaskAmountInvoiced { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseAmountToBeInvoiced
        /// </summary>
        [DataMember(Name="expenseAmountToBeInvoiced", EmitDefaultValue=false)]
        public Amount ExpenseAmountToBeInvoiced { get; set; }

        /// <summary>
        /// Gets or Sets ExpenseAmountInvoiced
        /// </summary>
        [DataMember(Name="expenseAmountInvoiced", EmitDefaultValue=false)]
        public Amount ExpenseAmountInvoiced { get; set; }

        /// <summary>
        /// Gets or Sets ProjectAmountInvoiced
        /// </summary>
        [DataMember(Name="projectAmountInvoiced", EmitDefaultValue=false)]
        public Amount ProjectAmountInvoiced { get; set; }

        /// <summary>
        /// Gets or Sets Deposit
        /// </summary>
        [DataMember(Name="deposit", EmitDefaultValue=false)]
        public Amount Deposit { get; set; }

        /// <summary>
        /// Gets or Sets DepositApplied
        /// </summary>
        [DataMember(Name="depositApplied", EmitDefaultValue=false)]
        public Amount DepositApplied { get; set; }

        /// <summary>
        /// Gets or Sets CreditNoteAmount
        /// </summary>
        [DataMember(Name="creditNoteAmount", EmitDefaultValue=false)]
        public Amount CreditNoteAmount { get; set; }

        /// <summary>
        /// Deadline for the project. UTC Date Time in ISO-8601 format.
        /// </summary>
        /// <value>Deadline for the project. UTC Date Time in ISO-8601 format.</value>
        [DataMember(Name="deadlineUtc", EmitDefaultValue=false)]
        public DateTime? DeadlineUtc { get; set; }

        /// <summary>
        /// Gets or Sets TotalInvoiced
        /// </summary>
        [DataMember(Name="totalInvoiced", EmitDefaultValue=false)]
        public Amount TotalInvoiced { get; set; }

        /// <summary>
        /// Gets or Sets TotalToBeInvoiced
        /// </summary>
        [DataMember(Name="totalToBeInvoiced", EmitDefaultValue=false)]
        public Amount TotalToBeInvoiced { get; set; }

        /// <summary>
        /// Gets or Sets Estimate
        /// </summary>
        [DataMember(Name="estimate", EmitDefaultValue=false)]
        public Amount Estimate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Project {\n");
            sb.Append("  ProjectId: ").Append(ProjectId).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  MinutesLogged: ").Append(MinutesLogged).Append("\n");
            sb.Append("  TotalTaskAmount: ").Append(TotalTaskAmount).Append("\n");
            sb.Append("  TotalExpenseAmount: ").Append(TotalExpenseAmount).Append("\n");
            sb.Append("  EstimateAmount: ").Append(EstimateAmount).Append("\n");
            sb.Append("  MinutesToBeInvoiced: ").Append(MinutesToBeInvoiced).Append("\n");
            sb.Append("  TaskAmountToBeInvoiced: ").Append(TaskAmountToBeInvoiced).Append("\n");
            sb.Append("  TaskAmountInvoiced: ").Append(TaskAmountInvoiced).Append("\n");
            sb.Append("  ExpenseAmountToBeInvoiced: ").Append(ExpenseAmountToBeInvoiced).Append("\n");
            sb.Append("  ExpenseAmountInvoiced: ").Append(ExpenseAmountInvoiced).Append("\n");
            sb.Append("  ProjectAmountInvoiced: ").Append(ProjectAmountInvoiced).Append("\n");
            sb.Append("  Deposit: ").Append(Deposit).Append("\n");
            sb.Append("  DepositApplied: ").Append(DepositApplied).Append("\n");
            sb.Append("  CreditNoteAmount: ").Append(CreditNoteAmount).Append("\n");
            sb.Append("  DeadlineUtc: ").Append(DeadlineUtc).Append("\n");
            sb.Append("  TotalInvoiced: ").Append(TotalInvoiced).Append("\n");
            sb.Append("  TotalToBeInvoiced: ").Append(TotalToBeInvoiced).Append("\n");
            sb.Append("  Estimate: ").Append(Estimate).Append("\n");
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
            return this.Equals(input as Project);
        }

        /// <summary>
        /// Returns true if Project instances are equal
        /// </summary>
        /// <param name="input">Instance of Project to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Project input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProjectId == input.ProjectId ||
                    (this.ProjectId != null &&
                    this.ProjectId.Equals(input.ProjectId))
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    this.CurrencyCode.Equals(input.CurrencyCode)
                ) && 
                (
                    this.MinutesLogged == input.MinutesLogged ||
                    (this.MinutesLogged != null &&
                    this.MinutesLogged.Equals(input.MinutesLogged))
                ) && 
                (
                    this.TotalTaskAmount == input.TotalTaskAmount ||
                    (this.TotalTaskAmount != null &&
                    this.TotalTaskAmount.Equals(input.TotalTaskAmount))
                ) && 
                (
                    this.TotalExpenseAmount == input.TotalExpenseAmount ||
                    (this.TotalExpenseAmount != null &&
                    this.TotalExpenseAmount.Equals(input.TotalExpenseAmount))
                ) && 
                (
                    this.EstimateAmount == input.EstimateAmount ||
                    (this.EstimateAmount != null &&
                    this.EstimateAmount.Equals(input.EstimateAmount))
                ) && 
                (
                    this.MinutesToBeInvoiced == input.MinutesToBeInvoiced ||
                    (this.MinutesToBeInvoiced != null &&
                    this.MinutesToBeInvoiced.Equals(input.MinutesToBeInvoiced))
                ) && 
                (
                    this.TaskAmountToBeInvoiced == input.TaskAmountToBeInvoiced ||
                    (this.TaskAmountToBeInvoiced != null &&
                    this.TaskAmountToBeInvoiced.Equals(input.TaskAmountToBeInvoiced))
                ) && 
                (
                    this.TaskAmountInvoiced == input.TaskAmountInvoiced ||
                    (this.TaskAmountInvoiced != null &&
                    this.TaskAmountInvoiced.Equals(input.TaskAmountInvoiced))
                ) && 
                (
                    this.ExpenseAmountToBeInvoiced == input.ExpenseAmountToBeInvoiced ||
                    (this.ExpenseAmountToBeInvoiced != null &&
                    this.ExpenseAmountToBeInvoiced.Equals(input.ExpenseAmountToBeInvoiced))
                ) && 
                (
                    this.ExpenseAmountInvoiced == input.ExpenseAmountInvoiced ||
                    (this.ExpenseAmountInvoiced != null &&
                    this.ExpenseAmountInvoiced.Equals(input.ExpenseAmountInvoiced))
                ) && 
                (
                    this.ProjectAmountInvoiced == input.ProjectAmountInvoiced ||
                    (this.ProjectAmountInvoiced != null &&
                    this.ProjectAmountInvoiced.Equals(input.ProjectAmountInvoiced))
                ) && 
                (
                    this.Deposit == input.Deposit ||
                    (this.Deposit != null &&
                    this.Deposit.Equals(input.Deposit))
                ) && 
                (
                    this.DepositApplied == input.DepositApplied ||
                    (this.DepositApplied != null &&
                    this.DepositApplied.Equals(input.DepositApplied))
                ) && 
                (
                    this.CreditNoteAmount == input.CreditNoteAmount ||
                    (this.CreditNoteAmount != null &&
                    this.CreditNoteAmount.Equals(input.CreditNoteAmount))
                ) && 
                (
                    this.DeadlineUtc == input.DeadlineUtc ||
                    (this.DeadlineUtc != null &&
                    this.DeadlineUtc.Equals(input.DeadlineUtc))
                ) && 
                (
                    this.TotalInvoiced == input.TotalInvoiced ||
                    (this.TotalInvoiced != null &&
                    this.TotalInvoiced.Equals(input.TotalInvoiced))
                ) && 
                (
                    this.TotalToBeInvoiced == input.TotalToBeInvoiced ||
                    (this.TotalToBeInvoiced != null &&
                    this.TotalToBeInvoiced.Equals(input.TotalToBeInvoiced))
                ) && 
                (
                    this.Estimate == input.Estimate ||
                    (this.Estimate != null &&
                    this.Estimate.Equals(input.Estimate))
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
                if (this.ProjectId != null)
                    hashCode = hashCode * 59 + this.ProjectId.GetHashCode();
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.MinutesLogged != null)
                    hashCode = hashCode * 59 + this.MinutesLogged.GetHashCode();
                if (this.TotalTaskAmount != null)
                    hashCode = hashCode * 59 + this.TotalTaskAmount.GetHashCode();
                if (this.TotalExpenseAmount != null)
                    hashCode = hashCode * 59 + this.TotalExpenseAmount.GetHashCode();
                if (this.EstimateAmount != null)
                    hashCode = hashCode * 59 + this.EstimateAmount.GetHashCode();
                if (this.MinutesToBeInvoiced != null)
                    hashCode = hashCode * 59 + this.MinutesToBeInvoiced.GetHashCode();
                if (this.TaskAmountToBeInvoiced != null)
                    hashCode = hashCode * 59 + this.TaskAmountToBeInvoiced.GetHashCode();
                if (this.TaskAmountInvoiced != null)
                    hashCode = hashCode * 59 + this.TaskAmountInvoiced.GetHashCode();
                if (this.ExpenseAmountToBeInvoiced != null)
                    hashCode = hashCode * 59 + this.ExpenseAmountToBeInvoiced.GetHashCode();
                if (this.ExpenseAmountInvoiced != null)
                    hashCode = hashCode * 59 + this.ExpenseAmountInvoiced.GetHashCode();
                if (this.ProjectAmountInvoiced != null)
                    hashCode = hashCode * 59 + this.ProjectAmountInvoiced.GetHashCode();
                if (this.Deposit != null)
                    hashCode = hashCode * 59 + this.Deposit.GetHashCode();
                if (this.DepositApplied != null)
                    hashCode = hashCode * 59 + this.DepositApplied.GetHashCode();
                if (this.CreditNoteAmount != null)
                    hashCode = hashCode * 59 + this.CreditNoteAmount.GetHashCode();
                if (this.DeadlineUtc != null)
                    hashCode = hashCode * 59 + this.DeadlineUtc.GetHashCode();
                if (this.TotalInvoiced != null)
                    hashCode = hashCode * 59 + this.TotalInvoiced.GetHashCode();
                if (this.TotalToBeInvoiced != null)
                    hashCode = hashCode * 59 + this.TotalToBeInvoiced.GetHashCode();
                if (this.Estimate != null)
                    hashCode = hashCode * 59 + this.Estimate.GetHashCode();
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
