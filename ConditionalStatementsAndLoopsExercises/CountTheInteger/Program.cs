using System;

namespace CountTheInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            try
            {
                while (true)
                {
                    int n = int.Parse(Console.ReadLine());
                    count++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(count);
            }
        }
    }
}
