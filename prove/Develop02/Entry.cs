using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public class Entry
{
    public string Prompt;
    public string UserEntry;
    public string EntryDate;
    public Entry(string Prompt, string UserEntry, string EntryDate)
    {
        this.Prompt = Prompt;
        this.UserEntry = UserEntry;
        this.EntryDate = EntryDate;
    }
}