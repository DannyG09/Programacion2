class Triangle : Shape
{
    // Constructor que pasa los parámetros al constructor de la clase base (Shape)
    public Triangle(double width, double height) : base(width, height) { }

    // Implementación del cálculo del área
    public override double CalculateSurface()
    {
        return (Width * Height) / 2;  // Área del triángulo
    }
    public override string GetName()
    {
        return "Triángulo";
    }
}