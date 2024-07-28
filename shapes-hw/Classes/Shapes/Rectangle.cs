using shapes_hw.Interfaces;

namespace shapes_hw.Classes.Shapes
{
    public class Rectangle : IShapeAreaMeter, IShapePerimeterMeter
    {
        public int SideX { get; set; }
        public int SideY { get; set; }

        public Rectangle(int width, int height)
        {
            SideX = width;
            SideY = height;
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