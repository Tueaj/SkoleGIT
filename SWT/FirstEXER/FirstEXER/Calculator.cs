﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public Calculator() { }

        public double Add(double a, double b)
        {         
            return  a + b;
        }
        public double Substract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }
        public double Power(double x, double exp)
        {
            return Math.Pow(x, exp);
        }

        public double Divide(double a, double b)
        {
            if (b == 0)
                return 0;
            else
                Accumulator = a / b;
            return Accumulator;
        }
    }
}
