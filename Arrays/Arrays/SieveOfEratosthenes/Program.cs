using System;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool[] arr = new bool[n + 1];
            arr[0] = arr[1] = false;

            for (int i = 2; i <= n; i++)
            {
                arr[i] = true;
            }

            for (int i = 0; i <= n; i++)
            {
                if (arr[i] == true)
                {
                    Console.Write(i + " ");

                    int p = i;
                    int multiplier = 1;
                    while (p <= n)
                    {
                        arr[p] = false;
                        multiplier++;
                        p = i * multiplier;
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
