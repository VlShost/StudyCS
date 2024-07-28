using shapes_hw.Interfaces;

namespace shapes_hw.Classes.Shapes
{
    public class Square : IArea, IPerimeter
    {
        public int Side { get; set; }

        public Square(int side)
        {
            Side = side;
        }

        public int GetArea()
        {
            return Side * Side;
        }

        public int GetPerimeter()
        {
            return 4 * Side;
        }
    }
}