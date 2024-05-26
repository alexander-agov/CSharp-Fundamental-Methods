using System.ComponentModel;
using System.Numerics;

namespace Calculations
{
    internal class Program
    {
        static void Main()
        {
            string action = Console.ReadLine();
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            switch (action)
            {
                case "add":
                    Add(numberOne, numberTwo);
                    break;
                case "multiply":
                    Multiply(numberOne, numberTwo);
                    break;
                case "subtract":
                    Subtract(numberOne, numberTwo);
                    break;
                case "divide":
                    Divide(numberOne, numberTwo);
                    break;
            }

        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
