using System;
using System.Collections.Generic;

public class ListActivity : Activity
{
    private int _entryCount;
    
    public ListActivity(string activityName, string description) : base(activityName, description)
    {
        
    }

    public ListActivity()
    {
        _entryCount = 0;
    }

    public void Listing()
    {
        
    }
}