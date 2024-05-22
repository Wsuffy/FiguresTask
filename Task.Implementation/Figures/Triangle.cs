using Task.Abstractions;
using Task.Utils.Exceptions;

namespace Task.Implementation.Figures;

public class Triangle : IFigure
{
    private double _sideA;
    private double _sideB;
    private double _sideC;

    public double SideA
    {
        get { return _sideA; }
        private set
        {
            if (value <= 0)
                throw new TaskExceptionWithLog("Side length must be positive");
            _sideA = value;
        }
    }

    public double SideB
    {
        get => _sideB;
        private set
        {
            if (value <= 0)
                throw new TaskExceptionWithLog("Side length must be positive");
            _sideB = value;
        }
    }

    public double SideC
    {
        get => _sideC;
        private set
        {
            if (value <= 0)
                throw new TaskExceptionWithLog("Side length must be positive");
            _sideC = value;
        }
    }

    public Triangle(double sideA, double sideB, double sideC)
    {
        _sideA = sideA;
        _sideB = sideB;
        _sideC = sideC;
        
        if (!IsValidTriangle())
        {
            throw new TaskExceptionWithLog("You try to create wrong triangle");
        }
    }

    public double CalculateArea()
    {
        var halfPerimeter = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
    }

    public bool IsRightAngeled()
    {
        var sideList = new List<double> { SideA, SideB, SideC };
        sideList.Sort();

        if (Math.Pow(sideList[0], 2) + Math.Pow(sideList[1], 2) == Math.Pow(sideList[2], 2))
            return true;

        return false;
    }

    private bool IsValidTriangle()
    {
        return SideA + SideB > SideC && SideA + SideC > SideB && SideB + SideC > SideA;
    }
}