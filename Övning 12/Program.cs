using System;

namespace Övning_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fråga användaren hur många tal den vill mata in
            Console.WriteLine("Hur många tal vill du skriva in?");
            int inputAmount = int.Parse(Console.ReadLine());
            string[] array = new string[inputAmount];

            //Fråga sedan efter tal i tur och ordning
            Console.WriteLine("Skriv nu in alla talen du vill ha");
            int inputNumbers = 0;

            for (int i = 0; i < array.Length; i++)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out inputNumbers))
                {
                    array[i] = input;
                }
                else 
                {
                    i--;
                }

            }
            
            //När alla tal är inmatade, skriv ut dem i omvänd ordning
            Array.Reverse(array);

            Console.Write("Omvända talet är ");
            foreach (var numbers in array)
            {
                Console.Write(numbers);
            }


            Console.ReadKey();
        }
    }
}
