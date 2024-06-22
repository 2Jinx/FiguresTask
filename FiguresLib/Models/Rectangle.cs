namespace FiguresLib.Models;

/// <summary>
/// Фигура прямоугольник (добавил для примера добавления новой фигуры)
/// </summary>
public class Rectangle: IFigure
{
    public Rectangle(double a, double b)
    {
        if (a <= 0.0 || b <= 0.0)
            throw new ArgumentException("Стороны прямоугольника должны быть больше 0!");

        A = a;
        B = b;
    }
    
    /// <summary>
    /// Первая сторона прямоугольника
    /// </summary>
    private double A { get; set; }
    
    /// <summary>
    /// Вторая сторона прямоугольника
    /// </summary>
    private double B { get; set; }

    public double CalculateSquare() =>
        A * B;
}