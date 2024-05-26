namespace GreaterOfTwoValues
{
    internal class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            string firstValue = Console.ReadLine();
            string secondValue = Console.ReadLine();
            if (type == "string")
            {
                GetMax(firstValue, secondValue);
            }
            else if (type == "char")
            {
                char a = char.Parse(firstValue);
                char b = char.Parse(secondValue);
                GetMax(a, b);
            }
            else
            {
                GetMax(int.Parse(firstValue), int.Parse(secondValue));
            }
        }
        static void GetMax(int a, int b)
        {
            Console.WriteLine(a < b ? b : a);
        }

        static void GetMax(string a, string b)
        {
            int result = a.CompareTo(b);
            Console.WriteLine(result > 0 ? a : b);
        }
        static void GetMax(char a, char b)
        {
            Console.WriteLine(a < b ? b : a);
        }
    }
}
