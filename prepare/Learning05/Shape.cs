public abstract class Shape
{
    private string_color;

    public Shape(string color)
    {
        _color = color;
    }

    public string Getcolor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();

}