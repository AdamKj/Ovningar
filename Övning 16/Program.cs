using System;
using System.Collections.Generic;

namespace Övning_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gör om uppgift 6, enkel miniräknare, så att man kan mata in allt på samma rad te x. 3 + 5

            double number = 0;
            double result = 0;
            var operators = new List<char> {'+', '-', '*', '/' };

            //Fråga användaren efter ett tal
            Console.WriteLine("Skriv in ett tal");
            var input = double.TryParse(Console.ReadLine(), out number);

            if (input == operators.Contains('+'))
            {
                number += result;
            }
            else if (input == operators.Contains('-'))
            {
                number -= result;
            }
            else if (input == operators.Contains('*'))
            {
                number *= result;
            }
            else
            {
                number /= result;
            }

            


            //Slå sedan ihop summan av de inmatade talen och tecknet och skriv ut, te x. 3 * 5 = 15
            Console.WriteLine($"Resultatet av talen blev {number}");

            Console.ReadKey();
        }
    }
}
