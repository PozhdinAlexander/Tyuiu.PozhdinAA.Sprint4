using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PozhdinAA.Sprint4.Task0.V9.Lib;

namespace Tyuiu.PozhdinAA.Sprint4.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();
            int[] numsArray = { 4, 6, 2, 8, 4, 5, 6, 9, 8, 7 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int wait = 73728;
            Assert.AreEqual(wait, res);
        }
    }
}