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
            IArea area = null;
            IPerimeter perimeter = null;

            bool validInput = false;

            switch (shapeName.ToLower())
            {
                case "rectangle":
                    int width, height;

                    do
                    {
                        OutputProvider.WriteOutput("Enter WIDTH of rectangle:");

                        if (!int.TryParse(InputProvider.ReadInput(), out width))
                        {
                            OutputProvider.WriteOutput("Invalid input. Please enter a valid integer.");
                        }
                        else if (width <= 0)
                        {
                            OutputProvider.WriteOutput("Invalid input. Please enter a positive integer.");
                        }
                        else
                        {
                            validInput = true;
                        }
                    } while (!validInput);

                    validInput = false;

                    do
                    {
                        OutputProvider.WriteOutput("Enter HEIGHT of rectangle:");

                        if (!int.TryParse(InputProvider.ReadInput(), out height))
                        {
                            OutputProvider.WriteOutput("Invalid input. Please enter an integer.");
                        }
                        else if (height <= 0)
                        {
                            OutputProvider.WriteOutput("Invalid input. Height must be a positive integer.");
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
                        OutputProvider.WriteOutput("Enter side length of square:");
                        if (!int.TryParse(InputProvider.ReadInput(), out side))
                        {
                            OutputProvider.WriteOutput("Invalid input. Please enter an integer.");
                        }
                        else if (side <= 0)
                        {
                            OutputProvider.WriteOutput("Invalid input. Side must be a positive integer.");
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
                    OutputProvider.WriteOutput("Invalid shape name");
                    return;
            }

            if (area != null && perimeter != null)
            {
                OutputProvider.WriteOutput($"\n{shapeName}: area is {area.GetArea()} and perimeter is {perimeter.GetPerimeter()}");
            }
        }
    }
}