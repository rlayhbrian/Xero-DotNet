/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
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

namespace Xero.DotNet.OAuth2.Model.PayrollNz
{
    /// <summary>
    /// Timesheets
    /// </summary>
    [DataContract]
    public partial class Timesheets :  IEquatable<Timesheets>, IValidatableObject
    {
        
        /// <summary>
        /// Gets or Sets Pagination
        /// </summary>
        [DataMember(Name="pagination", EmitDefaultValue=false)]
        public Pagination Pagination { get; set; }

        /// <summary>
        /// Gets or Sets Problem
        /// </summary>
        [DataMember(Name="problem", EmitDefaultValue=false)]
        public Problem Problem { get; set; }

        /// <summary>
        /// Gets or Sets _Timesheets
        /// </summary>
        [DataMember(Name="timesheets", EmitDefaultValue=false)]
        public List<Timesheet> _Timesheets { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Timesheets {\n");
            sb.Append("  Pagination: ").Append(Pagination).Append("\n");
            sb.Append("  Problem: ").Append(Problem).Append("\n");
            sb.Append("  _Timesheets: ").Append(_Timesheets).Append("\n");
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
            return this.Equals(input as Timesheets);
        }

        /// <summary>
        /// Returns true if Timesheets instances are equal
        /// </summary>
        /// <param name="input">Instance of Timesheets to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Timesheets input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pagination == input.Pagination ||
                    (this.Pagination != null &&
                    this.Pagination.Equals(input.Pagination))
                ) && 
                (
                    this.Problem == input.Problem ||
                    (this.Problem != null &&
                    this.Problem.Equals(input.Problem))
                ) && 
                (
                    this._Timesheets == input._Timesheets ||
                    this._Timesheets != null &&
                    input._Timesheets != null &&
                    this._Timesheets.SequenceEqual(input._Timesheets)
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
                if (this.Pagination != null)
                    hashCode = hashCode * 59 + this.Pagination.GetHashCode();
                if (this.Problem != null)
                    hashCode = hashCode * 59 + this.Problem.GetHashCode();
                if (this._Timesheets != null)
                    hashCode = hashCode * 59 + this._Timesheets.GetHashCode();
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
