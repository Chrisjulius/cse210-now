using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal instanceJournal = new Journal();
        List<string> entry = new List<string>();
        Console.WriteLine("Welcome to the Journal Program");
        
        while (true)
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
                        PromptGenerator promptGenerator = new PromptGenerator();
                        string prompt = promptGenerator.RandomPrompt();
                        Console.Write(prompt);

                        string userEntry = Console.ReadLine();

                        DateTime theCurrentTime = DateTime.Now;
                        string dateText = theCurrentTime.ToShortDateString();

                        string line = @$"Date: {dateText} - Prompt: {prompt}\n{userEntry}\n";
                        entry.Add(line);
                        break;
                    case 2:
                        foreach (string item in entry)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 3:
                        Console.Write("Enter in the name of the file as (.txt): ");
                        instanceJournal._loadFile = Console.ReadLine();
                        instanceJournal.Read();
                        break;
                    case 4:
                        Console.Write("What will you save the file as (.txt): ");
                        instanceJournal._saveFile = Console.ReadLine();
                        instanceJournal.Write(entry);
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
                Console.WriteLine("Something went wrong! Please follow the instructions.");
            }
        }
        
        
    }
}

/* 
To account for creativity on this Program.cs see the above comment
 other features exceeding requirements are:
 
 */