using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square = new Square("Red", 3);
        shapes.Add(square);

        Rectangle rectangle = new Rectangle("Blue", 4,5);
        shapes.Add(rectangle);

        Circle circle = new Circle("Green", 6);
        shapes.Add(circle);

        foreach (Shape shapes_ in shapes)
        {
            // Notice that all shapes have a GetColor method from the base class
            string color = shapes_.GetColor();

            // Notice that all shapes have a GetArea method, but the behavior is
            // different for each type of shape
            double area = shapes_.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }
}