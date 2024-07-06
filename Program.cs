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

            while (!endApp)
            {
                Console.WriteLine("\nPress Enter to start or Esc to exit");

                ConsoleKeyInfo inputKey = Console.ReadKey(true);
                if (inputKey.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Enter the name of shape (rectangle or square):");

                    string input = Console.ReadLine();
                    ShapeHandler.HandleShape(input);
                }
                else if (inputKey.Key == ConsoleKey.Escape)
                {
                    endApp = true;
                }
            }
        }
    }
}