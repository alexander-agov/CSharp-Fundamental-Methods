namespace PrintingTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }
        private static void PrintTriangle(int n)
        {
            for (int row = 1; row <= n; row++)
            {
                PrintLine(row);
            }
            for (int row = n - 1; row >= 0; row--)
            {
                PrintLine(row);
            }
        }
        static void PrintLine(int row)
        {
            for (int col = 1; col <= row; col++)
            {
                Console.Write($"{col} ");
            }
            Console.WriteLine();
        }
    }
}
