using System;

namespace Övning_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            double number;
            double sum = 0;

            while (true)
            {
                //Be användaren skriva in ett tal upprepade gånger
                Console.WriteLine("Skriv in ett tal:");
                bool input = double.TryParse(Console.ReadLine(), out number);

                if (input)
                {
                    //Efter varje inmatning ska summan av de inmatade talen adderas
                    sum += number;
                    Console.WriteLine($"Summan av dina tal är: {sum}");
                    counter++;
                }
                else
                {
                    //Skriver man inte in ett tal, stäng programmet
                    break;
                }
            }

            //Skriv tillsist ut medelvärdet av alla tal
            double averageNumber = sum / counter;
            Console.WriteLine($"Medelvärdet av dina tal är {averageNumber}");



            Console.ReadKey();
        }
    }
}
