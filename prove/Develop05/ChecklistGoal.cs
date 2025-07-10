using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;


public class ChecklistGoal : BaseGoal
{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;
    public ChecklistGoal(string name, string description, int points, bool status, int completions, int max, int bonus)
    : base(name, description, points, status)
    {
        _numberOfCompletions = completions;
        _maxGoals = max;
        _bonusPoints = bonus;
    }
    public ChecklistGoal() : base("","",0,false)
    {

    }
    public override void RunGoal()
    {
        throw new NotImplementedException();
    }
    public override int RecordEvent()
    {
        // throw new NotImplementedException();
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
    private void ObtainMaxGoal()
    {

    }
    private void ObtainBonusPoints()
    {
        
    }
}
