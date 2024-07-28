using shapes_hw.Interfaces;

namespace shapes_hw.Classes.ConsoleInputOutput
{
    public class ConsoleInputWriter : IOutputProvider
    {
        public void WriteLine(string output)
        {
            Console.WriteLine(output);
        }
    }
}