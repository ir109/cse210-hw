using System;
using System.Security.Cryptography.X509Certificates;
public abstract class BaseGoal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _status;
    protected string _goalType;

    public BaseGoal() {}
    public BaseGoal(string name, string description, int points, bool status)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = status;
    }
    public void DisplayName()
    {
        Console.WriteLine(_name);
    }
    public void DisplayDescription()
    {
        Console.WriteLine(_description);
    }
    public void DisplayPoints()
    {
        Console.WriteLine(_points);
    }
    public int GetPoints()
    {
        return _points;
    }
    public void MarkComplete()
    {
        _status = true;

    }
    public virtual string GetGoalType()
    {
        return _goalType;
    }
    public virtual string ListGoal()
    {
        return $"{_name} - {_description}";
    }
    public override string ToString()
    {
        return $"{_goalType}: {_name} \n{_description} \nPoints: {_points}";
    }
    public bool GetStatus()
    {
        return _status;
    }
    public abstract int RecordEvent();
    public abstract void RunGoal();
}

