using System;

namespace ProjektArbete
{
    class Program
    {
        static void Main(string[] args)
        {
            string PhoneNumber = "zero, seven, nine, three, four, eight, one, six, six, three";
            int actual = 0;

            bool isParsable = Int32.TryParse(PhoneNumber, out actual);

            if (isParsable)
                Console.WriteLine(actual);
            else
                Console.WriteLine("Could not be parsed");
        }
    }
}
