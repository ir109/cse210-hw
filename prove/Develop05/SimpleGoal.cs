using System;

public class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points, bool status)
    : base(name, description, points, status) { }
    public SimpleGoal() : base("","",0,false)
    {
        
    }
    public override void RunGoal()
    {
        //throw new NotImplementedException();
    }
    public override int RecordEvent()
    {
        //throw new NotImplementedException();
        return GetPoints();
    }
    
}
