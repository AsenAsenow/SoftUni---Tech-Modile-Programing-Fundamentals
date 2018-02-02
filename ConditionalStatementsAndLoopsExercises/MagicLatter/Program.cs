using System;
using System.Text;

namespace MagicLatter
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char noPrint = char.Parse(Console.ReadLine());

            int firstConvert = Convert.ToInt32(first);
            int secondConvert = Convert.ToInt32(second);
            int noPrintConvert = Convert.ToInt32(noPrint);


            for (int i = firstConvert; i <= secondConvert; i++)
            {
                for (int j = firstConvert; j <= secondConvert; j++)
                {
                    for (int k = firstConvert; k <= secondConvert; k++)
                    {
                        if (i==noPrintConvert||j==noPrintConvert||k==noPrintConvert)
                        {
                            continue;
                        }
                        else
                        {
                            Console.Write("{0}{1}{2} ",Convert.ToChar(i), Convert.ToChar(j), Convert.ToChar(k));
                        }
                    }
                }
            }




        }
    }
}
