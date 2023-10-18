using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint1.Task3.V2.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint1.Task3.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double priceNotebook = 2;
            int amountNotebook = 3;
            double pricePencil = 5;
            int amountPencil = 10;
            var res = ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil);
            Assert.AreEqual(56, res); 
        }
    }
}
