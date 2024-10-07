using calculator_hw.Enums;

namespace calculator_hw.Interfaces.UI
{
    public interface IUserInterfaceCreate
    {
        IUserInterfaceStart CreateUserInterface(CalculatorVersions version);
    }
}