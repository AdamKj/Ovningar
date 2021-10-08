using System;

namespace Övning_26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en klass som kan användas som stegräknare.
            //Den ska ha en property Steps som bara går att läsa;
            //en metod Step() som räknar upp Steps med 1 varje gång man anropar den;
            //och en metod Reset() som nollställer räknaren
            StepCounter step = new();

            for (int i = 0; i <= 1000; i++)
            {
                step.Step();
            }
            step.Reset();

            Console.ReadKey();
        }
    }
}
