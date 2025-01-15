/* 
 * Xero Bank Feeds API
 *
 * The Bank Feeds API is a closed API that is only available to financial institutions that have an established financial services partnership with Xero. If you're an existing financial services partner that wants access, contact your local Partner Manager. If you're a financial institution who wants to provide bank feeds to your business customers, contact us to become a financial services partner.
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

namespace Xero.DotNet.OAuth2.Model.Bankfeeds
{
    /// <summary>
    /// the lines details for a statement
    /// </summary>
    [DataContract]
    public partial class StatementLine :  IEquatable<StatementLine>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets CreditDebitIndicator
        /// </summary>
        [DataMember(Name="creditDebitIndicator", EmitDefaultValue=false)]
        public CreditDebitIndicator CreditDebitIndicator { get; set; }
        
        /// <summary>
        /// The date that the transaction was processed or cleared as seen in internet banking ISO-8601 YYYY-MM-DD
        /// </summary>
        /// <value>The date that the transaction was processed or cleared as seen in internet banking ISO-8601 YYYY-MM-DD</value>
        [DataMember(Name="postedDate", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime? PostedDate { get; set; }

        /// <summary>
        /// Transaction description
        /// </summary>
        /// <value>Transaction description</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Transaction amount
        /// </summary>
        /// <value>Transaction amount</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// Financial institute&#39;s internal transaction identifier. If provided this field is factored into duplicate detection.
        /// </summary>
        /// <value>Financial institute&#39;s internal transaction identifier. If provided this field is factored into duplicate detection.</value>
        [DataMember(Name="transactionId", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Typically the merchant or payee name
        /// </summary>
        /// <value>Typically the merchant or payee name</value>
        [DataMember(Name="payeeName", EmitDefaultValue=false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// Optional field to enhance the Description
        /// </summary>
        /// <value>Optional field to enhance the Description</value>
        [DataMember(Name="reference", EmitDefaultValue=false)]
        public string Reference { get; set; }

        /// <summary>
        /// The cheque/check number
        /// </summary>
        /// <value>The cheque/check number</value>
        [DataMember(Name="chequeNumber", EmitDefaultValue=false)]
        public string ChequeNumber { get; set; }

        /// <summary>
        /// Descriptive transaction type
        /// </summary>
        /// <value>Descriptive transaction type</value>
        [DataMember(Name="transactionType", EmitDefaultValue=false)]
        public string TransactionType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StatementLine {\n");
            sb.Append("  PostedDate: ").Append(PostedDate).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  CreditDebitIndicator: ").Append(CreditDebitIndicator).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  ChequeNumber: ").Append(ChequeNumber).Append("\n");
            sb.Append("  TransactionType: ").Append(TransactionType).Append("\n");
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
            return this.Equals(input as StatementLine);
        }

        /// <summary>
        /// Returns true if StatementLine instances are equal
        /// </summary>
        /// <param name="input">Instance of StatementLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StatementLine input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PostedDate == input.PostedDate ||
                    (this.PostedDate != null &&
                    this.PostedDate.Equals(input.PostedDate))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.CreditDebitIndicator == input.CreditDebitIndicator ||
                    this.CreditDebitIndicator.Equals(input.CreditDebitIndicator)
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.PayeeName == input.PayeeName ||
                    (this.PayeeName != null &&
                    this.PayeeName.Equals(input.PayeeName))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
                ) && 
                (
                    this.ChequeNumber == input.ChequeNumber ||
                    (this.ChequeNumber != null &&
                    this.ChequeNumber.Equals(input.ChequeNumber))
                ) && 
                (
                    this.TransactionType == input.TransactionType ||
                    (this.TransactionType != null &&
                    this.TransactionType.Equals(input.TransactionType))
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
                if (this.PostedDate != null)
                    hashCode = hashCode * 59 + this.PostedDate.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                hashCode = hashCode * 59 + this.CreditDebitIndicator.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.PayeeName != null)
                    hashCode = hashCode * 59 + this.PayeeName.GetHashCode();
                if (this.Reference != null)
                    hashCode = hashCode * 59 + this.Reference.GetHashCode();
                if (this.ChequeNumber != null)
                    hashCode = hashCode * 59 + this.ChequeNumber.GetHashCode();
                if (this.TransactionType != null)
                    hashCode = hashCode * 59 + this.TransactionType.GetHashCode();
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
