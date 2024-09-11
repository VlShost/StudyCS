using calculator_hw.Classes;
using calculator_hw.Classes.ConsoleInputOutput;
using calculator_hw.Debug.Classes;
using calculator_hw.Enums;
using calculator_hw.Interfaces.IOProviders;
using calculator_hw.Interfaces.UI;

namespace calculator_hw.UI
{
    public class DebugUI : IUserInterfaceStart, IUserInterfaceStop
    {
        private bool _endApp = true;

        public void Start()
        {
            _endApp = false;

            IInputProvider inputProvider = new ConsoleInputReader();
            IOutputProvider outputProvider = new ConsoleInputWriter();

            //var tokenizer = new InputTokenizer();
            //var processedTokens = new OperationPriorityProcessor();
            //var calculator = new Calculator();

            HelloMessage();

            while (!_endApp)
            {
                Console.Write("\nPress Enter to start or Esc to exit");

                ConsoleKeyInfo selection = Console.ReadKey(true);

                if (selection.Key == ConsoleKey.Enter)
                {
                    Console.Write("\nType a desired operation: ");

                    string input = "";

                    while (true)
                    {
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                        if (keyInfo.Key == ConsoleKey.Escape)
                        {
                            Stop();
                            break;
                        }

                        char inputKey = keyInfo.KeyChar;

                        if (char.IsDigit(inputKey) ||
                            inputKey == '.' || inputKey == ',' ||
                            Enum.IsDefined(typeof(Operators), (int)inputKey) ||
                            inputKey == '=' ||
                            inputKey == ' ')
                        {
                            Console.Write(inputKey);
                            input += inputKey;
                        }

                        if (keyInfo.Key == ConsoleKey.Backspace)
                        {
                            if (input.Length > 0)
                            {
                                input = input.Remove(input.Length - 1);
                                Console.Write("\b \b");
                            }
                        }

                        if (inputKey == '=')
                        {
                            var tokens = Debug.Classes.InputTokenizer.Tokenize(input);

                            Console.WriteLine($"Tokens: {tokens.Count()}");

                            foreach (var token in tokens)
                            {
                                Console.WriteLine(token);
                            }

                            tokens.Clear();
                            input = "";
                        }
                    };
                }
                else if (selection.Key == ConsoleKey.Escape)
                {
                    Stop();
                }
            }
        }

        public void Stop()
        {
            _endApp = true;
        }

        private void HelloMessage()
        {
            Console.WriteLine("*--------------------------*");
            Console.WriteLine("* Debug Console Calculator *");
            Console.WriteLine("*--------------------------*");

            Console.WriteLine("\nSupported Operations:");
            Console.WriteLine("  +  Addition          Example: 2 + 2 =");
            Console.WriteLine("  -  Subtraction       Example: 5 - 3 =");
            Console.WriteLine("  *  Multiplication    Example: 4 * 7 =");
            Console.WriteLine("  /  Division          Example: 10 / 2 =");

            Console.WriteLine("\nHow to Use:");
            Console.WriteLine("  - Enter Numbers and Operators. Multiple operations allowed. Example: 2 + 2 + 2");
            Console.WriteLine("  - Enter Decimal Numbers: Use '.' or ',' to input decimals.");
            Console.WriteLine("  - Complete the Operation: Press = to calculate the result. Example: 2 + 2 = 4");
            Console.WriteLine("  - Delete Last Character: Press Backspace to remove the last input.");
            Console.WriteLine("  - Exit the Program: Press Esc at any time to close the app.");
        }
    }
}