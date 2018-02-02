using System;

namespace ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string professions = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double totalPrice = 0;


            switch (professions)
            {
                case "Athlete":
                   totalPrice= quantity * 0.70;
                    break;
                case "Businessman":
                    totalPrice = quantity * 1.00;
                    break;
                case "Businesswoman":
                    totalPrice = quantity * 1.00;
                    break;
                case "SoftUni Student":
                    totalPrice = quantity * 1.70;
                    break;
                default:
                    totalPrice = quantity * 1.20;
                    break;
            }

            Console.WriteLine("The {0} has to pay {1:F2}.", professions, totalPrice);


        }
    }
}
