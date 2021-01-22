using System;
using System.Diagnostics.Tracing;

namespace FizzBuzz
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
        }
    }
}
