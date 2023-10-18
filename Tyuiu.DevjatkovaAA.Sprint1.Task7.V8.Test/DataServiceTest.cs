using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint1.Task7.V8.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint1.Task7.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 60;
            double y = 10;
            double z = 245.183401735616;
            var res = ds.Calculate(x, y); 
            Assert.AreEqual(z, res);
        }
    }
}
