using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
public class Goals
{
    private List<BaseGoal> goals = new List<BaseGoal>();
    private string _fileName;
    private int _totalScore;
    public void AddGoal(BaseGoal goal)
    {
        goals.Add(goal);
    }
    public void SaveGoals()
    {
        Console.Write("Enter a file name to save: ");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (BaseGoal goal in goals)
                outputFile.WriteLine(goal.ToString());
        }
    }
    public void LoadGoals()
    {
        if (File.Exists(_fileName))
        {
            Console.Write("Enter a file name to load: ");
            string[] lines = File.ReadAllLines(_fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('#');
                string[] data = parts[1].Split(";");
                switch (parts[0])
                {
                    case "SimpleGoal":
                        goals.Add(new SimpleGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3])));
                        break;
                    case "EternalGoal":
                        goals.Add(new EternalGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3]), int.Parse(data[4])));
                        break;
                    case "CheckListGoal":
                        goals.Add(new ChecklistGoal(data[0], data[1], int.Parse(data[2]), bool.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6])));
                        break;
                }
            }
        }
    }
    public void DisplayGoals()
    {
        int i = 1;
        foreach (BaseGoal goal in goals)
        {
            Console.WriteLine($"{i}. {goal.ListGoal()}");
            i++;
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_totalScore}");
    }
    public void RecordEvent()
    {
        Console.WriteLine("Which goal did you accomplish?");
        DisplayGoals();
        if (int.TryParse(Console.ReadLine(), out int index) && index <= goals.Count && index > 0)
        {
            int earned = goals[index - 1].RecordEvent();
            _totalScore += earned;
            Console.WriteLine($"Points earned: {earned}");
        }
    }
    // private string ObtainFileName(string fileName)
    // {
    //     _fileName = fileName;
    // }
}
