using Task.Implementation.Figures;
using Task.Utils.Exceptions;

namespace MindBoxTask.Figures;

[TestFixture]
public class TriangleTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CalculateArea_ReturnsCorrectValue()
    {
        var triangle = new Triangle(3, 4, 5);
        var expectedArea = 6;
        
        var actualArea = triangle.CalculateArea();
        
        Assert.That(actualArea, Is.EqualTo(expectedArea));
    }

    [Test]
    public void IsRightAngled_ReturnsTrueForRightAngledTriangle()
    {
        var triangle = new Triangle(3, 4, 5);

        var isRightAngled = triangle.IsRightAngeled();
        
        Assert.That(isRightAngled, Is.True);
    }
    
    [Test]
    public void IsRightAngled_ReturnsFalseForNonRightAngledTriangle()
    {
        var triangle = new Triangle(3, 4, 6);
        
        var isRightAngled = triangle.IsRightAngeled();
        
        Assert.IsFalse(isRightAngled);
    }
    
    [Test]
    public void Constructor_ThrowsExceptionWithIncorrectVariables()
    {
        Assert.Throws<TaskExceptionWithLog>(() => new Triangle(0, 4, 5));
    }   
    
    [Test]
    public void Constructor_ThrowsExceptionForInvalidTriangle()
    {
        // Act & Assert
        Assert.Throws<TaskExceptionWithLog>(() => new Triangle(1, 1, 3));
    }
}