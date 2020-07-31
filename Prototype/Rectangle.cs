namespace Prototype
{
    class Rectangle : IShape
    {
        public Rectangle() { }

        public Rectangle(int x, int y, string color, int width, int height)
        {
            X = x;
            Y = y;
            Color = color;
            Width = width;
            Height = height;
        }

        public Rectangle(Rectangle source)
        {
            X = source.X;
            Y = source.Y;
            Color = source.Color;
            Width = source.Width;
            Height = source.Height;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public string Color { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public IShape Clone() => new Rectangle(this);

        public override string ToString() => $"Circle: X-{X} | Y-{Y} | Color-{Color} | Width-{Width} | Height-{Height}";
    }
}
