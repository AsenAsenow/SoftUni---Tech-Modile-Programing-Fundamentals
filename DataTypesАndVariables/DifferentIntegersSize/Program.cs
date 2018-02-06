using System;

namespace DifferentIntegersSize
{
    class Program
    {

        static void Main(string[] args)
        {

            string number = Console.ReadLine();



            try
            {
                if (sbyte.Parse(number) > sbyte.MinValue && sbyte.Parse(number) < sbyte.MaxValue)
                {
                    Console.WriteLine($"{number} can fit in: ");
                    Console.WriteLine("* sbyte");
                    Console.WriteLine("* short");
                    Console.WriteLine("* int");
                    Console.WriteLine("* long");
                }
            }
            catch (Exception)
            {

                try
                {
                    if (byte.Parse(number) > byte.MinValue && byte.Parse(number) < byte.MaxValue)
                    {
                        Console.WriteLine($"{number} can fit in: ");
                        Console.WriteLine("* byte");
                        Console.WriteLine("* ushort");
                        Console.WriteLine("* int");
                        Console.WriteLine("* uint");
                        Console.WriteLine("* long");
                    }
                }
                catch (Exception)
                {

                    try
                    {
                        if (short.Parse(number) > short.MinValue && short.Parse(number) < short.MaxValue)
                        {
                            Console.WriteLine($"{number} can fit in: ");
                            Console.WriteLine("* short");
                            if (short.Parse(number) > 0)
                            {
                                Console.WriteLine("* ushort");
                            }
                            Console.WriteLine("* int");
                            if (short.Parse(number) > 0)
                            {
                                Console.WriteLine("* uint");
                            }
                            Console.WriteLine("* long");
                        }
                    }
                    catch (Exception)
                    {

                        try
                        {
                            if (ushort.Parse(number) > ushort.MinValue && ushort.Parse(number) < ushort.MaxValue)
                            {
                                Console.WriteLine($"{number} can fit in: ");
                                Console.WriteLine("* short");
                                Console.WriteLine("* int");
                                Console.WriteLine("* uint");
                                Console.WriteLine("* long");
                            }
                        }
                        catch (Exception)
                        {

                            try
                            {
                                if (int.Parse(number) > int.MinValue && int.Parse(number) < int.MaxValue)
                                {
                                    Console.WriteLine($"{number} can fit in: ");
                                    Console.WriteLine("* int");
                                    if (int.Parse(number) > 0)
                                    {
                                        Console.WriteLine("* uint");
                                    }

                                    Console.WriteLine("* long");
                                }
                            }
                            catch (Exception)
                            {

                                try
                                {
                                    if (uint.Parse(number) > uint.MinValue && uint.Parse(number) < uint.MaxValue)
                                    {
                                        Console.WriteLine($"{number} can fit in: ");

                                        Console.WriteLine("* uint");


                                        Console.WriteLine("* long");
                                    }
                                }
                                catch (Exception)
                                {

                                    try
                                    {
                                        if (long.Parse(number) > long.MinValue && long.Parse(number) < long.MaxValue)
                                        {
                                            Console.WriteLine($"{number} can fit in: ");
                                            Console.WriteLine("* long");
                                        }
                                    }
                                    catch (Exception)
                                    {

                                        Console.WriteLine($"{number} can't fit in any type");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
