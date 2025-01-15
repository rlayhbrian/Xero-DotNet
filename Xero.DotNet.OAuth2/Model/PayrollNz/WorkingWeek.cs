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
    /// WorkingWeek
    /// </summary>
    [DataContract]
    public partial class WorkingWeek :  IEquatable<WorkingWeek>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkingWeek" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public WorkingWeek() 
        { 
        }
        
        /// <summary>
        /// The number of hours worked on a Monday
        /// </summary>
        /// <value>The number of hours worked on a Monday</value>
        [DataMember(Name="monday", EmitDefaultValue=false)]
        public decimal? Monday { get; set; }

        /// <summary>
        /// The number of hours worked on a Tuesday
        /// </summary>
        /// <value>The number of hours worked on a Tuesday</value>
        [DataMember(Name="tuesday", EmitDefaultValue=false)]
        public decimal? Tuesday { get; set; }

        /// <summary>
        /// The number of hours worked on a Wednesday
        /// </summary>
        /// <value>The number of hours worked on a Wednesday</value>
        [DataMember(Name="wednesday", EmitDefaultValue=false)]
        public decimal? Wednesday { get; set; }

        /// <summary>
        /// The number of hours worked on a Thursday
        /// </summary>
        /// <value>The number of hours worked on a Thursday</value>
        [DataMember(Name="thursday", EmitDefaultValue=false)]
        public decimal? Thursday { get; set; }

        /// <summary>
        /// The number of hours worked on a Friday
        /// </summary>
        /// <value>The number of hours worked on a Friday</value>
        [DataMember(Name="friday", EmitDefaultValue=false)]
        public decimal? Friday { get; set; }

        /// <summary>
        /// The number of hours worked on a Saturday
        /// </summary>
        /// <value>The number of hours worked on a Saturday</value>
        [DataMember(Name="saturday", EmitDefaultValue=false)]
        public decimal? Saturday { get; set; }

        /// <summary>
        /// The number of hours worked on a Sunday
        /// </summary>
        /// <value>The number of hours worked on a Sunday</value>
        [DataMember(Name="sunday", EmitDefaultValue=false)]
        public decimal? Sunday { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WorkingWeek {\n");
            sb.Append("  Monday: ").Append(Monday).Append("\n");
            sb.Append("  Tuesday: ").Append(Tuesday).Append("\n");
            sb.Append("  Wednesday: ").Append(Wednesday).Append("\n");
            sb.Append("  Thursday: ").Append(Thursday).Append("\n");
            sb.Append("  Friday: ").Append(Friday).Append("\n");
            sb.Append("  Saturday: ").Append(Saturday).Append("\n");
            sb.Append("  Sunday: ").Append(Sunday).Append("\n");
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
            return this.Equals(input as WorkingWeek);
        }

        /// <summary>
        /// Returns true if WorkingWeek instances are equal
        /// </summary>
        /// <param name="input">Instance of WorkingWeek to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WorkingWeek input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Monday == input.Monday ||
                    (this.Monday != null &&
                    this.Monday.Equals(input.Monday))
                ) && 
                (
                    this.Tuesday == input.Tuesday ||
                    (this.Tuesday != null &&
                    this.Tuesday.Equals(input.Tuesday))
                ) && 
                (
                    this.Wednesday == input.Wednesday ||
                    (this.Wednesday != null &&
                    this.Wednesday.Equals(input.Wednesday))
                ) && 
                (
                    this.Thursday == input.Thursday ||
                    (this.Thursday != null &&
                    this.Thursday.Equals(input.Thursday))
                ) && 
                (
                    this.Friday == input.Friday ||
                    (this.Friday != null &&
                    this.Friday.Equals(input.Friday))
                ) && 
                (
                    this.Saturday == input.Saturday ||
                    (this.Saturday != null &&
                    this.Saturday.Equals(input.Saturday))
                ) && 
                (
                    this.Sunday == input.Sunday ||
                    (this.Sunday != null &&
                    this.Sunday.Equals(input.Sunday))
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
                if (this.Monday != null)
                    hashCode = hashCode * 59 + this.Monday.GetHashCode();
                if (this.Tuesday != null)
                    hashCode = hashCode * 59 + this.Tuesday.GetHashCode();
                if (this.Wednesday != null)
                    hashCode = hashCode * 59 + this.Wednesday.GetHashCode();
                if (this.Thursday != null)
                    hashCode = hashCode * 59 + this.Thursday.GetHashCode();
                if (this.Friday != null)
                    hashCode = hashCode * 59 + this.Friday.GetHashCode();
                if (this.Saturday != null)
                    hashCode = hashCode * 59 + this.Saturday.GetHashCode();
                if (this.Sunday != null)
                    hashCode = hashCode * 59 + this.Sunday.GetHashCode();
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
