using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace Projekt_2
{
    public static class Program
    {
        // one
        // one plus two
        // five plus five 
        // return result

        static void Main(string[] args)
        {
            Console.Write("Type a number: ");
            string userInput = Console.ReadLine(); //Låter användaren ange information T.ex. 'seven plus five'
            Console.WriteLine();

            var numbers = TextToNumbers(userInput);
            //var operators = Operators(userInput);
            Calculate();
            ReturnResult();
        }

        public static double TextToNumbers(string userInput)
        {
            // Skapar Dictionary för nyckelord som består av ett double värde.
            var myDictionary = new Dictionary<string, double>()
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
            if (myDictionary.TryGetValue(userInput, out double userInputAsNumber))
            {
                return userInputAsNumber;
                //We could convert the user input
            } else
            {
                return -1;
                //We could not convert the user input
            }
            
        }
        public static void Operators()
        {
            
        }
        public static void Calculate()
        {

        }
        public static void ReturnResult()
        {

        }
    }
}
