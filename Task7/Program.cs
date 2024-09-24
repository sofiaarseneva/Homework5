using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя целочисленное значение N. 
            //Сформировать двумерный массив размера NxN.Заполнить массив числами, вводимыми с клавиатуры.Проверить, является ли введенная с клавиатуры матрица магическим квадратом. 
            //Магическим квадратом называется матрица, сумма элементов которой в каждой строке, в каждом столбце и по каждой диагонали одинакова.

            Console.WriteLine("Введите целочисленное число N: ");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[N, N];
            bool magicSquare = true;
            int sumControl, sumRow, sumCol, sumMainDiagonal, sumOtherDiagonal;
            sumControl = sumMainDiagonal = sumOtherDiagonal = 0;
            Console.WriteLine("Введите элементы массива");
            //заполнение массива
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            //вывод массива
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
                Console.WriteLine();
            }
            //сумма первой строки, она же контрольная сумма, тк сумма строк = сумма столбцов = сумма по каждой диагонали
            for (int j = 0; j < N; j++)
            {
                sumControl += array[0, j];
            }
            //сумма остальных строк
            for (int i = 1; i < N; i++)
            {
                sumRow = 0;
                for (int j = 0; j < N; j++)
                {
                    sumRow += array[i, j];
                }
                if (sumRow != sumControl)
                {
                    magicSquare = false;
                    break;
                }
            }
            if (magicSquare)
            {
                //сумма столбцов
                for (int i = 0; i < N; i++)
                {
                    sumCol = 0;
                    for (int j = 0; j < N; j++)
                    {
                        sumCol += array[j, i];
                    }
                    if (sumCol != sumControl)
                    {
                        magicSquare = false;
                        break;
                    }
                }
            }
            if (magicSquare)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        //сумма главной диагонали
                        if (i == j)
                        {
                            sumMainDiagonal += array[i, j];
                        }
                    }
                }
                if (sumMainDiagonal != sumControl)
                {
                    magicSquare = false;
                }
            }
            if (magicSquare)
            {
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (i + j == N - 1) //сумма побочной диагонали
                        {
                            sumOtherDiagonal += array[i, j];
                        }
                    }
                }
                if (sumOtherDiagonal != sumControl)
                {
                    magicSquare = false;
                }
            }

            Console.WriteLine();
            if (magicSquare)
            {
                Console.WriteLine("Матрица является магическим квадратом!");
            }
            else
            {
                Console.WriteLine("Матрица не является магическим квадратом!");
            }
            Console.ReadKey();
        }
    }
}
