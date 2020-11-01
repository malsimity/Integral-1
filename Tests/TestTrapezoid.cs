using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Integral.Classes;
namespace Tests
{
    [TestClass]
    public class TestTrapezoid
    {
        [TestMethod]
        public void Integral_Trapezoid_XX_0_10_Correct()
        {
            //arrange
            double expected = 333.333;
            double a = 0;
            double b = 10;
            int n = 10000;
            ICalculator calcul = new TrapezoidCalc();

            //act
            double actual = calcul.Calculate(a, b, n, x => x * x);

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void Integral_Trapezoid_XX_10_0_Correct()
        {

            //arrange
            double expected = -333.333;
            double a = 10;
            double b = 0;
            int n = 10000;
            ICalculator calcul = new TrapezoidCalc();

            //act
            double actual = calcul.Calculate(a, b, n, x => x * x);

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void Integral_Trapezoid_XX_10_10_Correct()
        {

            //arrange
            double expected = 0;
            double a = 10;
            double b = 10;
            int n = 10000;
            ICalculator calcul = new TrapezoidCalc();

            //act
            double actual = calcul.Calculate(a, b, n, x => x * x);

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Integral_Trapezoid_XX_0_10_BadN()
        {
            //arrange
            double a = 0;
            double b = 10;
            int n = -1000000;
            ICalculator calcul = new TrapezoidCalc();

            //act
            double actual = calcul.Calculate(a, b, n, x => x * x);
        }

        [TestMethod]
        public void Integral_Trapezoid_0_0_10_Correct()
        {

            //arrange
            double expected = 0;
            double a = 0;
            double b = 10;
            int n = 10000;
            ICalculator calcul = new TrapezoidCalc();

            //act
            double actual = calcul.Calculate(a, b, n, x => 0);

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }

    }
}
