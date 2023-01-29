using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program");
        ProgramInst();
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
        // to catch any error from user's input
        try
        {
            int choice = int.Parse(Console.ReadLine());
             // Utilizing a switch...case...default to validate user input and to run program objects
            switch (choice)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    Console.Write("Thank you!");
                    System.Environment.Exit(0); // Proper exit from the program
                    break;
                // default to assist user in case of wrong input    
                default:
                    Console.WriteLine("Please, input a number from 1-5 to proceed");
                    break;                    
            }
        }

        catch (Exception e)
        {
            Console.WriteLine("Something went wrong! Try inputting a number from 1-5; see instruction above");
        }

        ProgramInst();
    }
}

/* 
To account for creativity on this Program.cs see the above comment
 other features exceeding requirements are:
 
 */