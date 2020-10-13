using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;

namespace Projekt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("> Type: ");
            string userInput = Console.ReadLine();


            // Kallar på metoder.
            ReturnValueFromStringToDouble();
            CalculateValueFromStringToDouble();

            var stringToNumberDictionarie = new Dictionary<string, double>() // Skapar Dictionary för nyckelord som består av ett double värde.
            {
                { "zero", 0},
                { "one",  1},
                { "two", 2},
                { "three", 3},
                { "four", 4},
                { "five", 5},
                { "six", 6},
                { "seven", 7},
                { "eight", 8},
                { "nine", 9},
                { "ten", 10},
            };
            Console.WriteLine();
        }
        public static double ReturnValueFromStringToDouble() // Returnerar värde från sträng till double.
        {
            return 0;
        }
        public static double CalculateValueFromStringToDouble() // Räknar ut värde från sträng till double.
        {
            return 0;
        }
    }
}
