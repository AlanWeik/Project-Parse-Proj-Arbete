using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestMarcus
{
    public class UnitTest1
    {
        [Fact]
        public void TestValueConverter() // Dennna metod skall konverta text till siffror, alltså inmatning = "one" skriv ut en "1"
        {
            string input = "";
            do
            {
                input = "one";
                var stringNumbers = new Dictionary<string, double>();
                stringNumbers.Add("one", 1);
                if (input == "one")
                {                 
                    Assert.Equal(1, stringNumbers["one"]);
                }
                else
                {
                    Console.WriteLine("Fel inmatning!");
                }
            } while (input != "one");  // Passed!!!!
        }
        [Fact]
        public void TestParseing() // Parseing mtod för att se om det går att parsa och om värdena överstämmer. 
        {
            var stringNumbers = new Dictionary<string, double>();
            stringNumbers.Add("one", 1); // metod som adderar till Dictionary.
            stringNumbers.Add("two", 2);
            stringNumbers.Add("three", 3);
            stringNumbers.Add("four", 4);
            stringNumbers.Add("five", 5);
            stringNumbers.Add("six", 6);
            stringNumbers.Add("seven", 7);
            stringNumbers.Add("eight", 8);
            stringNumbers.Add("nine", 9);
            string input = "";

            switch (input) // Switch-sats för inmatning
            {
                case "one plus one":
                    double result = double.Parse(input); // Parsar input.
                    break;
                case "one minus one":

                    break;
                case "one divided one":

                    break;
                case "one multiplie one":

                    break;

            }

        }
    }
}
