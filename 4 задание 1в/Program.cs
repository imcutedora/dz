namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            var dict = new Dictionary<string, double>();

            dict.Add("молоко", 89.99);
            dict.Add("хлеб", 49.99);

            foreach (var e in dict.Keys)
            {
                dict[e] = Math.Round(dict[e] * 1.1, 2);
            }

            foreach (var e in dict.Values)
                Console.WriteLine(e);
        }
    }
}