using System;
using System.Diagnostics.Tracing;
using System.Threading;

namespace Session11Day6Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How much did the item cost?");
            double cost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("How much did the customer pay?");
            double paid = Convert.ToDouble(Console.ReadLine());

            double change = Math.Round((paid - cost), 2);
            Console.WriteLine("They get " + change + " in change.");

            string giveBack = "";
            int counter = 0;

            while (change >= 100)
            {
                change -= 100;
                counter++;
            }
                if (counter > 1)
                {
                    giveBack = counter + " hundreds, ";
                }
                else if (counter == 1)
                {
                    giveBack = counter + " hundred, ";
                }
                counter = 0;

            if (change >= 50)
            {
                change -= 50;
                giveBack += "1 fifty, ";
            }
            while (change >= 20)
            {
                change -= 20;
                counter++;
            }
                if (counter == 2)
                {
                    giveBack = counter + " twenties, ";
                }
                else if (counter == 1)
                {
                    giveBack = counter + " twenty, ";
                }
                 counter = 0;

            if (change >= 10)
            {
                change = change - 10;
                giveBack += "1 ten, ";
            }

            if (change >= 5)
            {
                change = change - 5;
                giveBack += "1 five, ";
            }

            while (change >= 1)
            {
                change -= 1;
                counter++;
            }
                if (counter > 1)
                {
                    giveBack = giveBack + counter + " one(s), ";
                }
                else if (counter == 1)
                {
                    giveBack = giveBack + counter + " one, "; 
                }
                counter = 0;
            
            while (change >= 0.25)
            {
               
                change = change - .25;
                counter++;
            }
                if ( counter > 1)
                {
                    giveBack = giveBack + counter + " quarters, ";
                }
                else if (counter == 1)
                {
                    giveBack = giveBack + counter + " quarter, ";
                }
                counter = 0;

            while (change >= 0.10)
            {
                change = change - .10;
                counter++;
            }
                if(counter > 1)
                {
                    giveBack = giveBack + counter + " dimes, ";
                }
                else if (counter == 1)
                {
                    giveBack = giveBack + counter + " dime, ";
                }
                counter = 0;

            if (change >= 0.05)
            {
                change = change - .05;
                giveBack += " 1 nickel, ";
            }

            while (change >= .01)
            {
                change = change - .01;
                counter++;
            }
                if (counter > 1)
                {
                    giveBack = giveBack + counter + " pennies";
                }
                else if (counter == 1)
                {
                    giveBack = giveBack + counter + " penny";
                }

            Console.WriteLine("Give them " + giveBack+".");
            



           /*
            Console.WriteLine("Enter a sentence you want to convert to morse code.");
            string message = Console.ReadLine().ToLower();
            string mMessage = "";

            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == 'a')
                {
                    mMessage += ".- ";
                }
                else if (message[i] == 'b')
                {
                    mMessage += "-... ";
                }
                else if (message[i] == 'c')
                {
                    mMessage += "-.-. ";
                }
                else if (message[i] == 'd')
                {
                    mMessage += "-.. ";
                }
                else if (message[i] == 'e')
                {
                    mMessage += ". ";
                }
                else if (message[i] == 'f')
                {
                    mMessage += "..-. ";
                }
                else if (message[i] == 'g')
                {
                    mMessage += "--. ";
                }
                else if (message[i] == 'h')
                {
                    mMessage += ".... ";
                }
                else if (message[i] == 'i')
                {
                    mMessage += ".. ";
                }
                else if (message[i] == 'j')
                {
                    mMessage += ".--- ";
                }
                else if (message[i] == 'k')
                {
                    mMessage += "-.- ";
                }
                else if (message[i] == 'l')
                {
                    mMessage += ".-.. ";
                }
                else if (message[i] == 'm')
                {
                    mMessage += "-- ";
                }
                else if (message[i] == 'n')
                {
                    mMessage += "-. ";
                }
                else if (message[i] == 'o')
                {
                    mMessage += "--- ";
                }
                else if (message[i] == 'p')
                {
                    mMessage += ".--. ";
                }
                else if (message[i] == 'q')
                {
                    mMessage += "--.- ";
                }
                else if (message[i] == 'r')
                {
                    mMessage += ".-. ";
                }
                else if (message[i] == 's')
                {
                    mMessage += "... ";
                }
                else if (message[i] == 't')
                {
                    mMessage += "- ";
                }
                else if (message[i] == 'u')
                {
                    mMessage += "..- ";
                }
                else if (message[i] == 'v')
                {
                    mMessage += "...- ";
                }
                else if (message[i] == 'w')
                {
                    mMessage += ".-- ";
                }
                else if (message[i] == 'x')
                {
                    mMessage += "-..- ";
                }
                else if (message[i] == 'y')
                {
                    mMessage += "-.-- ";
                }
                else if (message[i] == 'z')
                {
                    mMessage += "--.. ";
                }
                else if (message[i] == '1')
                {
                    mMessage += ".---- ";
                }
                else if (message[i] == '2')
                {
                    mMessage += "..--- ";
                }
                else if (message[i] == '3')
                {
                    mMessage += "...-- ";
                }
                else if (message[i] == '4')
                {
                    mMessage += "....- ";
                }
                else if (message[i] == '5')
                {
                    mMessage += "..... ";
                }
                else if (message[i] == '6')
                {
                    mMessage += "-.... ";
                }
                else if (message[i] == '7')
                {
                    mMessage += "--... ";
                }
                else if (message[i] == '8')
                {
                    mMessage += "---.. ";
                }
                else if (message[i] == '9')
                {
                    mMessage += "----. ";
                }
                else if (message[i] == '0')
                {
                    mMessage += "----- ";
                }
                else if (message[i] == ' ')
                {
                    mMessage += "  ";
                }
                else if (message[i] == '.')
                {
                    mMessage += "   ";
                }
                else 
                {
                    mMessage += ""; 
                }
            }
            Console.Write("The message is: " + mMessage);
           */
        } 
    }
}
