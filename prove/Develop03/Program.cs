using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture stateRef = new Scripture();
        Reference myRef = new Reference("Proverbs", 3, 5, 6);
        stateRef.newLine();
        
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

/*
Action performed to exceed requirement:
- random words selected are not repeated twice done in the Scripture class (Scripture.cs)
*/