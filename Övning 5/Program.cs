using System;

namespace Övning_5
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            while (loop)
            {
                //Be användaren skriva in ett tal upprepade gånger
                Console.WriteLine("Skriv in ett tal:");
                double input = double.Parse(Console.ReadLine());

                //Efter varje inmatning ska summan av de inmatade talen adderas
                double sum = input + input;
                Console.WriteLine($"Summan av dina tal är: {sum}");
            }


            //Skriver man inte in ett tal, stäng programmet

            //Skriv tillsist ut medelvärdet av alla tal



            Console.ReadKey();
        }
    }
}
