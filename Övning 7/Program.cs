using System;

namespace Övning_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren skriva in valfri månad
            Console.WriteLine("Skriv in valfri månad");
            string inputMonth = Console.ReadLine();

            //Gör om den inmatade månaden till siffra
            switch (inputMonth)
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
