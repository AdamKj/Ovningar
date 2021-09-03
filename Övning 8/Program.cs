using System;

namespace Övning_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa ett program som skriver ut 1 på första raden, 2 på nästa, 4 på nästa, 8 på nästa osv.
            //Max 16 rader

            int tal = 1;

            for (int i = 1; i <= 16; i++)
            {
                Console.WriteLine(tal);
                tal *= 2;
            }

            Console.ReadKey();
        }
    }
}
