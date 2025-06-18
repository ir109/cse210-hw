class Circle : Shape
{
    private double _radius;

    public Circle(double radius, string color)
    : base(color)
    {
        _radius = radius;
    }
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}