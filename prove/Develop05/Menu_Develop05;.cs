using System;
public class Menu
{
    public int DisplayMenu()
    {
        int menuInput;
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
        do
        {
            Console.WriteLine(menu);
            menuInput = int.Parse(Console.ReadLine());
            switch (menuInput)
            {
                case 1:
                    Console.WriteLine("Case 1\n");
                    //add goal
                    break;
                case 2:
                    Console.WriteLine("Case 2\n");
                    //save
                    break;
                case 3:
                    Console.WriteLine("Case 3\n");
                    //load
                    break;
                case 4:
                    Console.WriteLine("Case 4\n");
                    //display goals
                    break;
                case 5:
                    Console.WriteLine("Case 5\n");
                    //display score
                    break;
                case 6:
                    Console.WriteLine("Case 6\n");
                    //record event
                    break;
                case 0:
                    Console.WriteLine("Exiting");
                    //exit
                    break;
                default:
                    Console.WriteLine("Invalid selection.\n");
                    break;
            }
        } while (menuInput != 0);
        return menuInput;
    }
        
    // public int DisplayCreateGoalMenu()
    // {

    // }
}
