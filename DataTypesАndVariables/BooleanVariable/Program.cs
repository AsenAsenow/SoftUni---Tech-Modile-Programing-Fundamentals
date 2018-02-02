using System;

namespace BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isBool = bool.Parse(Console.ReadLine());
            if (isBool)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
