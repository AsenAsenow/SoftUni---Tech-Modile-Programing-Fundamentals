using System;

namespace TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long numberOfPictures = int.Parse(Console.ReadLine());
            int filterTime = int.Parse(Console.ReadLine());
            int filterFactor = int.Parse(Console.ReadLine());
            int updateTime = int.Parse(Console.ReadLine());


            double usefulPictures = numberOfPictures * filterFactor / 100.0;
          
            double totalUpload = Math.Ceiling(usefulPictures) * updateTime;
            double timeTotalPicture = numberOfPictures * filterTime;
            double totalTime = totalUpload + timeTotalPicture;

            Console.WriteLine(TimeSpan.FromSeconds(totalTime).ToString(@"d\:hh\:mm\:ss"));

            

        }
    }
}
