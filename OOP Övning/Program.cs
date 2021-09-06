using System;

namespace OOP_Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();

            car1.Brand = "Audi";
            car1.Color = "White";
            
            car2.Brand = "Volvo";
            car2.Color = "Black";
            

            Console.WriteLine(car1.ToString());
            Console.WriteLine(car2.ToString());

            Console.ReadKey();
        }
    }
}
