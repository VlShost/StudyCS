namespace IOProvider
{
    public interface IInputProvider
    {
        ConsoleKeyInfo ReadKey();   //?

        ConsoleKeyInfo ReadKey(bool intercept);

        string ReadLine();
    }
}