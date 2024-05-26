namespace FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long num1 = long.Parse(Console.ReadLine());
            long num2 = long.Parse(Console.ReadLine());
            Console.WriteLine($"{(Factorial(num1) / Factorial(num2)):f2}");
        }
        static double Factorial(long num)
        {
            double result = 1;
            for (long i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
