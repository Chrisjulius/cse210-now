using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Scripture stateRef = new Scripture();
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