using System;
using System.Collections.Generic;
using SpecFlowDemo.Interfaces;

namespace Calculator.Tests
{
    public class CalculationContext
    {
        private readonly List<double> _values = new List<double>();

        public ICalculator Calculator { get; private set; }

        public double Result { get; set; }

        public Exception Exception { get; set; }

        public List<double> Values
        {
            get { return _values; }
        }

        public CalculationContext()
        {
            Calculator = new SpecFlowDemo.Impl.Calculator();
        }
    }
}
