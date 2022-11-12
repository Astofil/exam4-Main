using exam4;
public class Circle : Shape //abstract insted of public
{
    public double _radius = 1.0;
    public Circle()
    {

    }
    public Circle(double radius)
    {

    }
    public Circle(double radius, Color color, bool filled) : base(color,filled)
    {
        this._radius=radius;
    }
    public double GetRadius()
    {
        return this._radius;
    }
    public override double GetArea()
    {
        return 3.14*_radius*_radius;
    }
    public override double GetPerimeter()
    {
        return 2*3.14*_radius;
    }
    public override string ToString()
    {
        return $"Circle[Shape[color={_color}, filled={_filled}], radius={_radius}]";
    }
}