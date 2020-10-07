using System;
using System.Collections.Generic;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Xunit;
using Xunit.Sdk;

namespace Project_Parse_xUnitTest
{
    public class UnitTest1AW
    {
        [Fact]
        public void ConvertsOrNo()
        {
            {

                var one = new Dictionary <double, string>();
                one.Add(1, "one");
                Console.WriteLine(one[1]);

            }
        }
    }
}

    /*
    //Arrange
    string PhoneNumber = "zero, seven, nine, three, four, eight, one, six, six, three";
    int actual = 0;

    //Act
    bool isParsable = double.Parse(PhoneNumber, out actual);

    //Assert
    if (isParsable)
        Console.WriteLine(actual);
    else
        Console.WriteLine("Could not be parsed");
    */


    

