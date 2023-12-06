using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixFile
{
    internal class Matrix
    {
        private readonly int n;
        private readonly int m;
        private int[,] matrix;

        public Matrix(string filename)
        {
            string[] lines = File.ReadAllLines(filename);
            string[] proportions = lines[0].Split();
            n = Convert.ToInt32(proportions[0]);
            m = Convert.ToInt32(proportions[1]);
            matrix = new int[n, m];

            for (int i = 1; i <= n; i++)
            {
                string[] tempString = lines[i].Split();
                for (int j = 0; j < m; j++)
                {
                    matrix[i - 1, j] = Convert.ToInt32(tempString[j]);
                }
            }
        }

        public int this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        public void ChangeAllPrimeElements()
        {
            if (CheckDiagonal() == true)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (IsPrime(matrix[i, j]) == true)
                            matrix[i, j] = 1;
                    }
                }
            }
        }

        public bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public bool CheckDiagonal()
        {
            if (n == m)
            {
                bool flag = true;
                for (int i = 1; i < n - 1; i++)
                {
                    int tempElement = matrix[i, i];
                    if (tempElement > matrix[i + 1, i + 1])
                        flag = false;
                }
                return flag;
            }
            return false;
            
        }

        public void Print()
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write($"{matrix[i, j],3} ");
                Console.WriteLine();
            }
        }
    }
}
