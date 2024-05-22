using Task.Abstractions;

namespace Task.Implementation.Figures;

public class Triangle : IFigure
{
    public readonly double SideA;

    public readonly double SideB;

    public readonly double SideC;

    public Triangle(double sideA, double sideB, double sideC)
    {
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;

        if (!IsValidTriangle())
            throw new ArgumentException("You try to create wrong triangle, the sum of 2 side more then 3-rd",
                $"{nameof(sideA)} or {nameof(sideB)} or {nameof(sideC)}");
    }

    public double CalculateArea()
    {
        var halfPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
    }

    public bool IsRightAngele()
    {
        var sideList = new List<double>(3) { SideA, SideB, SideC };
        sideList.Sort();

        return Math.Pow(sideList[0], 2) + Math.Pow(sideList[1], 2) == Math.Pow(sideList[2], 2);
    }

    private bool IsValidTriangle() => SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
}