using System;

namespace NeighbourWars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshoDemage = int.Parse(Console.ReadLine());
            int goshoDemage = int.Parse(Console.ReadLine());
            int demagePesho = 100;
            int demageGosho = 100;
            string attackMenPesho = "Pesho";
            string attackMenGosho = "Gosho";
            string peshoAttack = "Roundhouse kick";
            string goshoAttack = "Thunderous fist";


            for (int i = 1; i <= int.MaxValue; i++)
            {
                if (i % 2 == 0)
                {
                    demagePesho -= goshoDemage;
                    if (demagePesho <= 0)
                    {
                        Console.WriteLine($"{attackMenGosho} won in {i}th round.");
                        return;
                        
                    }
                    else
                    {
                        Console.WriteLine("{0} used " +
                    "{1} and reduced" +
                    " {2}" +
                    " to {3} health.", attackMenGosho, goshoAttack, attackMenPesho, demagePesho);
                    }
                }
                else
                {
                    demageGosho -= peshoDemage;
                    if (demageGosho <= 0)
                    {
                        Console.WriteLine($"{attackMenPesho} won in {i}th round.");
                        return;
                        
                    }
                    else
                    {
                        Console.WriteLine("{0} used " +
                    "{1} and reduced" +
                    " {2}" +
                    " to {3} health.", attackMenPesho, peshoAttack, attackMenGosho, demageGosho);
                        
                    }
                }

                if (i % 3 == 0)
                {
                    demagePesho += 10;
                    demageGosho += 10;
                }

               

            }

        }
    }
}
