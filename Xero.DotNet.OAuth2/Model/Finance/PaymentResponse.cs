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
    /// PaymentResponse
    /// </summary>
    [DataContract]
    public partial class PaymentResponse :  IEquatable<PaymentResponse>, IValidatableObject
    {
        
        /// <summary>
        /// Xero Identifier of payment
        /// </summary>
        /// <value>Xero Identifier of payment</value>
        [DataMember(Name="paymentId", EmitDefaultValue=false)]
        public Guid? PaymentId { get; set; }

        /// <summary>
        /// Xero Identifier of batch payment. Present if the payment was created as part of a batch.
        /// </summary>
        /// <value>Xero Identifier of batch payment. Present if the payment was created as part of a batch.</value>
        [DataMember(Name="batchPaymentId", EmitDefaultValue=false)]
        public Guid? BatchPaymentId { get; set; }

        /// <summary>
        /// Date the payment is being made (YYYY-MM-DD) e.g. 2009-09-06
        /// </summary>
        /// <value>Date the payment is being made (YYYY-MM-DD) e.g. 2009-09-06</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? Date { get; set; }

        /// <summary>
        /// The amount of the payment
        /// </summary>
        /// <value>The amount of the payment</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// The bank amount of the payment
        /// </summary>
        /// <value>The bank amount of the payment</value>
        [DataMember(Name="bankAmount", EmitDefaultValue=false)]
        public decimal? BankAmount { get; set; }

        /// <summary>
        /// Exchange rate when payment is received. Only used for non base currency invoices and credit notes e.g. 0.7500
        /// </summary>
        /// <value>Exchange rate when payment is received. Only used for non base currency invoices and credit notes e.g. 0.7500</value>
        [DataMember(Name="currencyRate", EmitDefaultValue=false)]
        public double? CurrencyRate { get; set; }

        /// <summary>
        /// Gets or Sets Invoice
        /// </summary>
        [DataMember(Name="invoice", EmitDefaultValue=false)]
        public InvoiceResponse Invoice { get; set; }

        /// <summary>
        /// Gets or Sets CreditNote
        /// </summary>
        [DataMember(Name="creditNote", EmitDefaultValue=false)]
        public CreditNoteResponse CreditNote { get; set; }

        /// <summary>
        /// Gets or Sets Prepayment
        /// </summary>
        [DataMember(Name="prepayment", EmitDefaultValue=false)]
        public PrepaymentResponse Prepayment { get; set; }

        /// <summary>
        /// Gets or Sets Overpayment
        /// </summary>
        [DataMember(Name="overpayment", EmitDefaultValue=false)]
        public OverpaymentResponse Overpayment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentResponse {\n");
            sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
            sb.Append("  BatchPaymentId: ").Append(BatchPaymentId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BankAmount: ").Append(BankAmount).Append("\n");
            sb.Append("  CurrencyRate: ").Append(CurrencyRate).Append("\n");
            sb.Append("  Invoice: ").Append(Invoice).Append("\n");
            sb.Append("  CreditNote: ").Append(CreditNote).Append("\n");
            sb.Append("  Prepayment: ").Append(Prepayment).Append("\n");
            sb.Append("  Overpayment: ").Append(Overpayment).Append("\n");
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
            return this.Equals(input as PaymentResponse);
        }

        /// <summary>
        /// Returns true if PaymentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PaymentId == input.PaymentId ||
                    (this.PaymentId != null &&
                    this.PaymentId.Equals(input.PaymentId))
                ) && 
                (
                    this.BatchPaymentId == input.BatchPaymentId ||
                    (this.BatchPaymentId != null &&
                    this.BatchPaymentId.Equals(input.BatchPaymentId))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BankAmount == input.BankAmount ||
                    (this.BankAmount != null &&
                    this.BankAmount.Equals(input.BankAmount))
                ) && 
                (
                    this.CurrencyRate == input.CurrencyRate ||
                    (this.CurrencyRate != null &&
                    this.CurrencyRate.Equals(input.CurrencyRate))
                ) && 
                (
                    this.Invoice == input.Invoice ||
                    (this.Invoice != null &&
                    this.Invoice.Equals(input.Invoice))
                ) && 
                (
                    this.CreditNote == input.CreditNote ||
                    (this.CreditNote != null &&
                    this.CreditNote.Equals(input.CreditNote))
                ) && 
                (
                    this.Prepayment == input.Prepayment ||
                    (this.Prepayment != null &&
                    this.Prepayment.Equals(input.Prepayment))
                ) && 
                (
                    this.Overpayment == input.Overpayment ||
                    (this.Overpayment != null &&
                    this.Overpayment.Equals(input.Overpayment))
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
                if (this.PaymentId != null)
                    hashCode = hashCode * 59 + this.PaymentId.GetHashCode();
                if (this.BatchPaymentId != null)
                    hashCode = hashCode * 59 + this.BatchPaymentId.GetHashCode();
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.BankAmount != null)
                    hashCode = hashCode * 59 + this.BankAmount.GetHashCode();
                if (this.CurrencyRate != null)
                    hashCode = hashCode * 59 + this.CurrencyRate.GetHashCode();
                if (this.Invoice != null)
                    hashCode = hashCode * 59 + this.Invoice.GetHashCode();
                if (this.CreditNote != null)
                    hashCode = hashCode * 59 + this.CreditNote.GetHashCode();
                if (this.Prepayment != null)
                    hashCode = hashCode * 59 + this.Prepayment.GetHashCode();
                if (this.Overpayment != null)
                    hashCode = hashCode * 59 + this.Overpayment.GetHashCode();
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
