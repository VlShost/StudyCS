using IOProvider;
using IOProvider.ConsoleIO;
using calculator_hw.Classes;
using calculator_hw.Enums;
using calculator_hw.Interfaces.UI;

namespace calculator_hw.UI
{
    public class BasicUI : IUserInterfaceStart, IUserInterfaceStop
    {
        private bool _endApp = true;
        private CalculatorVersions _version;

        public BasicUI(CalculatorVersions version)
        {
            _version = version;
        }

        public void Start()
        {
            _endApp = false;

            IInputProvider inputProvider = new ConsoleInputReader();
            IOutputProvider outputProvider = new ConsoleOutputWriter();

            HelloMessage();

            while (!_endApp)
            {
                outputProvider.Write("\nPress Enter to start or Esc to exit");

                var selection = inputProvider.ReadKey(true);

                if (selection.Key == ConsoleKey.Enter)
                {
                    outputProvider.Write("\nType a desired operation: ");

                    string input = "";

                    while (true)
                    {
                        ConsoleKeyInfo keyInfo = inputProvider.ReadKey(true);

                        if (keyInfo.Key == ConsoleKey.Escape)
                        {
                            _endApp = true;
                            break;
                        }

                        char inputKey = keyInfo.KeyChar;

                        if (char.IsDigit(inputKey) ||
                            inputKey == '.' || inputKey == ',' ||
                            Enum.IsDefined(typeof(Operators), (int)inputKey) ||
                            inputKey == '=' ||
                            inputKey == ' ')
                        {
                            outputProvider.Write($"{inputKey}");
                            input += inputKey;
                        }

                        if (keyInfo.Key == ConsoleKey.Backspace)
                        {
                            if (input.Length > 0)
                            {
                                input = input.Remove(input.Length - 1);
                                outputProvider.Write("\b \b");
                            }
                        }

                        if (inputKey == '=')
                        {
                            var tokenizer = new InputTokenizer();
                            tokenizer.ClearTokens();

                            var tokens = tokenizer.Tokenize(input);

                            var processedTokens = new OperationPriorityProcessor(outputProvider, _version);
                            var result = processedTokens.ProcessTokens(tokens);

                            tokenizer.ClearTokens();
                            input = "";

                            outputProvider.Write($"{result}\n");
                        }
                    };
                }
                else if (selection.Key == ConsoleKey.Escape)
                {
                    _endApp = true;
                }
            }
        }

        public void Stop()
        {
            _endApp = true;
        }

        protected virtual void HelloMessage()
        {
            Console.WriteLine("*--------------------*");
            Console.WriteLine("* Console Calculator *");
            Console.WriteLine("*--------------------*");

            Console.WriteLine("\nHow to Use:");
            Console.WriteLine("  - Enter Numbers and Operators. Multiple operations allowed. Example: 2 + 2 + 2");
            Console.WriteLine("  - Enter Decimal Numbers: Use '.' or ',' to input decimals.");
            Console.WriteLine("  - Complete the Operation: Press = to calculate the result. Example: 2 + 2 = 4");
            Console.WriteLine("  - Delete Last Character: Press Backspace to remove the last input.");
            Console.WriteLine("  - Exit the Program: Press Esc at any time to close the app.");

            Console.WriteLine("\nSupported Operations:");
            Console.WriteLine("  +  Addition          Example: 2 + 2 =");
            Console.WriteLine("  -  Subtraction       Example: 5 - 3 =");
            Console.WriteLine("  *  Multiplication    Example: 4 * 7 =");
            Console.WriteLine("  /  Division          Example: 10 / 2 =");
        }
    }
}