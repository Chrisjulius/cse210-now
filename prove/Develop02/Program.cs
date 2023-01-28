using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");
        ProgramInst();
        
        while (true)
        {
            if (choice == 5)
            {
                Environment.Exit(0);
            }
            else if (choice == 1)
            {
                //Instance of the PromptGenerator
                 PromptGenerator prompt = new PromptGenerator();
                prompt.RandomPrompt();
            }
            else if (choice == 2)
            {

            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {
                
            }

            else
            {
                // Additional instruction incase of wrong input
                Console.WriteLine("Please, try to enter from 1-5");
            }
        }
    }

    static void ProgramInst()
    {
        // Utilizing a multiple line string for program instruction
        Console.Write(@"Please Select one of the following choices:
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit
        What would you like to do? ");
        int choice = int.Parse(Console.ReadLine());
        if (choice < 1 || choice > 5)
        {
            Console.WriteLine("Please, try to enter from 1-5");
        }

        
        ProgramInst();
    }
}

/* 
To account for creativity on this Program.cs see the above comment
 other features exceeding requirements are:
 
 */