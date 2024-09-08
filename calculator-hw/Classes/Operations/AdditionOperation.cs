using calculator_hw.Interfaces;

namespace calculator_hw.Classes.Operations
{
    public class AdditionOperation : IOperation
    {
        public double Execute(double leftOperand, double rightOpetrand)
        {
            return leftOperand += rightOpetrand;
        }
    }
}