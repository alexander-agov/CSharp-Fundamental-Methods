namespace TribonacciSequence
{
    internal class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            PrintTribonacciSequence(num);
        }
        static void PrintTribonacciSequence(int num)
        {
            if (num == 1 || num == 0)
            {
                Console.WriteLine(1);
                return;
            }
            else if (num == 2)
            {
                Console.WriteLine("1 1");
            }
            else
            {
                int[] tribonacci = new int[num];
                tribonacci[0] = 1;
                tribonacci[1] = 1;
                tribonacci[2] = 2;
                Console.Write("1 1 2");
                for (int i = 3; i < num; i++)
                {
                    tribonacci[i] = tribonacci[i - 1] + tribonacci[i - 2] + tribonacci[i - 3];
                    Console.Write(" " + tribonacci[i]);
                }
                Console.WriteLine();
            }
        }
    }
}