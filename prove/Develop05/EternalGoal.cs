using System;

public class EternalGoal : BaseGoal
{
    private int _numberOfCompletions;

    public EternalGoal()
    {
        _goalType = "EternalGoal";
    }
    public EternalGoal(string name, string description, int points, bool status, int completions)
    : base(name, description, points, status)
    {
        _goalType = "EternalGoal";
        _numberOfCompletions = completions;
    }
    public override void RunGoal()
    {
        Console.WriteLine("Running Eternal Goal...");
    }
    // public override string GetGoalType()
    // {
    //     return base.GetGoalType();
    // }
    public override int RecordEvent()
    {
        _numberOfCompletions++;
        return GetPoints();
    }
}

