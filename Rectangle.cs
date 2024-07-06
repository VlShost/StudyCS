﻿namespace shapes
{
    public class Rectangle : IShape
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