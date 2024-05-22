using Task.Utils.Exceptions;

namespace Task.Abstractions;

public interface IFigure
{
    public virtual double CalculateArea()
    {
        throw new TaskExceptionWithLog("This method is not implemented");
    }
}