public class Circle
{
    public double _radius;
    public const double pi=3.14;
    public Circle()
    {

    }
    public Circle(double radius)
    {
        this._radius=radius;
    }
    public double GetRadius()
    {
        return this._radius;
    }
    public void SetRadius(double radius)
    {
        this._radius=radius;
    }
    public double GetArea()
    {
        return pi*_radius*_radius;
    }
    public double GetCircumstance()
    {
        return 2*pi*_radius;
    }
    public override string ToString()
    {
        return $"Circle[radius={_radius}]";
    }
}