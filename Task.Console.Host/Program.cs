using Task.Implementation;
using Task.Implementation.Figures;

namespace Task.Console.Host;

static class Program
{
    static void Main()
    {
        var circle = ShapeFactory.CreateFigure("circle", 5);
        System.Console.WriteLine($"Площадь круга: {circle.CalculateArea()}");

        var rectangle = ShapeFactory.CreateFigure("rectangle", 3, 4);
        System.Console.WriteLine($"Площадь прямоугольника: {rectangle.CalculateArea()}");

        var triangle = ShapeFactory.CreateFigure("triangle", 3, 4, 5);
        System.Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
        
        if (triangle is Triangle t && t.IsRightAngeled())
        {
            System.Console.WriteLine("Треугольник является прямоугольным");
        }
    }
}