using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 20 случайных чисел в диапазоне[-50; 50]. Определить количество нечетных положительных элементов, стоящих на четных местах.

            const int n = 20;
            int[] array = new int[n];
            Random random = new Random();
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(-50, 50);
                Console.Write("[{0}]{1} ", i, array[i]);

                if ((i % 2) == 0 && array[i] > 0 && (array[i] % 2) != 0)
                {
                    k++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество положительных нечетных элементов на четных местах равно {0}", k);
            Console.ReadKey();
        }
    }
}
