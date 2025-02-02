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
    /// Defines ResidencyStatus
    /// </summary>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum ResidencyStatus
    {
        /// <summary>
        /// Enum AUSTRALIANRESIDENT for value: AUSTRALIANRESIDENT
        /// </summary>
        [EnumMember(Value = "AUSTRALIANRESIDENT")]
        AUSTRALIANRESIDENT = 1,

        /// <summary>
        /// Enum FOREIGNRESIDENT for value: FOREIGNRESIDENT
        /// </summary>
        [EnumMember(Value = "FOREIGNRESIDENT")]
        FOREIGNRESIDENT = 2,

        /// <summary>
        /// Enum WORKINGHOLIDAYMAKER for value: WORKINGHOLIDAYMAKER
        /// </summary>
        [EnumMember(Value = "WORKINGHOLIDAYMAKER")]
        WORKINGHOLIDAYMAKER = 3

    }

}
