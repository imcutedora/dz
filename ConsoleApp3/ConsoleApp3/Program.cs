using System;

namespace powerofthree
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            if (Math.Log(num, 3) % 1 == 0 || Math.Log(num, 3) % 1 >= 0.9999999999)
            {
                Console.WriteLine("Это степень числа 3.");
            }
            else
            {
                Console.WriteLine("Это не степень числа 3.");
            }

            Console.ReadKey();
        }
    }
}
