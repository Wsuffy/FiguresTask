namespace FigureExample.Figure;

public class Circle : IFigure
{
    public readonly double Radius;

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("You try to create wrong circle, your radius is less or equal 0",
                nameof(radius));
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}