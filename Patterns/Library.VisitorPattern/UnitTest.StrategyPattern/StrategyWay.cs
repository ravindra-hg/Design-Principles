using System;
using Library.StrategyPattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest.StrategyPattern
{
    [TestClass]
    public class StrategyWay
    {
        [TestInitialize]
        public void Initialize()
        {

        }

        [TestMethod]
        public void CheckSumCalculation()
        {
            Calculator calculator = new Calculator(new Sum());
            int result = calculator.Calculate(10, 20);
            Assert.AreEqual(30, result);
        }
        [TestMethod]
        public void CheckMinusCalculation()
        {
            Calculator calculator = new Calculator(new Minus());
            int result = calculator.Calculate(10, 20);
            Assert.AreEqual(-10, result);
        }
    }
}
