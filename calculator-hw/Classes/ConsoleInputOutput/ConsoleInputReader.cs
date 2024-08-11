using calculator_hw.Interfaces;

namespace calculator_hw.Classes.ConsoleInputOutput
{
    public class ConsoleInputReader : IInputProvider
    {
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        public string ReadKey()
        {
            throw new NotImplementedException();
        }
    }
}