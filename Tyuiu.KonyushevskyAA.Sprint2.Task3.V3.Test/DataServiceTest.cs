using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint2.Task3.V3.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint2.Task3.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            double wait = 18;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            double wait = 0.167;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition3()
        {
            DataService ds = new DataService();
            double x = -10;
            double res = ds.Calculate(x);
            double wait = 0.1;
            Assert.AreEqual(wait, res);

        }

        [TestMethod]
        public void ValidCondition4()
        {
            DataService ds = new DataService();
            double x = -30;
            double res = ds.Calculate(x);
            double wait = 600.033;
            Assert.AreEqual(wait, res);

        }
    }
}
