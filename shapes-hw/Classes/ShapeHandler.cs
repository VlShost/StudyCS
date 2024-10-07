using shapes_hw.Classes.Shapes;
using shapes_hw.Interfaces;

namespace shapes_hw.Classes
{
    public class ShapeHandler
    {
        public IInputProvider InputProvider { get; }
        public IOutputProvider OutputProvider { get; }

        public ShapeHandler(IInputProvider inputProvider, IOutputProvider outputProvider)
        {
            InputProvider = inputProvider;
            OutputProvider = outputProvider;
        }

        public void HandleShape(string shapeName)
        {
            IShapeAreaMeter area = null;
            IShapePerimeterMeter perimeter = null;

            bool validInput = false;

            switch (shapeName.ToLower())
            {
                case "rectangle":
                    int width, height;

                    do
                    {
                        OutputProvider.WriteLine("Enter WIDTH of rectangle:");

                        if (!int.TryParse(InputProvider.ReadLine(), out width))
                        {
                            OutputProvider.WriteLine("Invalid input. Please enter a valid integer.");
                        }
                        else if (width <= 0)
                        {
                            OutputProvider.WriteLine("Invalid input. Please enter a positive integer.");
                        }
                        else
                        {
                            validInput = true;
                        }
                    } while (!validInput);

                    validInput = false;

                    do
                    {
                        OutputProvider.WriteLine("Enter HEIGHT of rectangle:");

                        if (!int.TryParse(InputProvider.ReadLine(), out height))
                        {
                            OutputProvider.WriteLine("Invalid input. Please enter an integer.");
                        }
                        else if (height <= 0)
                        {
                            OutputProvider.WriteLine("Invalid input. Height must be a positive integer.");
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
                        OutputProvider.WriteLine("Enter side length of square:");
                        if (!int.TryParse(InputProvider.ReadLine(), out side))
                        {
                            OutputProvider.WriteLine("Invalid input. Please enter an integer.");
                        }
                        else if (side <= 0)
                        {
                            OutputProvider.WriteLine("Invalid input. Side must be a positive integer.");
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
                    OutputProvider.WriteLine("Invalid shape name");
                    return;
            }

            if (area != null && perimeter != null)
            {
                OutputProvider.WriteLine($"\n{shapeName}: area is {area.GetArea()} and perimeter is {perimeter.GetPerimeter()}");
            }
        }
    }
}