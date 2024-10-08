﻿using shapes_hw.Classes;
using shapes_hw.Classes.ConsoleInputOutput;
using shapes_hw.Interfaces;

namespace shapes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("*--------------------*");
            Console.WriteLine("*       SHAPES       *");
            Console.WriteLine("*--------------------*");

            IInputProvider inputProvider = new ConsoleInputReader();
            IOutputProvider outputProvider = new ConsoleInputWriter();

            ShapeHandler shapeHandler = new ShapeHandler(inputProvider, outputProvider);

            while (!endApp)
            {
                Console.WriteLine("\nPress Enter to start or Esc to exit");

                ConsoleKeyInfo inputKey = Console.ReadKey(true);
                if (inputKey.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Enter the name of shape (rectangle or square):");

                    string input = Console.ReadLine();
                    shapeHandler.HandleShape(input);
                }
                else if (inputKey.Key == ConsoleKey.Escape)
                {
                    endApp = true;
                }
            }
        }
    }
}