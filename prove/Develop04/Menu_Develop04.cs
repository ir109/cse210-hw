using System;

public class Menu 
{
    public int DisplayMenu()
    {
        
        string menu = 
@"Select an exersize:
1. Breathing Activity
2. Reflection Activity
3. Listing Activity
0. Exit program";
        Console.WriteLine(menu);
        return int.Parse(Console.ReadLine());
    }
}
