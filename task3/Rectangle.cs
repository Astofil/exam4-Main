// namespace exam4;
using exam4;
public class Rectangle : Shape //abstract instead of public
{
    protected double _width = 1.0;
    protected double _length = 1.0;
    public Rectangle()
    {

    }
    public Rectangle(double width, double length)
    {

    }
    public Rectangle(double width, double length, Color color, bool filled) : base(color, filled)
    {
        this._width=width;
        this._length=length;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        this._width=width;
    }
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        this._length=length;
    }
    public override double GetArea()
    {
        return _width*_length;
    }
    public override double GetPerimeter()
    {
        return 2*(_width+_length);
    }
    public override string ToString()
    {
        return $"Rectangle[Shape[color={_color}, filled={_filled}], width={_width}, length={_length}]";
    }
}