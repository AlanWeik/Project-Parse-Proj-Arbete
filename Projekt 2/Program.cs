using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace ProjektArbete
{
    public class Program
    {

        static void Main(string[] args)
        {

            string input;

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

            Console.WriteLine("Choose a number between zero and ten:");
            input = Console.ReadLine();

            if (input == "zero")
            {
                Console.WriteLine(numbers["zero"]);
            }



        }
    }
}