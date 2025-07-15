using System;
public class Menu
{
    public int DisplayMenu()
    {
        string menu =
@$"Selection:
1. Add Goal
2. Save Goal
3. Load Goal
4. Display Goals
5. Display Score
6. Record Event
0. Exit
";
        Console.WriteLine(menu);
        Console.Write("Enter your selection: ");
        int menuInput = int.Parse(Console.ReadLine());
        return menuInput;
    }
    public int DisplayCreateGoalMenu()
    {
        string menu =
@$"Selection:
1. Simple Goal
2. Eternal Goal
3. Check List Goal
";
        Console.WriteLine(menu);
        Console.Write("Select a new goal to create: ");
        int menuInput = int.Parse(Console.ReadLine());
        return menuInput;
    }
}
