using System;
using System.Collections.Generic;

public class Goal
{
    private int _score;
    private string _goalType;
    private string _goalName;
    private string _description;

    public Goal()
    {
        _goalType = "";
        _goalName = "";
        _score = 0;
        _description = "";
    }

    public virtual void CreateGoal()
    {
        Console.Write("What is the name of your goal? ");
        _goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        _description = Console.ReadLine();
        Console.Write("What is the amount of point associated with this goal? ");
        _score = int.Parse(Console.ReadLine());
    }

    public virtual string ShowGoal()
    {
        return $"[ ] {_goalName} ({_description}).";
    }

    public virtual string GoalDetails()
    {
        return $"{_goalType}:{_goalName},{_description},{_score}";
    }

    public void SetGoalType(string goaltype)
    {
        _goalType = goaltype;
    }
    public string GetGoalType()
    {
        return _goalType;
    }

    public string GetGoalName()
    {
        return _goalName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetScore()
    {
        return _score.ToString();
    }
}