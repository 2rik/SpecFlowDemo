﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace Calculator.Tests.Steps
{
    [Binding]
    public class CalculatorSteps
    {
        public CalculationContext Context { get; set; }

        public CalculatorSteps(CalculationContext context)
        {
            Context = context;
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(decimal value)
        {
            Context.Values.Add(value);
        }
        
        [When(@"I press (.*)")]
        public void WhenIPressAdd(string action)
        {
            switch (action.ToLower())
            {
                case "add":
                case "plus":
                    Context.Result = Context.Calculator.Sum(Context.Values.ToArray());
                    break;
                default: Assert.Inconclusive((String.Format("Action \"{0}\" is not implemented", action)));
                    break;
            }
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(decimal expected)
        {
            Assert.AreEqual(expected, Context.Result);
        }
    }
}
