using System;

class Program
{
    static void TestByRef(ref int x, ref string n)
    {
        x++;
        n += " plus a ";
        Console.WriteLine($"In TestByRef: {x}, {n}");
    }
    static void TestByOut(out int a)
    {
        a = 121;
        Console.WriteLine($"In TestByOut: a = {a}");
    }
    static void Main(string[] args)
    {
        int z = 10;
        string name = "e";

        TestByRef(ref z, ref name);
        Console.WriteLine($"In main: {z}, {name}");

        name += "i";
        TestByRef(ref z, ref name);
        Console.WriteLine($"In main: {z}, {name}");

        int c;
        TestByOut(out c);
        Console.WriteLine($"In Main: c = {c}");
    }
}
