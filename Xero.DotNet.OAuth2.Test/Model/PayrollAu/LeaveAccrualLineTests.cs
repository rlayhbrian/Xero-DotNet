/* 
 * Xero Payroll AU
 *
 * This is the Xero Payroll API for orgs in Australia region.
 *
 * The version of the OpenAPI document: 2.8.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.DotNet.OAuth2.Api;
using Xero.DotNet.OAuth2.Model.PayrollAu;
using Xero.DotNet.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Xero.DotNet.OAuth2.Test.Model.PayrollAu
{
    /// <summary>
    ///  Class for testing LeaveAccrualLine
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class LeaveAccrualLineTests : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }
        /// <summary>
        /// Test the property 'NumberOfUnits'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void NumberOfUnitsTest(string input)
        {
            JsonDoc.Assert<LeaveAccrualLine, decimal?>(
                input: new JsonDoc.Number(nameof(LeaveAccrualLine.NumberOfUnits), input),
                toProperty: x => x.NumberOfUnits,
                shouldBe: 20
            );
        }
    }
}
