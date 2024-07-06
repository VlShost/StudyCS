namespace shapes
{
    public class ShapeHandler
    {
        public static void HandleShape(string shapeName)
        {
            IArea area = null;
            IPerimeter perimeter = null;

            bool validInput = false;

            switch (shapeName.ToLower())
            {
                case "rectangle":
                    int width, height;

                    do
                    {
                        Console.WriteLine("Enter WIDTH of rectangle:");

                        if (!int.TryParse(Console.ReadLine(), out width))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid integer.");
                        }
                        else if (width <= 0)
                        {
                            Console.WriteLine("Invalid input. Please enter a positive integer.");
                        }
                        else
                        {
                            validInput = true;
                        }
                    } while (!validInput);

                    do
                    {
                        Console.WriteLine("Enter HEIGHT of rectangle:");

                        if (!int.TryParse(Console.ReadLine(), out height))
                        {
                            Console.WriteLine("Invalid input. Please enter an integer.");
                        }
                        else if (height <= 0)
                        {
                            Console.WriteLine("Invalid input. Height must be a positive integer.");
                        }
                        else
                        {
                            validInput = true;
                        }
                    } while (!validInput);

                    Rectangle rectangle = new Rectangle(width, height);

                    area = rectangle;
                    perimeter = rectangle;
                    break;

                case "square":
                    int side;

                    do
                    {
                        Console.WriteLine("Enter side length of square:");
                        if (!int.TryParse(Console.ReadLine(), out side))
                        {
                            Console.WriteLine("Invalid input. Please enter an integer.");
                        }
                        else if (side <= 0)
                        {
                            Console.WriteLine("Invalid input. Side must be a positive integer.");
                        }
                        else
                        {
                            validInput = true;
                        }
                    } while (!validInput);

                    Square square = new Square(side);

                    area = square;
                    perimeter = square;
                    break;

                default:
                    Console.WriteLine("Invalid shape name");
                    return;
            }

            if (area != null && perimeter != null)
            {
                Console.WriteLine($"\n{shapeName}: area is {area.GetArea()} and perimeter is {perimeter.GetPerimeter()}");
            }
        }
    }
}