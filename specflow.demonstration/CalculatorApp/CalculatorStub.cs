using System;
using System.Collections.Generic;

namespace Specflow.Demonstration.CalculatorApp
{
    public class CalculatorStub : ICalculator
    {
        private readonly Stack<double> values = new Stack<double>();
        private CalculatorOperation currentOperation;

        public CalculatorStub()
        {
            Clear();
        }

        public void Clear()
        {
            currentOperation = CalculatorOperation.None;
            values.Clear();
        }

        public void InputValue(double value)
        {
            values.Push(value);
        }

        public void PressButton(CalculatorOperation operation)
        {
            if (currentOperation == CalculatorOperation.None)
            {
                currentOperation = operation;
                return;
            }
            if (operation == CalculatorOperation.Equals)
            {
                if (currentOperation == CalculatorOperation.None || currentOperation == CalculatorOperation.Equals)
                {
                    throw new InvalidOperationException("Operation sequence is not correct");
                }
                double value2 = values.Pop();
                double value1 = values.Pop();
                if (currentOperation == CalculatorOperation.Plus)
                {
                    double result = value1 + value2;
                    values.Push(result);
                }
                if (currentOperation == CalculatorOperation.Minus)
                {
                    double result = value1 - value2;
                    values.Push(result);
                }
            }
        }

        public double GetResult()
        {
            return values.Peek();
        }
    }
}