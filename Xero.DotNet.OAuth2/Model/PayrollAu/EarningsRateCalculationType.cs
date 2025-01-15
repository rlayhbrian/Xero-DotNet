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
    /// Defines EarningsRateCalculationType
    /// </summary>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum EarningsRateCalculationType
    {
        /// <summary>
        /// Enum USEEARNINGSRATE for value: USEEARNINGSRATE
        /// </summary>
        [EnumMember(Value = "USEEARNINGSRATE")]
        USEEARNINGSRATE = 1,

        /// <summary>
        /// Enum ENTEREARNINGSRATE for value: ENTEREARNINGSRATE
        /// </summary>
        [EnumMember(Value = "ENTEREARNINGSRATE")]
        ENTEREARNINGSRATE = 2,

        /// <summary>
        /// Enum ANNUALSALARY for value: ANNUALSALARY
        /// </summary>
        [EnumMember(Value = "ANNUALSALARY")]
        ANNUALSALARY = 3

    }

}
