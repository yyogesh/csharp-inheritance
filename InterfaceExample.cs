interface IPolygon
{
    void calculateArea(int l, int b);
}


class Rectangle1 : IPolygon
{
    public void calculateArea(int l, int b)
    {
        int area = l * b;
        Console.WriteLine("Area of Rectangle: " + area);
    }
}

interface IColor
{
    void getColor();
}

class Rectangle2 : IPolygon, IColor
{
    public void calculateArea(int l, int b)
    {
        int area = l * b;
        Console.WriteLine("Area of Rectangle: " + area);
    }

    public void getColor()
    {
        Console.WriteLine("Red Rectangle");
    }
}