using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.OdarenkoAR.Sprint4.Task6.V14.Lib;
namespace Tyuiu.OdarenkoAR.Sprint4.Task6.V14
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #4 | Выполнила: Одаренко А. Р. | ИСПб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #14                                                             *");
            Console.WriteLine("* Выполнила Одаренко А. Р. | ИСПб-23-1                                    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковой массив данных, используя класс Array, выведите элементы   *");
            Console.WriteLine("* массива, длина которых больше 3 символа.                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var mas2 = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i <= mas2.Length-1; i++)
            {
                Console.WriteLine(mas2[i]);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string[] res = ds.Calculate(mas2);
            Console.WriteLine("Элементы массива, длина которых больше 3: ");
            for (int i = 0; i < res.Length-1; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}
