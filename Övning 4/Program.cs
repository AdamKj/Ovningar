using System;

namespace Övning_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gör om programmet i uppgift 1 så den frågar efter ett tal också
            //Fråga användaren efter namn
            Console.WriteLine("Vänligen skriv in ditt namn:");
            string name = Console.ReadLine();

            //Fråga användaren efter ett tal
            Console.WriteLine("Skriv nu in ett tal:");
            int number = int.Parse(Console.ReadLine());

            //Skriv ut hälsningen så många gånger som användaren skrev in ett tal
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"Hej {name}!");
            }

            Console.ReadKey();
        }
    }
}
