using System;
class Circle
{
    private double _radius; //can only be used in "class Circle"
    public void SetRadius(double radius) //can be used outside of "class Circle"
    {
        if(radius < 0)
        {
            Console.WriteLine("Error. Radius must be > 0");
            return;
        }
        _radius = radius; //"_radius" is the attribute, "radius" os the parameter
    }
    public double GetRadius()
    {
        return _radius;
    }
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Circle myCircle = new Circle(); //compiles a new circle
        myCircle.SetRadius(5);
        Console.WriteLine($"Radius 1 = {myCircle.GetRadius()}");

        Circle myCircle2 = new Circle(); //compiles a new circle
        myCircle2.SetRadius(20);
        Console.WriteLine($"Radius 2 = {myCircle2.GetRadius()}");

        Console.WriteLine($"Area 1 = {myCircle.GetArea()}");
        Console.WriteLine($"Area 2 = {myCircle2.GetArea()}");
    }
}
