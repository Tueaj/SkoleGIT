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
        [Test]
        public void Addnulnul()
        {
            double res = UUT1.Add(0, 0);
            Assert.That(res, Is.EqualTo(0));            
        }
        [Test]
        public void AddM5n7()
        {
            double res = UUT1.Add(-5, 7);
            Assert.That(res, Is.EqualTo(2));
        }
        [Test]
        public void AddDecimal()
        {
            double res = UUT1.Add(-0.5, 10);
            Assert.That(res, Is.EqualTo(9.5));
        }
        //SUBSTRACT TEST
        [Test]
        public void Subnulnul()
        {
            double res = UUT1.Substract(0, 0);
            Assert.That(res, Is.EqualTo(0));
        }
        [Test]
        public void SubM5n7()
        {
            double res = UUT1.Substract(-5, 7);
            Assert.That(res, Is.EqualTo(-12));
        }
        [Test]
        public void SubDecimal()
        {
            double res = UUT1.Substract(-0.5, 10);
            Assert.That(res, Is.EqualTo(-10.5));
        }
        //MULTIPLY TEST
        [Test]
        public void Mulnulnul()
        {
            double res = UUT1.Multiply(0, 0);
            Assert.That(res, Is.EqualTo(0));
        }
        [Test]
        public void MulM5n7()
        {
            double res = UUT1.Multiply(-5, 7);
            Assert.That(res, Is.EqualTo(-35));
        }
        [Test]
        public void MulDecimal()
        {
            double res = UUT1.Multiply(-0.5, 10);
            Assert.That(res, Is.EqualTo(-5));
        }

        //POWER TEST
        [Test]
        public void Pownulnul()
        {
            double res = UUT1.Power(0, 0);
            Assert.That(res, Is.EqualTo(1));
        }
        [Test]
        public void PowM5n7()
        {
            double res = UUT1.Power(-5, 2);
            Assert.That(res, Is.EqualTo(25));
        }
        [Test]
        public void PowDecimal()
        {
            double res = UUT1.Power(2.5, 2);
            Assert.That(res, Is.EqualTo(6.25));
        }

        [Test]
        public void AccuStart()
        {
            double res = UUT1.Accumulator;
            Assert.AreEqual(res,Is.EqualTo(0));
        }

        public void AccuAfterAdd()
        {
            double res = UUT1.Add(-5, 7);
            Assert.That(res, Is.EqualTo(UUT1.Accumulator));
        }

        [Test]
        public void Divide_TwoNumbers_CorrectResult()
        {
            double res = UUT1.Divide(10, 2);
            Assert.That(res, Is.EqualTo(5));
        }

        [Test]
        public void Divide_TwoHalfNumbers_CorrectResult()
        {
            double res = UUT1.Divide(10, 2.5);
            Assert.That(res, Is.EqualTo(4));
        }

        [Test]
        public void Divide_NegNumbers_CorrectResult()
        {
            double res = UUT1.Divide(-10, 4);
            Assert.That(res, Is.EqualTo(-2.5));
        }

        [Test]
        public void Divide_WithZero_Error()
        {
            double res = UUT1.Divide(10, 0);
            Assert.That(res, Is.EqualTo(0));
        }
    }
}