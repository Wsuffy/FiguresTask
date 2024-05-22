using FigureExample.Figure;
using FigureExample.Figure.Utils;
using Task.Domain;

namespace Task.Console.Host;

static class Program
{
    static void Main()
    {
        var circle = FigureFactory.CreateFigure(FigureDefaults.CIRCLE, 5);
        System.Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

        var rectangle = FigureFactory.CreateFigure(FigureDefaults.RECTANGLE, 3, 4);
        System.Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");

        var triangle = FigureFactory.CreateFigure(FigureDefaults.TRIANGLE, 3, 4, 5);
        System.Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");

        if (triangle is Triangle t && t.IsRightAngele())
        {
            System.Console.WriteLine("Треугольник является прямоугольным");
        }
    }
}