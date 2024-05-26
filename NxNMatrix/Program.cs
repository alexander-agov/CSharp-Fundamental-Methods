namespace NxNMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Column(num);
        }
        static void Column(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
