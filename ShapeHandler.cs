namespace shapes
{
    public class ShapeHandler
    {
        public static void HandleShape(string ShapeName)
        {
            IShape shape = null;

            switch (ShapeName.ToLower())
            {
                case "rectangle":
                    Console.WriteLine("Enter WIDTH of rectangle:");
                    int width = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter HEIGHT of rectangle:");
                    int height = int.Parse(Console.ReadLine());

                    shape = new Rectangle(width, height);
                    break;

                case "square":
                    Console.WriteLine("Enter side length of square:");
                    int side = int.Parse(Console.ReadLine());

                    shape = new Square(side);
                    break;

                default:
                    Console.WriteLine("Unknown shape");
                    return;
            }

            if (shape != null)
            {
                Console.WriteLine($"\n{shape}: area is {shape.GetArea()} and perimeter is {shape.GetPerimeter()}");
            }
        }
    }
}