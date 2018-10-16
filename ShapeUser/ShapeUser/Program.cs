namespace ShapeUser
{
    using System;
    using Shapes;

    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1);
            Console.WriteLine("Area={0}", c.Area());
        }
    }
}
