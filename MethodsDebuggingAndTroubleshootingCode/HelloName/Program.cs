using System;

namespace HelloName
{
    class Program
    {
        static void Main(string[] args)
        {
            string enterName = Console.ReadLine();
            
            Console.WriteLine("Hello, {0}!", printName(enterName));    
        }

        static string printName(string name)
        {
            return name;
        }
        
    }
}
