using System;

namespace Övning_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anropa själva boxen
            DrawBox(7, 4);


            Console.ReadKey();
        }


        //Skriv en metod DrawBox(int width, int height)
        public static void DrawBox(int width, int height)
        {
            //Töm konsollen med Console.Clear()
            Console.Clear();

            //Skapar raden
            string line = new('#', width);
            
            //Skapar inre raderna
            string innerLine = "";
            innerLine += "#";

            //Loopar igenom bredden
            for (int j = 0; j < width - 2; j++)
            {
                innerLine += "-";
            }
            innerLine += "#";
            Console.WriteLine(line);

            //Loopar igenom höjden
            for (int i = 0; i < height - 2; i++)
            {
                Console.WriteLine(innerLine);
            }
            Console.WriteLine(line);

        }
    }
}
