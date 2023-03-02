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

    private List<int> _promptIndex = new List<int>();
    private List<int> _questionIndex = new List<int>();

    public ReflectionActivity()
    {

    }

    public void Reflection()
    {   
        CommenceMsg("Breathing Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");

        Console.WriteLine("Consider the following prompt:\n\n");
        Console.WriteLine(GetPrompt());
        Console.WriteLine("\n");

        Reflect();
    }

    private void Reflect()
    {
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string next = Console.ReadLine();

        if (next == "")
        {
            Console.Write(@"Now ponder on each of the following questions as they are related to this experience.
You may begin in: ");
            CountdownPause();
            Console.Clear();

            DateTime now = DateTime.Now;
            DateTime end = now.AddSeconds(GetDuration());
            while (DateTime.Now < end)
            {
                Console.Write($"> {GetQuestion()}");
                SpinnerPause(15);
                Console.WriteLine("");
            }

            ConcludeMsg();
        }
        else
        {
            Reflect();
        }
    }

    private string GetPrompt()
    {
        Random prompt = new Random();
        int randomIndex;
        randomIndex = prompt.Next(0, _prompt.Count);

        do
        {
            if (!(_promptIndex.Contains(randomIndex)))
            {
                if (_promptIndex.Count == _prompt.Count)
                {
                    _promptIndex.Clear();
                }
                    _promptIndex.Add(randomIndex);
            }
            else
            {
                randomIndex = prompt.Next(0, _prompt.Count);
            }
        } while (!(_promptIndex.Contains(randomIndex)));
        

        //String formatting to output random prompt
        string output = String.Format("--- {0} ---", _prompt[randomIndex]);
        return output;
    }

    private string GetQuestion()
    {
        Random prompt = new Random();
        int randomIndex;
        randomIndex = prompt.Next(0, _question.Count);

        do
        {
            if (!(_questionIndex.Contains(randomIndex)))
            {
                if (_questionIndex.Count == _question.Count)
                {
                    _questionIndex.Clear();
                }
                    _questionIndex.Add(randomIndex);
            }
            else
            {
                randomIndex = prompt.Next(0, _question.Count);
            }
        } while (!(_questionIndex.Contains(randomIndex)));
        

        //String formatting to output random prompt
        string output = String.Format("{0}", _question[randomIndex]);
        return output;
    }

}