using calculator_hw.Classes.Operations.Basic;
using calculator_hw.Enums;
using calculator_hw.Interfaces;

namespace calculator_hw.Classes
{
    public class OperationsFactory
    {
        public static IOperation CreateBasicOperation(Operators operators)
        {
            switch (operators)
            {
                case Operators.Add:
                    return new AdditionOperation();

                case Operators.Subtract:
                    return new SubtractionOperation();

                case Operators.Multiply:
                    return new MultiplicationOperation();

                case Operators.Divide:
                    return new DivisionOperation();

                default:
                    throw new NotImplementedException($"{operators} currently not supported");
            }
        }
    }
}