using System;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";

            object objH = hello;
            object objW = world;
            Console.WriteLine("{0} {1}",objH,objW);
        }
    }
}
