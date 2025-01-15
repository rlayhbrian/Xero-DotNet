/* 
 * Bank Feeds API
 *
 * This specifing endpoints Xero Bank feeds API
 *
 * The version of the OpenAPI document: 2.6.1
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.DotNet.OAuth2.Api;
using Xero.DotNet.OAuth2.Model.Bankfeeds;
using Xero.DotNet.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;
using RestSharp;

namespace Xero.DotNet.OAuth2.Test.Model.Bankfeeds
{
    /// <summary>
    ///  Class for testing FeedConnection
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class FeedConnectionTests : IDisposable
    {
        public FeedConnectionTests()
        {
            // TODO uncomment below to create an instance of FeedConnection
            //instance = new FeedConnection();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'AccountType'
        /// </summary>
        [Theory]
        [InlineData("BANK", FeedConnection.AccountTypeEnum.BANK)]
        [InlineData("CREDITCARD", FeedConnection.AccountTypeEnum.CREDITCARD)]
        public void AccountType_ValidInputs_Deserialises(string input, FeedConnection.AccountTypeEnum expected)
        {
            JsonDoc.Assert<FeedConnection, FeedConnection.AccountTypeEnum>(
                input: new JsonDoc.String(nameof(FeedConnection.AccountType), input),
                toProperty: (x) => x.AccountType,
                shouldBe: expected
            );
        }

        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Theory]
        [InlineData("PENDING", FeedConnection.StatusEnum.PENDING)]
        [InlineData("REJECTED", FeedConnection.StatusEnum.REJECTED)]
        public void Status_ValidInputs_Deserialises(string input, FeedConnection.StatusEnum expected)
        {
            JsonDoc.Assert<FeedConnection, FeedConnection.StatusEnum>(
                input: new JsonDoc.String(nameof(FeedConnection.Status), input),
                toProperty: (x) => x.Status,
                shouldBe: expected
            );
        }
        /// <summary>
        /// Test the property 'Error' deserialises from an Error object
        /// </summary>
        [Fact]
        public void Error_GivenValidInput_Deserialises()
        {
            var response = new RestResponse();
            response.Content = $@"{{
                ""Error"": {{
                    ""type"": ""invalid-end-balance"",
                    ""title"": ""Invalid End Balance"",
                    ""status"": 422,
                    ""detail"": ""Detail""
                }}
            }}";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<FeedConnection>(response);

            Assert.Equal(Error.TypeEnum.InvalidEndBalance, actual.Error.Type);
            Assert.Equal("Invalid End Balance", actual.Error.Title);
            Assert.Equal(422, actual.Error.Status);
            Assert.Equal("Detail", actual.Error.Detail);
        }
    }
}
