using System;

namespace Övning_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren mata in valfri sträng
            Console.WriteLine("Skriv in valfri text");
            string input = Console.ReadLine();

            //Skriv ut varje tecken i strängen på enskild rad
            for (int i = 0; i < input.Length; i++)
            {
                Console.WriteLine(input[i]);
            }


            Console.ReadKey();
        }
    }
}
