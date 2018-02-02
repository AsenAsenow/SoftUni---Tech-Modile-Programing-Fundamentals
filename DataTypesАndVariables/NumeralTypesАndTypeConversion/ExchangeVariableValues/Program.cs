using System;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = 0;
            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}", a);
            Console.WriteLine("b = {0}", b);

            c = a * b / b;
            a = a * b / a;
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}", c);
        }
    }
}
