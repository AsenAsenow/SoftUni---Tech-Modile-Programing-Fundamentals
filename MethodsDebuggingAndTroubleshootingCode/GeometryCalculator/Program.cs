using System;

namespace GeometryCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            PrintArea(figure);
        }

        private static void PrintArea(string figure)
        {
            switch (figure.ToLower())
            {
                case "triangle":
                    TriangleArea();
                    break;
                case "square":
                    SquareArea();
                    break;
                case "rectangle":
                    RectangleArea();
                    break;
                case "circle":
                    CircleArea();
                    break;
                default:
                    break;
            }
        }

        private static void CircleArea()
        {
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", Math.PI * (radius * radius));
        }

        private static void RectangleArea()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", width * height);
        }

        private static void SquareArea()
        {
            double side = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", side * side);
        }

        private static void TriangleArea()
        {
            double side = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2}", (side * height) / 2);
        }
    }
}
