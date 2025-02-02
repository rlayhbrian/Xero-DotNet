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

namespace Xero.DotNet.OAuth2.Test.Model.Bankfeeds
{
    /// <summary>
    ///  Class for testing Pagination
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class PaginationTests : IDisposable
    {
        public PaginationTests()
        {
            // TODO uncomment below to create an instance of Pagination
            //instance = new Pagination();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'Page' deserialises from a valid int
        /// </summary>
        [Fact]
        public void Page_ValidInteger_Deserialises()
        {
            JsonDoc.Assert<Pagination, int?>(
                input: new JsonDoc.Number(nameof(Pagination.Page), "20"),
                toProperty: (t) => t.Page,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'Page' deserialises from null
        /// </summary>
        [Fact]
        public void Page_Null_Deserialises()
        {
            JsonDoc.Assert<Pagination, int?>(
                input: new JsonDoc.Null(nameof(Pagination.Page)),
                toProperty: (t) => t.Page,
                shouldBe: null
            );
        }
        /// <summary>
        /// Test the property 'PageSize' deserialises from a valid int
        /// </summary>
        [Fact]
        public void PageSize_ValidInteger_Deserialises()
        {
            JsonDoc.Assert<Pagination, int?>(
                input: new JsonDoc.Number(nameof(Pagination.PageSize), "20"),
                toProperty: (t) => t.PageSize,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'PageSize' deserialises from null
        /// </summary>
        [Fact]
        public void PageSize_Null_Deserialises()
        {
            JsonDoc.Assert<Pagination, int?>(
                input: new JsonDoc.Null(nameof(Pagination.PageSize)),
                toProperty: (t) => t.PageSize,
                shouldBe: null
            );
        }
        /// <summary>
        /// Test the property 'PageCount' deserialises from a valid int
        /// </summary>
        [Fact]
        public void PageCount_ValidInteger_Deserialises()
        {
            JsonDoc.Assert<Pagination, int?>(
                input: new JsonDoc.Number(nameof(Pagination.PageCount), "20"),
                toProperty: (t) => t.PageCount,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'PageCount' deserialises from null
        /// </summary>
        [Fact]
        public void PageCount_Null_Deserialises()
        {
            JsonDoc.Assert<Pagination, int?>(
                input: new JsonDoc.Null(nameof(Pagination.PageCount)),
                toProperty: (t) => t.PageCount,
                shouldBe: null
            );
        }
        /// <summary>
        /// Test the property 'ItemCount' deserialises from a valid int
        /// </summary>
        [Fact]
        public void ItemCount_ValidInteger_Deserialises()
        {
            JsonDoc.Assert<Pagination, int?>(
                input: new JsonDoc.Number(nameof(Pagination.ItemCount), "20"),
                toProperty: (t) => t.ItemCount,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'ItemCount' deserialises from null
        /// </summary>
        [Fact]
        public void ItemCount_Null_Deserialises()
        {
            JsonDoc.Assert<Pagination, int?>(
                input: new JsonDoc.Null(nameof(Pagination.ItemCount)),
                toProperty: (t) => t.ItemCount,
                shouldBe: null
            );
        }

    }

}
