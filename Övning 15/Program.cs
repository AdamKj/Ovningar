using System;

namespace Övning_15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren skriva in valfritt ord
            Console.WriteLine("Skriv in ett valfritt ord");
            string input = Console.ReadLine();

            //Kolla om ordet är ett palindrom eller inte och skriv ut det
            string reverse = "";

            for (int i = input.Length - 1; i >= 0; i--)
            {
                reverse += input[i];
            }

            if (input == reverse)
            {
                Console.WriteLine($"Ordet {input} är ett palindrom!");
            }
            else
            {
                Console.WriteLine($"Ordet {input} är inte ett palindrom.");
            } 

            

            Console.ReadKey();
        }
    }
}
