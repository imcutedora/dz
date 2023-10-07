using System;
using System.Collections.Generic;
using System.Linq;

namespace ps1
{
    class Program
    {
        static void Main()
        {
            //1.9
            //По заданным значениям трех коэффициентов a, b и с вывести уравнение a* x^ 2 + b * x + c.
            //Например, 2 - 1 0 должны давать 2x ^ 2 - x, а 0 2 7 должны давать 2x + 7.

            string equation = "";
            bool cut = false;

            for (int i = 2; i > -1; i--)
            {
                string a = Console.ReadLine();

                if (a == "0" && i == 2)
                {
                    cut = true;
                }

                else if (a == "0")
                {
                    a = "0";
                }

                else if (a.Contains("-"))
                {
                    if (i == 0)
                        equation = equation + ($"{a}");
                    if (int.Parse(a) == -1)
                        a = "-";
                    if (i == 2)
                        equation = equation + ($"{a}x^2");
                    if (i == 1)
                    {
                        equation = equation + ($"{a}x");
                        cut = false;
                    }
                }

                else
                {
                    if (i == 0)
                        equation = equation + ($"+{a}");
                    if (int.Parse(a) == 1)
                        a = "";
                    if (i == 2)
                        equation = equation + ($"{a}x^2");
                    if (i == 1)
                        equation = equation + ($"+{a}x");
                }

            }

            if (cut == true)
                equation = equation.Substring(1);
            Console.WriteLine(equation + "\n");

            //2.20
            //По заданному числу k, вывести символ 0 столько раз, сколько он встречается в двоичном
            //представлении числа

            Console.Write("k = ");
            int k = int.Parse(Console.ReadLine());

            string binary = Convert.ToString(k, 2);
            binary = binary.Replace("1", "");
            Console.WriteLine(binary + "\n");

            //3.11
            //Считывая числа пока не встретится 0, найти минимальное и максимальное число.

            int minValue = 999999999;
            int maxValue = -999999999;

            while (true)
            {
                int x = int.Parse(Console.ReadLine());

                if (x == 0)
                    break;

                if (x < minValue)
                    minValue = x;
                if (x > maxValue)
                    maxValue = x;
            }

            Console.WriteLine($"min: {minValue}\nmax: {maxValue}\n");

            //4.2
            //Найти сумму всех простых делителей заданного натурального числа (<10000)

            Console.Write("N = ");
            int num = int.Parse(Console.ReadLine());
            int sum = 1;

            List<int> devs = new List<int>();

            for (int i = 2; i < Math.Sqrt(num) + 1; i++)
            {
                if (num % i == 0)
                {
                    if (i == 2)
                    {
                        sum = sum + 2;
                    }
                    else
                    {
                        devs.Add(i);
                        devs.Add(num / i);
                    }
                }
            }

            devs = devs.Distinct().ToList();
            for (int i = 0; i < devs.Count(); i++)
            {
                var simple = true;
                for (int j = 2; j < devs[i]; j++)
                {
                    if (devs[i] % j == 0)
                    {
                        simple = false;
                        break;
                    }
                }
                if (simple == true)
                    sum = sum + devs[i];
            }

            Console.WriteLine("сумма простых делителей числа N: " + sum);

            Console.ReadKey();
        }
    }
}
