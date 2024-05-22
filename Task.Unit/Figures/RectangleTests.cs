using Task.Implementation.Figures;
using Task.Utils.Exceptions;

namespace MindBoxTask.Figures;

[TestFixture]
public class RectangleTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Rectangle_CalculateArea_ReturnsCorrectValue()
    {
        var rectangle = new Rectangle(3, 4);
        const int rectangleArea = 12;

        Assert.That(rectangle.CalculateArea(), Is.EqualTo(rectangleArea));
    }

    [Test]
    public void Constructor_ThrowsExceptionWithIncorrectVariables()
    {
        Assert.Throws<TaskExceptionWithLog>(() => { new Rectangle(0, 4); });
    }
}