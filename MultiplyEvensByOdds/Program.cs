namespace MultiplyEvensByOdds
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            long number;
            long.TryParse(input, out number);
            long result = GetMultipleOfEvenAndOdds(number);
            Console.WriteLine(result);
        }
        static long GetMultipleOfEvenAndOdds(long number)
        {
            long evenSum = GetSumOfEvenDigits(number);
            long oddSum = GetSumOfOddDigits(number);
            return evenSum * oddSum;
        }
        static long GetSumOfEvenDigits(long number)
        {
            number = Math.Abs(number);
            long sum = 0;
            while (number > 0)
            {
                int digit = (int)(number % 10);
                if (digit % 2 == 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
        static long GetSumOfOddDigits(long number)
        {
            number = Math.Abs(number);
            long sum = 0;
            while (number > 0)
            {
                int digit = (int)(number % 10);
                if (digit % 2 != 0)
                {
                    sum += digit;
                }
                number /= 10;
            }
            return sum;
        }
    }
}

