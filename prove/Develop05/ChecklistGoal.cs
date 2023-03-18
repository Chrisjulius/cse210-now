using System;
using System.Collections.Generic;

public class ChecklistGoal : Goal
{
    private int _bonus;
    private int _done;
    private int _completed;

    public ChecklistGoal() : base()
    {
        _bonus = 0;
        _done = 0;
        _completed = 0;
    }

    public override void CreateGoal()
    {
        base.CreateGoal();
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _done = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override string ShowGoal()
    {
        return $"[ ] {GetGoalName()} ({GetDescription()}) - Completed {_completed}/{_done} times.";
    }

    public int GetDone()
    {
        return _done;
    }
    public int GetCompleted()
    {
        return _completed;
    }
}