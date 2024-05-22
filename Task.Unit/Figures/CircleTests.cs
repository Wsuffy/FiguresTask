using Task.Implementation.Figures;
using Task.Utils.Exceptions;

namespace MindBoxTask.Figures;

[TestFixture]
public class CircleTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Circle_CalculateArea_ReturnsCorrectValue()
    {
        const int r = 5;
        var circleArea = Math.PI * Math.Pow(r, 2);

        var circle = new Circle(r);

        Assert.That(circleArea, Is.EqualTo(circle.CalculateArea()));
    }
    
    [Test]
    public void Constructor_ThrowsExceptionWithIncorrectVariables()
    {
        Assert.Throws<TaskExceptionWithLog>(() => { new Circle(0); });
    }
}