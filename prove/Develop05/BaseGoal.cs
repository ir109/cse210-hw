using System;
using System.Security.Cryptography.X509Certificates;
public abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;

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
    public int MarkComplete()
    {
        return 0;
    }
    public virtual string GetGoalType()
    {
        return "";
    }
    public virtual string ListGoal()
    {
        return "";
    }
    public override string ToString()
    {
        return base.ToString();
    }
    public abstract int RecordEvent();
    public abstract void RunGoal();
}

