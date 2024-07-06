namespace shapes
{
    public class Square : IShape
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