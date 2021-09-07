using System;

namespace Övning_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Be användaren mata in valfri text
            Console.WriteLine("Skriv in valfri text");
            string input = Console.ReadLine();

            //Ersätt alla vokaler med '*'
            char[] vowels = new char[] {'a','e','o','u','å','i','y','ä','ö' };

            foreach (char c in vowels)
            {
                input = input.Replace(c, '*');
            }

            //Skriv ut texten
            Console.WriteLine(input);

            

            Console.ReadKey();
        }
    }
}
