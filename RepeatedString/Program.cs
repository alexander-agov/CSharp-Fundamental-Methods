﻿using System.Text;

namespace RepeatedString
{
    internal class Program
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            string result = RepeatString(inputStr, count);
            Console.WriteLine(result);
        }
        static string RepeatString(string str, int count)
        {
            StringBuilder result = new StringBuilder(); 
            for (int i = 0; i < count; i++)
                result.Append(str);
            return result.ToString();                                 
        }
    }
}
