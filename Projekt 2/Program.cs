using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace Projekt_2
{
    public static class Program
    {
        // one plus two
        // five plus five 
        // return result

        static void Main(string[] args)
        {
            Console.Write("Type a textnumber like six : ");
            string userInput = Console.ReadLine(); //Låter användaren ange information T.ex. 'seven plus five'
            Console.WriteLine(userInput);

            var numbers = TextToNumbers(userInput); //kolla anrop.
            numbers = TextToOperators(userInput);
            var numbersOperators = TextToOperators(userInput);

            //var calculateNumbers = Calculate(userInput);
            //var result = ReturnResult(userInput);
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
            if (myDictionary.TryGetValue(userInput, out double userInputAsNumber)) // Hämtar värdet ifrån specifik key från dictionary.
            {
                return userInputAsNumber;
                //Lyckades att konvertera text till siffror.
            }
            else
            {
                return -1;
                //Lyckades inte att konvertera text till siffror
            }
        }
        public static double TextToOperators(string userInput)
        {
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

            string phrase = userInput; // tilldelar phrase användar input 
            string[] words = phrase.Split(' '); // Skapar array för splittning utav orden ifrån phrase. 

            if (myDictionary.TryGetValue(userInput, out double valueWithOperator)) // Hämtar värdet ifrån specifik key från dictionary.
            {
                switch (words[1])
                {
                    case "plus":
                        valueWithOperator = myDictionary[words[0]] + myDictionary[words[2]];
                        return valueWithOperator; // skall returnera värdet för addition
                    case "minus":
                        valueWithOperator = myDictionary[words[0]] - myDictionary[words[2]];
                        return valueWithOperator; // skall returnera värdet för subtraktion
                    case "multiplied":
                        valueWithOperator = myDictionary[words[0]] * myDictionary[words[2]];
                        return valueWithOperator; // skall returnera värdet för multiplikation
                    case "divided":
                        valueWithOperator = myDictionary[words[0]] / myDictionary[words[2]];
                        return valueWithOperator; // skall returnera värdet för division
                    default:
                        return 0;
                }
            }
            else
            {
                return -1;
            }

        }
        public static double ReturnResult(string result)
        {
            return 0;
        }



    }
}
