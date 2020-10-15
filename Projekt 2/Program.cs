using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ProjektArbete
{
    public class Program
    {


        static void Main(string[] args)
        {
            string userInput = Console.ReadLine();
            var numbers = LinkStringToDouble(userInput);
        }


        public static double LinkStringToDouble(string userInput)
        {

            Dictionary<string, double> numbers = new Dictionary<string, double>();
            numbers.Add("zero", 0);
            numbers.Add("one", 1);
            numbers.Add("two", 2);
            numbers.Add("three", 3);
            numbers.Add("four", 4);
            numbers.Add("five", 5);
            numbers.Add("six", 6);
            numbers.Add("seven", 7);
            numbers.Add("eight", 8);
            numbers.Add("nine", 9);
            numbers.Add("ten", 10);

            if (numbers.TryGetValue(userInput, out double UserInputAsNumber))
            {
                return UserInputAsNumber;
            }
            else
            {
                return - 1;
            }


            /*if (input == "zero")
            {
                Console.WriteLine(numbers["zero"]);
            }
            if (input == "one")
            {
                Console.WriteLine(numbers["one"]);
            }
            if (input == "two")
            {
                Console.WriteLine(numbers["two"]);
            }
            if (input == "three")
            {
                Console.WriteLine(numbers["three"]);
            }
            if (input == "four")
            {
                Console.WriteLine(numbers["four"]);
            }
            if (input == "five")
            {
                Console.WriteLine(numbers["five"]);
            }
            if (input == "six")
            {
                Console.WriteLine(numbers["six"]);
            }
            if (input == "seven")
            {
                Console.WriteLine(numbers["seven"]);
            }
            if (input == "eight")
            {
                Console.WriteLine(numbers["eight"]);
            }
            if (input == "nine")
            {
                Console.WriteLine(numbers["nine"]);
            }
            if (input == "10")
            {
                Console.WriteLine(numbers["10"]);
            }*/

            //return input;

        }

    }
}