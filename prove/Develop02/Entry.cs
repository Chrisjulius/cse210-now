using System;
using System.Collections.Generic;

public class Entry
{
    public Entry()
    {

    }

    public List<string> _entries = new List<string>();
    public string _entry = Console.ReadLine();

    public void Display()
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        promptGenerator.RandomPrompt();
    }
}