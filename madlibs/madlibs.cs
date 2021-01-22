using System;
using System.Data;

namespace Session11Day9Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write in a sentence you want and put [] around the words you want to change!");
            string template = Console.ReadLine();

            string insidethebracket = "";

            while(template.Contains(']'))
            {
                for (int i = 0; i < template.Length; i++)
                {
                    if (template[i] == '[')
                    {
                        insidethebracket = "";
                        i++;
                        while (template[i] != ']')
                        {
                            insidethebracket += template[i];
                            i++;
                        }
                        i = template.Length;
                    }
                }
                Console.WriteLine("Please give me a " + insidethebracket);
                string userInput = Console.ReadLine();
                template = template.Replace("[" + insidethebracket + "]", userInput);
            }
            Console.WriteLine(template);
        }
    }
}



/*
 string insideStaples = "";
 for (int i = 0; i < template.Length; i++)
 {
     if(i>startStaple && i<endStaple)
     {
         insideStaples = insideStaples + template[i];
     }
 }
*/
//get user input (forloop automatically enter the answer?)
//Console.WriteLine("Fill the brackets!");
//words[0] = Console.Read();


/*
string[] words = new string[3];
Console.WriteLine("Pick an animal!");
words[0] = (Console.ReadLine());
Console.WriteLine("Pick a noun!");
words[1] = (Console.ReadLine());
Console.WriteLine("Pick an adjective!");
words[2] = (Console.ReadLine());
string template = ("The care " + words[0] + " lived in a " + words[1] + " high in the clouds, where they have a lot of " + words[2] + " together");
Console.WriteLine(template);
*/