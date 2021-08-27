using System;

namespace Övning_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fråga användaren efter ett lösenord
            Console.WriteLine("Skriv in ditt lösenord");
            string input = Console.ReadLine();

            //Spara ett hemligt lösenord i en variabel
            string password = "hejsan";

            //Jämför användarens input med det hemliga lösenordet
            //om det är fel skriv ut FEL, om det är rätt skriv ut RÄTT
            if (input == password)
            {
                Console.WriteLine("Rätt lösenord!");
            }
            else
            {
                Console.WriteLine("Fel lösenord");
            }


            Console.ReadKey();
        }
    }
}
