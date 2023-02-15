using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Scripture stateRef = new Scripture();
        Console.WriteLine($"{stateRef.GetRenderRef()} {stateRef.GetRenderPassage()}");

        Console.WriteLine(@"
Please enter to continue or type 'quit' to finish:
");
        
        while (true)
        {
            string userInput = Console.ReadLine();
            if (userInput == "")
            {
                stateRef.clearWords(userInput);
            }

            else if (userInput == "quit")
            {
                System.Environment.Exit(0); 
            }
        }
    }
}