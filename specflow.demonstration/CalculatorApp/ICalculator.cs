namespace Specflow.Demonstration.CalculatorApp
{
    public interface ICalculator
    {
        void Clear();

        void InputValue(double value);

        void PressButton(CalculatorOperation operation);

        double GetResult();
    }
}