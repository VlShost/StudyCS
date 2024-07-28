namespace shapes_hw.Interfaces
{
    public interface IInputProvider
    {
        string ReadLine();
    }

    public interface IOutputProvider
    {
        void WriteLine(string output);
    }
}