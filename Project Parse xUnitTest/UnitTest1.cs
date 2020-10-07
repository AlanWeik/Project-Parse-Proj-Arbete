using System;
using System.Globalization;
using Xunit;


namespace Project_Parse_xUnitTest
{
    public class UnitTest1AW
    {
        [Fact]
        public void ConvertsOrNo()
        {

            //Arrange
            string PhoneNumber = "zero, seven, nine, three, four, eight, one, six, six, three";
            int actual = 0;

            //Act
            bool isParsable = Int32.TryParse(PhoneNumber, out actual);

            //Assert
            if (isParsable)
                Console.WriteLine(actual);
            else
                Console.WriteLine("Could not be parsed");

        }
    }
}
