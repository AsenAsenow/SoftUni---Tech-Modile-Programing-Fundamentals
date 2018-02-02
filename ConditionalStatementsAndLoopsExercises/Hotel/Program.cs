using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightCounter = int.Parse(Console.ReadLine());
            double studio = 0;
            double flatDouble = 0;
            double suite = 0;
            double totalStudio = 0;
            double totalDouble = 0;
            double totalSuite = 0;

            if (month.Equals("May")|| month.Equals("October"))
            {
                studio = 50;
                if (nightCounter > 7)
                {
                    studio = studio - (studio * 0.05);
                    
                    if (month.Equals("October"))
                    {
                        totalStudio = studio * (nightCounter - 1);
                    }
                    else
                    {
                        totalStudio = studio * nightCounter;
                    }

                }
                else
                {
                    totalStudio = studio * nightCounter;
                }
                
                
                flatDouble = 65;
                totalDouble = flatDouble * nightCounter;
                suite = 75;
                totalSuite = suite * nightCounter;
                
            }
            else if (month.Equals("June") || month.Equals("September"))
            {
                flatDouble = 72;
                if (nightCounter>14)
                {
                    flatDouble = flatDouble - (flatDouble * 0.10);
                    totalDouble = flatDouble * nightCounter;
                }
                else
                {
                    totalDouble = flatDouble * nightCounter;
                }
                studio = 60;

                if (month.Equals("September")&&nightCounter>7)
                {
                    totalStudio = studio * (nightCounter - 1);
                }
                else
                {
                    totalStudio = studio * nightCounter;
                }
                
                
                suite = 82;
                totalSuite = suite * nightCounter;
            }
            else if (month.Equals("July") || month.Equals("August")|| month.Equals("December"))
            {
                suite = 89;
                if (nightCounter>14)
                {
                    suite = suite - (suite * 0.15);
                    totalSuite = suite * nightCounter;
                }
                else
                {
                    totalSuite = suite * nightCounter;
                }
                studio = 68;
                totalStudio = studio * nightCounter;
                flatDouble = 77;
                totalDouble = flatDouble * nightCounter;

            }

            

            Console.WriteLine("Studio: {0:F2} lv.",totalStudio);
            Console.WriteLine("Double: {0:F2} lv.",totalDouble);
            Console.WriteLine("Suite: {0:F2} lv.",totalSuite);
        }
    }
}
