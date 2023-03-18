using System;
using System.Collections.Generic;

public class SimpleGoal : Goal
{
    private bool _completed;
    public SimpleGoal() : base()
    {
        _completed = false;
    }

    public override string GoalDetails()
    {
        return $"{GetGoalType()}:{GetGoalName()},{GetDescription()},{GetScore()},{_completed}";
    }

}