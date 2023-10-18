using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint1.Task2.V25.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint1.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int a = 2;
            var res = ds.ConvertRadsToDegrees(a); 
            Assert.AreEqual(114.649681528662, res);
        }
    }
}
