namespace shapes_hw.Interfaces
{
    public interface IInputProvider
    {
        string ReadKey();

        string ReadLine();
    }

    public interface IOutputProvider
    {
        void WriteLine(string line);

        void Write(string output);
    }
}