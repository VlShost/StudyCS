using calculator_hw.Enums;
using calculator_hw.Interfaces.UI;
using calculator_hw.UI;

namespace calculator_hw.Classes
{
    public class UserInterfaceFactory : IUserInterfaceCreate
    {
        public IUserInterfaceStart CreateUserInterface(CalculatorVersions version)
        {
            switch (version)
            {
                case CalculatorVersions.Basic:
                    return new BasicUI(version);

                case CalculatorVersions.Advanced:
                    return new AdvancedUI(version);

                default:
                    return new BasicUI(version);
            }
        }
    }
}