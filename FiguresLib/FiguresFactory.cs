using FiguresLib.Models;

namespace FiguresLib;

public static class FigureFactory
{
    public static IFigure CreateCircle(double radius)
    {
        return new Circle(radius);
    }

    public static IFigure CreateTriangle(double a, double b, double c)
    {
        return new Triangle(a, b, c);
    }
    
    public static IFigure CreateRectangle(double a, double b)
    {
        return new Rectangle(a, b);
    }
}