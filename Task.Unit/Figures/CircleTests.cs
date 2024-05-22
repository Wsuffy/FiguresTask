using Task.Implementation.Figures;

namespace MindBoxTask.Figures;

[TestFixture]
public class CircleTests
{
    [TestCase(5)]
    public void Circle_CalculateArea_ReturnsCorrectValue(double radius)
    {
        var circleArea = Math.PI * Math.Pow(radius, 2);

        var circle = new Circle(radius);

        Assert.That(circleArea, Is.EqualTo(circle.CalculateArea()));
    }

    [TestCase(0)]
    [TestCase(-1)]
    [TestCase(-100)]
    public void Constructor_ThrowsExceptionWithIncorrectVariables(double radius)
    {
        Assert.Throws<ArgumentException>(() => { new Circle(radius); });
    }
}