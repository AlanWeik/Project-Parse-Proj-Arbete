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
            Assert.Equal(1, number);
        }
        /*[Fact]
        public void Operators()
        {
            Assert.Equal(3, Program.Operators("one plus two"));
        }
        [Fact]
        public void Calculate()
        {
            Assert.Equal(10, Program.Calculate("five plus five"));
        }
        [Fact]
        public void ReturnResult()
        {
            Assert.Equal(10, Program.ReturnResult("The answer is: 10!"));
        }*/
    }
}
