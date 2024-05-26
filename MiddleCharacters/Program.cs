namespace MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            if (word.Length % 2 == 0)
            {
                EvenChar(word);
            }
            else
            {
                OddChar(word);
            }
        }
        static void OddChar(string word)
        {
            if (word.Length % 2 != 0)
            {
                Console.WriteLine(word[word.Length / 2]);
            }
        }
        static void EvenChar(string word)
        {
            if (word.Length % 2 == 0)
            {
                Console.Write(word[word.Length / 2 - 1]);
                Console.WriteLine(word[word.Length / 2]);
            }
        }
    }
}
