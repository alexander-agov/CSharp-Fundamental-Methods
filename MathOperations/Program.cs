namespace MathOperations
{
    internal class Program
    {
        static void Main()
        {
            double num1 = double.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double result = Calculate(num1, op, num2);
            Console.WriteLine(result);
        }
        static double Calculate(double num1, char op, double num2)
        {
            double result = 0;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
            return result;
        }
    }
}
