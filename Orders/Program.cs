namespace Orders
{
    internal class Program
    {
        static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            double result = Order(product, quantity);
            Console.WriteLine($"{result:f2}");
        }
        static double Order(string name, int num)
        {
            double result = 0;
            switch (name)
            {
                case "coffee":
                    result = num * 1.50;
                    break;
                case "water":
                    result = num * 1.00;
                    break;
                case "coke":
                    result = num * 1.40;
                    break;
                case "snacks":
                    result = num * 2.00;
                    break;
            }
            return result;
        }
    }
}

