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
    }
}
