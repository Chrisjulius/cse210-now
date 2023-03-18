using System;
using System.Collections.Generic;

class Program
{

    static void Main(string[] args)
    {
        LoadSave currentscore = new LoadSave();
        Console.WriteLine(currentscore.GetTotalScore());

        SimpleGoal simpleGoal = new SimpleGoal();
        EternalGoal eternalGoal = new EternalGoal();
        ChecklistGoal checklistGoal = new ChecklistGoal();
        LoadSave loadSave = new LoadSave();
        List<string> listGoal = new List<string>();
        List<string> saveGoal = new List<string>(){
            currentscore.GetTotalScore().ToString()
        };

        while (true)
        {
            Console.WriteLine();
            Console.Write($@"You have {currentscore.GetTotalScore()} points.
        
Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Event
    6. Quit
Select a choice from the menu: ");
            if (saveGoal.Count() > 0)
            {
                saveGoal[0] = currentscore.GetTotalScore().ToString();
            }
            string choice = Console.ReadLine();
            Console.WriteLine();
            Menu(choice);

            void Menu(string choice)
            {
                try
                {
                    switch(choice)
                    {
                        case "1":
                            Console.Write(@"The types of Goals are:
    1. Simple Goal
    2. Eternal Goal
    3. Checklist Goal
Which type of goal would you like to create? ");
                            string selection = Console.ReadLine();
                            Console.WriteLine();
                            if (selection == "1")
                            {
                                simpleGoal.SetGoalType("Simple Goal");
                                simpleGoal.CreateGoal();
                                listGoal.Add($"{listGoal.Count()+1}. {simpleGoal.ShowGoal()}");
                                saveGoal.Add($"{simpleGoal.GoalDetails()}");

                            }
                            else if (selection == "2")
                            {
                                eternalGoal.SetGoalType("Eternal Goal");
                                eternalGoal.CreateGoal();
                                listGoal.Add($"{listGoal.Count()+1}. {eternalGoal.ShowGoal()}");
                                saveGoal.Add($"{eternalGoal.GoalDetails()}");
                            }
                            else if (selection == "3")
                            {
                                checklistGoal.SetGoalType("Checklist Goal");
                                checklistGoal.CreateGoal();
                                listGoal.Add($"{listGoal.Count()+1}. {checklistGoal.ShowGoal()}");
                                saveGoal.Add($"{checklistGoal.GoalDetails()}");
                            }
                            break;
                        case "2":
                            foreach (string goal in listGoal)
                            {
                                Console.WriteLine(goal);
                            }
                            break;
                        case "3":
                            loadSave.WriteGoal(saveGoal);
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                        case "6":
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
    }
}