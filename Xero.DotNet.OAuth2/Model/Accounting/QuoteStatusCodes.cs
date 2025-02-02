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
    /// The status of the quote.
    /// </summary>
    /// <value>The status of the quote.</value>
    
    [JsonConverter(typeof(Client.CustomStringEnumConverter))]
    
    public enum QuoteStatusCodes
    {
        /// <summary>
        /// Enum DRAFT for value: DRAFT
        /// </summary>
        [EnumMember(Value = "DRAFT")]
        DRAFT = 1,

        /// <summary>
        /// Enum SENT for value: SENT
        /// </summary>
        [EnumMember(Value = "SENT")]
        SENT = 2,

        /// <summary>
        /// Enum DECLINED for value: DECLINED
        /// </summary>
        [EnumMember(Value = "DECLINED")]
        DECLINED = 3,

        /// <summary>
        /// Enum ACCEPTED for value: ACCEPTED
        /// </summary>
        [EnumMember(Value = "ACCEPTED")]
        ACCEPTED = 4,

        /// <summary>
        /// Enum INVOICED for value: INVOICED
        /// </summary>
        [EnumMember(Value = "INVOICED")]
        INVOICED = 5,

        /// <summary>
        /// Enum DELETED for value: DELETED
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED = 6

    }

}
