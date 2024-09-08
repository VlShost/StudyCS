using calculator_hw.Interfaces;

namespace calculator_hw.Classes.Operations
{
    public class DivisionOperation : IOperation
    {
        public double Execute(double leftOperand, double rightOperand)
        {
            if (rightOperand == 0)
            {
                return double.NaN;
            }
            return leftOperand / rightOperand;
        }
    }
}