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
        _fileName = ObtainFileName("Enter a file to save to: ");
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(_totalScore);
            foreach (BaseGoal goal in goals)
            {
                outputFile.WriteLine(goal.ToString());
            }
        }
        Console.WriteLine($"Your goal has been saved to {_fileName}");
    }
    public void LoadGoals()
    {
        _fileName = ObtainFileName("Enter a file to load from: ");
        if (File.Exists(_fileName))
        {
            goals.Clear();
            string[] lines = File.ReadAllLines(_fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split('#');
                // if (parts.Length != 2)
                // {
                //     continue;
                // }
                string goalType = parts[0];
                string[] data = parts[1].Split("#");
                switch (goalType)
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
        else
        {
            Console.WriteLine($"\nFile '{_fileName}' not found\n");
        }
    }
    public void DisplayGoals()
    {
        if (goals.Count != 0)
        {
            int i = 1;
            foreach (BaseGoal goal in goals)
            {
                Console.WriteLine($"{i}. {goal.ListGoal()}");
                i++;
            }
        }
        else
        {
            Console.WriteLine("There are no saved goals to display.");
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
    private string ObtainFileName(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }
}
