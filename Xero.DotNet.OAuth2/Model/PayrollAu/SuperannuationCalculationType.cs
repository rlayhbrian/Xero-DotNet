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
    /// Defines SuperannuationCalculationType
    /// </summary>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum SuperannuationCalculationType
    {
        /// <summary>
        /// Enum FIXEDAMOUNT for value: FIXEDAMOUNT
        /// </summary>
        [EnumMember(Value = "FIXEDAMOUNT")]
        FIXEDAMOUNT = 1,

        /// <summary>
        /// Enum PERCENTAGEOFEARNINGS for value: PERCENTAGEOFEARNINGS
        /// </summary>
        [EnumMember(Value = "PERCENTAGEOFEARNINGS")]
        PERCENTAGEOFEARNINGS = 2,

        /// <summary>
        /// Enum STATUTORY for value: STATUTORY
        /// </summary>
        [EnumMember(Value = "STATUTORY")]
        STATUTORY = 3

    }

}
