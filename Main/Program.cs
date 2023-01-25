using System;
using FindAreaLib;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(3,4,5);
            Console.WriteLine(triangle.FindArea());
            Console.WriteLine(triangle.IsRectangular);
        }
    }
}
