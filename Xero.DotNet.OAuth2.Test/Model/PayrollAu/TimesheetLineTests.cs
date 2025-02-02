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
    ///  Class for testing TimesheetLine
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TimesheetLineTests : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'NumberOfUnits'
        /// </summary>
        [Fact]
        public void NumberOfUnitsTest()
        {
            var response = new RestSharp.RestResponse();
            response.Content = $@"{{
                ""NumberOfUnits"": [
                    20.00,
                    20,
                    123.123123
                ]
            }}";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<TimesheetLine>(response);

            Assert.Equal(20f, actual.NumberOfUnits[0]);
            Assert.Equal(20f, actual.NumberOfUnits[1]);
            Assert.Equal(123.123123, actual.NumberOfUnits[2], precision: 6);
        }
    }
}
