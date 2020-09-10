using System;
using NUnit.Framework;

namespace Calculator.Test.Unit
{
    public class Tests
    {
        private Calculator UUT1;

        [SetUp]
        public void Setup()
        {
            UUT1 = new Calculator();
        }

        //ADD TEST
        [TestCase(0,0,0)]
        [TestCase(-5, 7, 2)]
        [TestCase(-0.5, 10, 9.5)]
        public void AddTwoNumbersAnwserCorrect(double a, double b, double c)
        {
            double res = UUT1.Add(a, b);
            Assert.That(res, Is.EqualTo(c));            
        }

        //SUBSTRACT TEST
        [TestCase(0, 0, 0)]
        [TestCase(-5, 7, -12)]
        [TestCase(-0.5, 10, -10.5)]
        public void SubtractTwoNumbersAnwserCorrect(double a, double b, double c)
        {
            double res = UUT1.Substract(a, b);
            Assert.That(res, Is.EqualTo(c));
        }

        //MULTIPLY TEST
        [TestCase(0, 0, 0)]
        [TestCase(-5, 7, -35)]
        [TestCase(-0.5, 10, -5)]
        public void MultiplyTwoNumbersAnwserCorrect(double a, double b, double c)
        {
            double res = UUT1.Multiply(0, 0);
            Assert.That(res, Is.EqualTo(0));
        }

        //POWER TEST
        [TestCase(0, 0, 1)]
        [TestCase(-5, 7, 25)]
        [TestCase(2.5, 2, 6.25)]
        public void PowerTwoNumbersAnwserCorrect(double a, double b, double c)
        {
            double res = UUT1.Power(0, 0);
            Assert.That(res, Is.EqualTo(1));
        }

        //Divide test
        [TestCase(10, 2, 5)]
        [TestCase(10, 2.5, 4)]
        [TestCase(-10, 4, -2.5)]
        [TestCase(105, 0, 0)]
        public void DivideTwoNumbersAnwserCorrect(double a, double b, double c)
        {
            double res = UUT1.Divide(a, b);
            Assert.That(res, Is.EqualTo(c));
        }

        //Accu test
        [Test]
        public void AccuEmptyAtStartCorrect()
        {
            double res = UUT1.Accumulator;
            Assert.That(res, Is.EqualTo(0.0d));
        }

        [Test]
        public void AccuNotEmptyAfterAddCorrect()
        {
            double res = UUT1.Add(-5, 7);
            Assert.That(res, Is.EqualTo(UUT1.Accumulator));
        }

        //Clear test
        [Test]
        public void clearEmptyAccu()
        {
            UUT1.Clear();
            Assert.That(UUT1.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void ClearAccuAfterAdd()
        {
            UUT1.Add(-5, 7);
            UUT1.Clear();
            Assert.That(UUT1.Accumulator, Is.EqualTo(0));
        }

        [Test]
        public void ClearAccuAfterSubtract()
        {
            double res=UUT1.Substract(-5, 7);
            UUT1.Clear();
            Assert.AreNotEqual(res,UUT1.Accumulator);
        }
    }

}