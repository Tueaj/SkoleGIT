﻿using System;
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
        }

        public double Accumulator { get; set; }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }
        public double Substract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }
        public double Power(double x, double exp)
        {
            Accumulator =  Math.Pow(x, exp);
            return Accumulator;
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
