using Microsoft.VisualStudio.TestPlatform.Utilities;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using Xunit.Sdk;
using Xunit.Abstractions;
using Microsoft.VisualBasic.CompilerServices;
using System.Data.Common;

namespace Project_Parse_xUnitTest
{
    public class UnitTest1AW
    {
        private readonly ITestOutputHelper output;

        public UnitTest1AW(ITestOutputHelper output)
        {
            this.output = output;
        }


       [Fact]
        public void ConvertsOrNo()
        {
            {
                string input = "one";
                var number = new Dictionary <string, double>();
                number.Add("one", 1);
                if (number.ContainsValue(1))
                {
                    output.WriteLine("Contains 1");
                }
            }
        }

        [Fact]
        public void EqualOrNot()
        {
            var numbers = new Dictionary<string, double>();
            numbers.Add("one", 1);

            double output = 1;

            Assert.Equal(output, numbers["one"]);
        }


        [Fact]
        public void Calculate()
        {
            //Arrange
            var numbers = new Dictionary<string, double>();
            numbers.Add("one", 1);
            int expected = 2;
            //Act
            double sum = numbers["one"] + numbers["one"];
            //Assert
            Assert.Equal(expected, sum);

        }
    }
}

