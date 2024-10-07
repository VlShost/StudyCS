using shapes_hw.Interfaces;

namespace shapes_hw.Classes.ConsoleInputOutput
{
    public class ConsoleInputWriter : IOutputProvider
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }

        public void Write(string output)
        {
            throw new NotImplementedException();
        }
    }
}