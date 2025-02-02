/* 
 * Xero Payroll NZ
 *
 * This is the Xero Payroll API for orgs in the NZ region.
 *
 * The version of the OpenAPI document: 2.7.0
 * Contact: api@xero.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Xero.DotNet.OAuth2.Api;
using Xero.DotNet.OAuth2.Model.PayrollNz;
using Xero.DotNet.OAuth2.Client;
using System.Reflection;
using Newtonsoft.Json;
using RestSharp;

namespace Xero.DotNet.OAuth2.Test.Model.PayrollNz
{
    /// <summary>
    ///  Class for testing Timesheet
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class TimesheetTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for Timesheet
        //private Timesheet instance;

        public TimesheetTests()
        {
            // TODO uncomment below to create an instance of Timesheet
            //instance = new Timesheet();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of Timesheet
        /// </summary>
        [Fact]
        public void TimesheetInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Timesheet
            //Assert.IsInstanceOfType<Timesheet> (instance, "variable 'instance' is a Timesheet");
        }


        /// <summary>
        /// Test the property 'TimesheetID'
        /// </summary>
        [Fact]
        public void TimesheetIDTest()
        {
            // TODO unit test for the property 'TimesheetID'
        }
        /// <summary>
        /// Test the property 'PayrollCalendarID'
        /// </summary>
        [Fact]
        public void PayrollCalendarIDTest()
        {
            // TODO unit test for the property 'PayrollCalendarID'
        }
        /// <summary>
        /// Test the property 'EmployeeID'
        /// </summary>
        [Fact]
        public void EmployeeIDTest()
        {
            // TODO unit test for the property 'EmployeeID'
        }
        /// <summary>
        /// Test the property 'StartDate'
        /// </summary>
        [Fact]
        public void StartDateTest()
        {
            // TODO unit test for the property 'StartDate'
        }
        /// <summary>
        /// Test the property 'EndDate'
        /// </summary>
        [Fact]
        public void EndDateTest()
        {
            // TODO unit test for the property 'EndDate'
        }
        /// <summary>
        /// Test the property 'Status'
        /// </summary>
        [Theory]
        [InlineData("Approved", Timesheet.StatusEnum.Approved)]
        [InlineData("Completed", Timesheet.StatusEnum.Completed)]
        [InlineData("Draft", Timesheet.StatusEnum.Draft)]
        public void StatusEnum_ValidInput_Deserialises(string input, Timesheet.StatusEnum expected)
        {
            var response = new RestResponse();
            response.Content = $@"""{input}""";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<Timesheet.StatusEnum>(response);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void StatusEnum_NullInput_Deserialises(){
            var response = new RestResponse();
            response.Content = "null";

            var deserializer = new CustomJsonCodec(new Configuration());
            var actual = deserializer.Deserialize<Timesheet.StatusEnum>(response);

            Assert.Equal(0, (int)actual);
        }
        /// <summary>
        /// Test the property 'TotalHours'
        /// </summary>
        [Fact]
        public void TotalHoursTest()
        {
            // TODO unit test for the property 'TotalHours'
        }
        /// <summary>
        /// Test the property 'UpdatedDateUTC'
        /// </summary>
        [Fact]
        public void UpdatedDateUTCTest()
        {
            // TODO unit test for the property 'UpdatedDateUTC'
        }
        /// <summary>
        /// Test the property 'TimesheetLines'
        /// </summary>
        [Fact]
        public void TimesheetLinesTest()
        {
            // TODO unit test for the property 'TimesheetLines'
        }

    }

}
