using calculator_hw.Classes;
using calculator_hw.Enums;

namespace calculator_hw
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            CalculatorVersions version = CalculatorVersions.Basic;

            if (args.Length > 0 && args[0] == "-version")
            {
                if (Enum.TryParse(args[1], true, out CalculatorVersions requestedVersion))
                {
                    version = requestedVersion;
                }
            }

            var uiFactory = new UserInterfaceFactory();
            var userInerface = uiFactory.CreateUserInterface(version);
            userInerface.Start();
        }
    }
}