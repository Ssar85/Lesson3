using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("какая размерность матрицы?");
            int r = Convert.ToInt32(Console.ReadLine());
           int [,] diag = new int [r, r];
            Console.WriteLine("какой цифрой заполняем?");
            int a =Convert.ToInt32( Console.ReadLine());

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    if (i == j) diag[i, j] = a;
                    Console.Write($"{diag[i, j]} ");

                }
                Console.WriteLine();
            }


        }
    }
}
