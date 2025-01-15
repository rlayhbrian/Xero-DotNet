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
    ///  Class for testing TaxDeclaration
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TaxDeclarationTests : IDisposable
    {
        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test the property 'EmploymentBasis' deserialises from valid inputs
        /// </summary>
        [Theory]
        [InlineData("FULLTIME", EmploymentBasis.FULLTIME)]
        [InlineData("PARTTIME", EmploymentBasis.PARTTIME)]
        [InlineData("CASUAL", EmploymentBasis.CASUAL)]
        [InlineData("LABOURHIRE", EmploymentBasis.LABOURHIRE)]
        [InlineData("SUPERINCOMESTREAM", EmploymentBasis.SUPERINCOMESTREAM)]
        public void EmploymentBasis_ValidInputs_Deserialises(string input, EmploymentBasis expected)
        {
            JsonDoc.Assert<TaxDeclaration, EmploymentBasis>(
                input: new JsonDoc.String(nameof(TaxDeclaration.EmploymentBasis), input),
                toProperty: (t) => t.EmploymentBasis,
                shouldBe: expected
            );
        }
        /// <summary>
        /// Test the property 'EmploymentBasis' deserialises from null to 0
        /// </summary>
        [Fact]
        public void EmploymentBasis_NullInput_DeserialisesTo0()
        {
            JsonDoc.Assert<TaxDeclaration, EmploymentBasis>(
                input: new JsonDoc.Null(nameof(TaxDeclaration.EmploymentBasis)),
                toProperty: (t) => t.EmploymentBasis,
                shouldBe: 0
            );
        }
        /// <summary>
        /// Test the property 'EmploymentBasis' deserialises to 0 when not present
        /// </summary>
        [Fact]
        public void EmploymentBasis_NotPresentInInput_DeserialisesTo0()
        {
            JsonDoc.Assert<TaxDeclaration, EmploymentBasis>(
                input: new JsonDoc.NotPresent(nameof(TaxDeclaration.EmploymentBasis)),
                toProperty: (t) => t.EmploymentBasis,
                shouldBe: 0
            );
        }
        /// <summary>
        /// Test the property 'TFNExemptionType' deserialises from valid inputs
        /// </summary>
        [Theory]
        [InlineData("NOTQUOTED", TFNExemptionType.NOTQUOTED)]
        [InlineData("PENDING", TFNExemptionType.PENDING)]
        [InlineData("PENSIONER", TFNExemptionType.PENSIONER)]
        [InlineData("UNDER18", TFNExemptionType.UNDER18)]
        public void TFNExemptionType_ValidInputs_Deserialises(string input, TFNExemptionType expected)
        {
            JsonDoc.Assert<TaxDeclaration, TFNExemptionType>(
                input: new JsonDoc.String(nameof(TaxDeclaration.TFNExemptionType), input),
                toProperty: (declaration) => declaration.TFNExemptionType,
                shouldBe: expected
            );
        }
        /// <summary>
        /// Test the property 'TFNExemptionType' deserialises from null to 0
        /// </summary>
        [Fact]
        public void TFNExemptionType_NullInput_DeserialisesTo0()
        {
            JsonDoc.Assert<TaxDeclaration, TFNExemptionType>(
                input: new JsonDoc.Null(nameof(TaxDeclaration.TFNExemptionType)),
                toProperty: (declaration) => declaration.TFNExemptionType,
                shouldBe: 0
            );
        }
        /// <summary>
        /// Test the property 'TFNExemptionType' deserialises to 0 when not present
        /// </summary>
        [Fact]
        public void TFNExemptionType_NotPresentInInput_DeserialisesTo0()
        {
            JsonDoc.Assert<TaxDeclaration, TFNExemptionType>(
                input: new JsonDoc.NotPresent(nameof(TaxDeclaration.TFNExemptionType)),
                toProperty: (declaration) => declaration.TFNExemptionType,
                shouldBe: 0
            );
        }
        /// <summary>
        /// Test the property 'AustralianResidentForTaxPurposes'
        /// </summary>
        [Theory]
        [InlineData("true", true)]
        [InlineData("false", false)]
        public void AustralianResidentForTaxPurposesTest(string input, bool expected)
        {
            JsonDoc.Assert<TaxDeclaration, bool?>(
                input: new JsonDoc.Bool(
                    nameof(TaxDeclaration.AustralianResidentForTaxPurposes),
                    input),
                toProperty: (declaration) => declaration.AustralianResidentForTaxPurposes,
                shouldBe: expected
            );
        }
        /// <summary>
        /// Test the property 'ResidencyStatus'
        /// </summary>
        [Theory]
        [InlineData("AUSTRALIANRESIDENT", ResidencyStatus.AUSTRALIANRESIDENT)]
        [InlineData("FOREIGNRESIDENT", ResidencyStatus.FOREIGNRESIDENT)]
        [InlineData("WORKINGHOLIDAYMAKER", ResidencyStatus.WORKINGHOLIDAYMAKER)]
        public void ResidencyStatus_ValidInputs_Deserialises(string input, ResidencyStatus expected)
        {
            JsonDoc.Assert<TaxDeclaration, ResidencyStatus>(
                input: new JsonDoc.String(nameof(TaxDeclaration.ResidencyStatus), input),
                toProperty: x => x.ResidencyStatus,
                shouldBe: expected
            );
        }
        /// <summary>
        /// Test the property 'TaxOffsetEstimatedAmount'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void TaxOffsetEstimatedAmountTest(string input)
        {
            JsonDoc.Assert<TaxDeclaration, decimal?>(
                input: new JsonDoc.Number(nameof(TaxDeclaration.TaxOffsetEstimatedAmount), input),
                toProperty: (declaration) => declaration.TaxOffsetEstimatedAmount,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'UpwardVariationTaxWithholdingAmount'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void UpwardVariationTaxWithholdingAmountTest(string input)
        {
            JsonDoc.Assert<TaxDeclaration, decimal?>(
                input: new JsonDoc.Number(nameof(TaxDeclaration.UpwardVariationTaxWithholdingAmount), input),
                toProperty: x => x.UpwardVariationTaxWithholdingAmount,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'ApprovedWithholdingVariationPercentage'
        /// </summary>
        [Theory]
        [InlineData("20.00")]
        [InlineData("20")]
        public void ApprovedWithholdingVariationPercentageTest(string input)
        {
            JsonDoc.Assert<TaxDeclaration, decimal?>(
                input: new JsonDoc.Number(nameof(TaxDeclaration.ApprovedWithholdingVariationPercentage), input),
                toProperty: x => x.ApprovedWithholdingVariationPercentage,
                shouldBe: 20
            );
        }
        /// <summary>
        /// Test the property 'UpdatedDateUTC'
        /// </summary>
        [Fact]
        public void UpdatedDateUTCTest()
        {
            JsonDoc.Assert<TaxDeclaration, DateTime?>(
                input: new JsonDoc.String(
                    nameof(TaxDeclaration.UpdatedDateUTC),
                    "/Date(1535481994000+0000)/"),
                toProperty: (declaration) => declaration.UpdatedDateUTC,
                shouldBe: new DateTime(2018, 8, 28, 18, 46, 34)
            );
        }
    }

}
