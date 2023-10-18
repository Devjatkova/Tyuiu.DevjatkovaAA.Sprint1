using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService(); 
            int k = 130985;
            int h = 9;
            var res = ds.Calculate(k);
            int result = Convert.ToInt32(res);
            Assert.AreEqual(h, result);
        }
    }
}
