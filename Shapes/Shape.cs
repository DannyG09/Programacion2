abstract class Shape
{
    // Propiedades de ancho y alto
    public double Width { get; set; }
    public double Height { get; set; }

    // Constructor
    public Shape(double width, double height)
    {
        Width = width;
        Height = height;
    }

    // Método abstracto para calcular el área
    public abstract double CalculateSurface();

    public abstract string GetName();
}
