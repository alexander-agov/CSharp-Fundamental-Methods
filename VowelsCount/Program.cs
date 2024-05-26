
namespace VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int result = CountVowels(word);
            Console.WriteLine(result);
        }
        static int CountVowels(string word)
        {
            int count = 0;
            string vowels = "aeiouAEIOU";
            foreach (char c in word)
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }
            return count;
        }
    }
}

