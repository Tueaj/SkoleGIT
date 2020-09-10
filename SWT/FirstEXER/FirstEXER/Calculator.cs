using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public Calculator()
        {
            Accumulator = 0.0d;
        }

        public double Accumulator { get; set; }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }
        public double Add(double b)
        {
            Accumulator += b;
            return Accumulator;
        }

        public double Substract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }
        public double Substract(double b)
        {
            Accumulator -= b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }
        public double Multiply(double b)
        {
            Accumulator *= b;
            return Accumulator;
        }

        public double Power(double x, double exp)
        {
            Accumulator =  Math.Pow(x, exp);
            return Accumulator;
        }
        public double Power(double x)
        {
            Accumulator = Math.Pow(x, Accumulator);
            return Accumulator;
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
            {
                Accumulator = 0;
            }
            else
            {
                Accumulator = a / b;
            }
            return Accumulator;
        }

        public double Divide(double b)
        {
            if (b == 0)
            {
                Accumulator = 0;
            }
            else
            {
                Accumulator /= b;
            }
            return Accumulator;
        }

        public void Clear()
        {
            Accumulator = 0;
        }
    }
}
