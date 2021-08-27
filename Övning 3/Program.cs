using System;

namespace Övning_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fråga användaren efter ett tal
            Console.WriteLine("Vänligen skriv in ett tal!");
            double input = double.Parse(Console.ReadLine());

            //Skriv ut om talet är mindre, större eller lika med 100
            int tal = 100;

            if (input < tal)
            {
                Console.WriteLine("Ditt tal är mindre än 100!");
            }
            else if (input == tal)
            {
                Console.WriteLine("Ditt tal är lika med 100!");
            }
            else
            {
                Console.WriteLine("Ditt tal är större än 100!");
            }

            Console.ReadKey();
        }
    }
}
