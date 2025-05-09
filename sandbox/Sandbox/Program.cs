using System;

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

        Cylinder myCylinder = new Cylinder(); //compiles a new cylinder
        myCylinder.SetHeight(10);
        myCylinder.SetCircle(myCircle); //sets the circle for the cylinder
        Console.WriteLine($"Volume of cylinder: {myCylinder.GetVolume()}"); //compiles the volume of the cylinder
        myCylinder.SetCircle(myCircle2); //sets the circle for the cylinder
    }
}
