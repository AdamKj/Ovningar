using System;

namespace Övning_23
{
    class Program
    {
        static void Main(string[] args)
        {
            //Skapa en metoden int[] IndexOfAll(string text, char c) som söker igenom strängen text
            //och returnerar en int[] med index till alla förekomster av c i text.
            Console.WriteLine("Skriv in valfri mening");
            string text = Console.ReadLine();
            Console.WriteLine("Skriv nu in valfri bokstav som du vill leta efter i meningen");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine("");
            Console.WriteLine($"Din text är '{text}'");
            Console.WriteLine($"Och du letar efter bokstaven '{c}'");
            IndexOfAll(text, c);
            Console.ReadKey();
        }

        public static int IndexOfAll(string text, char c)
        {
            int index = 0;
            while ((index = text.IndexOf(c, index)) != -1)
            {
                Console.WriteLine($"Bokstaven '{c}' finns på indexposition: {index}", index++);
            }
            return index;
        }
    }
}
