using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Sum_5plus2_7()
        {
            //arrange
            double a = 5;
            double b = 20;
            double expected = 7;
            //act
            Calc calc = new Calc();
            double actal = calc.Sum(a, b);

            //assert
            Assert.AreEqual(expected, actal);
        }
        [TestMethod]
        public void Minus_5minus2_3() { 
            double a = 5;
            double b = 3;
            double expected = 3;
            Calc calc = new Calc();
            double actal = calc.Minus(a, b);
            Assert.AreEqual(expected, actal);
        }
        [TestMethod]
        public void Delenie_6delit2_3() {
            int a = 6;
            int b = 2;
            int expected = 3;
            Calc calc = new Calc();
            int actal = calc.Delenie(a, b);
            Assert.AreEqual(expected, actal);
        }

        [TestMethod]
        public void Umnojenie_5na2_10()
        {
            double a = 5;
            double b = 2;
            double expected = 10;
            Calc calc = new Calc();
            double actal = calc.Umnojenie(a, b);
            Assert.AreEqual(expected, actal);
        }
    }
}
