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
    /// BankStatementResponse
    /// </summary>
    [DataContract]
    public partial class BankStatementResponse :  IEquatable<BankStatementResponse>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets StatementLines
        /// </summary>
        [DataMember(Name="statementLines", EmitDefaultValue=false)]
        public StatementLinesResponse StatementLines { get; set; }

        /// <summary>
        /// Gets or Sets CurrentStatement
        /// </summary>
        [DataMember(Name="currentStatement", EmitDefaultValue=false)]
        public CurrentStatementResponse CurrentStatement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BankStatementResponse {\n");
            sb.Append("  StatementLines: ").Append(StatementLines).Append("\n");
            sb.Append("  CurrentStatement: ").Append(CurrentStatement).Append("\n");
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
            return this.Equals(input as BankStatementResponse);
        }

        /// <summary>
        /// Returns true if BankStatementResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of BankStatementResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankStatementResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StatementLines == input.StatementLines ||
                    (this.StatementLines != null &&
                    this.StatementLines.Equals(input.StatementLines))
                ) && 
                (
                    this.CurrentStatement == input.CurrentStatement ||
                    (this.CurrentStatement != null &&
                    this.CurrentStatement.Equals(input.CurrentStatement))
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
                if (this.StatementLines != null)
                    hashCode = hashCode * 59 + this.StatementLines.GetHashCode();
                if (this.CurrentStatement != null)
                    hashCode = hashCode * 59 + this.CurrentStatement.GetHashCode();
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
