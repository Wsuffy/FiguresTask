using Task.Abstractions;
using Task.Utils.Exceptions;

namespace Task.Implementation.Figures;

public class Circle : IFigure
{
    private double _radius;

    public double Radius
    {
        get => _radius;
        private set
        {
            if (value <= 0)
                throw new TaskExceptionWithLog("Radius must be positive");
            _radius = value;
        }
    }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}