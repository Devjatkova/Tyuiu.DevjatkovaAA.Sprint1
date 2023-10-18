using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.DevjatkovaAA.Sprint1.Task6.V11.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint1.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "жизнь состоит из деталей, дак оторвись же от суеты и посмотри на них ";
            DataService ds = new DataService();
            bool res = ds.CheckeFirstLetterRepetition(strTest); 
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
