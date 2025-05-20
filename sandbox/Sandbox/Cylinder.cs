using System;

public class Cylinder
{
    private Circle _circle;

    private double _height;

//  default constructor example
//  public Cylinder()
//  {
//      _height = 0;
//      _circle = null;
//  }

//  non-default constructor example
//  public Cylinder(Circle cirle)
//  {
//      _circle = circle;
//      _height = 0;
//  }
// or
//  non-default constructor example
//  public Cylinder(Double height, Circle cirle)
//  {
//      _circle = circle;
//      _height = height;
//  }
// or
//  non-default constructor example
//  public Cylinder(Double height, double radius)
//  {
//      _height = height
//      _circle = new Circle(radius);
//  }
//or
//  non-default constructor example
//  public Cylinder(Double height)
//  {
//      _circle = circle;
//      SetHeight(10);
//  }

    public void SetCircle(Circle circle)
    {
        _circle = circle;
    }
    public void SetHeight(double height)
    {
        _height = height;
    }

    public double GetVolume()
    {
        return _circle.GetArea() * _height; // Area of the base * height
    }
}
