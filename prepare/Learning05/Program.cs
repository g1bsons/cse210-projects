using System;

class Program
{
    static void Main(string[] args)
    {
        Square mySquare = new Square("Purple", 4);
        Console.WriteLine(mySquare.GetColor());
        Console.WriteLine(mySquare.GetArea());

        Rectangle myRectangle = new Rectangle("Orange", 4, 6);
        Console.WriteLine(myRectangle.GetColor());
        Console.WriteLine(myRectangle.GetArea());

        Circle myCircle = new Circle("Green", 3);
        Console.WriteLine(myCircle.GetColor());
        Console.WriteLine(myCircle.GetArea());
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(mySquare);
        shapes.Add(myRectangle);
        shapes.Add(myCircle);

        foreach (Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }
    }
}