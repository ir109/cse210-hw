using System;

class Program
{
    static void Main(string[] args)
    {
        //?
        int? x = 31;
        string? name = "el";

        //??
        int y = x ?? 23; //if x is null, uses y
        Console.WriteLine(y);

        name ??= "em"; //if name is null, uses e
        Console.WriteLine(name);

        //?.
        string myName = null;
        int? length = myName?.Length;
        Console.WriteLine(length);

        //?:
        int age1 = 23;
        int age2 = 32;
        string older = age1 > age2 ? "1 is older" : "2 is older";
        Console.WriteLine(older);
        //can be written in if/else
        if (age1 > age2)
            older = "1 is older";
        else
            older = "2 is older";
        Console.WriteLine(older);
    }
}
