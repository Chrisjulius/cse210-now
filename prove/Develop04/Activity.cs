using System;
using System.Collections.Generic;

public class Activity
{
    private int _duration;
    private string _activityName;
    private string _description;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public Activity()
    {
        _duration = 0;
        _activityName = "";
        _description = "";

    }

    public void SpinnerPause()
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(5);

        int i = 0;

        while (DateTime.Now < end)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;
            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public void CountdownPause()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void SetDuration(string set)
    {
        _duration = int.Parse(set);
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    public string GetActivityName()
    {
        return _activityName;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }


}