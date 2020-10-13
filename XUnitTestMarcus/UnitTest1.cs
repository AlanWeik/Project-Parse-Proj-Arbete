using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestMarcus
{
    public class UnitTest1
    {
        [Fact] // Testet lyckades!
        public void TestValueConverter() // Dennna metod skall konverta text till siffror, alltså inmatning = "one" skriv ut en "1"
        {
            Dictionary<string, double> stringNumbers = new Dictionary<string, double>();
            stringNumbers.Add("one", 1); // Addar nyckelord i Dictionary.

            string input = "one";
            if (input == "one")
            {
                Assert.Equal(1, stringNumbers["one"]);
            }

        }
        [Fact]
        public void Operators()
        {

        }
        [Fact]
        public void CalculateValueFromStringToDouble()
        {
            string input = ("one plus two");
            var Operators = new Dictionary<string, Func<double, double, double>>()
            {
                { "plus", (a, b) => a + b}, //Lambda
                { "minus", (a, b) => a - b},
                {" multiplied", (a, b) => a * b},
                {" divided", (a, b) => a / b }

            };
            if (input == "plus")
            {
                Console.WriteLine();
            }
            if (input == "minus")
            {
                Console.WriteLine();
            }
            if (input == "multiplied")
            {
                Console.WriteLine();
            }
            if (input == "divided")
            {
                Console.WriteLine();
            }
        }
    }
}
