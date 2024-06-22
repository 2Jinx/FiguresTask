using FiguresLib.Models;

namespace FiguresLibTests;

public class FigureTests
{
    [Fact]
    public void CircleSquareTest()
    {
        var circle = new Circle(5);
        double expectedSquare = Math.PI * 25;
        Assert.Equal(expectedSquare, circle.CalculateSquare(), 5);
    }

    [Fact]
    public void TriangleSquareTest()
    {
        var triangle = new Triangle(3, 4, 5);
        double expectedSquare = 6;
        Assert.Equal(expectedSquare, triangle.CalculateSquare(), 5);
    }

    [Fact]
    public void RightTriangleTest()
    {
        var triangle = new Triangle(3, 4, 5);
        Assert.True(triangle.IsRightTriangle());
    }

    [Fact]
    public void NonRightTriangleTest()
    {
        var triangle = new Triangle(3, 3, 3);
        Assert.False(triangle.IsRightTriangle());
    }

    [Fact]
    public void RectangleSquareTest()
    {
        var rectangle = new Rectangle(4, 5);
        double expectedSquare = 20;
        Assert.Equal(expectedSquare, rectangle.CalculateSquare(), 5);
    }

    [Fact]
    public void NegativeCircleRadiusTest()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-5));
    }

    [Fact]
    public void InvalidTriangleSidesTest()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 3));
    }

    [Fact]
    public void NegativeRectangleSideTest()
    {
        Assert.Throws<ArgumentException>(() => new Rectangle(-4, 5));
    }
}