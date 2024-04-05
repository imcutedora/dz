using System.Collections;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nums = new int[] { -2, 56, 14, 32, -99, 374 };

            Console.WriteLine(GetAverage<int>(nums));
            Console.WriteLine(nums.Average() + " - для сравнения");
        }

        public static double GetAverage<T>(T[] elems)
        {
            double sum = default;

            foreach (var e in elems)
                sum += Convert.ToDouble(e);

            return sum / elems.Length;
        }
    }
}