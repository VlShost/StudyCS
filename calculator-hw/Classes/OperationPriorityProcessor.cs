using calculator_hw.Enums;
using calculator_hw.Interfaces;
using calculator_hw.Interfaces.IOProviders;

namespace calculator_hw.Classes
{
    public class OperationPriorityProcessor
    {
        private IOutputProvider OutputProvider { get; }
        private readonly CalculatorVersions _version;
        public double Result { get; private set; }

        public OperationPriorityProcessor(IOutputProvider outputProvider, CalculatorVersions version)
        {
            OutputProvider = outputProvider;
            _version = version;
        }

        public double ProcessTokens(List<string> inputTokens)
        {
            if (inputTokens.Count > 0)
            {
                if (!double.TryParse(inputTokens[0], out double result))
                {
                    OutputProvider.WriteLine("Wrong number format");
                    return 0;
                }

                for (int i = 1; i < inputTokens.Count - 1; i += 2)
                {
                    Operators operation = (Operators)inputTokens[i][0];
                    if (!double.TryParse(inputTokens[i + 1], out double nextOperand))
                    {
                        OutputProvider.WriteLine("Wrong number format");
                        return 0;
                    }

                    var operationsFactory = new OperationsFactory(OutputProvider);
                    IOperation op = operationsFactory.CreateOperation(operation, _version);

                    if (op != null)
                    {
                        result = Calculator.DoCalculation(result, nextOperand, op);
                    }
                    else
                    {
                        result = 0;
                    }
                }

                Result = result;
                return result;
            }
            else
            {
                OutputProvider.WriteLine("You must type an operation");
                return 0;
            }
        }
    }
}