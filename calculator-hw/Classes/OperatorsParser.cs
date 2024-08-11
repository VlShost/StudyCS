using calculator_hw.Enums;

namespace calculator_hw.Classes
{
    public class OperatorsParser
    {
        public static Operators ParseOperator(char op)
        {
            if (Enum.IsDefined(typeof(Operators), (int)op))
            {
                return (Operators)op;
            }
            else
            {
                throw new ArgumentException("Invalid operator", nameof(op));
            }
        }
    }
}