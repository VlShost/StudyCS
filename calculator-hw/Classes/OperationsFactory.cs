using calculator_hw.Classes.Operations.Advanced;
using calculator_hw.Classes.Operations.Basic;
using calculator_hw.Enums;
using calculator_hw.Interfaces;
using IOProvider;

namespace calculator_hw.Classes
{
    public class OperationsFactory
    {
        private IOutputProvider OutputProvider { get; }

        public OperationsFactory(IOutputProvider outputProvider)
        {
            OutputProvider = outputProvider;
        }

        public IOperation CreateOperation(Operators operators, CalculatorVersions version)
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

                case Operators.Power:
                    if (version == CalculatorVersions.Advanced)
                    {
                        return new PowerOperation();
                    }
                    break;

                default:
                    OutputProvider.WriteLine($"\n{operators} currently not supported");
                    return null;
            }
            OutputProvider.WriteLine($"\nOperation {operators} is not supported in this version");
            return null;
        }
    }
}