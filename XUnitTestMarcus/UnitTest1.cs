using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestMarcus
{
    public class UnitTest1
    {
        [Fact]
        public void TestValueConverter()
        {
            string input = "";
            do
            {
                input = Console.ReadLine();
                var stringNumbers = new Dictionary<string, double>();
                stringNumbers.Add("one", 1);
                if (input == "one")
                {
                    Console.WriteLine(input);
                }
                else
                {
                    Console.WriteLine("Fel inmatning!");
                }
            } while (input != "one");
        }
    }
}
