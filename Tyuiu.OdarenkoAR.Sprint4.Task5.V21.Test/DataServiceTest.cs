using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.OdarenkoAR.Sprint4.Task5.V21.Lib;
namespace Tyuiu.OdarenkoAR.Sprint4.Task5.V21.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            int[,] matrix = new int[5, 5] { { 2, -8, 2, -8, 2 }, { 2, -8, 2, -8, 2 }, { 2, -8, 2, -8, 2 }, { 2, -8, 2, -8, 2 }, { 2, -8, 2, -8, 2 } };
            int[,] wait = new int[5, 5] { { 2, 1, 2, 1, 2 }, { 2, 1, 2, 1, 2 }, { 2, 1, 2, 1, 2 }, { 2, 1, 2, 1, 2 }, { 2, 1, 2, 1, 2 } };
            CollectionAssert.AreEqual(ds.Calculate(matrix), wait);
        }
    }
}
