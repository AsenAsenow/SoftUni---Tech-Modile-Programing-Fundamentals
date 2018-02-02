using System;

namespace CaloriesCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());
            int sumCalories = 0;
            for (int i = 1; i <= counter; i++)
            {

                int calories=0;
                string ingredients = Console.ReadLine().ToLower();
                if (ingredients.Equals("cheese"))
                {
                    calories = 500;
                }
                else if (ingredients.Equals("tomato sauce"))
                {
                    calories = 150;
                }
                else if (ingredients.Equals("salami"))
                {
                    calories = 600;
                }
                else if (ingredients.Equals("pepper"))
                {
                    calories = 50;
                }
                sumCalories += calories;
            }
            Console.WriteLine("Total calories: {0}", sumCalories);
        }
    }
}
