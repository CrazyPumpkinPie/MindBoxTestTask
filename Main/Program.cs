using System;
using FindAreaLib;

namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(8);
            Console.WriteLine(circle.FindArea());
        }
    }
}
