using shapes_hw.Interfaces;

namespace shapes_hw.Classes.ConsoleInputOutput
{
    public class ConsoleInputReader : IInputProvider
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}