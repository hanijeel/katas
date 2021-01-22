using System;

namespace PaintBucket
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius you want?");
            int radius = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("What color of paint do you want? Choose one from red, blue, green, or yellow.");
            string color = Console.ReadLine().ToLower();

            int BucketCoverage = 100;
            int BucketPrice = 25;

            if(color == "red")
            {
               BucketCoverage = 100;
               BucketPrice = 25;
            }
            if(color == "blue")
            {
                BucketCoverage = 120;
                BucketPrice = 28;
            }
            if (color == "green")
            {
                BucketCoverage = 90;
                BucketPrice = 33;
            }
            if (color == "yellow")
            {
                BucketCoverage = 70;
                BucketPrice = 22;
            }

            double area = Math.PI * radius * radius;
            double numOfBuckets = Math.Ceiling(area / BucketCoverage);
            double totalPrice = numOfBuckets * BucketPrice;

            Console.WriteLine("You will need " + numOfBuckets + " buckets of " + color + " paint.");
            Console.WriteLine("It will cost $" + totalPrice + " in total.");
        }
    }
}
