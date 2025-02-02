/* 
 * Xero Accounting API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
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

namespace Xero.DotNet.OAuth2.Model.Accounting
{
    /// <summary>
    /// BankTransfer
    /// </summary>
    [DataContract]
    public partial class BankTransfer :  IEquatable<BankTransfer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankTransfer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public BankTransfer() 
        {  
          ValidationErrors = new List<ValidationError>(); 
        }
        
        /// <summary>
        /// Gets or Sets FromBankAccount
        /// </summary>
        [DataMember(Name="FromBankAccount", EmitDefaultValue=false)]
        public Account FromBankAccount { get; set; }

        /// <summary>
        /// Gets or Sets ToBankAccount
        /// </summary>
        [DataMember(Name="ToBankAccount", EmitDefaultValue=false)]
        public Account ToBankAccount { get; set; }

        /// <summary>
        /// amount of the transaction
        /// </summary>
        /// <value>amount of the transaction</value>
        [DataMember(Name="Amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The date of the Transfer YYYY-MM-DD
        /// </summary>
        /// <value>The date of the Transfer YYYY-MM-DD</value>
        [DataMember(Name="Date", EmitDefaultValue=false)]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The identifier of the Bank Transfer
        /// </summary>
        /// <value>The identifier of the Bank Transfer</value>
        [DataMember(Name="BankTransferID", EmitDefaultValue=false)]
        public Guid? BankTransferID { get; private set; }

        /// <summary>
        /// The currency rate
        /// </summary>
        /// <value>The currency rate</value>
        [DataMember(Name="CurrencyRate", EmitDefaultValue=false)]
        public decimal? CurrencyRate { get; private set; }

        /// <summary>
        /// The Bank Transaction ID for the source account
        /// </summary>
        /// <value>The Bank Transaction ID for the source account</value>
        [DataMember(Name="FromBankTransactionID", EmitDefaultValue=false)]
        public Guid? FromBankTransactionID { get; private set; }

        /// <summary>
        /// The Bank Transaction ID for the destination account
        /// </summary>
        /// <value>The Bank Transaction ID for the destination account</value>
        [DataMember(Name="ToBankTransactionID", EmitDefaultValue=false)]
        public Guid? ToBankTransactionID { get; private set; }

        /// <summary>
        /// The Bank Transaction boolean to show if it is reconciled for the source account
        /// </summary>
        /// <value>The Bank Transaction boolean to show if it is reconciled for the source account</value>
        [DataMember(Name="FromIsReconciled", EmitDefaultValue=false)]
        public bool? FromIsReconciled { get; set; }

        /// <summary>
        /// The Bank Transaction boolean to show if it is reconciled for the destination account
        /// </summary>
        /// <value>The Bank Transaction boolean to show if it is reconciled for the destination account</value>
        [DataMember(Name="ToIsReconciled", EmitDefaultValue=false)]
        public bool? ToIsReconciled { get; set; }

        /// <summary>
        /// Reference for the transactions.
        /// </summary>
        /// <value>Reference for the transactions.</value>
        [DataMember(Name="Reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// Boolean to indicate if a Bank Transfer has an attachment
        /// </summary>
        /// <value>Boolean to indicate if a Bank Transfer has an attachment</value>
        [DataMember(Name="HasAttachments", EmitDefaultValue=false)]
        public bool? HasAttachments { get; private set; }

        /// <summary>
        /// UTC timestamp of creation date of bank transfer
        /// </summary>
        /// <value>UTC timestamp of creation date of bank transfer</value>
        [DataMember(Name="CreatedDateUTC", EmitDefaultValue=false)]
        public DateTime? CreatedDateUTC { get; private set; }

        /// <summary>
        /// Displays array of validation error messages from the API
        /// </summary>
        /// <value>Displays array of validation error messages from the API</value>
        [DataMember(Name="ValidationErrors", EmitDefaultValue=false)]
        public List<ValidationError> ValidationErrors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankTransfer {\n");
            sb.Append("  FromBankAccount: ").Append(FromBankAccount).Append("\n");
            sb.Append("  ToBankAccount: ").Append(ToBankAccount).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  BankTransferID: ").Append(BankTransferID).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  FromBankTransactionID: ").Append(FromBankTransactionID).Append("\n");
            sb.Append("  ToBankTransactionID: ").Append(ToBankTransactionID).Append("\n");
            sb.Append("  FromIsReconciled: ").Append(FromIsReconciled).Append("\n");
            sb.Append("  ToIsReconciled: ").Append(ToIsReconciled).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  HasAttachments: ").Append(HasAttachments).Append("\n");
            sb.Append("  CreatedDateUTC: ").Append(CreatedDateUTC).Append("\n");
            sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
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
            return this.Equals(input as BankTransfer);
        }

        /// <summary>
        /// Returns true if BankTransfer instances are equal
        /// </summary>
        /// <param name="input">Instance of BankTransfer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankTransfer input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FromBankAccount == input.FromBankAccount ||
                    (this.FromBankAccount != null &&
                    this.FromBankAccount.Equals(input.FromBankAccount))
                ) && 
                (
                    this.ToBankAccount == input.ToBankAccount ||
                    (this.ToBankAccount != null &&
                    this.ToBankAccount.Equals(input.ToBankAccount))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.BankTransferID == input.BankTransferID ||
                    (this.BankTransferID != null &&
                    this.BankTransferID.Equals(input.BankTransferID))
                ) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    (this.CurrencyRate != null &&
                    this.CurrencyRate.Equals(input.CurrencyRate))
                ) && 
                (
                    this.FromBankTransactionID == input.FromBankTransactionID ||
                    (this.FromBankTransactionID != null &&
                    this.FromBankTransactionID.Equals(input.FromBankTransactionID))
                ) && 
                (
                    this.ToBankTransactionID == input.ToBankTransactionID ||
                    (this.ToBankTransactionID != null &&
                    this.ToBankTransactionID.Equals(input.ToBankTransactionID))
                ) && 
                (
                    this.FromIsReconciled == input.FromIsReconciled ||
                    (this.FromIsReconciled != null &&
                    this.FromIsReconciled.Equals(input.FromIsReconciled))
                ) && 
                (
                    this.ToIsReconciled == input.ToIsReconciled ||
                    (this.ToIsReconciled != null &&
                    this.ToIsReconciled.Equals(input.ToIsReconciled))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.HasAttachments == input.HasAttachments ||
                    (this.HasAttachments != null &&
                    this.HasAttachments.Equals(input.HasAttachments))
                ) && 
                (
                    this.CreatedDateUTC == input.CreatedDateUTC ||
                    (this.CreatedDateUTC != null &&
                    this.CreatedDateUTC.Equals(input.CreatedDateUTC))
                ) && 
                (
                    this.ValidationErrors == input.ValidationErrors ||
                    this.ValidationErrors != null &&
                    input.ValidationErrors != null &&
                    this.ValidationErrors.SequenceEqual(input.ValidationErrors)
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
                if (this.FromBankAccount != null)
                    hashCode = hashCode * 59 + this.FromBankAccount.GetHashCode();
                if (this.ToBankAccount != null)
                    hashCode = hashCode * 59 + this.ToBankAccount.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.BankTransferID != null)
                    hashCode = hashCode * 59 + this.BankTransferID.GetHashCode();
                if (this.CurrencyRate != null)
                    hashCode = hashCode * 59 + this.CurrencyRate.GetHashCode();
                if (this.FromBankTransactionID != null)
                    hashCode = hashCode * 59 + this.FromBankTransactionID.GetHashCode();
                if (this.ToBankTransactionID != null)
                    hashCode = hashCode * 59 + this.ToBankTransactionID.GetHashCode();
                if (this.FromIsReconciled != null)
                    hashCode = hashCode * 59 + this.FromIsReconciled.GetHashCode();
                if (this.ToIsReconciled != null)
                    hashCode = hashCode * 59 + this.ToIsReconciled.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.HasAttachments != null)
                    hashCode = hashCode * 59 + this.HasAttachments.GetHashCode();
                if (this.CreatedDateUTC != null)
                    hashCode = hashCode * 59 + this.CreatedDateUTC.GetHashCode();
                if (this.ValidationErrors != null)
                    hashCode = hashCode * 59 + this.ValidationErrors.GetHashCode();
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
