using System;
using System.Collections.Generic;

namespace OOP_Övning
{
    class Program
    {
        static void Main(string[] args)
        {
            var audi = new Car();
            var volvo = new Car();
            var bmw = new Car();

            var cars = new List<Car>();
            cars.Add(audi);
            cars.Add(volvo);
            cars.Add(bmw);

            audi.Brand = "Audi";
            audi.Color = "White";
            
            volvo.Brand = "Volvo";
            volvo.Color = "Black";

            bmw.Brand = "BMW";
            bmw.Color = "Green";

            foreach (var car in cars)
            {
                Console.WriteLine(car.ToString());
            }

            Console.WriteLine("-----------------------------");

            var numbers = new Queue<int>();
            numbers.Enqueue(5);
            numbers.Enqueue(1);
            numbers.Enqueue(8);
            numbers.Enqueue(2);

            Console.WriteLine(numbers.Dequeue());
            Console.WriteLine(numbers.Peek());
            Console.WriteLine(numbers.Dequeue());

            Console.WriteLine("-----------------------------");

            var numbers2 = new Stack<int>();
            numbers2.Push(2);
            numbers2.Push(6);
            numbers2.Push(5);
            numbers2.Push(9);

            Console.WriteLine(numbers2.Contains(6));

            Console.WriteLine(numbers2.Pop());
            Console.WriteLine(numbers2.Pop());
            Console.WriteLine(numbers2.Pop());
            Console.WriteLine(numbers2.Pop());

            Console.WriteLine("-----------------------------");

            var numbers3 = new Dictionary<int, string>();
            numbers3.Add(2, "två");
            numbers3.Add(6, "sex");
            numbers3.Add(12, "tolv");
            numbers3.Add(4, "fyra");
            if (!numbers3.ContainsKey(9))
            {
                numbers3.Add(9, "nio");
            }

            foreach (var number in numbers3)
            {
                Console.WriteLine($"Key: {number.Key} Value: {number.Value}");
            }

            Console.ReadKey();
        }
    }
}
