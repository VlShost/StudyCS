using calculator_hw.Interfaces;

namespace calculator_hw.Classes.Operations.Advanced
{
    public class PowerOperation : IOperation
    {
        public double Execute(double leftOperand, double rightOperand)
        {
            return Math.Pow(leftOperand, rightOperand);
        }
    }
}