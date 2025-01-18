class Circle : Shape
{
    // Constructor para el círculo 
    public Circle(double radius) : base(radius, radius) { }

    // Implementación del cálculo del área
    public override double CalculateSurface()
    {
        return Math.PI * Math.Pow(Width, 2);  // Área del círculo (π * radio^2)
    }

    public override string GetName()
    {
        return "Círculo";
    }
}