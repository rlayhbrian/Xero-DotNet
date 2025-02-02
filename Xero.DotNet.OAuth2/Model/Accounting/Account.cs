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
    /// Account
    /// </summary>
    [DataContract]
    public partial class Account :  IEquatable<Account>, IValidatableObject
    {
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="Type", EmitDefaultValue=false)]
        public AccountType Type { get; set; }
        /// <summary>
        /// Accounts with a status of ACTIVE can be updated to ARCHIVED. See Account Status Codes
        /// </summary>
        /// <value>Accounts with a status of ACTIVE can be updated to ARCHIVED. See Account Status Codes</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 1,

            /// <summary>
            /// Enum ARCHIVED for value: ARCHIVED
            /// </summary>
            [EnumMember(Value = "ARCHIVED")]
            ARCHIVED = 2,

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED = 3

        }

        /// <summary>
        /// Accounts with a status of ACTIVE can be updated to ARCHIVED. See Account Status Codes
        /// </summary>
        /// <value>Accounts with a status of ACTIVE can be updated to ARCHIVED. See Account Status Codes</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// For bank accounts only. See Bank Account types
        /// </summary>
        /// <value>For bank accounts only. See Bank Account types</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum BankAccountTypeEnum
        {
            /// <summary>
            /// Enum BANK for value: BANK
            /// </summary>
            [EnumMember(Value = "BANK")]
            BANK = 1,

            /// <summary>
            /// Enum CREDITCARD for value: CREDITCARD
            /// </summary>
            [EnumMember(Value = "CREDITCARD")]
            CREDITCARD = 2,

            /// <summary>
            /// Enum PAYPAL for value: PAYPAL
            /// </summary>
            [EnumMember(Value = "PAYPAL")]
            PAYPAL = 3,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 4,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 5

        }

        /// <summary>
        /// For bank accounts only. See Bank Account types
        /// </summary>
        /// <value>For bank accounts only. See Bank Account types</value>
        [DataMember(Name="BankAccountType", EmitDefaultValue=false)]
        public BankAccountTypeEnum BankAccountType { get; set; }
        /// <summary>
        /// Gets or Sets CurrencyCode
        /// </summary>
        [DataMember(Name="CurrencyCode", EmitDefaultValue=false)]
        public CurrencyCode CurrencyCode { get; set; }
        /// <summary>
        /// See Account Class Types
        /// </summary>
        /// <value>See Account Class Types</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum ClassEnum
        {
            /// <summary>
            /// Enum ASSET for value: ASSET
            /// </summary>
            [EnumMember(Value = "ASSET")]
            ASSET = 1,

            /// <summary>
            /// Enum EQUITY for value: EQUITY
            /// </summary>
            [EnumMember(Value = "EQUITY")]
            EQUITY = 2,

            /// <summary>
            /// Enum EXPENSE for value: EXPENSE
            /// </summary>
            [EnumMember(Value = "EXPENSE")]
            EXPENSE = 3,

            /// <summary>
            /// Enum LIABILITY for value: LIABILITY
            /// </summary>
            [EnumMember(Value = "LIABILITY")]
            LIABILITY = 4,

            /// <summary>
            /// Enum REVENUE for value: REVENUE
            /// </summary>
            [EnumMember(Value = "REVENUE")]
            REVENUE = 5

        }

        /// <summary>
        /// See Account Class Types
        /// </summary>
        /// <value>See Account Class Types</value>
        [DataMember(Name="Class", EmitDefaultValue=false)]
        public ClassEnum Class { get; set; }
        /// <summary>
        /// If this is a system account then this element is returned. See System Account types. Note that non-system accounts may have this element set as either “” or null.
        /// </summary>
        /// <value>If this is a system account then this element is returned. See System Account types. Note that non-system accounts may have this element set as either “” or null.</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum SystemAccountEnum
        {
            /// <summary>
            /// Enum DEBTORS for value: DEBTORS
            /// </summary>
            [EnumMember(Value = "DEBTORS")]
            DEBTORS = 1,

            /// <summary>
            /// Enum CREDITORS for value: CREDITORS
            /// </summary>
            [EnumMember(Value = "CREDITORS")]
            CREDITORS = 2,

            /// <summary>
            /// Enum BANKCURRENCYGAIN for value: BANKCURRENCYGAIN
            /// </summary>
            [EnumMember(Value = "BANKCURRENCYGAIN")]
            BANKCURRENCYGAIN = 3,

            /// <summary>
            /// Enum GST for value: GST
            /// </summary>
            [EnumMember(Value = "GST")]
            GST = 4,

            /// <summary>
            /// Enum GSTONIMPORTS for value: GSTONIMPORTS
            /// </summary>
            [EnumMember(Value = "GSTONIMPORTS")]
            GSTONIMPORTS = 5,

            /// <summary>
            /// Enum HISTORICAL for value: HISTORICAL
            /// </summary>
            [EnumMember(Value = "HISTORICAL")]
            HISTORICAL = 6,

            /// <summary>
            /// Enum REALISEDCURRENCYGAIN for value: REALISEDCURRENCYGAIN
            /// </summary>
            [EnumMember(Value = "REALISEDCURRENCYGAIN")]
            REALISEDCURRENCYGAIN = 7,

            /// <summary>
            /// Enum RETAINEDEARNINGS for value: RETAINEDEARNINGS
            /// </summary>
            [EnumMember(Value = "RETAINEDEARNINGS")]
            RETAINEDEARNINGS = 8,

            /// <summary>
            /// Enum ROUNDING for value: ROUNDING
            /// </summary>
            [EnumMember(Value = "ROUNDING")]
            ROUNDING = 9,

            /// <summary>
            /// Enum TRACKINGTRANSFERS for value: TRACKINGTRANSFERS
            /// </summary>
            [EnumMember(Value = "TRACKINGTRANSFERS")]
            TRACKINGTRANSFERS = 10,

            /// <summary>
            /// Enum UNPAIDEXPCLM for value: UNPAIDEXPCLM
            /// </summary>
            [EnumMember(Value = "UNPAIDEXPCLM")]
            UNPAIDEXPCLM = 11,

            /// <summary>
            /// Enum UNREALISEDCURRENCYGAIN for value: UNREALISEDCURRENCYGAIN
            /// </summary>
            [EnumMember(Value = "UNREALISEDCURRENCYGAIN")]
            UNREALISEDCURRENCYGAIN = 12,

            /// <summary>
            /// Enum WAGEPAYABLES for value: WAGEPAYABLES
            /// </summary>
            [EnumMember(Value = "WAGEPAYABLES")]
            WAGEPAYABLES = 13,

            /// <summary>
            /// Enum CISASSETS for value: CISASSETS
            /// </summary>
            [EnumMember(Value = "CISASSETS")]
            CISASSETS = 14,

            /// <summary>
            /// Enum CISASSET for value: CISASSET
            /// </summary>
            [EnumMember(Value = "CISASSET")]
            CISASSET = 15,

            /// <summary>
            /// Enum CISLABOUR for value: CISLABOUR
            /// </summary>
            [EnumMember(Value = "CISLABOUR")]
            CISLABOUR = 16,

            /// <summary>
            /// Enum CISLABOUREXPENSE for value: CISLABOUREXPENSE
            /// </summary>
            [EnumMember(Value = "CISLABOUREXPENSE")]
            CISLABOUREXPENSE = 17,

            /// <summary>
            /// Enum CISLABOURINCOME for value: CISLABOURINCOME
            /// </summary>
            [EnumMember(Value = "CISLABOURINCOME")]
            CISLABOURINCOME = 18,

            /// <summary>
            /// Enum CISLIABILITY for value: CISLIABILITY
            /// </summary>
            [EnumMember(Value = "CISLIABILITY")]
            CISLIABILITY = 19,

            /// <summary>
            /// Enum CISMATERIALS for value: CISMATERIALS
            /// </summary>
            [EnumMember(Value = "CISMATERIALS")]
            CISMATERIALS = 20,

            /// <summary>
            /// Enum Empty for value: 
            /// </summary>
            [EnumMember(Value = "")]
            Empty = 21

        }

        /// <summary>
        /// If this is a system account then this element is returned. See System Account types. Note that non-system accounts may have this element set as either “” or null.
        /// </summary>
        /// <value>If this is a system account then this element is returned. See System Account types. Note that non-system accounts may have this element set as either “” or null.</value>
        [DataMember(Name="SystemAccount", EmitDefaultValue=false)]
        public SystemAccountEnum SystemAccount { get; set; }
        
        /// <summary>
        /// Customer defined alpha numeric account code e.g 200 or SALES (max length &#x3D; 10)
        /// </summary>
        /// <value>Customer defined alpha numeric account code e.g 200 or SALES (max length &#x3D; 10)</value>
        [DataMember(Name="Code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Name of account (max length &#x3D; 150)
        /// </summary>
        /// <value>Name of account (max length &#x3D; 150)</value>
        [DataMember(Name="Name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The Xero identifier for an account – specified as a string following  the endpoint name   e.g. /297c2dc5-cc47-4afd-8ec8-74990b8761e9
        /// </summary>
        /// <value>The Xero identifier for an account – specified as a string following  the endpoint name   e.g. /297c2dc5-cc47-4afd-8ec8-74990b8761e9</value>
        [DataMember(Name="AccountID", EmitDefaultValue=false)]
        public Guid? AccountID { get; set; }

        /// <summary>
        /// For bank accounts only (Account Type BANK)
        /// </summary>
        /// <value>For bank accounts only (Account Type BANK)</value>
        [DataMember(Name="BankAccountNumber", EmitDefaultValue=false)]
        public string BankAccountNumber { get; set; }

        /// <summary>
        /// Description of the Account. Valid for all types of accounts except bank accounts (max length &#x3D; 4000)
        /// </summary>
        /// <value>Description of the Account. Valid for all types of accounts except bank accounts (max length &#x3D; 4000)</value>
        [DataMember(Name="Description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The tax type from taxRates
        /// </summary>
        /// <value>The tax type from taxRates</value>
        [DataMember(Name="TaxType", EmitDefaultValue=false)]
        public string TaxType { get; set; }

        /// <summary>
        /// Boolean – describes whether account can have payments applied to it
        /// </summary>
        /// <value>Boolean – describes whether account can have payments applied to it</value>
        [DataMember(Name="EnablePaymentsToAccount", EmitDefaultValue=false)]
        public bool? EnablePaymentsToAccount { get; set; }

        /// <summary>
        /// Boolean – describes whether account code is available for use with expense claims
        /// </summary>
        /// <value>Boolean – describes whether account code is available for use with expense claims</value>
        [DataMember(Name="ShowInExpenseClaims", EmitDefaultValue=false)]
        public bool? ShowInExpenseClaims { get; set; }

        /// <summary>
        /// Shown if set
        /// </summary>
        /// <value>Shown if set</value>
        [DataMember(Name="ReportingCode", EmitDefaultValue=false)]
        public string ReportingCode { get; set; }

        /// <summary>
        /// Shown if set
        /// </summary>
        /// <value>Shown if set</value>
        [DataMember(Name="ReportingCodeName", EmitDefaultValue=false)]
        public string ReportingCodeName { get; private set; }

        /// <summary>
        /// boolean to indicate if an account has an attachment (read only)
        /// </summary>
        /// <value>boolean to indicate if an account has an attachment (read only)</value>
        [DataMember(Name="HasAttachments", EmitDefaultValue=false)]
        public bool? HasAttachments { get; private set; }

        /// <summary>
        /// Last modified date UTC format
        /// </summary>
        /// <value>Last modified date UTC format</value>
        [DataMember(Name="UpdatedDateUTC", EmitDefaultValue=false)]
        public DateTime? UpdatedDateUTC { get; private set; }

        /// <summary>
        /// Boolean – describes whether the account is shown in the watchlist widget on the dashboard
        /// </summary>
        /// <value>Boolean – describes whether the account is shown in the watchlist widget on the dashboard</value>
        [DataMember(Name="AddToWatchlist", EmitDefaultValue=false)]
        public bool? AddToWatchlist { get; set; }

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
            sb.Append("class Account {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AccountID: ").Append(AccountID).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  BankAccountNumber: ").Append(BankAccountNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  BankAccountType: ").Append(BankAccountType).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  EnablePaymentsToAccount: ").Append(EnablePaymentsToAccount).Append("\n");
            sb.Append("  ShowInExpenseClaims: ").Append(ShowInExpenseClaims).Append("\n");
            sb.Append("  Class: ").Append(Class).Append("\n");
            sb.Append("  SystemAccount: ").Append(SystemAccount).Append("\n");
            sb.Append("  ReportingCode: ").Append(ReportingCode).Append("\n");
            sb.Append("  ReportingCodeName: ").Append(ReportingCodeName).Append("\n");
            sb.Append("  HasAttachments: ").Append(HasAttachments).Append("\n");
            sb.Append("  UpdatedDateUTC: ").Append(UpdatedDateUTC).Append("\n");
            sb.Append("  AddToWatchlist: ").Append(AddToWatchlist).Append("\n");
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
            return this.Equals(input as Account);
        }

        /// <summary>
        /// Returns true if Account instances are equal
        /// </summary>
        /// <param name="input">Instance of Account to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Account input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AccountID == input.AccountID ||
                    (this.AccountID != null &&
                    this.AccountID.Equals(input.AccountID))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.BankAccountNumber == input.BankAccountNumber ||
                    (this.BankAccountNumber != null &&
                    this.BankAccountNumber.Equals(input.BankAccountNumber))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.BankAccountType == input.BankAccountType ||
                    this.BankAccountType.Equals(input.BankAccountType)
                ) && 
                (
                    this.CurrencyCode == input.CurrencyCode ||
                    this.CurrencyCode.Equals(input.CurrencyCode)
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
                ) && 
                (
                    this.EnablePaymentsToAccount == input.EnablePaymentsToAccount ||
                    (this.EnablePaymentsToAccount != null &&
                    this.EnablePaymentsToAccount.Equals(input.EnablePaymentsToAccount))
                ) && 
                (
                    this.ShowInExpenseClaims == input.ShowInExpenseClaims ||
                    (this.ShowInExpenseClaims != null &&
                    this.ShowInExpenseClaims.Equals(input.ShowInExpenseClaims))
                ) && 
                (
                    this.Class == input.Class ||
                    this.Class.Equals(input.Class)
                ) && 
                (
                    this.SystemAccount == input.SystemAccount ||
                    this.SystemAccount.Equals(input.SystemAccount)
                ) && 
                (
                    this.ReportingCode == input.ReportingCode ||
                    (this.ReportingCode != null &&
                    this.ReportingCode.Equals(input.ReportingCode))
                ) && 
                (
                    this.ReportingCodeName == input.ReportingCodeName ||
                    (this.ReportingCodeName != null &&
                    this.ReportingCodeName.Equals(input.ReportingCodeName))
                ) && 
                (
                    this.HasAttachments == input.HasAttachments ||
                    (this.HasAttachments != null &&
                    this.HasAttachments.Equals(input.HasAttachments))
                ) && 
                (
                    this.UpdatedDateUTC == input.UpdatedDateUTC ||
                    (this.UpdatedDateUTC != null &&
                    this.UpdatedDateUTC.Equals(input.UpdatedDateUTC))
                ) && 
                (
                    this.AddToWatchlist == input.AddToWatchlist ||
                    (this.AddToWatchlist != null &&
                    this.AddToWatchlist.Equals(input.AddToWatchlist))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AccountID != null)
                    hashCode = hashCode * 59 + this.AccountID.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.BankAccountNumber != null)
                    hashCode = hashCode * 59 + this.BankAccountNumber.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.BankAccountType.GetHashCode();
                hashCode = hashCode * 59 + this.CurrencyCode.GetHashCode();
                if (this.TaxType != null)
                    hashCode = hashCode * 59 + this.TaxType.GetHashCode();
                if (this.EnablePaymentsToAccount != null)
                    hashCode = hashCode * 59 + this.EnablePaymentsToAccount.GetHashCode();
                if (this.ShowInExpenseClaims != null)
                    hashCode = hashCode * 59 + this.ShowInExpenseClaims.GetHashCode();
                hashCode = hashCode * 59 + this.Class.GetHashCode();
                hashCode = hashCode * 59 + this.SystemAccount.GetHashCode();
                if (this.ReportingCode != null)
                    hashCode = hashCode * 59 + this.ReportingCode.GetHashCode();
                if (this.ReportingCodeName != null)
                    hashCode = hashCode * 59 + this.ReportingCodeName.GetHashCode();
                if (this.HasAttachments != null)
                    hashCode = hashCode * 59 + this.HasAttachments.GetHashCode();
                if (this.UpdatedDateUTC != null)
                    hashCode = hashCode * 59 + this.UpdatedDateUTC.GetHashCode();
                if (this.AddToWatchlist != null)
                    hashCode = hashCode * 59 + this.AddToWatchlist.GetHashCode();
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
            // Name (string) maxLength
            if(this.Name != null && this.Name.Length > 150)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 150.", new [] { "Name" });
            }

            yield break;
        }
    }

}
