namespace shapes_hw.Interfaces
{
    public interface IInputProvider
    {
        string ReadInput();
    }

    public interface IOutputProvider
    {
        void WriteOutput(string output);
    }
}