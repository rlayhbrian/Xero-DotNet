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
    /// Address
    /// </summary>
    [DataContract]
    public partial class Address :  IEquatable<Address>, IValidatableObject
    {
        /// <summary>
        /// define the type of address
        /// </summary>
        /// <value>define the type of address</value>
        [JsonConverter(typeof(Client.CustomStringEnumConverter))]
        public enum AddressTypeEnum
        {
            /// <summary>
            /// Enum POBOX for value: POBOX
            /// </summary>
            [EnumMember(Value = "POBOX")]
            POBOX = 1,

            /// <summary>
            /// Enum STREET for value: STREET
            /// </summary>
            [EnumMember(Value = "STREET")]
            STREET = 2

        }

        /// <summary>
        /// define the type of address
        /// </summary>
        /// <value>define the type of address</value>
        [DataMember(Name="AddressType", EmitDefaultValue=false)]
        public AddressTypeEnum AddressType { get; set; }
        
        /// <summary>
        /// max length &#x3D; 500
        /// </summary>
        /// <value>max length &#x3D; 500</value>
        [DataMember(Name="AddressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// max length &#x3D; 500
        /// </summary>
        /// <value>max length &#x3D; 500</value>
        [DataMember(Name="AddressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// max length &#x3D; 500
        /// </summary>
        /// <value>max length &#x3D; 500</value>
        [DataMember(Name="AddressLine3", EmitDefaultValue=false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// max length &#x3D; 500
        /// </summary>
        /// <value>max length &#x3D; 500</value>
        [DataMember(Name="AddressLine4", EmitDefaultValue=false)]
        public string AddressLine4 { get; set; }

        /// <summary>
        /// max length &#x3D; 255
        /// </summary>
        /// <value>max length &#x3D; 255</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// max length &#x3D; 255
        /// </summary>
        /// <value>max length &#x3D; 255</value>
        [DataMember(Name="Region", EmitDefaultValue=false)]
        public string Region { get; set; }

        /// <summary>
        /// max length &#x3D; 50
        /// </summary>
        /// <value>max length &#x3D; 50</value>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// max length &#x3D; 50, [A-Z], [a-z] only
        /// </summary>
        /// <value>max length &#x3D; 50, [A-Z], [a-z] only</value>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// max length &#x3D; 255
        /// </summary>
        /// <value>max length &#x3D; 255</value>
        [DataMember(Name="AttentionTo", EmitDefaultValue=false)]
        public string AttentionTo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  AddressLine4: ").Append(AddressLine4).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  AttentionTo: ").Append(AttentionTo).Append("\n");
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
            return this.Equals(input as Address);
        }

        /// <summary>
        /// Returns true if Address instances are equal
        /// </summary>
        /// <param name="input">Instance of Address to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Address input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressType == input.AddressType ||
                    this.AddressType.Equals(input.AddressType)
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.AddressLine3 == input.AddressLine3 ||
                    (this.AddressLine3 != null &&
                    this.AddressLine3.Equals(input.AddressLine3))
                ) && 
                (
                    this.AddressLine4 == input.AddressLine4 ||
                    (this.AddressLine4 != null &&
                    this.AddressLine4.Equals(input.AddressLine4))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.AttentionTo == input.AttentionTo ||
                    (this.AttentionTo != null &&
                    this.AttentionTo.Equals(input.AttentionTo))
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
                hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.AddressLine3 != null)
                    hashCode = hashCode * 59 + this.AddressLine3.GetHashCode();
                if (this.AddressLine4 != null)
                    hashCode = hashCode * 59 + this.AddressLine4.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.AttentionTo != null)
                    hashCode = hashCode * 59 + this.AttentionTo.GetHashCode();
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
            // AddressLine1 (string) maxLength
            if(this.AddressLine1 != null && this.AddressLine1.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine1, length must be less than 500.", new [] { "AddressLine1" });
            }

            // AddressLine2 (string) maxLength
            if(this.AddressLine2 != null && this.AddressLine2.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine2, length must be less than 500.", new [] { "AddressLine2" });
            }

            // AddressLine3 (string) maxLength
            if(this.AddressLine3 != null && this.AddressLine3.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine3, length must be less than 500.", new [] { "AddressLine3" });
            }

            // AddressLine4 (string) maxLength
            if(this.AddressLine4 != null && this.AddressLine4.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AddressLine4, length must be less than 500.", new [] { "AddressLine4" });
            }

            // City (string) maxLength
            if(this.City != null && this.City.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for City, length must be less than 255.", new [] { "City" });
            }

            // Region (string) maxLength
            if(this.Region != null && this.Region.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Region, length must be less than 255.", new [] { "Region" });
            }

            // PostalCode (string) maxLength
            if(this.PostalCode != null && this.PostalCode.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PostalCode, length must be less than 50.", new [] { "PostalCode" });
            }

            // Country (string) maxLength
            if(this.Country != null && this.Country.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Country, length must be less than 50.", new [] { "Country" });
            }

            // AttentionTo (string) maxLength
            if(this.AttentionTo != null && this.AttentionTo.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AttentionTo, length must be less than 255.", new [] { "AttentionTo" });
            }

            yield break;
        }
    }

}
