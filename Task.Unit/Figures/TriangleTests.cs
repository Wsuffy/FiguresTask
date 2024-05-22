using FigureExample.Figure;

namespace MindBoxTask.Figures;

[TestFixture]
public class TriangleTests
{
    [TestCase(3, 4, 5)]
    [TestCase(5, 7, 8)]
    [TestCase(10, 12, 15)]
    public void CalculateArea_ReturnsCorrectValue(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);
        var halfPerimeter = (sideA + sideB + sideC) / 2;
        var expectedArea = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

        var actualArea = triangle.CalculateArea();

        Assert.That(actualArea, Is.EqualTo(expectedArea));
    }

    [TestCase(3, 4, 5)]
    [TestCase(5, 12, 13)]
    [TestCase(8, 15, 17)]
    public void IsRightAngled_ReturnsTrueForRightAngledTriangle(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(3, 4, 5);

        var isRightAngled = triangle.IsRightAngele();

        Assert.That(isRightAngled, Is.True);
    }

    [TestCase(3, 4, 6)]
    [TestCase(6, 8, 11)]
    [TestCase(7, 9, 13)]
    public void IsRightAngled_ReturnsFalseForNonRightAngledTriangle(double sideA, double sideB, double sideC)
    {
        var triangle = new Triangle(sideA, sideB, sideC);

        var isRightAngled = triangle.IsRightAngele();

        Assert.That(isRightAngled, Is.False);
    }

    [TestCase(0, 4, 5)]
    [TestCase(3, 0, 5)]
    [TestCase(3, 4, -1)]
    public void Constructor_ThrowsExceptionWithIncorrectVariables(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [TestCase(1, 1, 3)]
    [TestCase(12, 5, 5)]
    [TestCase(7, 11, 1)]
    public void Constructor_ThrowsExceptionForInvalidTriangle(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }

    [TestCase(-1, 2, 3)]
    [TestCase(2, -1, 5)]
    [TestCase(2, -1, -1)]
    [TestCase(2, 4, 0)]
    public void Constructor_ThrowsExceptionWithLessOrEcualZeroValue(double sideA, double sideB, double sideC)
    {
        Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
    }
}