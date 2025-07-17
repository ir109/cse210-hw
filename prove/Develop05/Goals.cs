using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;
public class Goals
{
    private List<BaseGoal> goals = new List<BaseGoal>();
    private string _fileName;
    private int _totalScore;
    public Goals()
    {
        _totalScore = 0;
    }
    public void AddGoal(BaseGoal goal)
    {
        goals.Add(goal);
    }
    public void SaveGoals()
    {
        _fileName = ObtainFileName("Enter a file to save to (default 'develop05_goals.txt'): ");
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(_totalScore);
            foreach (BaseGoal goal in goals)
            {
                outputFile.WriteLine(goal.GetStringRep());
            }
        }
        Console.WriteLine($"Your goal has been saved to '{_fileName}'");
    }
    public void LoadGoals()
    {
        _fileName = ObtainFileName("Enter a file to load from (default 'develop05_goals.txt'): ");
        if (File.Exists(_fileName))
        {
            try
            {
                goals.Clear();
                string[] lines = File.ReadAllLines(_fileName);

                if (lines.Length > 0 && int.TryParse(lines[0], out int loadedScore))
                {
                    _totalScore = loadedScore;
                }
                else
                {
                    _totalScore = 0;
                    Console.WriteLine("Warning: Could not read or parse total score.");
                }
                for (int i = 1; i < lines.Length; i++)
                {
                    string line = lines[i];
                    string[] parts = line.Split('#');
                    if (parts.Length < 2)
                    {
                        Console.WriteLine($"Warning: Skipping malformed line during load: {line}");
                        continue;
                    }
                    string goalType = parts[0];
                    // string[] data = parts[1].Split("#");

                    BaseGoal loadedGoal = null;
                    try
                    {
                        switch (goalType)
                        {
                            case "SimpleGoal":
                                loadedGoal = (new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                                break;
                            case "EternalGoal":
                                loadedGoal = (new EternalGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5])));
                                break;
                            case "CheckListGoal":
                                loadedGoal = (new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])));
                                break;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"Error parsing data for goal type {goalType} in line: {line}. Details: {ex.Message}");
                    }
                    catch (IndexOutOfRangeException ex)
                    {
                        Console.WriteLine($"Error: not enough data parts for {goalType} in line {line}. Details: {ex.Message}");
                    }
                    if (loadedGoal != null)
                    {
                        goals.Add(loadedGoal);
                    }
                }
                Console.WriteLine($"Goals loaded from '{_fileName}'");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File '{_fileName}' not found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred while loading goals: {ex.Message}");
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
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].ListGoal()}");
            }
        }
        if (goals.Count == 0)
        {
            Console.WriteLine("There are no saved goals to display.");
            return;
        }
    }
    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_totalScore}");
    }
    public void RecordEvent()
    {
        if (goals.Count == 0)
        {
            Console.WriteLine("No goals to record for.");
        }
        Console.WriteLine("Which goal did you accomplish?");
        DisplayGoals();
        Console.Write("Enter the number of the goal: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index <= goals.Count && index > 0)
        {
            int earned = goals[index - 1].RecordEvent();
            _totalScore += earned;
            Console.WriteLine($"Points earned: {earned}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please try again.");
        }
    }
    private string ObtainFileName(string prompt)
    {
        Console.Write(prompt);
        string fileName = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(fileName))
        {
            return "develop05_goals.txt";
        }
        return fileName;
    }
}
