using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.SorokinMA.Sprint7.ProjectV11.Lib;
using System.IO;

namespace Tyuiu.SorokinMA.Sprint7.ProjectV11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        double[] test = new double[] { 1, 2, 3, 5, 6, 7 };
        [TestMethod]
        public void GetDataBaseValid()
        {
            string[,] res = ds.GetDataBase(@"C:\Users\User\source\repos\Tyuiu.SorokinMA.Sprint7\Tyuiu.SorokinMA.Sprint7.ProjectV11\bin\Debug\ForTest.csv");
            string[,] wait = { { "1", "2", "3" },
                               { "4", "5", "6" },
                               { "7", "8", "9" } };
            CollectionAssert.AreEqual(wait, res);
        }
        [TestMethod]
        public void SumValid()
        {
            Assert.AreEqual(ds.Sum(test), 24);
        }
        [TestMethod]
        public void AvergeValid()
        {
            Assert.AreEqual(ds.Average(test), 4);
        }
        [TestMethod]
        public void MinValid()
        {
            Assert.AreEqual(ds.Min(test), 1);
        }
        [TestMethod]
        public void MaxValid()
        {
            Assert.AreEqual(ds.Max(test), 7);
        }

    }
}
