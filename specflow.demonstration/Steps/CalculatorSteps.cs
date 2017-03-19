using System;
using System.Collections.Generic;
using NUnit.Framework;
using Specflow.Demonstration.CalculatorApp;
using TechTalk.SpecFlow;

namespace Specflow.Demonstration.Steps
{
    [Binding]
    public class CalcaulatorSteps
    {
        private readonly CustomContext context;

        public CalcaulatorSteps(CustomContext context)
        {
            this.context = context;
        }

        [Given(@"running application")]
        public void GivenRunningApplication()
        {
            context.Calculator = new CalculatorStub();
        }
        
        [When(@"user inputs number equal to (.*)")]
        public void WhenUserInputsNumberEqualTo(double value)
        {
            context.Calculator.InputValue(value);
        }
        
        [When(@"user presses ‘(.+)’ button")]
        public void WhenUserPressesButton(Button button)
        {
            context.Calculator.PressButton(button.Operation);
        }

        [Then(@"result should be equal to (.*)")]
        public void ThenResultShouldBeEqualTo(double result)
        {
            Assert.AreEqual(result, context.Calculator.GetResult());
        }

        [StepArgumentTransformation]
        public Button WaitForMinutesTransformation(string button)
        {
            IDictionary<string, CalculatorOperation> mapping = new Dictionary<string, CalculatorOperation>()
            {
                ["+"] = CalculatorOperation.Plus,
                ["-"] = CalculatorOperation.Minus,
                ["="] = CalculatorOperation.Equals
            };
            CalculatorOperation operation;
            if (mapping.TryGetValue(button, out operation))
            {
                return new Button
                {
                    Operation = operation,
                };
            }
            throw new ArgumentException("Unknown button");
        }
    }
}
