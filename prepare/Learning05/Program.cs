using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> myShape = new List<Shape>();
        myShape.Add(new Square(7, "blue"));
        myShape.Add(new Rectangle(4, 2, "red"));
        myShape.Add(new Circle(9, "yellow"));

        foreach (Shape shape in myShape)
        {
            DisplayShape(shape);
        }
    }
    public static void DisplayShape(Shape shape)
    {
        Console.Write(shape.GetArea());
        Console.WriteLine(shape.GetColor());
    }
}