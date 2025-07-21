using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    public DateTime GetDate()
    {
        return _date;
    }
    public int GetMinutes()
    {
        return _minutes;
    }
    public virtual double GetDistance()
    {
        return 0;
    }
    public virtual double GetSpeed()
    {
        return 0;
    }
    public virtual double GetPace()
    {
        return 0;
    }
    public virtual string GetSummary()
    {
        return $"{_date:yyyy MM dd} {GetType().Name} ({_minutes} min): " + $"Distance: {GetDistance():0.0} km\nSpeed: {GetSpeed():0.0} kph\nPace: {GetPace():0.00} min per km\n";
    }
}
