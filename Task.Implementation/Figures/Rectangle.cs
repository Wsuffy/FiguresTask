using Task.Abstractions;
using Task.Utils.Exceptions;

namespace Task.Implementation.Figures;

public class Rectangle : IFigure
{
    private double _sideA;
    private double _sideB;

    public double SideA
    {
        get => _sideA;
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

    public Rectangle(double sideA, double sideB)
    {
        SideA = sideA;
        SideB = sideB;
    }

    public double CalculateArea()
    {
        return SideA * SideB;
    }
}