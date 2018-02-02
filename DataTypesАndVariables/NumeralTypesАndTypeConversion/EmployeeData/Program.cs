using System;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            byte age = byte.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long uniqueNumber = long.Parse(Console.ReadLine());
            int personalID = int.Parse(Console.ReadLine());
            Console.WriteLine("First name: {0}",firstName);
            Console.WriteLine("Last name: {0}",lastName);
            Console.WriteLine("Age: {0}",age);
            Console.WriteLine("Gender: {0}",gender);
            Console.WriteLine("Personal ID: {0}",uniqueNumber);
            Console.WriteLine("Unique Employee number: {0}",personalID);
           
        }
    }
}
