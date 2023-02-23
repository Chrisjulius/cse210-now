using System;
using System.Collections.Generic;

public class Activity
{
    private string _duration;
    private string _activityName;
    private string _description;

    public Activity(string activityName, string description)
    {
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

    public string SetDuration(string set)
    {
        _duration = set;
        return _duration;
    }

    public string GetDuration()
    {
        return _duration;
    }
}