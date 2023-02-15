using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture stateRef = new Scripture();
        Console.WriteLine($"{stateRef.GetRenderRef()} {stateRef.GetRenderPassage()}");

        Console.WriteLine(@"
Please enter to continue or type 'quit' to finish:
");
        string userInput = Console.ReadLine();
        if (!(userInput == "quit"))
        {
            stateRef.clearWords(userInput);
        }

        else
        {
            System.Environment.Exit(0); 
        }
        
    }
}