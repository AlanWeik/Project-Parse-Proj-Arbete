using System;
using System.Collections.Generic;
using System.Globalization;

namespace Projekt_2
{
    class Program
    {
        static void Main(string[] args)
        {
            ReturnValueFromStringToDouble(); // Kallar på Dicitionary metoden.
            CalculateValueFromStringToDouble();
        }
        public static string ReturnValueFromStringToDouble() // Metod som testar datastruktur och skriver ut sifforir vid text inmatning.
        {
            string input = ""; // Användar input.
            do
            {
                try
                {
                    var stringNumbers = new Dictionary<string, double>(); // Dicitionary för keywords.
                    Console.Write("Type one:  ");
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
                catch (Exception e) // Felmeddelande.
                {
                    Console.WriteLine(e);
                    throw;
                }

            }
            while (input != "one");
            return (input); // Returnernar input värde och skriver ut på skärmen.
        }
        public static double CalculateValueFromStringToDouble() //Metod för att räkna ut konverterad data.
        {
            return 0;
        }
    }
}
