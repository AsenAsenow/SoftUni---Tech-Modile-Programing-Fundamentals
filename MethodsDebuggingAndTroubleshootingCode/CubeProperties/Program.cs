using System;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string figurе = Console.ReadLine();

            switch (figurе)
            {
                case "face":
                    CalculateFace(a,figurе);
                    break;
                case "space":
                    CalculateSpace(a, figurе);
                    break;
                case "volume":
                    CalculatVolume(a, figurе);
                    break;
                case "area":
                    CalculateArea(a, figurе);
                    break;
                default:
                    break;
            }

        }

        static void CalculateFace(double a, string figure)
        {          
            Console.WriteLine("{0:f2}", Math.Sqrt(2 * (a * a)));
        }

        static void CalculateSpace(double a, string figure)
        {           
            Console.WriteLine("{0:f2}", Math.Sqrt(3 * (a * a)));
        }

        static void CalculatVolume(double a, string figure)
        {
            Console.WriteLine("{0:f2}", a * a * a);
        }

        static void CalculateArea(double a, string figure)
        {
            Console.WriteLine("{0:f2}", 6 * (a * a));
        }
    }
}
