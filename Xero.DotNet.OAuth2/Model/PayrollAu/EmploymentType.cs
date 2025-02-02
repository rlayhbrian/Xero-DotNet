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
    /// Defines EmploymentType
    /// </summary>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum EmploymentType
    {
        /// <summary>
        /// Enum EMPLOYEE for value: EMPLOYEE
        /// </summary>
        [EnumMember(Value = "EMPLOYEE")]
        EMPLOYEE = 1,

        /// <summary>
        /// Enum CONTRACTOR for value: CONTRACTOR
        /// </summary>
        [EnumMember(Value = "CONTRACTOR")]
        CONTRACTOR = 2

    }

}
