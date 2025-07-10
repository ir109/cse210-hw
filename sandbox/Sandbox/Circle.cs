// using System;

// public class Circle
// {
//     private double _radius; //can only be used in "class Circle"

//     //default constructor examole
//     //public Circle()
//     //{
//     //  _radius = 0.0;
//     //}

//     //non-default constructor example
//     //public Circle(double radius)
//     //{
//     //  SetRadius(radius);
//     //}

//     public void SetRadius(double radius) //gives parameters to be used outside of "class Circle"
//     {
//         if(radius < 0)
//         {
//             Console.WriteLine("Error. Radius must be > 0");
//             return;
//         }
//         _radius = radius; //"_radius" is the attribute, "radius" is the parameter
//     }
//     public double GetRadius()
//     {
//         return _radius;
//     }
//     public double GetArea()
//     {
//         return Math.PI * _radius * _radius;
//     }
// }