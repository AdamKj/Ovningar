using System;

namespace OOP_Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Car car2 = new Car();
            car1._brand = "Audi";
            car1._color = "White";
            car2._brand = "Volvo";
            car2._color = "Black";
            Console.WriteLine($"{car1._color} {car1._brand}");
            Console.WriteLine($"{car2._color} {car2._brand}");

            Console.ReadKey();
        }
    }
}
