using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public PromptGenerator()
    {

    }

    public List<string> _prompt = new List<string>()
    {
        "Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", 
        "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", 
        "If I had one thing I could do over today, what would it be?",
        "What are you grateful for today?",
        "What lesson did you learn from today?"
    };
    
    public string RandomPrompt()
    {
        Random prompt = new Random();
        //String formatting to output random prompt
        string output = String.Format("{0}\n> ", _prompt[prompt.Next(0, _prompt.Count)]);
        return output;
    }
}