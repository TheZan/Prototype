namespace Prototype
{
    interface IShape
    {
        int X { get; set; }
        int Y { get; set; }
        string Color { get; set; }

        IShape Clone();
    }
}
