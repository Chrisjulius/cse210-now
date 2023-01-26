using System;

class Program
{
    static void Main(string[] args)
    {
        ProgramInst();
        Console.Write("What would you like to do? ");
        Choices();
    }

    static void ProgramInst()
    {
        Console.WriteLine("Welcome to the Journal Program");
        // Utilizing a multiple line string for program instruction
        Console.WriteLine(@"Please Select one of the following choices:
        1. Write
        2. Display
        3. Load
        4. Save
        5. Quit");
    }

    static void Choices()
    {
        int choice = int.Parse(Console.ReadLine());
        do
        {
            if (choice == 5)
            {
                Environment.Exit(0);
            }
            else if (choice == 1)
            {

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
        } while (true);
    }
}

/* 
To account for creativity on this Program.cs see the above comment
 other features exceeding requirements are:
 
 */