using System;
using System.Collections.Generic;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {

    }
    public void Breath()
    {
        CommenceMsg("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");

        DateTime now = DateTime.Now;
        DateTime end = now.AddSeconds(GetDuration());
        while (DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            CountdownPause();

            Console.WriteLine("\n");
            Console.Write("Now breathe out... ");
            CountdownPause();
            Console.WriteLine("\n");
        }

        ConcludeMsg();


    }
}