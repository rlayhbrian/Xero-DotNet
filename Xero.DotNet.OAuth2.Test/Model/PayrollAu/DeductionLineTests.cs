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
using RestSharp;

namespace Xero.DotNet.OAuth2.Test.Model.PayrollAu
{
    /// <summary>
    ///  Class for testing DeductionLine
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class DeductionLineTests : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'CalculationType' deserialises from valid inputs
        /// </summary>
        [Theory]
        [InlineData("FIXEDAMOUNT", DeductionTypeCalculationType.FIXEDAMOUNT)]
        [InlineData("POSTTAX", DeductionTypeCalculationType.POSTTAX)]
        [InlineData("PRETAX", DeductionTypeCalculationType.PRETAX)]
        public void CalculationType_ValidInputs_Deserialises(string input, DeductionTypeCalculationType expected)
        {
            var response = new RestResponse();
            response.Content = $@"{{
                ""CalculationType"": ""{input}""
            }}";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<DeductionLine>(response);

            Assert.Equal(expected, actual.CalculationType);
        }
        /// <summary>
        /// Test the property 'CalculationType' deserialises to 0 from null
        /// </summary>
        [Fact]
        public void CalculationType_NullInput_DeserialisesTo0()
        {
            var response = new RestResponse();
            response.Content = @"{
                ""CalculationType"": null
            }";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<DeductionLine>(response);

            Assert.Equal(0, (int)actual.CalculationType);
        }
        /// <summary>
        /// Test the property 'CalculationType' deserialises to 0 when not present
        /// </summary>
        [Fact]
        public void CalculationType_NotPresentInInput_DeserialisesTo0()
        {
            var response = new RestResponse();
            response.Content = "{}";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<DeductionLine>(response);

            Assert.Equal(0, (int)actual.CalculationType);
        }
        /// <summary>
        /// Test the property 'Amount'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void Amount_ValidInputs_Deserialises(string input)
        {
            var response = new RestResponse();
            response.Content = $@"{{
                ""Amount"": {input}
            }}";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<DeductionLine>(response);

            Assert.Equal(20, actual.Amount);
        }
        /// <summary>
        /// Test the property 'Percentage'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void Percentage_ValidInputs_Deserialises(string input)
        {
            var response = new RestResponse();
            response.Content = $@"{{
                ""Percentage"": {input}
            }}";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<DeductionLine>(response);

            Assert.Equal(20, actual.Percentage);
        }
        /// <summary>
        /// Test the property 'NumberOfUnits'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void NumberOfUnits_ValidInputs_Deserialises(string input)
        {
            var response = new RestResponse();
            response.Content = $@"{{
                ""NumberOfUnits"": {input}
            }}";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<DeductionLine>(response);

            Assert.Equal(20, actual.NumberOfUnits);
        }
    }
}
