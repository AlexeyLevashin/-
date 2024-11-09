using System;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Площадь круга:");
            circle.Radius = 10;
            Console.WriteLine (circle.GetArea());

            Console.WriteLine("Площадь прямоугольника:");
            rectangle.height = 10;
            rectangle.width = 10;
            Console.WriteLine(rectangle.GetArea());

            Console.ReadLine();
        }
    }
}
