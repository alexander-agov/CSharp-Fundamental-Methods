
using System.Globalization;

namespace PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                Console.WriteLine(isNumberPalindrome(input));
            }
        }
        static bool isNumberPalindrome(string input)
        {
            string firstHalf = input.Substring(0, input.Length / 2);
            char[] charArr = input.ToCharArray();
            Array.Reverse(charArr);
            string temp = new string(charArr);
            string lastHalf = temp.Substring(0, temp.Length / 2);
            return firstHalf == lastHalf;
        }
    }
}

