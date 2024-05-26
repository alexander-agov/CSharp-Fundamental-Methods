namespace TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int n = 1; n <= num; n++)
            {
                if (IsTopNumber(n))
                {
                    Console.WriteLine(n);
                }
            }
        }
        static bool IsTopNumber(int num)
        {
            if (SumOfDigitsDivisibleBy8(num) && HasAtLeastOneOddDigit(num))
            {
                return true;
            }
            return false;
        }
        static bool SumOfDigitsDivisibleBy8(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            return sum % 8 == 0;
        }
        static bool HasAtLeastOneOddDigit(int num)
        {
            while (num > 0)
            {
                int digit = num % 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }
    }
}
