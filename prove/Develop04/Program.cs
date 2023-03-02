using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine(@"Menu Options:
    1. Start breathing activity
    2. Start reflecting activity
    3. Start listing activity
    4. Quit");

            Console.Write("Select a choice from the menu: ");
            string selection = Console.ReadLine();
            Console.Clear();
            ProgramSelection(selection);
        }
        
    }

    static void ProgramSelection(string selection)
    {
        ListActivity mindfulList = new ListActivity();
        ReflectionActivity mindfulReflect = new ReflectionActivity();
        BreathingActivity mindfulBreathing = new BreathingActivity();

        try
        {
            switch (selection)
            {
                case "1":
                    mindfulBreathing.Breath();
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    System.Environment.Exit(0);
                    break;

            }
        }

        catch (Exception)
        {
            Console.WriteLine("Please try again and follow the instruction.");
        }    
    }
}