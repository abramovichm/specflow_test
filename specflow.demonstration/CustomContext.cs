using System;
using Specflow.Demonstration.CalculatorApp;

namespace Specflow.Demonstration
{
    public class CustomContext : IDisposable
    {
        public ICalculator Calculator { get; set; }

        public void Dispose()
        {
            Console.WriteLine("CustomContext.Dispose");
        }
    }
}