using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KonyushevskyAA.Sprint2.Task7.V1.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService dataService = new DataService();
            double x = 0.2;
            double y = -0.7;

            bool res = dataService.CheckDotInShadedArea(x, y);
            
            Assert.IsFalse(res);
        }
    }
}
