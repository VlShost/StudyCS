using shapes_hw.Interfaces;

namespace shapes_hw.Classes.Shapes
{
    public class Rectangle : IShapeAreaMeter, IShapePerimeterMeter
    {
        public int SideX { get; init; }
        public int SideY { get; init; }
        public int Area { get; private set; }
        public int Perimeter { get; private set; }

        public Rectangle()
        {
            SideX = 0;
            SideY = 0;
            Area = 0;
            Perimeter = 0;
        }

        public Rectangle(int width, int height)
        {
            SideX = width;
            SideY = height;
            Area = GetArea();
            Perimeter = GetPerimeter();
        }

        public int GetArea()
        {
            return SideX * SideY;
        }

        public int GetPerimeter()
        {
            return (SideX + SideY) * 2;
        }
    }
}