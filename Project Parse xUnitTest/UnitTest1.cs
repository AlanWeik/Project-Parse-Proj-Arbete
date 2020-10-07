using System;
using System.Globalization;
using Xunit;

namespace Project_Parse_xUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void ConvertsOrNo()
        {

            //Arrange
            string numbers = "zero, seven, nine, three, four, eight, one, six, six, three";
            int actual = 0793481663;

            //Act
            Convert.ToDouble(numbers);
            actual = new char();

            //Assert
            Assert.Equal(numbers, actual);



        }
    }
}
