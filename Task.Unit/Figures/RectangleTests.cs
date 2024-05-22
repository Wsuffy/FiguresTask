using FigureExample.Figure;

namespace MindBoxTask.Figures;

[TestFixture]
public class RectangleTests
{
    [TestCase(3, 4)]
    [TestCase(5, 11)]
    [TestCase(8, 4)]
    public void Rectangle_CalculateArea_ReturnsCorrectValue(double sideA, double sideB)
    {
        var rectangle = new Rectangle(sideA, sideB);
        var rectangleArea = sideA * sideB;

        Assert.That(rectangle.CalculateArea(), Is.EqualTo(rectangleArea));
    }

    [TestCase(0,4)]
    [TestCase(2,-1)]
    [TestCase(-42,-11)]
    public void Constructor_ThrowsExceptionWithIncorrectVariables(double sideA, double sideB)
    {
        Assert.Throws<ArgumentException>(() => { new Rectangle(sideA, sideB); });
    }
}