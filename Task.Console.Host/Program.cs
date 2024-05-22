using Task.Domain;
using Task.Implementation;
using Task.Implementation.Figures;

namespace Task.Console.Host;

static class Program
{
    static void Main()
    {
        var circle = ShapeFactory.CreateFigure(FigureDefaults.CIRCLE, 5);
        System.Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

        var rectangle = ShapeFactory.CreateFigure(FigureDefaults.RECTANGLE, 3, 4);
        System.Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");

        var triangle = ShapeFactory.CreateFigure(FigureDefaults.TRIANGLE, 3, 4, 5);
        System.Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");

        if (triangle is Triangle t && t.IsRightAngele())
        {
            System.Console.WriteLine("Треугольник является прямоугольным");
        }
    }
}