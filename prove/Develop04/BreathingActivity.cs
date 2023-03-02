using System;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    public BreathingActivity(string activityName, string description) : base(activityName, description)
    {

    }

    public BreathingActivity()
    {

    }
    public void Breath()
    {
        SetActivityName("Breathing Activity");
        Console.WriteLine($"Welcome to the {GetActivityName()}.\n");

        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");

        Console.Write("How long, in seconds, would you like for your session? ");
        SetDuration(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready...");
        SpinnerPause();
        Console.WriteLine("\n");


        DateTime now = DateTime.Now;
        DateTime end = now.AddSeconds(GetDuration());
        while (DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            CountdownPause();

            Console.WriteLine("");
            Console.Write("Now breathe out... ");
            CountdownPause();
            Console.WriteLine("");
        }

        ConcludeMsg();


    }
}