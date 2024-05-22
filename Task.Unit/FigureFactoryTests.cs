using FigureExample.Figure;
using FigureExample.Figure.Utils;
using Task.Domain;

namespace MindBoxTask;

[TestFixture]
public class FigureFactoryTests
{
    [TestCase(5)]
    [TestCase(7)]
    [TestCase(18)]
    public void CreateFigure_Circle_ReturnsCircle(int radius)
    {
        var figure = FigureFactory.CreateFigure(FigureDefaults.CIRCLE, radius);

        var circle = figure as Circle;

        Assert.Multiple(() =>
        {
            Assert.That(figure, Is.InstanceOf<Circle>());
            Assert.That(circle!.Radius, Is.EqualTo(radius));
        });
    }

    [TestCase(4, 5)]
    [TestCase(7, 11)]
    [TestCase(4, 5)]
    public void CreateFigure_Rectangle_ReturnsRectangle(int sideA, int sideB)
    {
        var figure = FigureFactory.CreateFigure(FigureDefaults.RECTANGLE, sideA, sideB);

        var rectangle = figure as Rectangle;

        Assert.Multiple(() =>
        {
            Assert.That(figure, Is.InstanceOf<Rectangle>());
            Assert.That(rectangle!.SideA, Is.EqualTo(sideA));
            Assert.That(rectangle.SideB, Is.EqualTo(sideB));
        });
    }

    [TestCase(3, 4, 5)]
    [TestCase(5, 6, 7)]
    [TestCase(3, 3, 5)]
    public void CreateFigure_Triangle_ReturnsTriangle(int sideA, int sideB, int sideC)
    {
        var figure = FigureFactory.CreateFigure(FigureDefaults.TRIANGLE, sideA, sideB, sideC);

        var triangle = figure as Triangle;

        Assert.Multiple(() =>
        {
            Assert.That(figure, Is.InstanceOf<Triangle>());
            Assert.That(triangle!.SideA, Is.EqualTo(sideA));
            Assert.That(triangle.SideB, Is.EqualTo(sideB));
            Assert.That(triangle.SideC, Is.EqualTo(sideC));
        });
    }

    [Test]
    public void CreateFigure_InvalidFigureName_ThrowsException()
    {
        var figureName = "hexagon";
        var parameters = new double[] { 1, 2, 3, 4, 5, 6 };

        Assert.Throws<ArgumentException>(() => FigureFactory.CreateFigure(figureName, parameters));
    }

    [Test]
    public void CreateFigure_InvalidCircleParameters_ThrowsException()
    {
        var parameters = new double[] { 1, 2 };

        Assert.Throws<ArgumentException>(() => FigureFactory.CreateFigure(FigureDefaults.CIRCLE, parameters));
    }

    [Test]
    public void CreateFigure_InvalidRectangleParameters_ThrowsException()
    {
        var parameters = new double[] { 1 };

        Assert.Throws<ArgumentException>(() => FigureFactory.CreateFigure(FigureDefaults.RECTANGLE, parameters));
    }

    [Test]
    public void CreateFigure_InvalidTriangleParameters_ThrowsException()
    {
        var parameters = new double[] { 1, 2 };

        Assert.Throws<ArgumentException>(() => FigureFactory.CreateFigure(FigureDefaults.TRIANGLE, parameters));
    }
}