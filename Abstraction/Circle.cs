using System;

namespace Abstraction
{
    public class Circle:Shape
    {
        public int Radius {  get; set; }
        public override double GetArea()
        {
            return 3.14 * Math.Pow(Radius,2);
        }
    }
}
