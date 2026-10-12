using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Blue", 5);
        square.GetColor();
        square.GetArea();

        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("Black", 4));
        shapes.Add(new Rectangle("Red", 5, 6));
        shapes.Add(new Circle("Purple", 2.3));

        foreach(Shape shape in shapes)
        {
            double dimension = shape.GetArea();
            string color = shape.GetColor();
            Console.WriteLine($"The {color} shape has an area of {dimension}");
        }

    }
}