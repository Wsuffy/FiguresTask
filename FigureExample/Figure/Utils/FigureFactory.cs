using Task.Domain;

namespace FigureExample.Figure.Utils;

public static class FigureFactory
{
    private static readonly IReadOnlyDictionary<string, Func<double[], IFigure>> _figureDictionary =
        new Dictionary<string, Func<double[], IFigure>>()
        {
            {
                FigureDefaults.CIRCLE, doubles =>
                {
                    if (doubles.Length != 1)
                        throw new ArgumentException($"Can't create a {FigureDefaults.CIRCLE}", nameof(doubles));
                    return new Circle(doubles.First());
                }
            },
            {
                FigureDefaults.RECTANGLE, doubles =>
                {
                    if (doubles.Length != 2)
                        throw new ArgumentException($"Can't create a {FigureDefaults.RECTANGLE}", nameof(doubles));
                    return new Rectangle(doubles[0], doubles[1]);
                }
            },
            {
                FigureDefaults.TRIANGLE, doubles =>
                {
                    if (doubles.Length != 3)
                        throw new ArgumentException($"Can't create a {FigureDefaults.TRIANGLE}", nameof(doubles));
                    return new Triangle(doubles[0], doubles[1], doubles[2]);
                }
            }
        };

    public static IFigure CreateFigure(string figureName, params double[] parameters)
    {
        var isFactoryExists = _figureDictionary.TryGetValue(figureName, out var factory);
        
        if (!isFactoryExists)
            throw new ArgumentException("Wrong figure type or parameters",nameof(figureName));

        return factory!.Invoke(parameters);
    }
}