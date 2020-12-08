using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Integral.Classes;
namespace Tests
{
    [TestClass]
    public class TestRectangle
    {
        [TestMethod]
        public void Integral_Rectangle_XX_0_10_Correct()
        {
            //arrange подготовить
            double expected = 333.333;
            double a = 0;
            double b = 10;
            int n = 10000;
            ICalculator calcul = new RectangleCalculator();

            //act действие
            double actual = calcul.Calculate(a, b, n, x => x * x);

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void Integral_Rectangle_XX_10_0_Correct()
        {

            //arrange
            double expected = -333.333;
            double a = 10;
            double b = 0;
            int n = 10000;
            ICalculator calcul = new RectangleCalculator();

            //act
            double actual = calcul.Calculate(a, b, n, x => x * x);

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void Integral_Rectangle_XX_10_10_Correct()
        {

            //arrange
            double expected = 0;
            double a = 10;
            double b = 10;
            int n = 10000;
            ICalculator calcul = new RectangleCalculator();

            //act
            double actual = calcul.Calculate(a, b, n, x => x * x);

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Integral_Rectangle_XX_0_10_BadN()
        {
            //arrange
            double a = 0;
            double b = 10;
            int n = -1000000;
            ICalculator calcul = new RectangleCalculator();

            //act
            double actual = calcul.Calculate(a, b, n, x => x * x);

        }

        [TestMethod]
        public void Integral_Rectangle_0_0_10_Correct()
        {

            //arrange
            double expected = 0;
            double a = 0;
            double b = 10;
            int n = 10000;
            ICalculator calcul = new RectangleCalculator();

            //act
            double actual = calcul.Calculate(a, b, n, x => 0);

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }

        [TestMethod]
        public void Integral_Rectangle_XXx_0_10_Correct()
        {
            //arrange подготовить
            double expected = 2500;
            double a = 0;
            double b = 10;
            int n = 10000;
            ICalculator calcul = new RectangleCalculator();

            //act действие
            double actual = calcul.Calculate(a, b, n, x => x * x * x);

            //assert
            Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
