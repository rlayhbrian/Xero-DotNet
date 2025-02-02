/* 
 * Xero Payroll AU API
 *
 * This is the Xero Payroll API for orgs in Australia region.
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

namespace Xero.DotNet.OAuth2.Model.PayrollAu
{
    /// <summary>
    /// Defines TaxScaleType
    /// </summary>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum TaxScaleType
    {
        /// <summary>
        /// Enum REGULAR for value: REGULAR
        /// </summary>
        [EnumMember(Value = "REGULAR")]
        REGULAR = 1,

        /// <summary>
        /// Enum ACTORSARTISTSENTERTAINERS for value: ACTORSARTISTSENTERTAINERS
        /// </summary>
        [EnumMember(Value = "ACTORSARTISTSENTERTAINERS")]
        ACTORSARTISTSENTERTAINERS = 2,

        /// <summary>
        /// Enum HORTICULTURISTORSHEARER for value: HORTICULTURISTORSHEARER
        /// </summary>
        [EnumMember(Value = "HORTICULTURISTORSHEARER")]
        HORTICULTURISTORSHEARER = 3,

        /// <summary>
        /// Enum SENIORORPENSIONER for value: SENIORORPENSIONER
        /// </summary>
        [EnumMember(Value = "SENIORORPENSIONER")]
        SENIORORPENSIONER = 4,

        /// <summary>
        /// Enum WORKINGHOLIDAYMAKER for value: WORKINGHOLIDAYMAKER
        /// </summary>
        [EnumMember(Value = "WORKINGHOLIDAYMAKER")]
        WORKINGHOLIDAYMAKER = 5,

        /// <summary>
        /// Enum FOREIGN for value: FOREIGN
        /// </summary>
        [EnumMember(Value = "FOREIGN")]
        FOREIGN = 6

    }

}
