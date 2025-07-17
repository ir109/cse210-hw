using System;

public class SimpleGoal : BaseGoal
{
    public SimpleGoal()
    {
        _goalType = "SimpleGoal";
    }
    public SimpleGoal(string name, string description, int points, bool status)
    : base(name, description, points, status)
    {
        _goalType = "SimpleGoal";
    }
    public override void RunGoal()
    {
        Console.WriteLine("Running Simple Goal...");
    }
    public override int RecordEvent()
    {
        if (!_status)
        {
            MarkComplete();
            return GetPoints();
        }
        return 0;
    }
    public override string GetStringRep()
    {
        return $"{_goalType}#{_name}#{_description}#{_points}#{_status}";
    }
}
