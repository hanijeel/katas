using System;

namespace GardenBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of your garden box?");
            string length = Console.ReadLine();

            Console.WriteLine("What is the width of your garden box?");
            string width = Console.ReadLine();
            
            int area = Convert.ToInt32(length) * Convert.ToInt32(width);
            Console.WriteLine("The area of your garden box is " + area + " square.");
            
            int perimeter = (Convert.ToInt32(length) + Convert.ToInt32(width)) *2;
            Console.WriteLine("The perimeter of your garden box is " + perimeter + ".");
            
            Console.WriteLine("You can plant " + (area * 16)/16 + " carrots, "+ 
               (area * 3)/16 + " corns, or " + (area * 9)/16 + " beets in your garden box.");
        }
    }
}
