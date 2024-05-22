using Task.Implementation;
using Task.Implementation.Figures;
using Task.Utils.Exceptions;

namespace MindBoxTask;

[TestFixture]
public class ShapeFactoryTests
{
    [Test]
    public void CreateFigure_Circle_ReturnsCircle()
    {
        var figureName = "circle";
        var radius = 5;

        var figure = ShapeFactory.CreateFigure(figureName, radius);

        var circle = figure as Circle;
        
        Assert.Multiple(() =>
        {
            Assert.That(figure, Is.InstanceOf<Circle>());
            Assert.That(circle!.Radius, Is.EqualTo(radius));
        });
    }

    [Test]
    public void CreateFigure_Rectangle_ReturnsRectangle()
    {
        var figureName = "rectangle";
        var width = 4;
        var height = 5;

        var figure = ShapeFactory.CreateFigure(figureName, width, height);

        var rectangle = figure as Rectangle;

        Assert.Multiple(() =>
        {
            Assert.That(figure, Is.InstanceOf<Rectangle>());
            Assert.That(rectangle!.SideA, Is.EqualTo(width));
            Assert.That(rectangle.SideB, Is.EqualTo(height));
        });
    }

    [Test]
    public void CreateFigure_Triangle_ReturnsTriangle()
    {
        var figureName = "triangle";
        var sideA = 3;
        var sideB = 4;
        var sideC = 5;

        var figure = ShapeFactory.CreateFigure(figureName, sideA, sideB, sideC);

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

        Assert.Throws<TaskExceptionWithLog>(() => ShapeFactory.CreateFigure(figureName, parameters));
    }

    [Test]
    public void CreateFigure_InvalidCircleParameters_ThrowsException()
    {
        var figureName = "circle";
        var parameters = new double[] { 1, 2 };

        Assert.Throws<TaskExceptionWithLog>(() => ShapeFactory.CreateFigure(figureName, parameters));
    }

    [Test]
    public void CreateFigure_InvalidRectangleParameters_ThrowsException()
    {
        var figureName = "rectangle";
        var parameters = new double[] { 1 };

        Assert.Throws<TaskExceptionWithLog>(() => ShapeFactory.CreateFigure(figureName, parameters));
    }

    [Test]
    public void CreateFigure_InvalidTriangleParameters_ThrowsException()
    {
        var figureName = "triangle";
        var parameters = new double[] { 1, 2 };
        
        Assert.Throws<TaskExceptionWithLog>(() => ShapeFactory.CreateFigure(figureName, parameters));
    }
}

