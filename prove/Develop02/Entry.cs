using System;
using System.Collections.Generic;

public class Entry
{
    public Entry()
    {

    }
    PromptGenerator promptGenerator = new PromptGenerator();

    public void Display()
    {
       promptGenerator.RandomPrompt();
    }
}