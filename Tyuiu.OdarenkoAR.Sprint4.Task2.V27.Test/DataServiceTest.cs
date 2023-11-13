using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OdarenkoAR.Sprint4.Task2.V27.Lib;
namespace Tyuiu.OdarenkoAR.Sprint4.Task2.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] array = { 3, 5, 5, 7, 2, 3, 6, 4, 6, 5, 3, 3 };
            int res = ds.Calculate(array);
            int wait = 18;
            Assert.AreEqual(wait, res);
        }
    }
}
