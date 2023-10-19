using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kontrolnaya
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            int[] nums = new int[] { 1, 2, 3, 2, 1 };
            Console.WriteLine($"Массив симметричен: {IsSymmetric(nums)}\n");

            //2
            Console.WriteLine("в каждой новой строке введите 10 целых чисел");
            int[] inputNums = new int[10];
            for (int i = 0; i < inputNums.Length; i++)
                inputNums[i] = int.Parse(Console.ReadLine());
            Console.WriteLine($"Всего последовательностей: {CountSequences(inputNums)}\n");

            //3
            Console.WriteLine("Исходная матрица:\n");
            int[,] matrix = new int[10, 10];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = r.Next(0, 100);
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            matrix = Swap(matrix);
            Console.WriteLine("\nОбработанная матрица:\n");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }

        static bool IsSymmetric(int[] array)
        {
            int count;
            bool sym = true;

            if (array.Length % 2 == 0)
                count = array.Length / 2;
            else
                count = (array.Length - 1) / 2;

            for (int i = 0; i < count; i++)
            {
                if (array[i] != array[array.Length - 1 - i])
                    sym = false;
            }

            return sym;
        }

        static int CountSequences(int[] array)
        {
            int c = 0;
            bool flag = false;

            //цепочка из одного элемента - не цепочка
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= array[i - 1])
                {
                    flag = true;
                }
                else if (flag == true)
                {
                    flag = false;
                    c++;
                }
            }
            if (flag == true)
                c++;

            return c;
        }

        static int[,] Swap(int[,] matrix1)
        {
            int maxnum = 0;
            int minnum = 100;
            int maxx = 0, maxy = 0, minx = 0, miny = 0;

            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    if (matrix1[i, j] > maxnum)
                    {
                        maxnum = matrix1[i, j];
                        maxx = i;
                        maxy = j;
                    }
                    else if (matrix1[i, j] < minnum)
                    {
                        minnum = matrix1[i, j];
                        minx = i;
                        miny = j;
                    }
                }
            }

            matrix1[maxx, maxy] = minnum;
            matrix1[minx, miny] = maxnum;

            return matrix1;
        }
    }
}
