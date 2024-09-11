﻿//using calculator_hw.Classes;
//using calculator_hw.Enums;
//using calculator_hw.Interfaces.IOProviders;
//using calculator_hw.Interfaces.UI;

//namespace calculator_hw.UI
//{
//    public class AdvancedUI : IUserInterfaceStart, IUserInterfaceStop
//    {
//        private bool _endApp = true;

//        public void Start()
//        {
//            _endApp = false;

//            Console.WriteLine("*-----------------------------*");
//            Console.WriteLine("* Advanced Console Calculator *");
//            Console.WriteLine("*-----------------------------*");

//            Console.WriteLine("\nSupported Operations:");
//            Console.WriteLine("  +  Addition          Example: 2 + 2 =");
//            Console.WriteLine("  -  Subtraction       Example: 5 - 3 =");
//            Console.WriteLine("  *  Multiplication    Example: 4 * 7 =");
//            Console.WriteLine("  /  Division          Example: 10 / 2 =");

//            Console.WriteLine("\nHow to Use:");
//            Console.WriteLine("  - Enter Numbers and Operators. Multiple operations allowed. Example: 2 + 2 + 2");
//            Console.WriteLine("  - Enter Decimal Numbers: Use '.' or ',' to input decimals.");
//            Console.WriteLine("  - Complete the Operation: Press = to calculate the result. Example: 2 + 2 = 4");
//            Console.WriteLine("  - Delete Last Character: Press Backspace to remove the last input.");
//            Console.WriteLine("  - Exit the Program: Press Esc at any time to close the app.");

//            IInputProvider inputProvider = new ConsoleInputReader();
//            IOutputProvider outputProvider = new ConsoleInputWriter();

//            var tokenizer = new InputTokenizer();
//            var processedTokens = new OperationPriorityProcessor();
//            var calculator = new Calculator();

//            while (!_endApp)
//            {
//                Console.Write("\nPress Enter to start or Esc to exit");

//                ConsoleKeyInfo selection = Console.ReadKey(true);

//                if (selection.Key == ConsoleKey.Enter)
//                {
//                    Console.Write("\nType a desired operation: ");

//                    string input = "";

//                    while (true)
//                    {
//                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

//                        if (keyInfo.Key == ConsoleKey.Escape)
//                        {
//                            _endApp = true;
//                            break;
//                        }

//                        char inputKey = keyInfo.KeyChar;

//                        if (char.IsDigit(inputKey) ||
//                            inputKey == '.' || inputKey == ',' ||
//                            Enum.IsDefined(typeof(Operators), (int)inputKey) ||
//                            inputKey == '=' ||
//                            inputKey == ' ')
//                        {
//                            Console.Write(inputKey);
//                            input += inputKey;
//                        }

//                        if (keyInfo.Key == ConsoleKey.Backspace)
//                        {
//                            if (input.Length > 0)
//                            {
//                                input = input.Remove(input.Length - 1);
//                                Console.Write("\b \b");
//                            }
//                        }

//                        if (inputKey == '=')
//                        {
//                            input = "";

//                            var result = Calculator.DoCalculation(processedTokens);

//                            Console.Write(result);
//                        }
//                    };
//                }
//                else if (selection.Key == ConsoleKey.Escape)
//                {
//                    _endApp = true;
//                }
//            }
//        }

//        public void Stop()
//        {
//            _endApp = true;
//        }
//    }
//}