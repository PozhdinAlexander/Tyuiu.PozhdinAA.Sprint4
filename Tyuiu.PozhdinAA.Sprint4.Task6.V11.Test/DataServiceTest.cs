using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PozhdinAA.Sprint4.Task6.V11.Lib;

namespace Tyuiu.PozhdinAA.Sprint4.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int wait = 3;
            string[] array = new string[] { "Кошка", "Собака", "Слон", "Жираф", "Бегемот", "Игуана", "Ягуар" };
            int res = ds.Calculate(array);
            Assert.AreEqual(wait, res);
        }
    }
}