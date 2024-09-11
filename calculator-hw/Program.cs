using calculator_hw.UI;

namespace calculator_hw
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                if (args[0] == "-version" && args[1] == "basic")
                {
                    var userInterface = new BasicUI();
                    userInterface.Start();
                }
                else if (args[0] == "-version" && args[1] == "advanced")
                {
                    //var userInterface = new AdvancedUI();
                }
                else if (args[0] == "-version" && args[1] == "debug")
                {
                    var userInterface = new DebugUI();
                    userInterface.Start();
                }
            }
            else
            {
                var userInerface = new BasicUI();
                userInerface.Start();
            }
        }
    }
}