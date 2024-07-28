namespace shapes
{
    public class ConsoleInputWriter : IOutputProvider
    {
        public void WriteOutput(string output)
        {
            Console.WriteLine(output);
        }
    }
}