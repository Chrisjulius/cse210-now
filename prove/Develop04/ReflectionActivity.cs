using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _question = new List<string> 
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?", 
        "How did you get started?", 
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?", 
        "What is your favorite thing about this experience?", 
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?", 
        "How can you keep this experience in mind in the future?"        
    };

    private List<string> _prompt = new List<string> 
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    public ReflectionActivity(string duration, string activityName, string description) : base(duration, activityName, description)
    {

    }

    public ReflectionActivity()
    {

    }

    public void Reflect()
    {

    }

    public void GetPrompt()
    {

    }

    public void GetQuestion()
    {
        
    }

}