﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OdarenkoAR.Sprint4.Task6.V14.Lib;
namespace Tyuiu.OdarenkoAR.Sprint4.Task6.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            var mas2 = new string[] { "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль" };
            string[] res = ds.Calculate(mas2);
            string[] wait = { "Январь", "Февраль", "Март", "Апрель", "Июнь", "Июль" };
        }
    }
}
