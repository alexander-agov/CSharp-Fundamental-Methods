using System.ComponentModel.DataAnnotations;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type == "int")
            {
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(GetResult(number));
            }
            else if (type == "real")
            {
                double number = double.Parse(Console.ReadLine());
                Console.WriteLine(GetResult(number));
            }
            else if (type == "string")
            {
                string text = Console.ReadLine();
                Console.WriteLine(GetResult(text));
            }
        }
        static int GetResult(int number)
        {
            return number * 2;
        }
        static string GetResult(double number)
        {
            double result = number * 1.5;
            return result.ToString("F2");
        }
        static string GetResult(string text)
        {
            return $"${text}$";
        }
    }
}
