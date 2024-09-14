using calculator_hw.Interfaces;

namespace calculator_hw.Classes.Operations.Basic
{
    public class AdditionOperation : IOperation
    {
        public double Execute(double leftOperand, double rightOperand)
        {
            return leftOperand += rightOperand;
        }
    }
}