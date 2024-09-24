using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сформировать одномерный массив из 7 элементов.Заполнить массив числами, вводимыми с клавиатуры, определить среднее арифметическое элементов
            int[] array = new int[7];
            int Sum = 0;
            Console.WriteLine("Введите 7 чисел для массива:");

            for (int i = 0; i < 7; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
                Sum += array[i];
            }

            Console.WriteLine("Среднее арифметическое элементов указанного массива равно {0}", ((double) Sum/7));
            Console.ReadKey();

        }
    }
}
