namespace exam4;
using exam4;
public class Square : Rectangle
{
    public double _side =1.0;
    public Square()
    {

    }
    public Square(double side)
    {

    }
    public Square(double side, double width, double length, Color color, bool filled) : base(width, length, color, filled)
    {
        this._side=side;
    }
    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        this._side=side;
    }
    // public override double GetArea()
    // {
    //     return _side*_side;
    // }
    // public override double GetPerimeter()
    // {
    //     return 4*_side;
    // }
    // public override string ToString()
    // {
    //     return $"Square[Rectangle[Shape[color={_color}, filled={_filled}],width={_width}, length={_length}]]";
    // }
}