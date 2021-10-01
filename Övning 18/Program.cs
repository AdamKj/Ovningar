using System;
using System.Linq;

namespace Övning_18
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren mata in en mening
            Console.WriteLine("Skriv in valfri mening");
            var input = Console.ReadLine();

            var separators = new[] { ' ', ',', '.', '!', '?' };

            var words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            var averagewords = words.Select(s => s.Length).Average();

            //Skriv ut det genomsnittliga antalet bokstäver i orden
            Console.WriteLine("");
            Console.WriteLine($"det genomsnittliga antalet bokstäver i alla ord i din mening är {averagewords}st");


            Console.ReadKey();
        }
    }
}
