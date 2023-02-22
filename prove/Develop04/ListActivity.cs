using System;
using System.Collections.Generic;

public class ListActivity : Activity
{
    private int _entryCount;
    
    public ListActivity(int entryCount, string duration, string activityName, string description) : base(duration, activityName, description)
    {
        _entryCount = entryCount;
    }

    public ListActivity()
    {
        _entryCount = 0;
    }

    public void Listing()
    {
        
    }
}