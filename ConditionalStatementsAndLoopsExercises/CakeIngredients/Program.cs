using System;

namespace CakeIngredients
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            
            bool isBool = true;

              while (isBool)
              {

                string ingredients = Console.ReadLine();
                if (ingredients.Equals("Bake!"))
                  {
                      Console.WriteLine("Preparing cake with {0} ingredients.", counter);
                    isBool=false;
                  }
                  else
                  {
                      Console.WriteLine("Adding ingredient {0}.", ingredients);
                      counter++;
                    continue;

                  }


              }
         
        }
    }
}
