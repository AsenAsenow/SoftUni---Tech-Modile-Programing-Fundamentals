using System;

namespace RestaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string discount = Console.ReadLine();
            string hallName = null;
            int price = 0;
            double discountProcent = 0;
            int discountPrice = 0;
            

            

            if (countOfPeople<0||countOfPeople>120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                if (countOfPeople > 0 && countOfPeople <= 50)
                {
                    hallName = "Small Hall";
                    price = 2500;
                }
                else if (countOfPeople > 50 && countOfPeople <= 100)
                {
                    hallName = "Terrace";
                    price = 5000;
                }
                else if (countOfPeople > 100 && countOfPeople <= 120)
                {
                    hallName = "Great Hall";
                    price = 7500;
                }


                if (discount.Equals("Normal"))
                {
                    discountProcent = 0.05;
                    discountPrice = 500;
                }
                else if (discount.Equals("Gold"))
                {
                    discountProcent = 0.10;
                    discountPrice = 750;
                }
                else if (discount.Equals("Platinum"))
                {
                    discountProcent = 0.15;
                    discountPrice = 1000;
                }

                double totalPrice = price + discountPrice;
                double totalDiscount = totalPrice - (totalPrice * discountProcent);
                double totalPersonPrice = totalDiscount / countOfPeople;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine("The price per person is {0:F2}$", totalPersonPrice);
            }

            


        }
    }
}
