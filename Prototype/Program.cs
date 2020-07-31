using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(100, 210, "Black", 30, 50);
            Console.WriteLine(rectangle);

            Circle circle = new Circle(10, 20, "Red", 5);
            Console.WriteLine(circle);

            var cloneCircle = circle.Clone();
            Console.WriteLine(cloneCircle);

            var cloneRectangle = rectangle.Clone();
            Console.WriteLine(cloneRectangle);

            Console.ReadKey();
        }
    }
}
