namespace AddAndSubtract
{
    internal class Program
    {
        static void Main()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int sum = SumOfFirstTwoInt(num1, num2);
            int result = SubtractTheThirdInt(sum, num3);
            Console.WriteLine(result);
        }
        static int SumOfFirstTwoInt(int a, int b)
        {
            return a + b;
        }
        static int SubtractTheThirdInt(int sum, int c)
        {
            return sum - c;
        }
    }
}
