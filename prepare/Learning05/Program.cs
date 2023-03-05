using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 2);
        Console.WriteLine(square.GetColor());
        Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("Blue", 2, 4);
        Console.WriteLine(rectangle.GetColor());
        Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("White", 5);
        Console.WriteLine(circle.GetColor());
        Console.WriteLine(circle.GetArea());
        Console.WriteLine("\n");

        List<Shape> anyShape = new List<Shape>();
        anyShape.Add(new Circle("White", 5));
        anyShape.Add(new Rectangle("Red", 2, 3));
        anyShape.Add(new Square("Blue", 4));

        foreach (Shape shape in anyShape)
        {
            string colors = shape.GetColor();
            double areas = shape.GetArea();
            
            Console.WriteLine(colors);
            Console.WriteLine(areas);
            Console.WriteLine("\n");
        }

    }
}