using System;
using System.Linq;
using SpecFlowDemo.Interfaces;

namespace SpecFlowDemo.Impl
{
    public class Calculator : ICalculator
    {
        public double Sum(params double[] values)
        {
            return values.Sum();
        }

        public double Divide(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double Minus(double a, double b)
        {
            throw new NotImplementedException();
        }

        public double Multiply(params double[] values)
        {
            throw new NotImplementedException();
        }

        public double Sin(double a)
        {
            throw new NotImplementedException();
        }
    }
}
