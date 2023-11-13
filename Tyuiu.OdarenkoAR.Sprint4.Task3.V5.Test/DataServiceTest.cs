using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OdarenkoAR.Sprint4.Task3.V5.Lib;
namespace Tyuiu.OdarenkoAR.Sprint4.Task3.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] ar = { { 3, 4, 8, 6, 3 }, { 9, 9, 3, 6, 9 }, { 5, 6, 7, 2, 3 }, { 3, 6, 2, 3, 8 }, { 5, 7, 2, 6, 4 } };
            Assert.AreEqual(25, ds.Calculate(ar));
        }
    }
}
