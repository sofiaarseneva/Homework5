using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 15 элементов, которые выбираются случайным образом из диапазона[0; 50].
            //Определить сумму максимального и минимального элементов массива.
            const int n = 15;
            int[] array = new int[n];
            Random random = new Random();
            int min, max;
            min = max = 0;

            for (int i = 0; i < n; i++)
            {
                array[i] = random.Next(0,50);
                Console.Write("{0} ", array[i]);
            }

            max = min = array[0];

            foreach (int a in array)
            {
                if (a > max)
                    max = a;
                if (a < min)
                    min = a;
            }
            Console.WriteLine();
            Console.WriteLine("Минимальный элемент массива равен {0}, максимальный элемент равен {1}", min, max);
            Console.WriteLine("Их сумма равна {0}", min + max);
            Console.ReadKey();
        }
    }
}
