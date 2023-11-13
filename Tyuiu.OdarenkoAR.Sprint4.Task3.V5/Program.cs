using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.OdarenkoAR.Sprint4.Task3.V5.Lib;
namespace Tyuiu.OdarenkoAR.Sprint4.Task3.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Одаренко А. Р. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: двумерные массивы (статический ввод)                              *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнила Одаренко А. Р. | ИСПб-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* статическими значениями в диапозоне от 2 до 9. Найдите сумму элементов  *");
            Console.WriteLine("* в первом столбце массива.                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            int[,] array = { { 3, 4, 8, 6, 3 }, { 9, 9, 3, 6, 9 }, { 5, 6, 7, 2, 3 }, { 3, 6, 2, 3, 8 }, { 5, 7, 2, 6, 4 } };
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Матрица: \n3 4 8 6 3\n9 9 3 6 9\n5 6 7 2 3\n3 6 2 3 8\n5 7 2 6 4");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма элементов в первом столбце матрицы = " + ds.Calculate(array));
            Console.ReadKey();
        }
    }
}
