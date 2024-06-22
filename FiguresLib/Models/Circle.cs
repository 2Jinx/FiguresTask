namespace FiguresLib.Models;

/// <summary>
/// Фигура круг
/// </summary>
public class Circle: IFigure
{
    public Circle(double radius)
    {
        if (radius <= 0.0)
            throw new ArgumentException("Радиус должен быть больше 0!");
        
        Radius = radius;
    }
    
    /// <summary>
    /// Радиус круга
    /// </summary>
    private double Radius { get; set; }

    public double CalculateSquare() =>
        Math.PI * Math.Pow(Radius, 2);
}