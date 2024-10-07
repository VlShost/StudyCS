using calculator_hw.Enums;

namespace calculator_hw.UI
{
    public class AdvancedUI : BasicUI
    {
        public AdvancedUI(CalculatorVersions version) : base(version)
        {
        }

        protected override void HelloMessage()
        {
            base.HelloMessage();
            Console.WriteLine("\nAdditional Supported Operations:");
            Console.WriteLine("  ^  Power              Example: 2 ^ 3 =");
        }
    }
}