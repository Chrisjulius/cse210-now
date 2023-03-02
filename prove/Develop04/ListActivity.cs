using System;
using System.Collections.Generic;

public class ListActivity : Activity
{
    private int _entryCount;
    private List<int> _promptIndex = new List<int>();
    private List<string> _prompt = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };
    
    public ListActivity(string activityName, string description) : base(activityName, description)
    {
        
    }

    public ListActivity()
    {
        _entryCount = 0;
    }

    public void Listing()
    {
        CommenceMsg("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(GetPrompt());
        Console.Write("You may begin in: ");
        CountdownPause();
        Console.WriteLine("");

        DateTime now = DateTime.Now;
        DateTime end = now.AddSeconds(GetDuration());
        while (DateTime.Now < end)
        {
            Console.Write("> ");
            Console.ReadLine();
            _entryCount++;
        }
        Console.WriteLine($"You listed {_entryCount} items!\n\n");

        ConcludeMsg();
    }

    private string GetPrompt()
    {
        Random prompt = new Random();
        int randomIndex;
        randomIndex = prompt.Next(0, _prompt.Count);

        do
        {
            if (!(_promptIndex.Contains(randomIndex)))
            {
                if (_promptIndex.Count == _prompt.Count)
                {
                    _promptIndex.Clear();
                }
                    _promptIndex.Add(randomIndex);
            }
            else
            {
                randomIndex = prompt.Next(0, _prompt.Count);
            }
        } while (!(_promptIndex.Contains(randomIndex)));
        

        //String formatting to output random prompt
        string output = String.Format("--- {0} ---", _prompt[randomIndex]);
        return output;
    }
}