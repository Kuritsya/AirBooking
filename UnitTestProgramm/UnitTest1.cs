using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using RPO_lab_2;

namespace UnitTestProgramm
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SumFullPrice()
        {
            var calc = new Calculator();

            var res = calc.Multipy(5000, 6);

            Assert.AreEqual(30000, res);
        }

    }
}
