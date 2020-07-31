namespace Prototype
{
    class Circle : IShape
    {
        public Circle() { }

        public Circle(int x, int y, string color, int radius)
        {
            X = x;
            Y = y;
            Color = color;
            Radius = radius;
        }

        public Circle(Circle source)
        {
            X = source.X;
            Y = source.Y;
            Color = source.Color;
            Radius = source.Radius;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }
        public int Radius { get; set; }

        public IShape Clone() => new Circle(this);

        public override string ToString() => $"Circle: X-{X} | Y-{Y} | Color-{Color} | Radius-{Radius}";
    }
}
