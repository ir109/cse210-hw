using System;

public class Running : Activity
{
    private double _distanceKm;

    public Running(DateTime date, int minutes, double distanceKm)
    : base(date, minutes)
    {
        _distanceKm = distanceKm;
    }
    public override double GetDistance()
    {
        return _distanceKm;
    }
    public override double GetSpeed()
    {
        return _distanceKm / GetMinutes() * 60;
    }
    public override double GetPace()
    {
        return GetMinutes() / _distanceKm;
    }
}
