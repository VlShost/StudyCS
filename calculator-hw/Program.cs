using calculator_hw.Classes;
using calculator_hw.Classes.ConsoleInputOutput;
using calculator_hw.Interfaces;

namespace calculator_hw
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("*--------------------*");
            Console.WriteLine("* Console Calculator *");
            Console.WriteLine("*--------------------*");

            IInputProvider inputProvider = new ConsoleInputReader();
            IOutputProvider outputProvider = new ConsoleInputWriter();

            var calculator = new Calculator(outputProvider);

            char inputKey = Char.MinValue;
            string input = "";

            while (!endApp)
            {
                Console.Write("\nType a desired operation: ");

                do
                {
                    inputKey = Console.ReadKey().KeyChar;

                    if (inputKey == '=')
                    {
                        break;
                    }
                    else if (inputKey == 'q')
                    {
                        endApp = true;
                        break;
                    }

                    input += inputKey;
                } while (true);

                if (inputKey == '=')
                {
                    //InputReader.Read(input);
                    input = "";
                }
                else if (endApp)
                {
                    break;
                }

                Console.WriteLine("\nPress \"Enter\" to start new operation or press \"q\" to close the app:");
            }
        }
    }
}