using System;

namespace Övning_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren skriva in 2 månader för att sedan räkna ut hur många månader som skiljer sig mellan dom
            //Be användaren skriva in valfri månad
            Console.WriteLine("Skriv in en valfri månad");
            string inputMonthOne = Console.ReadLine();
            Console.WriteLine("Skriv nu in en till månad");
            string inputMonthTwo = Console.ReadLine();



            //Räkna ut hur långt det är mellan den första inmatade månaden, till den andra
            

            switch (inputMonthTwo)
            {
                case "Januari":
                    Console.WriteLine("1");
                    break;
                case "Februari":
                    Console.WriteLine("2");
                    break;
                case "Mars":
                    Console.WriteLine("3");
                    break;
                case "April":
                    Console.WriteLine("4");
                    break;
                case "Maj":
                    Console.WriteLine("5");
                    break;
                case "Juni":
                    Console.WriteLine("6");
                    break;
                case "Juli":
                    Console.WriteLine("7");
                    break;
                case "Augusti":
                    Console.WriteLine("8");
                    break;
                case "September":
                    Console.WriteLine("9");
                    break;
                case "Oktober":
                    Console.WriteLine("10");
                    break;
                case "November":
                    Console.WriteLine("11");
                    break;
                case "December":
                    Console.WriteLine("12");
                    break;
                default:
                    Console.WriteLine("Skriv in en korrekt månad");
                    break;
            }


            Console.ReadKey();
        }
    }
}
