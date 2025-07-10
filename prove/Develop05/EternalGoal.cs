using System;

public class EternalGoal : BaseGoal
{
    private int _numberOfCompletions;

    public EternalGoal(string name, string description, int points, bool status, int completions)
    : base(name, description, points, status)
    {
        _numberOfCompletions = completions;
    }
    public EternalGoal() : base("","",0,false)
    {

    }
    public override void RunGoal()
    {
        throw new NotImplementedException();
    }
    public override string GetGoalType()
    {
        return base.GetGoalType();
    }
    public override int RecordEvent()
    {
        //throw new NotImplementedException();
        return GetPoints();
    }
    public override string ToString()
    {
        return base.ToString();
    }
    public override string ListGoal()
    {
        return base.ListGoal();
    }
}

