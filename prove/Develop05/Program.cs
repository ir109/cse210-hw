using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Goals goals = new Goals();

        bool running = true;
        while (running)
        {
            int menuInput = menu.DisplayMenu();
            switch (menuInput)
            {
                case 1:
                    int goalType = menu.DisplayCreateGoalMenu();
                    Console.Write("Name of goal: ");
                    string name = Console.ReadLine();
                    Console.Write("Write a short description of this Goal: ");
                    string description = Console.ReadLine();
                    Console.Write("Enter the number of points for this goal: ");
                    int points = int.Parse(Console.ReadLine());
                    switch (goalType)
                    {
                        case 1:
                            goals.AddGoal(new SimpleGoal(name, description, points, false));
                            break;
                        case 2:
                            goals.AddGoal(new EternalGoal(name, description, points, false, 0));
                            break;
                        case 3:
                            Console.Write("Enter the maximum number of goals: ");
                            int max = int.Parse(Console.ReadLine());
                            Console.Write("Enter the number of bonus points that will be received: ");
                            int bonus = int.Parse(Console.ReadLine());
                            goals.AddGoal(new ChecklistGoal(name, description, points, false, 0, max, bonus));
                            break;
                        default:
                            Console.WriteLine("Invalid input. Please try again.");
                            break;
                    }
                    break;
                case 2:
                    goals.SaveGoals();
                    break;
                case 3:
                    goals.LoadGoals();
                    break;
                case 4:
                    goals.DisplayGoals();
                    break;
                case 5:
                    goals.DisplayScore();
                    break;
                case 6:
                    goals.RecordEvent();
                    break;
                case 0:
                    Console.WriteLine("Goodbye.");
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    break;
            } while (menuInput != 0);
        }
    }
}