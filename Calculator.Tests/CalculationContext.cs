using SpecFlowDemo.Interfaces;
using System;
using System.Collections.Generic;

namespace Calculator.Tests
{
    public class CalculationContext
    {
        private readonly List<decimal> _values = new List<decimal>();

        public ICalculator Calculator { get; private set; }

        public decimal Result { get; set; }

        public Exception Exception { get; set; }

        public List<decimal> Values
        {
            get { return _values; }
        }

        public CalculationContext()
        {
            Calculator = new SpecFlowDemo.Impl.Calculator();
        }
    }
}
