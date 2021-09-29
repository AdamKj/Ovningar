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
            var numberOfLetters = input.Length;

            var separators = new[] { ' ', ',', '.', '!', '?' };
            var emptySpaces = input.Split(separators);

            double result = 0;
            foreach (var sep in separators)
            {
                if (input.Contains(sep))
                {
                    string words = emptySpaces[0];
                    Console.WriteLine(words);
                    result = numberOfLetters / sep;
                }
            }
            Console.WriteLine($"Det genomsnittliga antalet bokstäver i alla ord i din mening är {result}");


            //var words = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            //var averageWords = words.Select(s=>s.Length).Average();

            //Skriv ut det genomsnittliga antalet bokstäver i orden
            //Console.WriteLine("");
            //Console.WriteLine($"Det genomsnittliga antalet bokstäver i alla ord i din mening är {averageWords}");


            Console.ReadKey();
        }
    }
}
