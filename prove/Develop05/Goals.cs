using System;
using System.ComponentModel.DataAnnotations;
public class Goals
{
    private List<BaseGoal> _goals;
    private string _fileName;
    private int _totalScore;
    public Goals()
    {
        _goals = new List<BaseGoal>();
        
        _totalScore = 0;
    }
    public void SaveGoals(string _fileName)
    {

    }
    public void LoadGoals()
    {

    }
    public void DisplayGoals()
    {

    }
    public void DisplayScore()
    {

    }
    public void RecordEvent()
    {

    }
    private void ObtainFileName(string prompt)
    {
        
    }
}
