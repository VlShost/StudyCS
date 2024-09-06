using calculator_hw.Enums;
using calculator_hw.Interfaces.IOProviders;

namespace calculator_hw.Classes
{
    public class Calculator
    {
        public IOutputProvider OutputProvider { get; set; }

        public Calculator(IOutputProvider outputProvider)
        {
            OutputProvider = outputProvider;
        }

        public double DoCalculation(double num1, double num2, Operators op)
        {
            double result = double.NaN;
            switch (op)
            {
                case Operators.Add:
                    result = num1 + num2;
                    break;

                case Operators.Subtract:
                    result = num1 - num2;
                    break;

                case Operators.Multiply:
                    result = num1 * num2;
                    break;

                case Operators.Divide:
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        OutputProvider.WriteLine("\nYou can't divide by 0.");
                        result = 0;
                    }
                    break;

                case Operators.Power:
                    result = Math.Pow(num1, num2);
                    break;

                default:
                    OutputProvider.WriteLine("\nUnsupported operation.");
                    break;
            }
            return result;
        }
    }
}