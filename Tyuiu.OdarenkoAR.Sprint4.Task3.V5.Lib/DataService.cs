using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.OdarenkoAR.Sprint4.Task3.V5.Lib
{
    public class DataService : ISprint4Task3V5
    {
        public int Calculate(int[,] array)
        {
            int s = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                s += array[i, 0];
            }
            return s;
        }
    }
}
