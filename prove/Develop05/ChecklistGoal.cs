using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;


public class ChecklistGoal : BaseGoal
{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;

    public ChecklistGoal()
    {
        _goalType = "CheckListGoal";
    }
    public ChecklistGoal(string name, string description, int points, bool status, int completions, int max, int bonus)
    : base(name, description, points, status)
    {
        _numberOfCompletions = completions;
        _maxGoals = max;
        _bonusPoints = bonus;
    }
    public override void RunGoal()
    {
        Console.WriteLine("Running Checklist Goal...");
    }
    public override int RecordEvent()
    {
        _numberOfCompletions++;
    
        _numberOfCompletions++;
        if (_numberOfCompletions >= _maxGoals)
        {
            MarkComplete();
            return GetPoints() + _bonusPoints;
        }
    
        return GetPoints();
    }
    public override string ToString()
    {
        return $"{_goalType}:{_name},{_description},{_points},{_numberOfCompletions},{_maxGoals},{_bonusPoints}";
    }
    public override string ListGoal()
    {
        return $"{_name} ({_numberOfCompletions}/{_maxGoals})";
    }
}
