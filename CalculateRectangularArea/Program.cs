
namespace CalculateRectangularArea
{
    internal class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double area = RectangularArea(width, height);
            Console.WriteLine(area);
        }

        static double RectangularArea(double a, double b)
        {
            return a * b;
        }
    }
}
