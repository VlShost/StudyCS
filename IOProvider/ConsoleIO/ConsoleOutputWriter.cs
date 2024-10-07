namespace IOProvider.ConsoleIO
{
    public class ConsoleOutputWriter : IOutputProvider
    {
        public void WriteLine(string line)
        {
            Console.WriteLine(line);
        }

        public void Write(string output)
        {
            Console.Write(output);
        }
    }
}