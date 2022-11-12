namespace exam4;

    public enum Color
    {
         red,
         white,
         black
    }

abstract class Shape
{
    
    protected bool _filled=true;
    protected Color _color;
    public Shape()
    {

    }
    public Shape(Color color, bool filled)
    {
        this._color=color;
        this._filled=filled;
    }
    public Color GetColor()
    {
        return _color;
    }
    public void SetColor(Color color)
    {
        this._color=color;
    }
    public abstract double GetArea();
    public abstract double GetPerimeter();
    public override string ToString()
    {
        return $"Shape[color={_color}, filled={_filled}]";
    }

}


