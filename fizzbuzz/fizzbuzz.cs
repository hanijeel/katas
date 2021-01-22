using System;
using System.Diagnostics.Tracing;

namespace Session11Day3Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int counter = 1; counter <= 100; counter = counter +1)
            {
                if(counter % 15 == 0)
                {
                    Console.WriteLine("FizzBuzz"); 
                }
                else if(counter % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (counter %5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(counter);
                }
             }

            int number = 1;
            while ( number <= 100)
            {
                if ( number % 15 == 0)
                { 
                    Console.WriteLine("FizzBuzz"); 
                }
                else if (number % 3 == 0)
                { 
                    Console.WriteLine("Fizz"); 
                }
                else if (number % 5 == 0)
                { 
                    Console.WriteLine("Buzz"); 
                }
                else 
                { 
                    Console.WriteLine(number); 
                }

                number = number + 1;
            }

            //string x = "yes";
            //while (x == "yes")
            //{
            //    Console.WriteLine("Which month were you born? Choose a number from 01 to 12.");
            //    int month = Convert.ToInt32(Console.ReadLine());
            //    while (month < 01 || month > 12)
            //    {
            //        Console.WriteLine("You did not enter a valid number. Try again?");
            //        month = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.WriteLine("What day were you born on? Choose an answer from 01 to 31.");
            //    int day = Convert.ToInt32(Console.ReadLine());
            //    while (day < 01 || day > 31)
            //    {
            //        Console.WriteLine("You did not enter a valid number. Try again?");
            //        day = Convert.ToInt32(Console.ReadLine());
            //    }

            //    string season = "";
            //    if ((month == 03 && day >= 15) || (month == 04) || (month == 05) || (month == 06 && day <= 14))  //from 03/15 to 06/14
            //    { season = "spring"; }
            //    else if ((month == 06 && day >= 15) || (month == 07) || (month == 08) || (month == 09 && day <= 14))  //from 06/15 to 09/14
            //    { season = "summer, just like me"; }
            //    else if ((month == 09 && day >= 15) | (month == 10) || (month == 11) || (month == 12 && day <= 14))  //from 09/15 to 12/14
            //    { season = "fall"; }
            //    else if ((month == 12 && day >= 15) || month == 01 || month == 02 || (month == 03 && day <= 14)) //from 12/15 to 03/14
            //    { season = "winter"; }

            //    Console.WriteLine("You were born in " + season + "!");
            //    Console.WriteLine("Do you want to re-do? Answer yes or no");
            //    x = Console.ReadLine().ToLower();
            //}

        }
    }
}
