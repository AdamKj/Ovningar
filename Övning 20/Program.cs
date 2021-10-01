using System;
using System.Collections.Generic;
using System.Linq;

namespace Övning_22
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skriv en funktion som kan ta ett godtyckligt antal strängar som parametrar
            //Returerna den längsta av dem
            LongestWord();
            Console.ReadKey();
        }

        public static void LongestWord()
        {
            Console.WriteLine("Skriv in 8st olika ord. Skriv in ett ord i taget");
            string[] words = new string[8];
            for (int i = 0; i < words.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                words[i] = Console.ReadLine();
            }

            string longestWord = words.OrderByDescending(s => s.Length).First();

            Console.WriteLine($"Det längsta ordet är '{longestWord}'");
        }
    }
}
