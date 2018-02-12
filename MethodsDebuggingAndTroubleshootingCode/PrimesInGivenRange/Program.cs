using System;
using System.Collections.Generic;

namespace PrimesInGivenRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            Console.WriteLine(FindPrimesInRange(start, end));

        }

        static List<int> FindPrimesInRange(int start, int end)
        {
            int prime = 0;
            List<int> list = new List<int>();
            for (int i = start; i <= Math.Sqrt(end); i++)
            {
                if (end % i == 0)
                {
                    list.Add(i);
                }
            }
            return list;

        }
    }
}
