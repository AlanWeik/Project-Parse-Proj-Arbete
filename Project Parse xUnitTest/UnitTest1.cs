using Microsoft.VisualStudio.TestPlatform.Utilities;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using Xunit.Sdk;
using Xunit.Abstractions;


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
                //string input = "one";
                var number = new Dictionary <string, double>();
                number.Add("one", 1);
                if (number.ContainsValue(1))
                {
                    output.WriteLine("Contains 1");
                }

                /*if (input == "one")
                {
                    Assert.Equal(input, number); // OM Dictionary <string, double> blir det Assert.Equal(1, number["one"]);
                }
                else
                {
                    Console.WriteLine("Wrong type of input, write 'one' damnit.");
                }*/

            }
        }
    }
}
