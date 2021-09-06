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
            int[] array = new int[inputAmount];

            //Fråga sedan efter tal i tur och ordning
            Console.WriteLine("Skriv nu in alla talen du vill ha");
            int inputNumbers = 0;

            for (int i = 0; i < array.Length; i++)
            {
                inputNumbers = int.Parse(Console.ReadLine());
                array[i] = inputNumbers;
                Array.Reverse(array);
            }


            //När alla tal är inmatade, skriv ut de i omvänd ordning
            Console.WriteLine($"Omvända talet är {inputNumbers}");

            

            Console.ReadKey();
        }
    }
}
