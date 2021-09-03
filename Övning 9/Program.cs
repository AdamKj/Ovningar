using System;

namespace Övning_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren skriva ett tal mellan 1-100
            Console.WriteLine("Gissa rätt tal mellan 1 - 100!");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Skriv in ett tal mellan 1 - 100:");
            int input = int.Parse(Console.ReadLine());

            //Spara ett slumpmässigt hemligt tal i en variabel
            Random random = new Random();
            int hemligtTal = random.Next(1, 101);

            //Användaren ska upprepade gånger gissa rätt nummer tills man gissar rätt
            while (true)
            {
                

                if (input > hemligtTal)
                {
                    //Gissar man för högt, skriv ut det
                    Console.WriteLine("För högt, gissa igen:");
                    input = int.Parse(Console.ReadLine());
                }
                else if (input < hemligtTal)
                {
                    //Gissar man för lågt, skriv ut det
                    Console.WriteLine("För lågt, gissa igen:");
                    input = int.Parse(Console.ReadLine());
                }
                else
                {
                    break;
                }
            }

            //Gissar man rätt, skriv ut det
            Console.WriteLine($"Grattis! Du gissade rätt! Det rätta numret var {hemligtTal}");


            Console.ReadKey();
        }
    }
}
