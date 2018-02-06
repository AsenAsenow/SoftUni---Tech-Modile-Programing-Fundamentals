using System;

namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int enter = int.Parse(Console.ReadLine());

            Console.WriteLine(Fib(enter));

        }

        static float Fib(float n)
        {
            float first = 0;
            float second = 1;
            float third = 0;
            if (n == 0)
            {
                third = 1;
                return third;
            }
            for (float i = 1; i <= n; i++)
            {
               
                third = first + second;
                first = second;
                second = third;
               
            }

            return third;
        }
    }
}
