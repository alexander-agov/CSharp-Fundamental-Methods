namespace MathPower
{
    internal class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = MathPower(number, power);
            Console.WriteLine(result);
        }
        static double MathPower(double b, int p)
        {
            double r = 1;
            for (int i = 0; i < p; i++)
                r *= b;
            return r;
        }
    }
}
