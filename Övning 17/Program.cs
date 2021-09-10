using System;

namespace Övning_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren mata in en text tex. abcdefghijklmnopqrstuvwxyzåäö
            Console.WriteLine("Mata in valfri textsträng");
            string input = Console.ReadLine();

            //Be användaren mata in en delsträng i den först inmatningen tex. defg
            Console.WriteLine("Skriv nu in den delsträngen du vill markera ifrån din textsträng");
            string inputSub = Console.ReadLine();

            //Markera den delsträngen i den första texten med en annan färg
            string subMatch = input.Substring(input.IndexOf(inputSub), inputSub.Length);
            string beforeMatch = input.Substring(0, input.IndexOf(subMatch));
            string afterMatch = input.Substring(input.LastIndexOf(subMatch) + inputSub.Length);

            //Skriv ut hela texten med delsträngen markerad
            Console.Write(beforeMatch);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(subMatch);
            Console.ResetColor();
            Console.Write(afterMatch);
            

            Console.ReadKey();
        }
    }
}
