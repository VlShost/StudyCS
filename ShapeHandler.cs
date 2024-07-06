namespace shapes
{
    public class ShapeHandler
    {
        public static void HandleShape(string shapeName)
        {
            IArea area = null;
            IPerimeter perimeter = null;

            switch (shapeName.ToLower())
            {
                case "rectangle":
                    Console.WriteLine("Enter WIDTH of rectangle:");
                    int width = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter HEIGHT of rectangle:");
                    int height = int.Parse(Console.ReadLine());

                    Rectangle rectangle = new Rectangle(width, height);

                    area = rectangle;
                    perimeter = rectangle;
                    break;

                case "square":
                    Console.WriteLine("Enter side length of square:");
                    int side = int.Parse(Console.ReadLine());

                    Square square = new Square(side);

                    area = square;
                    perimeter = square;
                    break;

                default:
                    Console.WriteLine("Unknown shape");
                    return;
            }

            if (area != null && perimeter != null)
            {
                Console.WriteLine($"\n{shapeName}: area is {area.GetArea()} and perimeter is {perimeter.GetPerimeter()}");
            }
        }
    }
}