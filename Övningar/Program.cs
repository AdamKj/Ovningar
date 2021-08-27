using System;

namespace Övningar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fråga användaren efter namn 
            Console.WriteLine("Skriv ut ditt namn:");
            string input = Console.ReadLine();

            //Skriv ut namn och en hälsning
            Console.WriteLine($"Hej {input}!");

            Console.ReadKey();
        }
    }
}
