using calculator_hw.Interfaces;

namespace calculator_hw.Classes
{
    public class Calculator
    {
        public static double DoCalculation(double leftOperand, double rightOperand, IOperation operation)
        {
            return operation.Execute(leftOperand, rightOperand);
        }
    }
}