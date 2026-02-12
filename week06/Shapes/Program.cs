using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square(3, "Blue");

        //Console.WriteLine(square.GetColor());
        //Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("Blue", 2, 3);
        //Console.WriteLine(rectangle.GetColor());
        //Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("Blue", 2);
        //Console.WriteLine(circle.GetColor());
        //Console.WriteLine(circle.GetArea());

        List<Shapes> shapes = new List<Shapes>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shapes shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"Color: {color}\n Area: {area}");
        }
    }
}