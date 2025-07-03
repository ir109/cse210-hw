namespace Develop05;

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
        return int.Parse(Console.ReadLine());
    }
    public int DisplayCreateGoalMenu()
    {

    }
}
