using System;

namespace Övning_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gör en array med siffrorna 0-9 i text
            string[] numbers = {"noll", "ett", "två", "tre", "fyra", "fem", "sex", "sju", "åtta", "nio"};

            //Be användaren skriva in en siffra
            Console.WriteLine("Skriv in en siffra mellan 0 - 9:");
            

            //Skriv ut användarens input i text
            for (int i = 0; i < numbers.Length; i++)
            {
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine(numbers[input]);
            }

            
            Console.ReadKey();
        }
    }
}
