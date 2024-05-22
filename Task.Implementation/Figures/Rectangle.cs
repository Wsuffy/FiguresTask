using Task.Abstractions;

namespace Task.Implementation.Figures;

public class Rectangle : IFigure
{
    public readonly double SideA;

    public readonly double SideB;

    public Rectangle(double sideA, double sideB)
    {
        SideA = sideA;
        SideB = sideB;
        if (sideA <= 0 || sideB < 0)
            throw new ArgumentException("You try to create wrong circle, your radius is less or equal 0",
                $"{nameof(sideA)} or {nameof(sideB)}");
    }

    public double CalculateArea()
    {
        return SideA * SideB;
    }
}