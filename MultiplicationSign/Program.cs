namespace MultiplicationSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            string productSign = DetermineProductSign(num1, num2, num3);
            Console.WriteLine(productSign);
        }
        static string DetermineProductSign(int num1, int num2, int num3)
        {
            int negativesCount = 0;
            if (num1 < 0)
            {
                negativesCount++;
            }
            if (num2 < 0)
            {
                negativesCount++;
            }
            if (num3 < 0)
            {
                negativesCount++;
            }
            if (negativesCount % 2 == 0 && num1*num2*num3 !=0)
            {
                return "positive";
            }
            else if (negativesCount % 2 != 0 && num1 * num2 * num3 != 0)
            {
                return "negative";
            }
            else 
            {
                return "zero";
            }
        }
    }
}
