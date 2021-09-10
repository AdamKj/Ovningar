using System;

namespace Övning_16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Gör om uppgift 6, enkel miniräknare, så att man kan mata in allt på samma rad te x. 3 * 5

            //Fråga användaren efter ett tal
            Console.WriteLine("Skriv in valfri ekvation");
            var input = Console.ReadLine();

            var operands = new char[] { '+', '-', '*', '/' };
            var numbers = input.Split(operands);

            //Slå sedan ihop summan av de inmatade talen och tecknet och skriv ut, te x. 3 * 5 = 15
            foreach (var operand in operands)
            {
                if (input.Contains(operand))
                {
                    Console.WriteLine($"{numbers[0].Trim()} {operand} {numbers[1].Trim()} = {PerformOperation(numbers, operand)}");
                }
            }

            Console.ReadKey();
        }

        static double PerformOperation(string[] numbers, char operand)
        {
            double result = 0;
            switch (operand)
            {
                case '+':
                    result = Addition(double.Parse(numbers[0].Trim()), double.Parse(numbers[1].Trim()));
                    break;
                case '-':
                    result = Sub(double.Parse(numbers[0].Trim()), double.Parse(numbers[1].Trim()));
                    break;
                case '*':
                    result = Multiply(double.Parse(numbers[0].Trim()), double.Parse(numbers[1].Trim()));
                    break;
                case '/':
                    result = Divide(double.Parse(numbers[0].Trim()), double.Parse(numbers[1].Trim()));
                    break;
                default:
                    break;
            }
            return result;
        }
        private static double Divide(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
        private static double Multiply(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        private static double Sub(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        private static double Addition(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
