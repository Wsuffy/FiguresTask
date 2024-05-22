using Task.Abstractions;
using Task.Implementation.Figures;
using Task.Utils.Exceptions;

namespace Task.Implementation;

public static class ShapeFactory
{
    public static IFigure CreateFigure(string figureName, params double[] parameters)
    {
        switch (figureName.ToLower())
        {
            case "circle":
            {
                if (parameters.Length == 1)
                    return new Circle(parameters.First());
                break;
            }

            case "rectangle":
            {
                if (parameters.Length == 2)
                    return new Rectangle(parameters.First(), parameters.Last());
                break;
            }

            case "triangle":
            {
                if (parameters.Length == 3)
                    return new Triangle(parameters[0], parameters[1], parameters[2]);
                break;
            }
        }

        throw new TaskExceptionWithLog("Wrong figure type or parameters");
    }
}