using calculator_hw.Classes;
using calculator_hw.Classes.ConsoleInputOutput;
using calculator_hw.Enums;
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

            IInputProvider inputProvider = new ConsoleInputReader();
            IOutputProvider outputProvider = new ConsoleInputWriter();

            var calculator = new Calculator(outputProvider);

            while (!endApp)
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
                            endApp = true;
                            break;
                        }

                        char inputKey = keyInfo.KeyChar;

                        if (char.IsDigit(inputKey) ||
                            (inputKey == '.' || inputKey == ',') ||
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
                            Console.WriteLine($"\n{input}");

                            var tokenizedInput = InputTokenizer.Tokenize(input);

                            foreach (var tokenItem in tokenizedInput)
                            {
                                Console.WriteLine($"{tokenItem}");
                            }

                            Console.WriteLine("\nCount: " + tokenizedInput.Count);

                            input = "";
                        }
                    };
                }
                else if (selection.Key == ConsoleKey.Escape)
                {
                    endApp = true;
                }
            }
        }
    }
}