using shapes_hw.Interfaces;

namespace shapes_hw.Classes.ConsoleInputOutput
{
    public class ConsoleInputWriter : IOutputProvider
    {
        public void WriteOutput(string output)
        {
            Console.WriteLine(output);
        }
    }
}