using System;

namespace Övning_25
{
    class Program
    {
        static void Main(string[] args)
        {
            string model = "Volvo";
            int price = 499000;
            string color = "Black";
            Car volvo = new(model, price, color);

            volvo.HalfPrice();
            Console.WriteLine(volvo);

            Console.ReadKey();
        }
    }
}
