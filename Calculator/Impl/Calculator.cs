using System;
using System.Linq;
using System.Windows.Markup;
using SpecFlowDemo.Interfaces;

namespace SpecFlowDemo.Impl
{
    public class Calculator : ICalculator
    {
        public decimal Sum(params decimal[] values)
        {
            return values.Sum();
        }

        public decimal Divide(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }

        public decimal Minus(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }

        public decimal Multiply(decimal a, decimal b)
        {
            throw new NotImplementedException();
        }
    }
}
