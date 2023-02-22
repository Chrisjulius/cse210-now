using System;
using System.Collections.Generic;

public class Activity
{
    private string _duration;
    private string _activityName;
    private string _description;

    public Activity(string duration, string activityName, string description)
    {
        _duration = duration;
        _activityName = activityName;
        _description = description;
    }

    public Activity()
    {
        _duration = "";
        _activityName = "";
        _description = "";

    }

    public void SpinnerPause()
    {

    }

    public void CountdownPause()
    {
        
    }
}