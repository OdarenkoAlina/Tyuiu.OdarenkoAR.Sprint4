using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.OdarenkoAR.Sprint4.Task4.V27.Lib;
namespace Tyuiu.OdarenkoAR.Sprint4.Task4.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Одаренко А. Р. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: двумерные массивы. (ввод с клавиатуры)                            *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнила Одаренко А. Р. | ИСПб-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры в диапозоне от 1 до 9. Найдите сумму нечётных   *");
            Console.WriteLine("* элементов массива. (4, 3, 9, 2, 2 ), ( 8, 4, 1, 4, 3 ),                 *");
            Console.WriteLine("* ( 3, 9, 2, 2, 5 ), ( 4, 6, 8, 5, 6 ), ( 1, 5, 2, 2, 5).                 *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите количество строк в массиве: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            int columns = Convert.ToInt32(Console.ReadLine());
            int[,] mtrx = new int[rows, columns];
            Console.WriteLine("***************************************************************************");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("Введите {i},{j} элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nМассив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine("{mtrx[i, j]} \t ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mtrx);
            Console.WriteLine("Сумма нечетных элементов массива = " + res);
            Console.ReadKey();
        }
    }
}
