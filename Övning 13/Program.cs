using System;

namespace Övning_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren mata in en text
            Console.WriteLine("Skriv in valfri text");
            string userInput = Console.ReadLine();
            char[] array = userInput.ToCharArray();

            //Loop för att skriva ut texten baklänges
            for (int i = 0, j = userInput.Length - 1; i < j; i++, j--)
            {
                char c = array[i];
                array[i] = array[j];
                array[j] = c;
            }

            //Skriv ut den omvända texten
            Console.Write($"Din omvända text är ");
            Console.Write(array);

            

            Console.ReadKey();
        }
    }
}
