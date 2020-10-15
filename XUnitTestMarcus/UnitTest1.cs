using System;
using System.Collections.Generic;
using Xunit;
using Projekt_2;

namespace XUnitTestMarcus
{
    public class UnitTest1
    {
        [Fact]
        public void TextToNumbers()
        {
            var userInput = "one";
            var number = Program.TextToNumbers(userInput);
            Assert.Equal(1, number);  // Success!
        }

        [Fact]
        public void TextToOperators()
        {
            var userInput = "one plus two";
            var operate = Program.TextToOperators(userInput);
            Assert.Equal(3, operate);
        }
        [Fact]
        public void ReturnResult()
        {
            Assert.Equal(10, Program.ReturnResult("The answer is: 10!"));
        }
    }
}
