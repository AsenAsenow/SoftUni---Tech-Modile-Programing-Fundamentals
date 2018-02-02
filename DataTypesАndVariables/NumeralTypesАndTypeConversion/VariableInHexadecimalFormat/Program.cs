using System;

namespace VariableInHexadecimalFormat
{
    class Program
    {
        static void Main(string[] args)
        {
            string hexNum = Console.ReadLine();
           
            
            Console.WriteLine(Convert.ToInt32(hexNum,16));
        }
    }
}
