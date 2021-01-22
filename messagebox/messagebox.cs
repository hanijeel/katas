using System;
using System.Reflection.Metadata;

namespace Session11Day4Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            string [] messages = new string[5];
            string answer = "start";
            int messageID = 0;

            while (answer != "c")
            {
                Console.WriteLine("Would you like to (a) store a message or (b) retrieve a message or (c) exit?");
                answer = Console.ReadLine();

                if (messageID == 4) //box is full
                {
                    Console.WriteLine("The message box is full. Try again later!");
                    answer = "c";
                }

                if (answer == "a") //store message
                {
                    Console.WriteLine("Write the message you want to store:");
                    messages[messageID] = Console.ReadLine();
                    Console.WriteLine("Your message ID is " + messageID + ".");
                    messageID++;
                }
                else if (answer == "b") //find message
                {
                    Console.WriteLine("What is the ID of the message you would like to restore?");
                    Console.WriteLine("Your message is: " + messages[(Convert.ToInt32(Console.ReadLine()))]);
                }
                else if (answer == "c")  //exit
                {
                    Console.WriteLine("Goodbye!");
                }
                else //catch errors
                {
                    Console.WriteLine( "You did not enter a valid answer. Try again?"); 
                }

            }

            /* This program allows users to enter either a message or request a message via ID
             * Users should be given a prompt to chose to enter or retrieve a message
             * If users enter a message, the ID of that message should be returned
             * If an ID is entered under retrieve, the message should be displayed
             * 
             * Example:
             * Would you like to a) store a message or b) retrieve a message or c) exit?
             * > a
             * Enter the message you would like to store
             * > Hello there
             * Your message ID is 3
             * Would you like to a) store a message or b) retreive a message or c) exit?
             * > b
             * What message ID would you like to see?
             * > 3
             * The message is: Hello there
             * Would you like to a) store a message or b) retreive a message or c) exit?
             * 
             * /*
Array: message[]
int messageNumber = 0;

while(variable == true) //not accurate
Console.WriteLine("Select A, B, C"){
string answer = Console.readline();

if answer == a{
switch:
    1) Write a message (store)
        messageNumber = something?
        Console.writeline("put stuff here, yo.");
        message[] = console.readline();
}
else if answer == b{

    2) retrieve/ read message

        Console.writeline("What message ID would you like?");
        answer = Console.readline();
        messageNumber = convert.toInt32(answer);
        Console.write("The message is: ");
        Console.writeline(message[messageNumber]);

}
else if answer == c{
    3) Exit

}
else {
Console.writeline("Come on, friend, work with me here.");
 }
 
 */


        }
    }
}
