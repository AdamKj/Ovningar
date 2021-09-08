using System;

namespace Övning_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gör om uppgift 6, enkel miniräknare, så att man kan mata in allt på samma rad
            //Fråga användaren efter ett tal
            Console.WriteLine("Skriv in ett tal");
            double inputOne = double.Parse(Console.ReadLine());

            //Fråga sedan efter ett av följande +,-,*,/
            Console.WriteLine("Skriv nu in ett av följande:");
            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            string operand = Console.ReadLine();

            //Fråga användaren efter ett andra tal
            Console.WriteLine("Skriv nu in ett till tal");
            double inputTwo = double.Parse(Console.ReadLine());

            double result = 0;
            switch (operand)
            {
                case "+":
                    result = inputOne + inputTwo;
                    break;
                case "-":
                    result = inputOne - inputTwo;
                    break;
                case "*":
                    result = inputOne * inputTwo;
                    break;
                case "/":
                    result = inputOne / inputTwo;
                    break;
                default:
                    Console.WriteLine("Vänligen skriv bara in ett av följande +,-,*,/");
                    break;
            }

            //Slå sedan ihop summan av de inmatade talen och tecknet och skriv ut, te x. 3 * 5 = 15
            Console.WriteLine($"Resultatet av talen blev {inputOne} {operand} {inputTwo} = {result}");

            Console.ReadKey();
        }
    }
}
