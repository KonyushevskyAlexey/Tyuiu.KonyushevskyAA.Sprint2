using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint2.Task6.V11.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint2.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            int g = 20;
            int m = 9;
            int n = 1;

            string res = ds.FindDateOfNextDay(g, m, n);
            string w = "9";


            Assert.AreEqual(w, res);

        }
    }
}
