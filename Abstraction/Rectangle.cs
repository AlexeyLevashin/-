using System;

namespace Abstraction
{
    public class Rectangle:Shape
    {
        public int height {  get; set; }
        public int width { get; set; }
        public override double GetArea()
        {
            return height*width;
        }
    }
}
