﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.OdarenkoAR.Sprint4.Task0.V3.Lib
{
    public class DataService : ISprint4Task0V3
    {
        public int GetMultOddArrEl(int[] array)
        {
            int d = 0;
            for(int i = 0; i <= array.Length - 1; i++)
            {
                if(array[i] % 2 != 0)
                {
                    d *= array[i];
                }
            }
            return d;
        }
    }
}
