using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace ProjektArbete
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*string hello = "twelve";
            int twelve = 12;
            Convert.ToChar(hello);
            Convert.ToUInt64(hello);*/

            /*var one = new Dictionary <double, string>();
            one.Add(1, "one");
            Console.WriteLine(one[1]);*/

            /*var two = new Dictionary<double, string>();
            two.Add(2, "two");
            Console.WriteLine(two[2]);*/

            /*var stringNumbers = new Dictionary<string, double>();
            Console.Write("Type numbers (in letters): ");
            string input = Console.ReadLine();
            stringNumbers.Add("one", 1); // Adderar värde .Add() metod


            if (input == "one")
            {
                Console.WriteLine(stringNumbers["one"]);
            }
            Console.ReadKey();*/


            string input;
            do
            {

                try
                {
                    var stringNumbers = new Dictionary<string, double>();
                    Console.Write("Type numbers:  ");
                    input = Console.ReadLine();
                    stringNumbers.Add("one", 1); // Adderar värde .Add() metod
                    if (input == "one")
                    {
                        Console.WriteLine(stringNumbers["one"]);
                    }
                    if (input != "one")
                    {
                        Console.WriteLine($"Fel inmatning! Skriv bara 'one' ");
                    }
                    Console.ReadKey();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
            while (input != "one");

        }
    }
}