using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя целочисленное значение N. Сформировать двумерный массив размера NxN следующего вида
            //1 0 1 0 1
            //0 1 0 1 0
            //1 0 1 0 1
            //0 1 0 1 0
            //1 0 1 0 1

            Console.WriteLine("Введите целочисленное число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if ((i % 2 != 0 && j % 2 != 0) || (i % 2 == 0 && j % 2 == 0))
                    {
                        array[i, j] = 1;
                    }
                    else
                    {
                        array[i, j] = 0;
                    }
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
