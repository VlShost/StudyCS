namespace shapes
{
    public class ConsoleInputReader : IInputProvider
    {
        public string ReadInput()
        {
            return Console.ReadLine();
        }
    }
}